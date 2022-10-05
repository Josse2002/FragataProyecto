using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Fragata.Entities;

namespace Fragata.DAL
{
    public class PagoDAL
    {
        public static List<Pago> ObtenerPago()
        {
            List<Pago> _listaPago = new List<Pago>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ObtenerPago", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Pago _pago = new Pago();

                        _pago.Id = _reader.GetInt64(0);
                        _pago.HoraRecibido = _reader.GetDateTime(1);
                        _pago.FechaRecibido = _reader.GetDateTime(2);
                        _pago.IdPedido = _reader.GetInt64(3);
                        _pago.Estado = _reader.GetString(4);

                        _listaPago.Add(_pago);
                      
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

            return _listaPago;

        }   

        public static int AgregarPago(Pago pPago)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {

                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarPago", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.Add(new SqlParameter("@HoraRecbido", pPago.HoraRecibido));
                    _command.Parameters.Add(new SqlParameter("@FechaRecibido", pPago.FechaRecibido));
                    _command.Parameters.Add(new SqlParameter("@IdPedido", pPago.IdPedido));
                    _command.Parameters.Add(new SqlParameter("@Estado", pPago.Estado));

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
        public static int ModificarPago(Pago pPago)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ModificarPago", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    //FORMA ABREVIADA DE CONFIGURAR PARÁMETROS
                    _command.Parameters.AddWithValue("@HoraRecibido", pPago.HoraRecibido);
                    _command.Parameters.AddWithValue("@FechaRecibido", pPago.FechaRecibido);
                    _command.Parameters.AddWithValue("@IdPedido", pPago.IdPedido);
                    _command.Parameters.AddWithValue("@Estado", pPago);

                    //FALTA HORA RECIBIDO Y ESTADO
                    
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
     public static int AnularPago(Int64 pId)
        {
            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AnularPago", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Id", pId);

                  int  _resultado = _command.ExecuteNonQuery();

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

























