using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglaNegocio
{
    public class RNClientePersona
    {
        readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;
        const string estadoActivo = "1";
        const string estadoInactivo = "0";

        public void Registrar(ClientePersona persona, Personal personal)
        {
            string sql = $@"INSERT INTO clientepersona(CodigoCategoriaCliente, CodigoDistrito, Nombres, Apellidos,
                            CodigoTipoDocumento, NumeroDocumento,FechaNacimiento, Direccion, Correo, Celular, Vigente) 
                          VALUES({persona.Categoria.Codigo}, {persona.Distrito.Codigo}, '{persona.Nombres}', 
                                  '{persona.Apellidos}', '{persona.TipoDocumento.Codigo}', '{persona.NumeroDocumento}','{persona.FechaNacimiento:yyyyMMdd}',
                                  '{persona.Direccion}', '{persona.CorreoPersonal}', '{persona.Celular}',
                                  {(persona.Vigente == true ? estadoActivo : estadoInactivo)})";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlTransaction tr = cn.BeginTransaction())
                    {
                        using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                        {
                            cmd.Transaction = tr;
                            cmd.ExecuteNonQuery();
                            sql = $@"INSERT INTO cartera(CodigoClientePersona, CodigoPersonal, Vigente)
                                     VALUES {persona.Codigo}, {personal.Codigo}, {(persona.Vigente == true ? estadoActivo : estadoInactivo)}";
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                        }
                        tr.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizar(ClientePersona persona, Personal personal)
        {
            string sql = $@"UPDATE clientepersona 
                        SET CodigoCategoriaCliente = {persona.Categoria.Codigo}, CodigoDistrito = {persona.Distrito.Codigo},
                            Nombres = '{persona.Nombres}', Apellidos = '{persona.Apellidos}', CodigoTipoDocumento = {persona.TipoDocumento.Codigo},
                            NumeroDocumento = '{persona.NumeroDocumento}', FechaNacimiento = '{persona.FechaNacimiento:yyyyMMdd}',
                            Direccion = '{persona.Direccion}',
                            Correo = '{persona.CorreoPersonal}', Celular = '{persona.Celular}',
                            Vigente = {(persona.Vigente == true ? estadoActivo : estadoInactivo)}
                        WHERE Codigo = {persona.Codigo}";
            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlTransaction tr = cn.BeginTransaction())
                    {
                        using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                        {
                            cmd.Transaction = tr;
                            cmd.ExecuteNonQuery();
                            sql = $@"UPDATE cartera
                                     SET CodigoClientePersona = {persona.Codigo} , CodigoPersonal = {personal.Codigo}, 
                                     Vigente = {(persona.Vigente == true ? estadoActivo : estadoInactivo)})
                                     WHERE CodigoClientePersona = {persona.Codigo}";
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                        }
                        tr.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ClientePersona Leer(int codigo)
        {
            ClientePersona persona = null;
            string sql = $@"SELECT CP.CodigoCategoriaCliente, CP.CodigoDistrito, CP.Nombres, CP.Apellidos, CP.CodigoTipoDocumento, 
                          CP.NumeroDocumento, CP.FechaNacimiento,CP.Direccion, CP.Correo, CP.Celular, CP.Vigente
	                      FROM clientepersona CP 
                          WHERE CP.Codigo = {codigo}";
            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                persona = new ClientePersona()
                                {
                                    Codigo = codigo,
                                    Categoria = new CategoriaCliente()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoCategoriaCliente"))
                                    },
                                    Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                    Apellidos = dr.GetString(dr.GetOrdinal("Apellidos")),
                                    TipoDocumento = new TipoDocumento()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoTipoDocumento"))
                                    },
                                    NumeroDocumento = dr.GetString(dr.GetOrdinal("NumeroDocumento")),
                                    FechaNacimiento = dr.GetDateTime(dr.GetOrdinal("FechaNacimiento")),
                                    CorreoPersonal = dr.GetString(dr.GetOrdinal("Correo")),
                                    Celular = dr.GetString(dr.GetOrdinal("Celular")),
                                    Distrito = new Distrito
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoDistrito"))
                                    },
                                    Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                    Vigente = dr.GetBoolean(dr.GetOrdinal("Vigente"))
                                };
                            }
                            dr.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return persona;
        }

        public ClientePersona Leer(string numeroDocumento, string codigoTipoDocumento)
        {
            ClientePersona persona = null;
            string sql = $@"SELECT CP.Codigo, CP.CodigoCategoriaCliente, CP.CodigoDistrito, CP.Nombres, CP.Apellidos,CP.FechaNacimiento,  
                          CP.Direccion, CP.Correo, CP.Celular, CP.Vigente, CC.InteresAnual
	                      FROM clientepersona CP JOIN categoriacliente CC ON CP.CodigoCategoriaCliente = CC.Codigo
                          WHERE CP.NumeroDocumento = '{numeroDocumento}' AND CP.CodigoTipoDocumento = '{codigoTipoDocumento}'";
            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                persona = new ClientePersona()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Categoria = new CategoriaCliente()
                                    {
                                        Codigo = dr.GetByte(dr.GetOrdinal("CodigoCategoriaCliente")),
                                        InteresAnual = (double)dr.GetDecimal(dr.GetOrdinal("InteresAnual"))
                                    },
                                    Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                    Apellidos = dr.GetString(dr.GetOrdinal("Apellidos")),
                                    FechaNacimiento = dr.GetDateTime(dr.GetOrdinal("FechaNacimiento")),
                                    CorreoPersonal = dr.GetString(dr.GetOrdinal("CorreoPersonal")),
                                    Celular = dr.GetString(dr.GetOrdinal("Celular")),
                                    Distrito = new Distrito
                                    {
                                        Codigo = dr.GetByte(dr.GetOrdinal("CodigoDistrito"))
                                    },
                                    Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                    Vigente = dr.GetBoolean(dr.GetOrdinal("Vigente"))
                                };
                            }
                            dr.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return persona;
        }

        public List<ClientePersona> Listar(string nombreCompleto)
        {
            List<ClientePersona> personas = null;
            string sql = $@"SELECT CP.Codigo, CP.Nombres, CP.Apellidos, CP.NumeroDocumento, CP.CodigoTipoDocumento, CP.Celular,  CP.Vigente, 
						CC.Nombre AS Categoria, D.Distrito, CC.InteresAnual
	                    FROM clientepersona CP JOIN categoriacliente CC ON CC.Codigo = CP.CodigoCategoriaCliente
		                JOIN Distrito D ON D.Codigo = CP.CodigoDistrito
	                    WHERE CP.Nombres LIKE '{nombreCompleto}%' OR CP.Apellidos LIKE '{nombreCompleto}%'
	                    ORDER BY CP.Nombres";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            personas = new List<ClientePersona>();
                            while (dr.Read() == true)
                            {
                                personas.Add(new ClientePersona()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                    Apellidos = dr.GetString(dr.GetOrdinal("Apellidos")),
                                    TipoDocumento = new TipoDocumento()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoTipoDocumento"))
                                    },
                                    NumeroDocumento = dr.GetString(dr.GetOrdinal("NumeroDocumento")),
                                    Celular = dr.GetString(dr.GetOrdinal("Celular")),
                                    Categoria = new CategoriaCliente()
                                    {
                                        Nombre = dr.GetString(dr.GetOrdinal("Categoria")),
                                        InteresAnual = (double)dr.GetDecimal(dr.GetOrdinal("InteresAnual"))
                                    },
                                    Distrito = new Distrito
                                    {
                                        DistritoNombre = dr.GetString(dr.GetOrdinal("Distrito"))
                                    },
                                    Vigente = dr.GetBoolean(dr.GetOrdinal("Vigente"))
                                });
                            }
                            dr.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return personas;
        }

        public bool ExistePersona(string numDocumento)
        {
            bool existe = false;
            string sql = $@"SELECT Codigo
	                      FROM ClientePersona 
                          WHERE NumeroDocumento = '{numDocumento}'";
            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                existe = true;
                            }
                            dr.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return existe;
        }
    }
}
