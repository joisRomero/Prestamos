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
                      {(prestamo.Vigente == true ? 1 : 0)}, 0, {Sesion.Usuario.Personal.Codigo}, ";

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
                                        VALUES ({codigoPrestamo}, {cuota.Numero}, {cuota.Monto}, '{cuota.Fecha:yyyyMMdd}')";

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
    }
}
