using InventarioApi.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InventarioApi.Data
{
    public class DataArticulo
    {
        //Registrar conteos
        public static bool Registrar(Conteo oConteo)
        {
            using (SqlConnection oConexion = new SqlConnection(Clonexion.connectionBD))
            {
                SqlCommand cmd = new SqlCommand("agregarinventa_conteo", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pConteo", SqlDbType.Int).Value = oConteo.conteo;
                cmd.Parameters.AddWithValue("@plote", SqlDbType.VarChar).Value = oConteo.lote;
                cmd.Parameters.AddWithValue("@pfecha", SqlDbType.DateTime).Value = oConteo.fecha;
                cmd.Parameters.AddWithValue("@pbodega", SqlDbType.VarChar).Value = oConteo.bodega;
                cmd.Parameters.AddWithValue("@pcodigo", SqlDbType.VarChar).Value = oConteo.codigo;
                cmd.Parameters.AddWithValue("@pdescripcion", SqlDbType.VarChar).Value = oConteo.descripcion;
                cmd.Parameters.AddWithValue("@pcantidad", SqlDbType.Decimal).Value = oConteo.cantidad;
                cmd.Parameters.AddWithValue("@pproveedor", SqlDbType.VarChar).Value = oConteo.proveedor;
                cmd.Parameters.AddWithValue("@ptipo", SqlDbType.VarChar).Value = oConteo.tipo;
                cmd.Parameters.AddWithValue("@pubicacion", SqlDbType.VarChar).Value = oConteo.ubicacion;
                cmd.Parameters.AddWithValue("@prack", SqlDbType.VarChar).Value = oConteo.rack;
                cmd.Parameters.AddWithValue("@pum", SqlDbType.VarChar).Value = oConteo.um;
                cmd.Parameters.AddWithValue("@user", SqlDbType.VarChar).Value = oConteo.user;
                //cmd.Parameters.AddWithValue("@pcantidad", oConteo.cantidad);
                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch(Exception ex)
                {
                    return false;
                }
            }
        }
        //Obtener Registros por medio de un id de producto
        public static Articulos Obtener(string Busqueda)
        {
            Articulos oArticulo = new Articulos();
            using (SqlConnection oConexion = new SqlConnection(Clonexion.connectionBD))
            {
                SqlCommand cmd = new SqlCommand("BuscarArticulos", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@busqueda", Busqueda);
                try
                {
                    oConexion.Open();
                    //cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oArticulo = new Articulos()
                            {
                                ARTICULO = dr["ARTICULO"].ToString(),
                                DESCRIPCION = dr["DESCRIPCION"].ToString(),
                                PROVEEDOR = dr["PROVEEDOR"].ToString(),
                                TIPO = dr["TIPO"].ToString(),
                                UM = dr["UM"].ToString()
                            };

                        }
                    }
                    return oArticulo;
                }
                catch (Exception ex)
                {
                    return oArticulo;
                 
                }
            }
        }

        //Obtener Ubicaciones
        //Obtener UBICACIONES por medio de un id de producto
        public static List<UBICACIONES> ObtenerUbicacion(string Codigo)
        {
            List<UBICACIONES> oUbicaciones = new List<UBICACIONES>();
            using (SqlConnection oConexion = new SqlConnection(Clonexion.connectionBD))
            {
                SqlCommand cmd = new SqlCommand("BuscarUbicacion", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", Codigo);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oUbicaciones.Add(new UBICACIONES()
                            {
                                
                                UBICACION = dr["UBICACION"].ToString(),

                            });
                        }

                    }



                    return oUbicaciones;
                }
                catch (Exception ex)
                {
                    return oUbicaciones;
                }
            }
        }

        public static List<Articulos> Listar()
        {
            List<Articulos> oListarArticulo = new List<Articulos>();
            using (SqlConnection oConexion = new SqlConnection(Clonexion.connectionBD))
            {
                SqlCommand cmd = new SqlCommand("usp_listar_art", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oListarArticulo.Add(new Articulos()
                            {
                                ARTICULO =  dr["ARTICULO"].ToString(),
                                DESCRIPCION = dr["DESCRIPCION"].ToString(),
                                PROVEEDOR = dr["PROVEEDOR"].ToString(),
                                TIPO = dr["TIPO"].ToString(),
                                UM = dr["UM"].ToString()    

                            });
                        }

                    }



                    return oListarArticulo;
                }
                catch (Exception ex)
                {
                    return oListarArticulo;
                }
            }
        }

        public static List<UBICACIONES> ListarUbicacion()
        {
            List<UBICACIONES> oListarUbicacion = new List<UBICACIONES>();
            using (SqlConnection oConexion = new SqlConnection(Clonexion.connectionBD))
            {
                SqlCommand cmd = new SqlCommand("SP_LISTAR_UBICACION", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oListarUbicacion.Add(new UBICACIONES()
                            {
                                UBICACION = dr["UBICACION"].ToString(),
                                

                            });
                        }

                    }



                    return oListarUbicacion;
                }
                catch (Exception ex)
                {
                    return oListarUbicacion;
                }
            }
        }

    }
}