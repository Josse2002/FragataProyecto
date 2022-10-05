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
    public class FacturaDAL
    {
        #region OBTENER FACTURAS...
        //OBTENER ENVIOS DE LA BASE DE DATOS

        public static List<Recibo> ObtenerFactura()
        {
            List<Recibo> _ListaFacturas = new List<Recibo>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ConsultarFactura", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Recibo Facturaa = new Recibo();

                        Facturaa.Id = _reader.GetInt64(0);
                        Facturaa.NombreCliente = _reader.GetString(1);
                        Facturaa.Fecha = _reader.GetDateTime(2);
                        Facturaa.Numero = _reader.GetString(3);
                        Facturaa.Productos = _reader.GetString(4);
                        Facturaa.Estado = _reader.GetString(5);
                        Facturaa.Total = _reader.GetDecimal(6);
                        Facturaa.VentasAfectas = _reader.GetString(7);
                        _ListaFacturas.Add(Facturaa);
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

            return _ListaFacturas;
        }
        #endregion

        public static int AgregarFactura(Recibo recibo)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarFactura", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Cliente", recibo.NombreCliente);
                    _command.Parameters.AddWithValue("@Fecha", recibo.Fecha);
                    _command.Parameters.AddWithValue("@Numero", recibo.Numero);
                    _command.Parameters.AddWithValue("@Productos", recibo.Productos);
                    _command.Parameters.AddWithValue("@VentasAfectas", recibo.Total);
                    _command.Parameters.AddWithValue("@Total", recibo.Total);
                    _command.Parameters.AddWithValue("@IdPedido", recibo.IdPedido);
                    _command.Parameters.AddWithValue("@IdEnvio", recibo.IdEnvio);
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

      
        public static List<Recibo> BuscarFacturaNombre(string cliente, string parametro)
        {
            List<Recibo> _ListaFacturas = new List<Recibo>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("BuscarFacturaCliente", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Cliente", cliente);
                    _command.Parameters.AddWithValue("@Parametro", parametro);
                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Recibo Facturaa = new Recibo();

                        Facturaa.Id = _reader.GetInt64(0);
                        Facturaa.NombreCliente = _reader.GetString(1);
                        Facturaa.Fecha = _reader.GetDateTime(2);
                        Facturaa.Numero = _reader.GetString(3);
                        Facturaa.Productos = _reader.GetString(4);
                        Facturaa.Estado = _reader.GetString(5);
                        Facturaa.Total = _reader.GetDecimal(6);
                        Facturaa.VentasAfectas = _reader.GetString(7);
                        _ListaFacturas.Add(Facturaa);
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

            return _ListaFacturas;
        }

        public static List<Recibo> BuscarFacturaCodigo(string numero, string parametro)
        {
            List<Recibo> _ListaFacturas = new List<Recibo>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("BuscarFacturaNumero", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Numero", numero);
                    _command.Parameters.AddWithValue("@Parametro", parametro);
                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Recibo Facturaa = new Recibo();

                        Facturaa.Id = _reader.GetInt64(0);
                        Facturaa.NombreCliente = _reader.GetString(1);
                        Facturaa.Fecha = _reader.GetDateTime(2);
                        Facturaa.Numero = _reader.GetString(3);
                        Facturaa.Productos = _reader.GetString(4);
                        Facturaa.Estado = _reader.GetString(5);
                        Facturaa.Total = _reader.GetDecimal(6);
                        Facturaa.VentasAfectas = _reader.GetString(7);
                        _ListaFacturas.Add(Facturaa);
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

            return _ListaFacturas;
        }

        public static List<Recibo> OrdenarFactura(string parametro)
        {
            List<Recibo> _ListaFacturas = new List<Recibo>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("OrdenarFacturas", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    
                    _command.Parameters.AddWithValue("@Parametro", parametro);
                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Recibo Facturaa = new Recibo();

                        Facturaa.Id = _reader.GetInt64(0);
                        Facturaa.NombreCliente = _reader.GetString(1);
                        Facturaa.Fecha = _reader.GetDateTime(2);
                        Facturaa.Numero = _reader.GetString(3);
                        Facturaa.Productos = _reader.GetString(4);
                        Facturaa.Estado = _reader.GetString(5);
                        Facturaa.Total = _reader.GetDecimal(6);
                        Facturaa.VentasAfectas = _reader.GetString(7);
                        _ListaFacturas.Add(Facturaa);
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

            return _ListaFacturas;
        }

    }
}
