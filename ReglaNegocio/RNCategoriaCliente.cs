using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ReglaNegocio
{
    public class RNCategoriaCliente
    {
        readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;

        public void Registrar(CategoriaCliente categoria)
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;
            string sql = $@"INSERT INTO CategoriaCliente(Nombre, Descripcion, Interes, Vigente)
                            VALUES( '{categoria.Nombre}', '{categoria.Descripcion}', {categoria.Interes},
                                    {(categoria.Vigente == true ? 1 : 0)})";
            try 
            {
                cn = new SqlConnection(cadenaConexion);
                cmd = new SqlCommand(sql, cn);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                cmd = null;

                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                    cn.Dispose();
                }
                cn = null;
            }
        }

        public void Actualizar(CategoriaCliente categoria)
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;
            string sql = $@"UPDATE CategoriaCliente 
                            SET Nombre = '{categoria.Nombre}', Descripcion = '{categoria.Descripcion}',
                                Interes = {categoria.Interes}, Vigente = {(categoria.Vigente == true ? 1 : 0)}
                            WHERE Codigo = {categoria.Codigo}";
            try
            {
                cn = new SqlConnection(cadenaConexion);
                cmd = new SqlCommand(sql, cn);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                cmd = null;
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                    cn.Dispose();
                }
                cn = null;
            }
        }

        public void DarDeBaja(int codigo)
        {
            SqlConnection cn = null;
            SqlCommand cmd = null;
            string sql = $@"UPDATE CategoriaCliente 
                            SET Vigente = 0
                            WHERE Codigo = {codigo}";
            try
            {
                cn = new SqlConnection(cadenaConexion);
                cmd = new SqlCommand(sql, cn);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                cmd = null;
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                    cn.Dispose();
                }
                cn = null;
            }
        }

        public CategoriaCliente Leer(int codigo)
        {
            CategoriaCliente cat = null;
            string sql = $@"SELECT CC.Nombre, CC.Interes, CC.Descripcion, CC.Vigente
                        FROM CategoriaCliente CC
                        WHERE CC.Codigo = {codigo}";

            SqlConnection cn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = null;

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read() == true)
                {
                    cat = new CategoriaCliente
                    {
                        Codigo = codigo,
                        Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                        Descripcion = dr.GetString(dr.GetOrdinal("Descripcion")),
                        Interes = (double)dr.GetDecimal(dr.GetOrdinal("Interes")),
                        Vigente = dr.GetBoolean(dr.GetOrdinal("Vigente"))
                    };
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dr != null && dr.IsClosed == false)
                {
                    dr.Close();
                }
                dr = null;
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                cmd = null;
                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                    cn.Dispose();
                }
                cn = null;
            }

            return cat;
        }

        public List<CategoriaCliente> Listar()
        {
            List<CategoriaCliente> categorias = null;
            string sql = $@"SELECT CC.Codigo, CC.Nombre, CC.Interes, CC.Vigente
                            FROM CategoriaCliente CC
                            ORDER BY CC.Nombre";
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-IOE6HV8\SQLEXPRESS;Initial Catalog=Prestamos;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = null;

            try
            {
                cn.Open();
                dr = cmd.ExecuteReader();
                categorias = new List<CategoriaCliente>();
                while (dr.Read())
                {
                    categorias.Add(new CategoriaCliente()
                    {
                        Codigo = dr.GetByte(dr.GetOrdinal("Codigo")),
                        Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                        Interes = (double)dr.GetDecimal(dr.GetOrdinal("Interes")),
                        Vigente = dr.GetBoolean(dr.GetOrdinal("Vigente"))
                    });
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (dr != null && dr.IsClosed == false)
                {
                    dr.Close();
                }
                dr = null;

                if (cmd != null)
                {
                    cmd.Dispose();
                }
                cmd = null;

                if (cn != null && cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                    cn.Dispose();
                }
                cn = null;
            }

            return categorias;
        }

        public List<CategoriaCliente> ListarVigentes()
        {
            List<CategoriaCliente> categorias = null;
            string sql = $@"SELECT CC.Codigo, CC.Nombre
                        FROM CategoriaCliente CC
                        WHERE CC.Vigente = 1 
                        ORDER BY CC.Nombre";

            try
            {
                using (SqlConnection cn = new SqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            categorias = new List<CategoriaCliente>();
                            while (dr.Read() == true)
                            {
                                categorias.Add(new CategoriaCliente()
                                {
                                    Codigo = dr.GetByte(dr.GetOrdinal("Codigo")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
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

            return categorias;
        }

        public bool ExisteCategoriaCliente(string nombre)
        {
            bool existe = false;
            string sql = $@"SELECT Codigo
                        FROM CategoriaCliente
                        WHERE Nombre = '{nombre}'";

            try
            {
                using (SqlConnection cn = new SqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read() == true)
                            {
                                existe = true;
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

            return existe;
        }
    }
}
