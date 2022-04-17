using Entidades;
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
                      CodigoClienteEmpresa, CodigoClientePersona)
                  VALUES('{prestamo.Fecha:yyyyMMdd HH:mm}', {prestamo.Interes}, {prestamo.Monto }, 
                      '{prestamo.TipoPeriodo}', {prestamo.CantidadPeriodos}, {(prestamo.DejaGarantia == true ? 1 : 0)},
                      {(prestamo.Vigente == true ? 1 : 0)}, ";

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
                using (SqlConnection cn = new SqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (SqlTransaction tr = cn.BeginTransaction())
                    {
                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            cmd.Transaction = tr;

                            cmd.ExecuteNonQuery();
                            cmd.CommandText = "SELECT @@IDENTITY AS Codigo";
                            codigoPrestamo = Int32.Parse(cmd.ExecuteScalar().ToString());
                            prestamo.Codigo = codigoPrestamo;

                            foreach (var cuota in prestamo.Cuotas)
                            {
                                sql = $@"INSERT INTO Cuota( CodigoPrestamo, Numero, Monto, FechaVencimiento) 
                                        VALUES ({codigoPrestamo}, {cuota.Numero}, {cuota.Monto}, '{cuota.Fecha:yyyyMMdd}')";

                                cmd.CommandText = sql;
                                cmd.ExecuteNonQuery();
                            }
                        }

                        tr.Commit(); // finalizar transacción con visto bueno
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
