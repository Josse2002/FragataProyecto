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
    public class VentaDAL
    {

        public static List<Venta> ObtenerVentas()
        {
            List<Venta> _listaVenta = new List<Venta>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ObtenerVentas", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Venta venta = new Venta();

                        venta.Id = _reader.GetInt64(0);
                        venta.FechaAgregado = _reader.GetDateTime(1);
                        venta.CantidadPagada = _reader.GetDecimal(2);
                        venta.Cambio = _reader.GetDecimal(3);
                        venta.CantidadPagar = _reader.GetDecimal(4);
                        venta.AtentidoPor = _reader.GetString(5);
                        venta.NombreUsuario = _reader.GetString(6);
                        venta.Productos = _reader.GetString(7);


                        _listaVenta.Add(venta);
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

            return _listaVenta;

        }

        public static List<Venta> ObtenerVentasPorFecha(DateTime pFecha, string pParametro)
        {
            List<Venta> _listaVenta = new List<Venta>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("BuscarVentaDesdeFecha", _connection);
                    _command.CommandType = CommandType.StoredProcedure;
                    _command.Parameters.AddWithValue("@Fecha", pFecha);
                    _command.Parameters.AddWithValue("@Parametro", pParametro);
                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Venta venta = new Venta();


                        venta.Id = _reader.GetInt64(0);
                        venta.FechaAgregado = _reader.GetDateTime(1);
                        venta.CantidadPagada = _reader.GetDecimal(2);
                        venta.Cambio = _reader.GetDecimal(3);
                        venta.CantidadPagar = _reader.GetDecimal(4);
                        venta.AtentidoPor = _reader.GetString(5);
                        venta.NombreUsuario = _reader.GetString(6);
                        venta.Productos = _reader.GetString(7);


                        _listaVenta.Add(venta);
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

            return _listaVenta;

        }

        public static List<Venta> OrdenarVenta(string pParametro)
        {
            List<Venta> _listaVenta = new List<Venta>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("OrdenarVentas", _connection);
                    _command.CommandType = CommandType.StoredProcedure;
                    
                    _command.Parameters.AddWithValue("@Parametro", pParametro);
                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Venta venta = new Venta();

                        venta.Id = _reader.GetInt64(0);
                        venta.FechaAgregado = _reader.GetDateTime(1);
                        venta.CantidadPagada = _reader.GetDecimal(2);
                        venta.Cambio = _reader.GetDecimal(3);
                        venta.CantidadPagar = _reader.GetDecimal(4);
                        venta.AtentidoPor = _reader.GetString(5);
                        venta.NombreUsuario = _reader.GetString(6);
                        venta.Productos = _reader.GetString(7);


                        _listaVenta.Add(venta);
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

            return _listaVenta;

        }

        public static int AgregarVenta(Venta pVenta)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarVenta", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    //PARAMETROS
                    _command.Parameters.AddWithValue("@FechaAgregado", pVenta.FechaAgregado);
                    _command.Parameters.AddWithValue("@CantidadPagada", pVenta.CantidadPagada);
                    _command.Parameters.AddWithValue("@Cambio", pVenta.Cambio);
                    _command.Parameters.AddWithValue("@CantidadPagar", pVenta.CantidadPagar);
                    _command.Parameters.AddWithValue("@AtentidoPor", pVenta.AtentidoPor);
                    _command.Parameters.AddWithValue("@NombreUsuario", pVenta.NombreUsuario);
                    _command.Parameters.AddWithValue("@Productos", pVenta.Productos);

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
