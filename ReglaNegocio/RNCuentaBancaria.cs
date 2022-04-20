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
    public class RNCuentaBancaria
    {
        readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;
        const string estadoActivo = "1";
        const string estadoInactivo = "0";
        public void Registrar(CuentaBancaria cuentaB)
        {
            string sql = $@"INSERT INTO cuentabancaria(EntidadBancaria_Codigo, Numero, CCI, Vigente) 
                          VALUES({cuentaB.EntidadB.Codigo}, '{cuentaB.Numero}', '{cuentaB.CCI}',
                                  {(cuentaB.Vigente == true ? estadoActivo : estadoInactivo)})";

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
        public void Actualizar(CuentaBancaria cuentaB)
        {
            string sql = $@"UPDATE cuentabancaria 
                        SET EntidadBancaria_Codigo = {cuentaB.EntidadB.Codigo}, Numero = '{cuentaB.Numero}', 
                            CCI = '{cuentaB.CCI}',
                            Vigente = {(cuentaB.Vigente == true ? estadoActivo : estadoInactivo)}
                        WHERE Codigo = {cuentaB.Codigo}";
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
        public CuentaBancaria Leer(int codigo)
        {
            CuentaBancaria cuentaB = null;
            string sql = $@"SELECT CB.EntidadBancaria_Codigo, CB.Numero, CB.CCI, CB.Vigente
	                      FROM cuentabancaria CB 
                        WHERE CB.Codigo = {codigo}";
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
                                cuentaB = new CuentaBancaria()
                                {
                                    Codigo = codigo,
                                    EntidadB = new EntidadBancaria()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("EntidadBancaria_Codigo"))
                                    },
                                    Numero = dr.GetString(dr.GetOrdinal("Numero")),
                                    CCI = dr.GetString(dr.GetOrdinal("CCI")),
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

            return cuentaB;
        }
        public bool ExisteNumero(string Numero)
        {
            bool existe = false;
            string sql = $@"SELECT Codigo
	                      FROM cuentabancaria
                        WHERE Numero = '{Numero}'";
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
        public bool ExisteCCI(string CCI)
        {
            bool existe = false;
            string sql = $@"SELECT Codigo
	                      FROM cuentabancaria
                        WHERE CCI = '{CCI}'";
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
        public List<CuentaBancaria> Listar(string entidadB)
        {
            List<CuentaBancaria> cuentaB = null;
            string sql = $@"SELECT CB.Codigo, CB.Numero, CB.CCI, CB.Vigente, EB.Nombre AS Entidad
	        FROM cuentabancaria CB JOIN entidadbancaria EB ON CB.EntidadBancaria_Codigo = EB.Codigo
	        WHERE EB.Nombre LIKE '{entidadB}%'
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
                            cuentaB = new List<CuentaBancaria>();
                            while (dr.Read() == true)
                            {
                                cuentaB.Add(new CuentaBancaria()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Numero = dr.GetString(dr.GetOrdinal("Numero")),
                                    CCI = dr.GetString(dr.GetOrdinal("CCI")),
                                    EntidadB = new EntidadBancaria()
                                    {
                                        Nombre = dr.GetString(dr.GetOrdinal("Entidad"))
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

            return cuentaB;
        }
    }
}
