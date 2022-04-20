using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglaNegocio
{
    public class RNUsuario
    {
        readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;
        const string estadoActivo = "1";
        const string estadoInactivo = "0";

        public void Registrar(Usuario usuario)
        {
            string sql = $@"INSERT INTO usuario(Nombre, Clave, Tipo, CodigoPersonal, Vigente) 
                            VALUES('{usuario.Nombre}', '{usuario.Clave}', '{usuario.Tipo}',
                                    {usuario.Personal.Codigo}, 
                                    {(usuario.Vigente == true ? estadoActivo : estadoInactivo)})";

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

        public void ActualizarSinClave(Usuario usuario)
        {
            string sql = $@"UPDATE usuario
                            SET Nombre = '{usuario.Nombre}',
                            Tipo = '{usuario.Tipo}',
                            CodigoPersonal = '{usuario.Personal.Codigo}', 
                            Vigente = {(usuario.Vigente == true ? estadoActivo : estadoInactivo)}
                            WHERE Codigo = {usuario.Codigo}";
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
                Console.WriteLine("======" + ex.Message);
                throw ex;
            }
        }

        public void ActualizarConClave(Usuario usuario)
        {
            string sql = $@"UPDATE usuario
                            SET Nombre = '{usuario.Nombre}', Clave = '{usuario.Clave}',
                            Tipo = '{usuario.Tipo}',
                            CodigoPersonal = '{usuario.Personal.Codigo}', 
                            Vigente = {(usuario.Vigente == true ? estadoActivo : estadoInactivo)}
                            WHERE Codigo = {usuario.Codigo}";
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

        public Usuario Leer(int codigo)
        {
            Usuario usuario = null;
            string sql = $@"SELECT U.Nombre, U.Tipo, U.CodigoPersonal, U.Vigente, P.Nombres, P.Apellidos, P.NumeroDocumento
	                        FROM usuario U JOIN personal P ON U.CodigoPersonal = P.Codigo
                            WHERE U.Codigo = {codigo}";
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
                                usuario = new Usuario()
                                {
                                    Codigo = codigo,
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Tipo = dr.GetString(dr.GetOrdinal("Tipo")),
                                    Personal = new Personal()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoPersonal")),
                                        Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                        Apellidos = dr.GetString(dr.GetOrdinal("Apellidos")),
                                        NumeroDocumento = dr.GetString(dr.GetOrdinal("NumeroDocumento"))
                                    },
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

            return usuario;
        }

        public Usuario Leer(string nombre)
        {
            Usuario usuario = null;
            string sql = $@"SELECT U.Codigo, U.Tipo, U.CodigoPersonal, U.Vigente, P.Nombres, P.Apellidos, P.NumeroDocumento
	                        FROM usuario U JOIN personal P ON U.CodigoPersonal = P.Codigo
                            WHERE U.Nombre = '{nombre}'";
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
                                usuario = new Usuario()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombre = nombre,
                                    Tipo = dr.GetString(dr.GetOrdinal("Tipo")),
                                    Personal = new Personal()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoPersonal")),
                                        Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                        Apellidos = dr.GetString(dr.GetOrdinal("Apellidos")),
                                        NumeroDocumento = dr.GetString(dr.GetOrdinal("NumeroDocumento"))
                                    },
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

            return usuario;
        }

        public List<Usuario> Listar()
        {
            List<Usuario> usuario = null;
            string sql = $@"SELECT U.Codigo, U.Nombre, U.Vigente, P.Nombres, P.Apellidos, P.NumeroDocumento
                            FROM usuario U JOIN Personal P on U.CodigoPersonal = P.Codigo
                            ORDER BY P.Nombres";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            usuario = new List<Usuario>();
                            while (dr.Read() == true)
                            {
                                usuario.Add(new Usuario()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Personal = new Personal()
                                    {
                                        Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                        Apellidos = dr.GetString(dr.GetOrdinal("Apellidos")),
                                        NumeroDocumento = dr.GetString(dr.GetOrdinal("NumeroDocumento"))
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

            return usuario;
        }
        public void DarDeBaja(int codigo)
        {
            string sql = $@"UPDATE usuario 
                            SET Vigente = {estadoInactivo}
                         WHERE Codigo = {codigo}";
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

        public bool Login(string nombre, string clave)
        {
            bool estaRegistrado = false;
            string sql = $@"SELECT codigo FROM usuario WHERE Nombre = '{nombre}' AND Clave = '{clave}'";
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
                                estaRegistrado = true;
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

            return estaRegistrado;
        }

        public bool EstaRegistradoElUsuario(int codigo)
        {
            bool estaRegistrado = false;
            string sql = $@"SELECT codigo FROM usuario WHERE CodigoPersonal = {codigo}";
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
                                estaRegistrado = true;
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

            return estaRegistrado;
        }

        public bool EstaRegistradoElNombreDeUsuario(string nombre)
        {
            bool estaRegistrado = false;
            string sql = $@"SELECT codigo FROM usuario WHERE Nombre = '{nombre}'";
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
                                estaRegistrado = true;
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

            return estaRegistrado;
        }
    }
}
