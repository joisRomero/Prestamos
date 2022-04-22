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
    public class RNReporteListaPrestamos
    {
        readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;
        public List<ReporteListaPrestamos> Listar()
        {
            List<ReporteListaPrestamos> pres = null;
            string sql = $@"SELECT P.Fecha AS Fecha, P.Monto AS MontoPrestado, P.Interes AS Interes, P.TipoPeriodo AS Periodo, P.CantidadPeriodos AS CantidadCuotas, 
                            if((P.CodigoClientePersona) is null, CE.RazonSocial, CONCAT(CP.Apellidos,', ',CP.Nombres)) AS Nombre,
                            if((P.CodigoClientePersona) is null, 'Empresa', 'Persona') AS TipoCliente
                            FROM prestamo P 
                            LEFT JOIN clienteempresa CE ON CE.Codigo = P.CodigoClienteEmpresa
                            LEFT JOIN clientepersona CP ON CP.Codigo = P.CodigoClientePersona
                            WHERE P.CodigoPersonal = {Sesion.Usuario.Personal.Codigo} AND P.Fecha >= '{Sesion.Caja.FechaInicio:yyyy-MM-dd HH:mm:ss}'
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
                            pres = new List<ReporteListaPrestamos>();
                            while (dr.Read() == true)
                            {
                                pres.Add(new ReporteListaPrestamos()
                                {
                                    TipoCliente = dr.GetString(dr.GetOrdinal("TipoCliente")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha")),
                                    MontoPrestado = dr.GetDouble(dr.GetOrdinal("MontoPrestado")),
                                    Interes = dr.GetDouble(dr.GetOrdinal("Interes")),
                                    Periodo = dr.GetString(dr.GetOrdinal("Periodo")),
                                    CantidadCuotas = dr.GetInt16(dr.GetOrdinal("CantidadCuotas"))
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

            return pres;
        }
    }
}
