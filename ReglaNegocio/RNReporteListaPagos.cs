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
    public class RNReporteListaPagos
    {
        readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;
        public List<ReporteListaPagos> Listar()
        {
            List<ReporteListaPagos> pagos = null;
            string sql = $@"SELECT P.Fecha AS Fecha, P.Monto AS MontoPagado, FP.Nombre AS FormaPago,
							if((PR.CodigoClientePersona) is null, CE.RazonSocial, CONCAT(CPE.Apellidos,', ',CPE.Nombres)) AS NombreCliente
                            FROM pago P 
                            JOIN formapago FP ON FP.Codigo = P.CodigoFormaPago
                            JOIN cuotapago CP ON CP.CodigoPago = P.Codigo 
                            JOIN cuota C ON CP.CodigoCuota = C.Codigo
                            JOIN prestamo PR ON PR.Codigo = C.CodigoPrestamo
                            LEFT JOIN clienteempresa CE ON CE.Codigo = PR.CodigoClienteEmpresa
                            LEFT JOIN clientepersona CPE ON CPE.Codigo = PR.CodigoClientePersona
                            WHERE P.CodigoCaja = {Sesion.Caja.Codigo} AND P.Fecha > '{Sesion.Caja.FechaInicio:yyyy-MM-dd HH:mm:ss}'
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
                            pagos = new List<ReporteListaPagos>();
                            while (dr.Read() == true)
                            {
                                pagos.Add(new ReporteListaPagos()
                                { 
                                    Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha")),
                                    MontoPagado = dr.GetDouble(dr.GetOrdinal("MontoPagado")),
                                    FormaPago = dr.GetString(dr.GetOrdinal("FormaPago")),
                                    NombreCliente = dr.GetString(dr.GetOrdinal("NombreCliente"))
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

            return pagos;
        }
    }
}
