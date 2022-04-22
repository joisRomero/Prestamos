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
    public class RNReportes
    {
        readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;

        public List<ReporteListaTotalPrestamo> Listar()
        {
            List<ReporteListaTotalPrestamo> ReporteListaTotalPrestamo = null;
            string sql = $@"SELECT P.Codigo,P.Fecha, P.Monto,P.MontoPagado,if((P.CodigoClientePersona) is null,CE.RazonSocial,CP.Nombres) AS CLIENTE
	                    FROM prestamo P 
                        LEFT JOIN ClientePersona CP ON P.CodigoClientePersona=CP.Codigo
	                    LEFT JOIN ClienteEmpresa CE ON P.CodigoClienteEmpresa = CE.Codigo
	                    WHERE P.Vigente = 1 AND P.Monto > P.MontoPagado
	                    ORDER BY P.Fecha";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            ReporteListaTotalPrestamo = new List<ReporteListaTotalPrestamo>();
                            while (dr.Read() == true)
                            {
                                ReporteListaTotalPrestamo.Add(new ReporteListaTotalPrestamo()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombres = dr.GetString(dr.GetOrdinal("CLIENTE")),
                                    Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha")),
                                    MontoPrestado = dr.GetDouble(dr.GetOrdinal("Monto")),
                                    MontoPagado = dr.GetDouble(dr.GetOrdinal("MontoPagado"))
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

            return ReporteListaTotalPrestamo;
        }
    }
}
