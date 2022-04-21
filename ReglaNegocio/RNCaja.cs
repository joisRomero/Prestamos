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
    public class RNCaja
    {
        readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;
        const string iniciada = "1";
        const string cerrada = "0";

        public void IniciarCaja(Caja caja)
        {
            string sql = $@"INSERT INTO caja(FechaInicio, FechaFin, Estado, CodigoPersonal) 
                            VALUES('{caja.FechaInicio:yyyy-MM-dd H:mm:ss}', '{caja.FechaFin:yyyy-MM-dd H:mm:ss}', 
                            {(caja.Estado == true ? iniciada : cerrada)}, {caja.Personal.Codigo})";

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

        public void CerrarCaja(Caja caja)
        {
            string sql = $@"UPDATE caja
                            SET FechaFin = '{caja.FechaFin:yyyy-MM-dd H:mm:ss}',
                            Estado = {cerrada}
                            WHERE Codigo = {caja.Codigo}";
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

        public Caja TieneCajaAbierta(int CodigoPersonal)
        {
            Caja caja = null;
            string sql = $@"SELECT Codigo, FechaInicio, FechaFin
                            FROM caja 
                            WHERE CodigoPersonal = {CodigoPersonal} AND Estado = 1";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                caja = new Caja()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    FechaInicio = dr.GetDateTime(dr.GetOrdinal("FechaInicio")),
                                    FechaFin = dr.GetDateTime(dr.GetOrdinal("FechaFin")),
                                    Estado = true
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return caja;
        }
    }
}
