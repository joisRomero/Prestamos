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
    public class RNPago
    {
        readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;

        public void Registrar(Pago pago)
        {
            string sql;
            int codigoPago;

            if (pago.CuentaBancaria != null)
            {
                sql = $@"INSERT INTO pago( Monto, NumeroOperacion, Fecha, Vigente, CodigoFormaPago, 
                     CodigoCaja, CodigoCuentaBancaria)
                     VALUES({pago.Monto}, {pago.NumeroOperacion}, '{pago.Fecha:yyyy-MM-dd H:mm:ss}', 
                     1, {pago.FormaPago.Codigo}, {pago.Caja.Codigo}, {pago.CuentaBancaria.Codigo}";
            }
            else
            {
                sql = $@"INSERT INTO pago( Monto, Fecha, Vigente, CodigoFormaPago, 
                     CodigoCaja)
                     VALUES({pago.Monto}, '{pago.Fecha:yyyy-MM-dd H:mm:ss}', 
                     1, {pago.FormaPago.Codigo}, {pago.Caja.Codigo})";
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
                            codigoPago = Int32.Parse(cmd.ExecuteScalar().ToString());
                            pago.Codigo = codigoPago;

                            foreach (var cuotaPago in pago.CuotasPago)
                            {
                                sql = $@"INSERT INTO cuotapago(CodigoCuota,CodigoPago,Monto,Vigente)
                                         VALUES({cuotaPago.Cuota.Codigo}, {pago.Codigo}, {pago.Monto}, 1)";

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
