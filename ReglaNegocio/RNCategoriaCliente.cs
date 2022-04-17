using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace ReglaNegocio
{
    public class RNCategoriaCliente
    {
        readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;

        public void Registrar(CategoriaCliente categoria)
        {
            
            string sql = $@"INSERT INTO categoriacliente(Nombre, Descripcion, InteresAnual, Vigente, Negociable)
                            VALUES( '{categoria.Nombre}', '{categoria.Descripcion}', {categoria.Interes},
                                    {(categoria.Vigente == true ? 1 : 0)}, {(categoria.Negociable == true ? 1 : 0)})";
            try 
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizar(CategoriaCliente categoria)
        {
            
           
            string sql = $@"UPDATE categoriacliente 
                            SET Nombre = '{categoria.Nombre}', Descripcion = '{categoria.Descripcion}',
                                Interes = {categoria.Interes}, Vigente = {(categoria.Vigente == true ? 1 : 0)},
                                Negociable = {(categoria.Negociable == true ? 1 : 0)}
                            WHERE Codigo = {categoria.Codigo}";
            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DarDeBaja(int codigo)
        {
            string sql = $@"UPDATE categoriacliente 
                            SET Vigente = 0
                            WHERE Codigo = {codigo}";
            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CategoriaCliente Leer(int codigo)
        {
            CategoriaCliente cat = null;
            string sql = $@"SELECT CC.Nombre, CC.InteresAnual, CC.Descripcion, CC.Vigente, CC.Negociable
                        FROM categoriacliente CC
                        WHERE CC.Codigo = {codigo}";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read() == true)
                            {
                                cat = new CategoriaCliente
                                {
                                    Codigo = codigo,
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Descripcion = dr.GetString(dr.GetOrdinal("Descripcion")),
                                    Interes = (double)dr.GetDecimal(dr.GetOrdinal("Interes")),
                                    Vigente = dr.GetBoolean(dr.GetOrdinal("Vigente")),
                                    Negociable = dr.GetBoolean(dr.GetOrdinal("Negociable"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return cat;
        }
       
        public List<CategoriaCliente> Listar()
        {
            List<CategoriaCliente> categorias = null;
            string sql = $@"SELECT CC.Codigo, CC.Nombre, CC.InteresAnual, CC.Vigente, CC.Negociable
                            FROM categoriacliente CC
                            ORDER BY CC.Nombre";
            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            categorias = new List<CategoriaCliente>();
                            while (dr.Read())
                            {
                                categorias.Add(new CategoriaCliente()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Interes = (double)dr.GetDecimal(dr.GetOrdinal("InteresAnual")),
                                    Vigente = dr.GetBoolean(dr.GetOrdinal("Vigente")),
                                    Negociable = dr.GetBoolean(dr.GetOrdinal("Negociable"))
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
            return categorias;
        }

        public List<CategoriaCliente> ListarVigentes()
        {
            List<CategoriaCliente> categorias = null;
            string sql = $@"SELECT CC.Codigo, CC.Nombre
                        FROM categoriacliente CC
                        WHERE CC.Vigente = 1 
                        ORDER BY CC.Nombre";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            categorias = new List<CategoriaCliente>();
                            while (dr.Read() == true)
                            {
                                categorias.Add(new CategoriaCliente()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
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
                        FROM categoriacliente
                        WHERE Nombre = '{nombre}'";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
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
