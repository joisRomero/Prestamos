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
    public class RNDistrito
    {
        readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;
        
        public void Registrar(Distrito distrito)
        {
            
            string sql = $@"INSERT INTO distrito(Distrito, Provincia, Departamento, Vigente)
                        VALUES('{distrito.DistritoNombre}', '{distrito.Provincia}', 
                              '{distrito.Departamento}', {(distrito.Vigente == true ? 1 : 0) })";
            try
            {
                using(MySqlConnection cn = new MySqlConnection(cadenaConexion))
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

        public List<Distrito> Listar()
        {
            List<Distrito> distritos = null;
            string sql = $@"SELECT Codigo, Distrito, Provincia, Departamento, Vigente
                            FROM distrito
                            ORDER BY Distrito";

            try
            {
                using(MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using(MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using(MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            distritos = new List<Distrito>();
                            while (dr.Read() == true)
                            {
                                distritos.Add(new Distrito()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    DistritoNombre = dr.GetString(dr.GetOrdinal("Distrito")),
                                    Provincia = dr.GetString(dr.GetOrdinal("Provincia")),
                                    Departamento = dr.GetString(dr.GetOrdinal("Departamento")),
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
            
            return distritos;
        }

        public void Actualizar(Distrito dis)
        {
            string sql = $@"UPDATE distrito 
                            SET Distrito = '{dis.DistritoNombre}', Provincia = '{dis.Provincia}',
                                Departamento = '{dis.Departamento}', Vigente = {(dis.Vigente == true ? 1 : 0)}
                            WHERE Codigo = {dis.Codigo}";
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

        public Distrito Leer(int codigo)
        {
            Distrito dis = null;
            string sql = $@"SELECT D.Codigo, D.Distrito, D.Provincia, D.Departamento, D.Vigente
                            FROM distrito D
                            WHERE D.Codigo = {codigo}";

            try
            {
                using(MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using(MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using(MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read() == true)
                            {
                                dis = new Distrito
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    DistritoNombre = dr.GetString(dr.GetOrdinal("Distrito")),
                                    Provincia = dr.GetString(dr.GetOrdinal("Provincia")),
                                    Departamento = dr.GetString(dr.GetOrdinal("Departamento")),
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

            return dis;
        }

        public void DarDeBaja(int codigo)
        {
            string sql = $@"UPDATE distrito 
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

        public List<Distrito> ListarDepartamentos()
        {
            List<Distrito> departamentos = null;
            string sql = $@"SELECT DISTINCT D.Departamento
	                      FROM distrito D
                          WHERE D.Vigente = 1
	                      ORDER BY D.Departamento";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            departamentos = new List<Distrito>();
                            while (dr.Read() == true)
                            {
                                departamentos.Add(new Distrito()
                                {
                                    Departamento = dr.GetString(dr.GetOrdinal("Departamento")),
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

            return departamentos;
        }

        public List<Distrito> ListarDistritos(string provincia)
        {
            List<Distrito> distritos = null;
            string sql = $@"SELECT Codigo, Distrito 
                            FROM distrito 
                            WHERE Provincia = '{provincia}' AND Vigente = 1 ORDER BY Distrito";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            distritos = new List<Distrito>();
                            while (dr.Read() == true)
                            {
                                distritos.Add(new Distrito()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    DistritoNombre = dr.GetString(dr.GetOrdinal("Distrito")),
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

            return distritos;
        }

        public List<Distrito> ListarProvincias(string departamento)
        {
            List<Distrito> provincias = null;
            string sql = $@"SELECT DISTINCT D.Provincia
	                      FROM distrito D
                          WHERE D.Departamento = '{ departamento }' AND D.Vigente = 1
	                      ORDER BY D.Provincia";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            provincias = new List<Distrito>();
                            while (dr.Read() == true)
                            {
                                provincias.Add(new Distrito()
                                {
                                    Provincia = dr.GetString(dr.GetOrdinal("Provincia")),
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

            return provincias;
        }

        public bool ExisteDistrito(Distrito distrito)
        {
            bool existe = false;
            string sql = $@"SELECT Codigo
                            FROM distrito 
                            WHERE Distrito = '{distrito.DistritoNombre}' AND 
                                  Departamento = '{distrito.Departamento}' AND
                                  Provincia = '{distrito.Provincia}'";
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

    }
}
