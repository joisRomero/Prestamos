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
    public class RNClienteEmpresa
    {
        readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;
        const string estadoActivo = "1";
        const string estadoInactivo = "0";
        public void Registrar(ClienteEmpresa empresa)
        {
            string sql = $@"INSERT INTO clienteempresa(CodigoCategoriaCliente, RazonSocial, RUC, Telefono, correo, CodigoDistrito, 
                              Direccion, Vigente) 
                          VALUES({empresa.Categoria.Codigo}, '{empresa.RazonSocial}', '{empresa.RUC}', '{empresa.Telefono}',
                                  '{empresa.Correo}', {empresa.Distrito.Codigo}, '{empresa.Direccion }', 
                                  {(empresa.Vigente == true ? estadoActivo : estadoInactivo)})";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizar(ClienteEmpresa empresa)
        {
            string sql = $@"UPDATE clienteempresa 
                        SET CodigoCategoriaCliente = {empresa.Categoria.Codigo}, RazonSocial = '{empresa.RazonSocial}', 
                            RUC = '{empresa.RUC}', Telefono = '{empresa.Telefono}', Correo = '{empresa.Correo}',
                            CodigoDistrito = {empresa.Distrito.Codigo}, Direccion = '{empresa.Direccion}', 
                            Vigente = {(empresa.Vigente == true ? estadoActivo : estadoInactivo)}
                        WHERE Codigo = {empresa.Codigo}";
            try
            {
                using(MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using(MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ClienteEmpresa Leer(int codigo)
        {
            ClienteEmpresa empresa = null;
            string sql = $@"SELECT CE.CodigoCategoriaCliente, CE.RazonSocial, CE.RUC, CE.Telefono, CE.Correo, 
                          CE.CodigoDistrito, CE.Direccion, CE.Vigente
	                      FROM clienteempresa CE 
                        WHERE CE.Codigo = {codigo}";
            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using(MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using(MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                empresa = new ClienteEmpresa()
                                {
                                    Codigo = codigo,
                                    Categoria = new CategoriaCliente()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoCategoriaCliente"))
                                    },
                                    RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial")),
                                    RUC = dr.GetString(dr.GetOrdinal("RUC")),
                                    Telefono = dr.GetString(dr.GetOrdinal("Telefono")),
                                    Correo = dr.GetString(dr.GetOrdinal("Correo")),
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

            return empresa;
        }

        public ClienteEmpresa Leer(string documento)
        {
            ClienteEmpresa empresa = null;
            string sql = $@"SELECT CE.Codigo, CE.CodigoCategoriaCliente, CE.RazonSocial, CE.Telefono, CE.Correo, 
                          CE.CodigoDistrito, CE.Direccion, CE.Vigente, CC.InteresAnual
	                      FROM clienteempresa CE JOIN categoriacliente CC ON CE.CodigoCategoriaCliente = CC.Codigo
                          WHERE CE.RUC = '{documento}'";
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
                                empresa = new ClienteEmpresa()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Categoria = new CategoriaCliente()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoCategoriaCliente")),
                                        InteresAnual = (double)dr.GetDecimal(dr.GetOrdinal("InteresAnual"))
                                    },
                                    RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial")),
                                    Telefono = dr.GetString(dr.GetOrdinal("Telefono")),
                                    Correo = dr.GetString(dr.GetOrdinal("Correo")),
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

            return empresa;
        }

        public List<ClienteEmpresa> Listar(string razonSocial)
        {
            List<ClienteEmpresa> empresas = null;
            string sql = $@"SELECT CE.Codigo, CE.RazonSocial, CE.RUC, CE.Vigente, CC.Nombre AS Categoria, CC.InteresAnual, D.Distrito
	        FROM clienteempresa CE JOIN categoriacliente CC ON CC.Codigo = CE.CodigoCategoriaCliente
		        JOIN distrito D ON D.Codigo = CE.CodigoDistrito
	        WHERE CE.RazonSocial LIKE '{razonSocial}%'
	        ORDER BY CE.RazonSocial";

            try
            {
                using(MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using(MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            empresas = new List<ClienteEmpresa>();
                            while (dr.Read() == true)
                            {
                                empresas.Add(new ClienteEmpresa()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial")),
                                    RUC = dr.GetString(dr.GetOrdinal("RUC")),
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

            return empresas;
        }

        public bool ExisteEmpresa(string RUC)
        {
            bool existe = false;
            string sql = $@"SELECT Codigo
	                      FROM clienteempresa 
                        WHERE RUC = '{RUC}'";
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
