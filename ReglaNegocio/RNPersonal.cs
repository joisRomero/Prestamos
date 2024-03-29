﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using MySql.Data.MySqlClient;
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
            string sql = $@"INSERT INTO personal(Nombres, Apellidos, CodigoTipoDocumento, NumeroDocumento,
                            Correo, Celular, Direccion, Vigente) 
                            VALUES('{personal.Nombres}', '{personal.Apellidos}', {personal.TipoDocumento.Codigo},
                                    '{personal.NumeroDocumento}', '{personal.Correo}', '{personal.Celular}',
                                    '{personal.Direccion}',
                                    {(personal.Vigente == true ? estadoActivo : estadoInactivo)})";

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

        public void Actualizar(Personal personal)
        {
            string sql = $@"UPDATE personal
                            SET Nombres = '{personal.Nombres}', Apellidos = '{personal.Apellidos}',
                            CodigoTipoDocumento = { personal.TipoDocumento.Codigo },
                            NumeroDocumento = '{personal.NumeroDocumento}', Correo = '{personal.Correo}',
                            Celular = '{personal.Celular}', Direccion = '{personal.Direccion}',
                            Vigente = {(personal.Vigente == true ? estadoActivo : estadoInactivo)}
                            WHERE Codigo = {personal.Codigo}";
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

        public Personal Leer(int codigo)
        {
            Personal personal = null;
            string sql = $@"SELECT P.Nombres, P.Apellidos, P.CodigoTipoDocumento, P.NumeroDocumento, P.Correo, 
                            P.Celular, P.Direccion, P.Vigente
                            FROM Personal P
                            WHERE P.Codigo = {codigo}";
            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                personal = new Personal()
                                {
                                    Codigo = codigo,
                                    Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                    Apellidos = dr.GetString(dr.GetOrdinal("Apellidos")),
                                    TipoDocumento = new TipoDocumento()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoTipoDocumento")),
                                    },
                                    NumeroDocumento = dr.GetString(dr.GetOrdinal("NumeroDocumento")),
                                    Correo = dr.GetString(dr.GetOrdinal("Correo")),
                                    Celular = dr.GetString(dr.GetOrdinal("Celular")),
                                    Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
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

        public Personal Leer(string numeroDocumento)
        {
            Personal personal = null;
            string sql = $@"SELECT P.Nombres, P.Apellidos, P.CodigoTipoDocumento, P.Correo, 
                            P.Celular, P.Direccion, P.Vigente, P.Codigo
                            FROM Personal P
                            WHERE P.NumeroDocumento = {numeroDocumento}";
            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                personal = new Personal()
                                {
                                    NumeroDocumento = numeroDocumento,
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                    Apellidos = dr.GetString(dr.GetOrdinal("Apellidos")),
                                    TipoDocumento = new TipoDocumento()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoTipoDocumento")),
                                    },
                                    Correo = dr.GetString(dr.GetOrdinal("Correo")),
                                    Celular = dr.GetString(dr.GetOrdinal("Celular")),
                                    Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
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
            string sql = $@"SELECT P.Codigo, P.Nombres, P.Apellidos, P.CodigoTipoDocumento, P.NumeroDocumento, 
	                        P.Vigente, P.Correo, P.Celular, TP.Siglas
                            FROM Personal P JOIN TipoDocumento TP on TP.Codigo = P.CodigoTipoDocumento
                            ORDER BY P.Nombres";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            personal = new List<Personal>();
                            while (dr.Read() == true)
                            {
                                personal.Add(new Personal()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                    Apellidos = dr.GetString(dr.GetOrdinal("Apellidos")),
                                    Correo = dr.GetString(dr.GetOrdinal("Correo")),
                                    Celular = dr.GetString(dr.GetOrdinal("Celular")),
                                    TipoDocumento = new TipoDocumento()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoTipoDocumento")),
                                        Siglas = dr.GetString(dr.GetOrdinal("Siglas"))
                                    },
                                    NumeroDocumento = dr.GetString(dr.GetOrdinal("NumeroDocumento")),
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

        public List<Personal> ListarExistentes()
        {
            List<Personal> personal = null;
            string sql = $@"SELECT P.Codigo, P.Nombres, P.Apellidos, P.CodigoTipoDocumento, P.NumeroDocumento, P.Vigente
                            FROM Personal P 
                            WHERE P.Vigente = 1
                            ORDER BY P.Nombres";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            personal = new List<Personal>();
                            while (dr.Read() == true)
                            {
                                personal.Add(new Personal()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombres = dr.GetString(dr.GetOrdinal("Nombres")),
                                    Apellidos = dr.GetString(dr.GetOrdinal("Apellidos")),
                                    TipoDocumento = new TipoDocumento()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoTipoDocumento")),
                                    },
                                    NumeroDocumento = dr.GetString(dr.GetOrdinal("NumeroDocumento")),
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



        public bool ExistePersonal(string numeroDocumento)
        {
            bool existe = false;
            string sql = $@"SELECT Codigo
	                        FROM Personal 
                         WHERE NumeroDocumento = '{numeroDocumento}'";
            try
            {
                using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
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
    }
}
