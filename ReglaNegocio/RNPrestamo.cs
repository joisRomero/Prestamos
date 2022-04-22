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
    public class RNPrestamo
    {
        readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;

        public void Registrar(Prestamo prestamo)
        {
            string sql;
            int codigoPrestamo;

            sql = $@"INSERT INTO Prestamo( Fecha, Interes, Monto, TipoPeriodo, CantidadPeriodos, DejaGarantia, Vigente, 
                     MontoPagado, CodigoPersonal, CodigoClienteEmpresa, CodigoClientePersona)
                  VALUES('{prestamo.Fecha:yyyy-MM-dd H:mm:ss}', {prestamo.Interes}, {prestamo.Monto }, 
                      '{prestamo.TipoPeriodo}', {prestamo.CantidadPeriodos}, {(prestamo.DejaGarantia == true ? 1 : 0)},
                      {(prestamo.Vigente == true ? 1 : 0)}, {prestamo.MontoPagado}, {prestamo.Personal.Codigo}, ";

            if (prestamo.Cliente is ClientePersona)
            {
                sql += $@" null, {prestamo.Cliente.Codigo} )";
            }
            else
            {
                sql += $@" {prestamo.Cliente.Codigo}, null )";
            }

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
                            cmd.CommandText = "SELECT @@IDENTITY AS Codigo";
                            codigoPrestamo = Int32.Parse(cmd.ExecuteScalar().ToString());
                            prestamo.Codigo = codigoPrestamo;

                            foreach (var cuota in prestamo.Cuotas)
                            {
                                sql = $@"INSERT INTO Cuota( CodigoPrestamo, Numero, Monto, FechaVencimiento) 
                                        VALUES ({codigoPrestamo}, {cuota.Numero}, {cuota.Monto}, '{cuota.FechaVencimiento:yyyyMMdd}')";

                                cmd.CommandText = sql;
                                cmd.ExecuteNonQuery();
                            }
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
        
        public List<Prestamo> PrestamosPorPagar(ICliente cliente)
        {
            List<Prestamo> prestamos = null;
            string sql = $@"SELECT P.Codigo, P.Fecha, P.Monto, P.MontoPagado
	                        FROM prestamo P
	                        WHERE P.Vigente = 1 AND P.Monto > P.MontoPagado";

            if (cliente is ClientePersona)
            {
                sql += $@" AND P.CodigoClientePersona = {cliente.Codigo}
                           ORDER BY P.Fecha";
            }
            else
            {
                sql += $@" AND P.CodigoClienteEmpresa = {cliente.Codigo}
                           ORDER BY P.Fecha";
            }

            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            prestamos = new List<Prestamo>();
                            while (dr.Read() == true)
                            {
                                prestamos.Add(new Prestamo()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Fecha = dr.GetDateTime(dr.GetOrdinal("Fecha")),
                                    Monto = dr.GetDouble(dr.GetOrdinal("Monto")),
                                    MontoPagado = dr.GetDouble(dr.GetOrdinal("MontoPagado")),
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

            return prestamos;
        }

        public List<Cuota> CuotasPorPagar(Prestamo prestamo)
        {
            List<Cuota> cuotas = null;
            string sql = $@"SELECT C.Codigo, C.FechaVencimiento, C.Monto - IFNULL( CP.TotalPagado, 0) AS Saldo
	                        FROM cuota C LEFT OUTER JOIN 
			                (SELECT CPA.CodigoCuota, SUM( CPa.Monto ) AS TotalPagado
					                FROM cuotapago CPa JOIN Pago P ON P.Codigo = CPa.CodigoPago
					                WHERE P.Vigente = 1
					                GROUP BY CPA.CodigoCuota
			                ) AS CP ON C.Codigo = CP.CodigoCuota
	                        WHERE C.CodigoPrestamo = {prestamo.Codigo} AND C.Monto > IFNULL( CP.TotalPagado, 0)
	                        ORDER BY C.Numero";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            cuotas = new List<Cuota>();
                            while (dr.Read() == true)
                            {
                                cuotas.Add(new Cuota()
                                { 
                                    FechaVencimiento = dr.GetDateTime(dr.GetOrdinal("FechaVencimiento")),
                                    Monto = dr.GetDouble(dr.GetOrdinal("Saldo")),
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

            return cuotas;
        }
    }
}
