using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglaNegocio
{
    class RNFomaPago
    {
        readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;

        public List<TipoDocumento> Listar()
        {
            List<TipoDocumento> tiposDocumentos = null;
            string sql = $@"SELECT Codigo, Nombre, Siglas
                            FROM tipodocumento WHERE Vigente = 1";
            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            tiposDocumentos = new List<TipoDocumento>();
                            while (dr.Read())
                            {
                                tiposDocumentos.Add(new TipoDocumento()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Siglas = dr.GetString(dr.GetOrdinal("Siglas")),
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
            return tiposDocumentos;
        }
    }
}
