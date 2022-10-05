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
    public class DetallePedidoDAL
    {
        #region OBTENER DETALLE PEDIDO...
        //OBTENER ENVIOS DE LA BASE DE DATOS

        public static List<DetallePedido> ObtenerDetallePedido()
        {
            List<DetallePedido> _ListaDetallePedido = new List<DetallePedido>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ObtenerDetallePedido", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        DetallePedido _DetallePedido = new DetallePedido();

                        _DetallePedido.Id = _reader.GetInt64(0);
                        _DetallePedido.CostoEnvio = _reader.GetDecimal(1);
                        _DetallePedido.Cantidad = _reader.GetInt64(2);
                        _DetallePedido.DescripcionPersonalizado = _reader.GetString(3);
                        _DetallePedido.IdPedido = _reader.GetInt64(4);
                        _DetallePedido.Estado = _reader.GetString(5);


                        _ListaDetallePedido.Add(_DetallePedido);
                    }

                    _reader.Close();
                    _connection.Close();
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

            return _ListaDetallePedido;
        }
        #endregion

        #region AGREGAR DETALLE PEDIDO...

        //AGREGAR DETALLE FACTURA

        public static int AgregarDetallePedido(DetallePedido pDetallePedido)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarDetallePedido", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    //FORMA ABREVIADA DE CONFIGURAR PARÁMETROS
                    _command.Parameters.AddWithValue("@CostoEnvio", pDetallePedido.CostoEnvio);
                    _command.Parameters.AddWithValue("@Cantidad", pDetallePedido.Cantidad);
                    _command.Parameters.AddWithValue("@DescripcionPersonalizado", pDetallePedido.DescripcionPersonalizado);
                    _command.Parameters.AddWithValue("@IdPedido", pDetallePedido.IdPedido);
                    _command.Parameters.AddWithValue("@Estado", pDetallePedido.Estado);
                   


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

        #region ANULAR DETALLE PEDIDO...

        //ANULAR DETALLE PEDIDO

        public static int AnularDetallerPedido(Int64 pId)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AnularDetallePedido", _connection);
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

        #region EDITAR DETALLE PEDIDO...

        //MODIFICAR DETALLE PEDIDO

        public static int ModificarDetallePedido(DetallePedido pDetallePedido)
        {
            int resultado = 0;

            try
            {
                using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();

                    SqlCommand _command = new SqlCommand("EditarDetallePedido", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@CostoEnvio", pDetallePedido.CostoEnvio);
                    _command.Parameters.AddWithValue("@Cantidad", pDetallePedido.Cantidad);
                    _command.Parameters.AddWithValue("@DescripcionPersonalizado", pDetallePedido.DescripcionPersonalizado);
                    _command.Parameters.AddWithValue("@IdPedido", pDetallePedido.IdPedido);
                    _command.Parameters.AddWithValue("@Estado", pDetallePedido.Estado);


                    resultado = _command.ExecuteNonQuery();
                    _conn.Close();

                    return resultado;
                }
            }
            catch(SqlException ex)
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
    }
}
