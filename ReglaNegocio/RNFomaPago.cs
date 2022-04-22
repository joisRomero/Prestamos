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
    public class RNFomaPago
    {
        readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;

        public List<FormaPago> Listar()
        {
            List<FormaPago> formaPago = null;
            string sql = $@"SELECT Codigo, Nombre, Descripcion
                            FROM formapago WHERE Vigente = 1";
            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            formaPago = new List<FormaPago>();
                            while (dr.Read())
                            {
                                formaPago.Add(new FormaPago()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Descripcion = dr.GetString(dr.GetOrdinal("Descripcion")),
                                    Vigente = true
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return formaPago;
        }
    }
}
