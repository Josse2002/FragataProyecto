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
    public class SalidaDAL
    {
        //OBTENER SALIDA


        public static List<Salida> ObtenerSalida()
        {
            List<Salida> _listaSalida = new List<Salida>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ObtenerSalida", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Salida _Salida = new Salida();

                        _Salida.Id = _reader.GetInt64(0);
                        _Salida.Fecha = _reader.GetDateTime(1);
                        _Salida.Motivo = _reader.GetString(2);
                        _Salida.Monto = _reader.GetDecimal(3);


                        _listaSalida.Add(_Salida);
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

            return _listaSalida;

        }


        //AGREGAR SALIDA


        public static int AgregarSalida(Salida pSalida)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarSalida", _connection);
                    _command.CommandType = CommandType.StoredProcedure;


                    //CONFIGURAR PARÁMETROS
                    _command.Parameters.AddWithValue("@Fecha", pSalida.Fecha);
                    _command.Parameters.AddWithValue("@Motivo", pSalida.Motivo);
                    _command.Parameters.AddWithValue("@Monto", pSalida.Monto);
                   
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


        //ANULAR SALIDA


        public static int AnularSalida(Int64 pId)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AnularSalida", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    
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


        //BUSCAR SALIDA POR FECHA

        public static List<Salida> BuscarSalidaPorFecha(DateTime pFecha, string pParametro)
        {
            List<Salida> _listaSalida = new List<Salida>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("BuscarSalidaPordeFecha", _connection);
                    _command.CommandType = CommandType.StoredProcedure;
                    _command.Parameters.AddWithValue("@Fecha", pFecha);
                    _command.Parameters.AddWithValue("@Parametro", pParametro);

                    SqlDataReader _reader = _command.ExecuteReader();

                   

                    while (_reader.Read())
                    {
                        Salida Salida = new Salida();


                        Salida.Id = _reader.GetInt64(0);
                        Salida.Fecha = _reader.GetDateTime(1);
                        Salida.Motivo = _reader.GetString(2);
                        Salida.Monto = _reader.GetDecimal(3);


                        _listaSalida.Add(Salida);
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

            return _listaSalida;

        }


        //ORDENAR SALIDA


         public static List<Salida> OrdenarSalida(string pParametro)
        {
            List<Salida> _listaSalida = new List<Salida>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("OrdenarSalida", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();
                    
                    _command.Parameters.AddWithValue("@Parametro", pParametro);

                    while (_reader.Read())
                    {
                        Salida _Salida = new Salida();

                        _Salida.Id = _reader.GetInt64(0);
                        _Salida.Fecha = _reader.GetDateTime(1);
                        _Salida.Motivo = _reader.GetString(2);
                        _Salida.Monto = _reader.GetDecimal(3);


                        _listaSalida.Add(_Salida);
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

            return _listaSalida;

        }





    }
}
