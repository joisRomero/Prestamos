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
    public class RNEntidadBancaria
    {
        readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;

        public void Registrar(EntidadBancaria eb)
        {
            string sql = $@"INSERT INTO entidadbancaria(Nombre, Siglas, Vigente)
                        VALUES('{eb.Nombre}', '{eb.Siglas}', 
                              {(eb.Vigente == true ? 1 : 0) })";
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

        public List<EntidadBancaria> Listar()
        {
            List<EntidadBancaria> eb = null;
            string sql = $@"SELECT Codigo, Nombre, Siglas, Vigente
                            FROM entidadbancaria
                            ORDER BY Nombre";

            try
            {
                using(MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using(MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using(MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            eb = new List<EntidadBancaria>();
                            while (dr.Read() == true)
                            {
                                eb.Add(new EntidadBancaria()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Siglas = dr.GetString(dr.GetOrdinal("Siglas")),
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
            
            return eb;
        }


        public void Actualizar(EntidadBancaria eb)
        {
            string sql = $@"UPDATE entidadbancaria 
                            SET Nombre = '{eb.Nombre}', Siglas = '{eb.Siglas}',
                               Vigente = {(eb.Vigente == true ? 1 : 0)}
                            WHERE Codigo = {eb.Codigo}";
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
        public EntidadBancaria Leer(int codigo)
        {
            EntidadBancaria eb = null;
            string sql = $@"SELECT EB.Codigo, EB.Nombre, EB.Siglas, EB.Vigente
                            FROM entidadbancaria EB
                            WHERE EB.Codigo = {codigo}";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read() == true)
                            {
                                eb = new EntidadBancaria
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Siglas = dr.GetString(dr.GetOrdinal("Siglas")),
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

            return eb;
        }
        public void DarDeBaja(int codigo)
        {
            string sql = $@"UPDATE entidadbancaria 
                            SET Vigente = 0
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
        public bool ExisteEntidadB(EntidadBancaria eb)
        {
            bool existe = false;
            string sql = $@"SELECT Codigo
                            FROM entidadbancaria 
                            WHERE Nombre = '{eb.Nombre}'";
            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read() == true)
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
        public List<EntidadBancaria> ListarVigentes()
        {
            List<EntidadBancaria> entidadesB = null;
            string sql = $@"SELECT EB.Codigo, EB.Nombre
                        FROM entidadbancaria EB
                        WHERE EB.Vigente = 1 
                        ORDER BY EB.Nombre";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            entidadesB = new List<EntidadBancaria>();
                            while (dr.Read() == true)
                            {
                                entidadesB.Add(new EntidadBancaria()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Vigente = true
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

            return entidadesB;
        }
    }
}
