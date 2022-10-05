using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fragata.Entities;

namespace Fragata.DAL
{
    public class ExistenciaDAL
    {
        public static List<Existencia> ObtenerExistencia()
        {
            List<Existencia> _listaExistencia = new List<Existencia>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ObtenerExistencias", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Existencia _Existencia = new Existencia();

                        _Existencia.Id = _reader.GetInt64(0);
                        _Existencia.Nombre = _reader.GetString(1);
                        _Existencia.Codigo = _reader.GetString(2);
                        _Existencia.Cantidad = _reader.GetInt64(3);
                        _Existencia.Categoria = _reader.GetString(4);
                        _Existencia.UltimaFechaAgregado = _reader.GetDateTime(5);
                        _Existencia.Imagen = (byte[])_reader[6];
                        _Existencia.IdProveedor = _reader.GetInt64(7);
                        _listaExistencia.Add(_Existencia);
                    }

                    _reader.Close();
                    _command.ExecuteNonQuery();

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

            return _listaExistencia;

        }

        //BUSCAR EXISTENCIAS POR NOMBRE 

        public static List<Existencia> BuscarExistenciaPorNombre(string pNombre)
        {
            List<Existencia> _listaExistencia = new List<Existencia>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("BuscarMaterialesNombre", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Nombre", pNombre);
                    

                    SqlDataReader _reader = _command.ExecuteReader();
                   

                    while (_reader.Read())
                    {
                        Existencia _Existencia = new Existencia();

                        _Existencia.Id = _reader.GetInt64(0);
                        _Existencia.Nombre = _reader.GetString(1);
                        _Existencia.Codigo = _reader.GetString(2);
                        _Existencia.Cantidad = _reader.GetInt64(3);
                        _Existencia.Categoria = _reader.GetString(4);
                        _Existencia.UltimaFechaAgregado = _reader.GetDateTime(5);
                        _Existencia.Imagen = (byte[])_reader[6];
                        _Existencia.IdProveedor = _reader.GetInt64(7);



                        _listaExistencia.Add(_Existencia);
                    }

                    _reader.Close();
                    _command.ExecuteNonQuery();

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

            return _listaExistencia;
        }
        // BUSCAR EXISTENCIA POR ID 

        public static List<Existencia> BuscarExistenciaPorId(Int64 pId) 
        {
            List<Existencia> _listaExistencia = new List<Existencia>();
            //NO ES OBTENER EXISTENCIA POR ID

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("BuscarExistenciaPorId", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Id", pId);

                    SqlDataReader _reader = _command.ExecuteReader();


                    while (_reader.Read())
                    {
                        Existencia _Existencia = new Existencia();

                        _Existencia.Id = _reader.GetInt64(0);
                        _Existencia.Nombre = _reader.GetString(1);
                        _Existencia.Codigo = _reader.GetString(2);
                        _Existencia.Cantidad = _reader.GetInt64(3);
                        _Existencia.Categoria = _reader.GetString(4);
                        _Existencia.UltimaFechaAgregado = _reader.GetDateTime(5);
                        _Existencia.Imagen = (byte[])_reader[6];
                        _Existencia.IdProveedor = _reader.GetInt64(7);



                        _listaExistencia.Add(_Existencia);
                    }

                    _reader.Close();
                    _command.ExecuteNonQuery();

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

            return _listaExistencia;
        }


        public static int AgregarExistencia(Existencia pExistencia)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarExistencia", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    //PARAMETROS
                    _command.Parameters.AddWithValue("@Nombre", pExistencia.Nombre);
                    _command.Parameters.AddWithValue("@Codigo", pExistencia.Codigo);
                    _command.Parameters.AddWithValue("@CantidadDisponible", pExistencia.Cantidad);
                    _command.Parameters.AddWithValue("@Categoria", pExistencia.Categoria);
                    _command.Parameters.AddWithValue("@UltimaF", pExistencia.UltimaFechaAgregado);
                    _command.Parameters.AddWithValue("@Fotografia", pExistencia.Imagen);
                    _command.Parameters.AddWithValue("@ÍdProveedor", pExistencia.IdProveedor);


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

        public static int EditarExistencia(Existencia pExistencia)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EditarExistencia", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    //PARAMETROS
                    _command.Parameters.AddWithValue("@Id", pExistencia.Id);
                    _command.Parameters.AddWithValue("@Nombre", pExistencia.Nombre);
                    _command.Parameters.AddWithValue("@Codigo", pExistencia.Codigo);
                    _command.Parameters.AddWithValue("@CantidadDisponible", pExistencia.Cantidad);
                    _command.Parameters.AddWithValue("@Categoria", pExistencia.Categoria);
                    _command.Parameters.AddWithValue("@UltimaF", pExistencia.UltimaFechaAgregado);
                    _command.Parameters.AddWithValue("@Fotografia", pExistencia.Imagen);
                    _command.Parameters.AddWithValue("@ÍdProveedor", pExistencia.IdProveedor);


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
        public static int EliminarExistencia(Int64 pId)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarExistencia", _connection);
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

        public static List<Existencia> BuscarExistenciaPorNombreOrden(string pNombre, string pParametro)
        {
            List<Existencia> _listaExistencia = new List<Existencia>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("BuscarExistenciasPorNombre", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Nombre", pNombre);
                    _command.Parameters.AddWithValue("@Parametro", pParametro);

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Existencia _Existencia = new Existencia();

                        _Existencia.Id = _reader.GetInt64(0);
                        _Existencia.Nombre = _reader.GetString(1);
                        _Existencia.Codigo = _reader.GetString(2);
                        _Existencia.Cantidad = _reader.GetInt64(3);
                        _Existencia.Categoria = _reader.GetString(4);
                        _Existencia.UltimaFechaAgregado = _reader.GetDateTime(5);
                        _Existencia.Imagen = (byte[])_reader[6];
                        _Existencia.IdProveedor = _reader.GetInt64(7);
                        _listaExistencia.Add(_Existencia);
                    }

                    _reader.Close();
                    _command.ExecuteNonQuery();

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

            return _listaExistencia;

        }

        public static List<Existencia> BuscarExistenciaPorCodigo(string pCodigo, string pParametro)
        {
            List<Existencia> _listaExistencia = new List<Existencia>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("BuscarExistenciaPorCodigo", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Nombre", pCodigo);
                    _command.Parameters.AddWithValue("@Parametro", pParametro);

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Existencia _Existencia = new Existencia();

                        _Existencia.Id = _reader.GetInt64(0);
                        _Existencia.Nombre = _reader.GetString(1);
                        _Existencia.Codigo = _reader.GetString(2);
                        _Existencia.Cantidad = _reader.GetInt64(3);
                        _Existencia.Categoria = _reader.GetString(4);
                        _Existencia.UltimaFechaAgregado = _reader.GetDateTime(5);
                        _Existencia.Imagen = (byte[])_reader[6];
                        _Existencia.IdProveedor = _reader.GetInt64(7);
                        _listaExistencia.Add(_Existencia);
                    }

                    _reader.Close();
                    _command.ExecuteNonQuery();

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

            return _listaExistencia;

        }

        public static List<Existencia> OrdenarExistencia(string pParametro)
        {
            List<Existencia> _listaExistencia = new List<Existencia>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("OrdenarExistencia", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    
                    _command.Parameters.AddWithValue("@Parametro", pParametro);

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Existencia _Existencia = new Existencia();

                        _Existencia.Id = _reader.GetInt64(0);
                        _Existencia.Nombre = _reader.GetString(1);
                        _Existencia.Codigo = _reader.GetString(2);
                        _Existencia.Cantidad = _reader.GetInt64(3);
                        _Existencia.Categoria = _reader.GetString(4);
                        _Existencia.UltimaFechaAgregado = _reader.GetDateTime(5);
                        _Existencia.Imagen = (byte[])_reader[6];
                        _Existencia.IdProveedor = _reader.GetInt64(7);
                        _listaExistencia.Add(_Existencia);
                    }

                    _reader.Close();
                    _command.ExecuteNonQuery();

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

            return _listaExistencia;

        }
    }
}
