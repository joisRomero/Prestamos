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
    public class RNPersonal
    {
        readonly string cadenaConexion = ConfigurationManager.ConnectionStrings["DBConexion"].ConnectionString;
        const string estadoActivo = "1";
        const string estadoInactivo = "0";

        public void Registrar(Personal personal)
        {
            string sql = $@"INSERT INTO Personal(Nombres, Apellidos, DNI, Direccion, 
                            CorreoPersonal, CorreoLaboral, Celular, Vigente) 
                            VALUES('{personal.Nombres}', '{personal.Apellidos}', '{personal.DNI}',
                                    '{personal.Direccion}', '{personal.CorreoPersonal}', '{personal.CorreoLaboral}',
                                    '{personal.Celular}',
                                  {(personal.Vigente == true ? estadoActivo : estadoInactivo)})";

            try
            {
                using (SqlConnection cn = new SqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
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

        public void Actualizar(Personal personal)
        {
            string sql = $@"UPDATE Personal 
                        SET Nombres = '{personal.Nombres}', Apellidos = '{personal.Apellidos}', 
                            DNI = '{personal.DNI}', Direccion = '{personal.Direccion}', 
                            CorreoPersonal = '{personal.CorreoPersonal}', CorreoLaboral = '{personal.CorreoLaboral}', 
                            Celular = '{personal.Celular}',
                            Vigente = {(personal.Vigente == true ? estadoActivo : estadoInactivo)}
                        WHERE Codigo = {personal.Codigo}";
            try
            {
                using (SqlConnection cn = new SqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
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

        public Personal Leer(int codigo)
        {
            Personal personal = null;
            string sql = $@"SELECT P.Nombres, P.Apellidos, P.DNI, P.Direccion, P.CorreoPersonal, 
                            P.CorreoLaboral, P.Celular, P.Vigente
                            FROM Personal P
                            WHERE P.Codigo = {codigo}";
            try
            {
                using (SqlConnection cn = new SqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                personal = new Personal()
                                {
                                    Codigo = codigo,
                                    Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                    Apellidos = dr.GetString(dr.GetOrdinal("Apellidos")),
                                    DNI = dr.GetString(dr.GetOrdinal("DNI")),
                                    Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                    CorreoPersonal = dr.GetString(dr.GetOrdinal("CorreoPersonal")),
                                    CorreoLaboral = dr.GetString(dr.GetOrdinal("CorreoLaboral")),
                                    Celular = dr.GetString(dr.GetOrdinal("Celular")),
                                    Vigente = dr.GetBoolean(dr.GetOrdinal("Vigente"))
                                };
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

            return personal;
        }

        public List<Personal> Listar()
        {
            List<Personal> personal = null;
            string sql = $@"SELECT P.Codigo, P.Nombres, P.Apellidos, P.DNI, P.Direccion, P.CorreoPersonal, 
                            P.CorreoLaboral, P.Celular, P.Vigente
                            FROM Personal P
                            ORDER BY P.Nombres";

            try
            {
                using (SqlConnection cn = new SqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            personal = new List<Personal>();
                            while (dr.Read() == true)
                            {
                                personal.Add(new Personal()
                                {
                                    Codigo = dr.GetByte(dr.GetOrdinal("Codigo")),
                                    Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                    Apellidos = dr.GetString(dr.GetOrdinal("Apellidos")),
                                    DNI = dr.GetString(dr.GetOrdinal("DNI")),
                                    Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                    CorreoPersonal = dr.GetString(dr.GetOrdinal("CorreoPersonal")),
                                    CorreoLaboral = dr.GetString(dr.GetOrdinal("CorreoLaboral")),
                                    Celular = dr.GetString(dr.GetOrdinal("Celular")),
                                    Vigente = dr.GetBoolean(dr.GetOrdinal("Vigente"))
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

            return personal;
        }

        public bool ExistePersonal(string DNI)
        {
            bool existe = false;
            string sql = $@"SELECT Codigo
	                      FROM Personal 
                        WHERE DNI = '{DNI}'";
            try
            {
                using (SqlConnection cn = new SqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
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
        public void DarDeBaja(int codigo)
        {
            string sql = $@"UPDATE Personal 
                        SET Vigente = {estadoInactivo}
                        WHERE Codigo = {codigo}";
            try
            {
                using (SqlConnection cn = new SqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
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


    }
}
