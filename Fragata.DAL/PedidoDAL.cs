using Fragata.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragata.DAL
{
    public class PedidoDAL
    {
        public static List<Pedido> ObtenerPedidos()
        {
            List<Pedido> _listaPedidos = new List<Pedido>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ConsultarPedido", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Pedido _pedido = new Pedido();

                        _pedido.Id = _reader.GetInt64(0);

                        _pedido.Fecha = _reader.GetDateTime(1);
                        _pedido.Hora = _reader.GetDateTime(2);
                        _pedido.CodigoPedido = _reader.GetString(3);
                        _pedido.FormaEntrega = _reader.GetString(4);

                        _pedido.Estado = _reader.GetString(5);
                        _pedido.precioPedido = _reader.GetDecimal(6);
                        _pedido.Productos = _reader.GetString(7);
                        _pedido.Usuario = _reader.GetString(8);
                        _pedido.CantidadProductos = _reader.GetString(9);
                        _listaPedidos.Add(_pedido);
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

            return _listaPedidos;

        }
        public static List<Pedido> ObtenerPedidosActivos()
        {
            List<Pedido> _listaPedidos = new List<Pedido>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ObtenerPedidosActivos", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Pedido _pedido = new Pedido();

                        _pedido.Id = _reader.GetInt64(0);

                        _pedido.Fecha = _reader.GetDateTime(1);
                        _pedido.Hora = _reader.GetDateTime(2);
                        _pedido.CodigoPedido = _reader.GetString(3);
                        _pedido.FormaEntrega = _reader.GetString(4);

                        _pedido.Estado = _reader.GetString(5);
                        _pedido.precioPedido = _reader.GetDecimal(6);
                        _pedido.Productos = _reader.GetString(7);
                        _pedido.Usuario = _reader.GetString(8);
                        _pedido.CantidadProductos = _reader.GetString(9);
                        _listaPedidos.Add(_pedido);
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

            return _listaPedidos;

        }

        #region BUSCAR PEDIDO EN ENVIO...
        //BUSCAR EMPLEADOS

        public static List<Pedido> BuscarPedidoEnEnvio(string pTexto, string pParametro)
        {
            List<Pedido> _listaPedido = new List<Pedido>();

            try
            {
                using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();

                    SqlCommand _command = new SqlCommand("BuscarPedidoEnEnvio", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Texto", pTexto);
                    _command.Parameters.AddWithValue("@Parametro", pParametro);

                    SqlDataReader _reader = _command.ExecuteReader();


                    while (_reader.Read())
                    {

                        Pedido _pedido = new Pedido();

                        _pedido.Id = _reader.GetInt64(0);

                        _pedido.Fecha = _reader.GetDateTime(1);
                        _pedido.Hora = _reader.GetDateTime(2);
                        _pedido.CodigoPedido = _reader.GetString(3);
                        _pedido.FormaEntrega = _reader.GetString(4);

                        _pedido.Estado = _reader.GetString(5);
                        _pedido.precioPedido = _reader.GetDecimal(6);
                        _pedido.Productos = _reader.GetString(7);
                        _pedido.Usuario = _reader.GetString(8);
                        _pedido.CantidadProductos = _reader.GetString(9);
                        _listaPedido.Add(_pedido);
                    }


                    _reader.Close();
                    _command.ExecuteNonQuery();

                    _conn.Close();



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

            return _listaPedido;
        }

        #endregion

        public static List<Pedido> BuscarPedidoPorCliente(string pCliente, string pParametro)
        {
            List<Pedido> _listaPedidos = new List<Pedido>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("BuscarPedidoPorCliente", _connection);
                    _command.CommandType = CommandType.StoredProcedure;
                    _command.Parameters.AddWithValue("@Nombre", pCliente);
                    _command.Parameters.AddWithValue("@Parametro", pParametro);

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Pedido _pedido = new Pedido();

                        _pedido.Id = _reader.GetInt64(0);

                        _pedido.Fecha = _reader.GetDateTime(1);
                        _pedido.Hora = _reader.GetDateTime(2);
                        _pedido.CodigoPedido = _reader.GetString(3);
                        _pedido.FormaEntrega = _reader.GetString(4);

                        _pedido.Estado = _reader.GetString(5);
                        _pedido.precioPedido = _reader.GetDecimal(6);
                        _pedido.Productos = _reader.GetString(7);
                        _pedido.Usuario = _reader.GetString(8);
                        _pedido.CantidadProductos = _reader.GetString(9);
                        _listaPedidos.Add(_pedido);
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

            return _listaPedidos;

        }

        public static List<Pedido> BuscarPedidoPorCodigo(string pCodigo, string pParametro)
        {
            List<Pedido> _listaPedidos = new List<Pedido>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("BuscarPedidoPorCodigo", _connection);
                    _command.CommandType = CommandType.StoredProcedure;
                    _command.Parameters.AddWithValue("@Codigo", pCodigo);
                    _command.Parameters.AddWithValue("@Parametro", pParametro);

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Pedido _pedido = new Pedido();

                        _pedido.Id = _reader.GetInt64(0);

                        _pedido.Fecha = _reader.GetDateTime(1);
                        _pedido.Hora = _reader.GetDateTime(2);
                        _pedido.CodigoPedido = _reader.GetString(3);
                        _pedido.FormaEntrega = _reader.GetString(4);

                        _pedido.Estado = _reader.GetString(5);
                        _pedido.precioPedido = _reader.GetDecimal(6);
                        _pedido.Productos = _reader.GetString(7);
                        _pedido.Usuario = _reader.GetString(8);
                        _pedido.CantidadProductos = _reader.GetString(9);
                        _listaPedidos.Add(_pedido);
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

            return _listaPedidos;

        }

        public static List<Pedido> OrdenarPedido(string pParametro)
        {
            List<Pedido> _listaPedidos = new List<Pedido>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("OrdenarPedido", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Parametro", pParametro);

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Pedido _pedido = new Pedido();

                        _pedido.Id = _reader.GetInt64(0);

                        _pedido.Fecha = _reader.GetDateTime(1);
                        _pedido.Hora = _reader.GetDateTime(2);
                        _pedido.CodigoPedido = _reader.GetString(3);
                        _pedido.FormaEntrega = _reader.GetString(4);

                        _pedido.Estado = _reader.GetString(5);
                        _pedido.precioPedido = _reader.GetDecimal(6);
                        _pedido.Productos = _reader.GetString(7);
                        _pedido.Usuario = _reader.GetString(8);
                        _pedido.CantidadProductos = _reader.GetString(9);
                        _listaPedidos.Add(_pedido);
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

            return _listaPedidos;

        }

        public static int AgregarPedido(Pedido pedido)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarPedido", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Fecha", pedido.Fecha);
                    _command.Parameters.AddWithValue("@Hora", pedido.Hora);
                    _command.Parameters.AddWithValue("@CodigoPedido", pedido.CodigoPedido);
                    _command.Parameters.AddWithValue("@FormaEntrega", pedido.FormaEntrega);
                    _command.Parameters.AddWithValue("@PrecioPedido", pedido.precioPedido);
                    _command.Parameters.AddWithValue("@Productos", pedido.Productos);
                    _command.Parameters.AddWithValue("@Usuario", pedido.Usuario);
                    _command.Parameters.AddWithValue("@CantidadProductos", pedido.CantidadProductos);


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

        public static int EditarPedido(Pedido pedido)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EditarPedido", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Id", pedido.Id);
                    _command.Parameters.AddWithValue("@Fecha", pedido.Fecha);
                    _command.Parameters.AddWithValue("@Hora", pedido.Hora);
                    _command.Parameters.AddWithValue("@CodigoPedido", pedido.CodigoPedido);
                    _command.Parameters.AddWithValue("@FormaEntrega", pedido.FormaEntrega);
                    _command.Parameters.AddWithValue("@PrecioPedido", pedido.precioPedido);
                    _command.Parameters.AddWithValue("@Productos", pedido.Productos);
                    _command.Parameters.AddWithValue("@Usuario", pedido.Usuario);
                    _command.Parameters.AddWithValue("@CantidadProductos", pedido.CantidadProductos);


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


        public static int CambiarEstado(Int64 pId, string pEstado)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AnularPedido", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Id", pId);
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

    }
}
