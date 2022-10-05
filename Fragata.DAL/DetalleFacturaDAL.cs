using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Fragata.Entities;
using System.Data;

namespace Fragata.DAL
{
    public class DetalleFacturaDAL
    {

        //DETALLE FACTURA SOLO VA A TENER AGREGAR, ANULAR, BUSCAR Y ORDENAR; ELIMINAR Y EDITAR
        //NO LO TENDRA YA QUE NO SE VA A PODER HACER EN EL SISTEMA

        //PREGUNTAR A JESUS XD

        #region AGREGAR DETALLE FACTURA...

        //AGREGAR DETALLE FACTURA

        public static int AgregarDetalleFactura(DetalleFactura pDetalleFactura)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarDetalleFactura", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    //FORMA ABREVIADA DE CONFIGURAR PARÁMETROS
                    _command.Parameters.AddWithValue("@Cantidad", pDetalleFactura.Cantidad);
                    _command.Parameters.AddWithValue("@IdProducto", pDetalleFactura.IdProducto);
                    _command.Parameters.AddWithValue("@PrecioUnitario", pDetalleFactura.PrecioUnitario);
                    _command.Parameters.AddWithValue("@VentasNS", pDetalleFactura.VentasNoSujetas);
                    _command.Parameters.AddWithValue("@VentasEX", pDetalleFactura.VentasExentas);
                    _command.Parameters.AddWithValue("@VentasAfectas", pDetalleFactura.VentasAfectas);
                    _command.Parameters.AddWithValue("@IdFactura", pDetalleFactura.IdFactura);
                    
                    
                    
                    

                    _resultado = _command.ExecuteNonQuery();

                    _connection.Close();

                    return _resultado;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (ArgumentException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        #endregion

        #region ANULAR DETALLE FACTURA...

        //ANULAR DETALLE FACTURA

        public static int AnularDetalleFactura(Int64 pId)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarDetalleFactura", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    //FORMA LARGA DE CONFIGURAR PARÁMETROS
                    _command.Parameters.AddWithValue("@Id", pId);

                    _resultado = _command.ExecuteNonQuery();

                    _connection.Close();

                    return _resultado;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (ArgumentException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region ORDENAR DETALLE FACTURA POR MONTO

        public static List<DetalleFactura> OrdenarDetalleFacturaPorMonto()
        {
            List<DetalleFactura> _listaDetalleFactura = new List<DetalleFactura>();
            try
            {
                using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();
                    SqlCommand _command = new SqlCommand("OrdenarDetalleFacturaPorMonto", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        DetalleFactura _DetalleFactura = new DetalleFactura();
                        _DetalleFactura.Id = _reader.GetInt64(0);
                        _DetalleFactura.Cantidad = _reader.GetInt32(1);
                        _DetalleFactura.IdProducto = _reader.GetInt64(2);
                        _DetalleFactura.PrecioUnitario = _reader.GetDecimal(3);
                        _DetalleFactura.VentasNoSujetas = _reader.GetDecimal(4);
                        _DetalleFactura.VentasExentas = _reader.GetDecimal(5);
                        _DetalleFactura.VentasAfectas = _reader.GetDecimal(6);
                        _DetalleFactura.IdFactura = _reader.GetInt64(7);

                        

                        _listaDetalleFactura.Add(_DetalleFactura);

                        _reader.Close();


                        _command.ExecuteNonQuery();
                        _conn.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (TimeoutException ex)
            {
                throw;
            }
            catch (FormatException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }

            return _listaDetalleFactura;
        }

        #endregion

        #region VER DETALLE FACTURAS ANULADAS Y ACTIVAS

        //VER POR ESTADO LA FACTURA

        public static int OrdenarPorEstado(string pEstado)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("OrdenarPorEstadoDetalleFactura", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    //FORMA LARGA DE CONFIGURAR PARÁMETROS
                    _command.Parameters.AddWithValue("@Estado", pEstado);

                    _resultado = _command.ExecuteNonQuery();

                    _connection.Close();

                    return _resultado;
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (ArgumentException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region EDITAR DETALLE FACTURA...

        //MODIFICAR EMPLEADO

        public static int ModificarDetalleFactura(DetalleFactura pDetalleFactura)
        {
            int resultado = 0;

            try
            {
                using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();

                    SqlCommand _command = new SqlCommand("EditarDetalleFactura", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Id", pDetalleFactura.Id);
                    _command.Parameters.AddWithValue("@Cantidad", pDetalleFactura.Cantidad);
                    _command.Parameters.AddWithValue("@IdProducto", pDetalleFactura.IdProducto);
                    _command.Parameters.AddWithValue("@PrecioUnitario", pDetalleFactura.PrecioUnitario);
                    _command.Parameters.AddWithValue("@VentasNS", pDetalleFactura.VentasNoSujetas);
                    _command.Parameters.AddWithValue("@VentasEX", pDetalleFactura.VentasExentas);
                    _command.Parameters.AddWithValue("@VentasAfectas", pDetalleFactura.VentasAfectas);
                    _command.Parameters.AddWithValue("@IdFactura", pDetalleFactura.IdFactura);

                    resultado = _command.ExecuteNonQuery();
                    _conn.Close();

                    return resultado;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
