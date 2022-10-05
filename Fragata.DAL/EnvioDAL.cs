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
    public class EnvioDAL
    {

        #region OBTENER ENVIOS...
        //OBTENER ENVIOS DE LA BASE DE DATOS

        public static List<Envio> ObtenerEnvios()
        {
            List<Envio> _ListaEnvios = new List<Envio>();

            try
            {
                using(SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ObtenerEnvios", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Envio _Envio = new Envio();

                        _Envio.Id = _reader.GetInt64(0);
                        _Envio.Hora = _reader.GetDateTime(1);
                        _Envio.Fecha = _reader.GetDateTime(2);
                        _Envio.Direccion = _reader.GetString(3);
                        _Envio.IdPedido = _reader.GetInt64(4);
                        _Envio.Estado = _reader.GetString(5);
                        _Envio.Telefono = _reader.GetString(6);
                        _Envio.Mail = _reader.GetString(7);
                        _Envio.PrecioEnvio = _reader.GetDecimal(8);

                        _ListaEnvios.Add(_Envio);
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

            return _ListaEnvios;
        }
        #endregion

        #region AGREGAR ENVIOS...

        //AGREGAR ENVIOS A LA BASE DE DATOS

        public static int AgregarEnvios(Envio pEnvio)
        {
            int _result = 0;

            try
            {
                using(SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();
                    SqlCommand _command = new SqlCommand("AgregarEnvio", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    //PARAMETROS

                    _command.Parameters.AddWithValue("@Hora", pEnvio.Hora);
                    _command.Parameters.AddWithValue("@Fecha", pEnvio.Fecha);
                    _command.Parameters.AddWithValue("@Direccion", pEnvio.Direccion);
                    _command.Parameters.AddWithValue("@IdPedido", pEnvio.IdPedido);
                    _command.Parameters.AddWithValue("@Telefono", pEnvio.Telefono);
                    _command.Parameters.AddWithValue("@Mail", pEnvio.Mail);
                    _command.Parameters.AddWithValue("@PrecioEnvio", pEnvio.PrecioEnvio);

                    _result = _command.ExecuteNonQuery();
                    _connection.Close();

                    return _result;
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

        #region EDITAR ENVIO...

        public static int EditarEnvio(Envio pEnvio)
        {
            int resultado = 0;

            try
            {
                using(SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();
                    SqlCommand _command = new SqlCommand("EditarEnvio", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    //PARAMETROS
                    _command.Parameters.AddWithValue("@Id", pEnvio.Id);
                    _command.Parameters.AddWithValue("@Hora", pEnvio.Hora);
                    _command.Parameters.AddWithValue("@Fecha", pEnvio.Fecha);
                    _command.Parameters.AddWithValue("@Direccion", pEnvio.Direccion);
                    _command.Parameters.AddWithValue("@IdPedido", pEnvio.IdPedido);
                    _command.Parameters.AddWithValue("@Telefono", pEnvio.Telefono);
                    _command.Parameters.AddWithValue("@Mail", pEnvio.Mail);
                    _command.Parameters.AddWithValue("@PrecioEnvio", pEnvio.PrecioEnvio);

                    resultado = _command.ExecuteNonQuery();

                    _connection.Close();

                    return resultado;
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

        #region CANCELAR ENVIO...

        public static int CancelarEnvio(Int64 pId)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("CancelarEnvio", _connection);
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


        public static int MarcarCompletado(Int64 pId, string pEstado)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("MarcarEnvioCompletado", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    //FORMA LARGA DE CONFIGURAR PARÁMETROS
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

        #region BUSCAR ENVIO POR DIRECCION...
        //BUSCAR EMPLEADOS

        public static List<Envio> BuscarEnvioPorDireccion(string pDireccion, string pParametro)
        {
            List<Envio> _listaEnvios = new List<Envio>();

            try
            {
                using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();

                    SqlCommand _command = new SqlCommand("BuscarEnvioPorDireccion", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Direccion", pDireccion);
                    _command.Parameters.AddWithValue("@Parametro", pParametro);
                    SqlDataReader _reader = _command.ExecuteReader();


                    while (_reader.Read())
                    {
                        Envio _Envio = new Envio();

                        _Envio.Id = _reader.GetInt64(0);
                        _Envio.Hora = _reader.GetDateTime(1);
                        _Envio.Fecha = _reader.GetDateTime(2);
                        _Envio.Direccion = _reader.GetString(3);
                        _Envio.IdPedido = _reader.GetInt64(4);
                        _Envio.Estado = _reader.GetString(5);
                        _Envio.Telefono = _reader.GetString(6);
                        _Envio.Mail = _reader.GetString(7);
                        _Envio.PrecioEnvio = _reader.GetDecimal(8);

                        _listaEnvios.Add(_Envio);
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

            return _listaEnvios;
        }

        #endregion


        #region BUSCAR ENVIO POR TELEFONO...
        //BUSCAR EMPLEADOS

        public static List<Envio> BuscarEnvioPorTelefono(string pTelefono, string pParametro)
        {
            List<Envio> _listaEnvios = new List<Envio>();

            try
            {
                using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();

                    SqlCommand _command = new SqlCommand("BuscarEnvioPorTelefono", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Telefono", pTelefono);
                    _command.Parameters.AddWithValue("@Parametro", pParametro);
                    SqlDataReader _reader = _command.ExecuteReader();


                    while (_reader.Read())
                    {
                        Envio _Envio = new Envio();

                        _Envio.Id = _reader.GetInt64(0);
                        _Envio.Hora = _reader.GetDateTime(1);
                        _Envio.Fecha = _reader.GetDateTime(2);
                        _Envio.Direccion = _reader.GetString(3);
                        _Envio.IdPedido = _reader.GetInt64(4);
                        _Envio.Estado = _reader.GetString(5);
                        _Envio.Telefono = _reader.GetString(6);
                        _Envio.Mail = _reader.GetString(7);
                        _Envio.PrecioEnvio = _reader.GetDecimal(8);

                        _listaEnvios.Add(_Envio);
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

            return _listaEnvios;
        }

        #endregion

        #region BUSCAR ENVIO POR CORREO...
        //BUSCAR EMPLEADOS

        public static List<Envio> BuscarEnvioPorCorreo(string pCorreo, string pParametro)
        {
            List<Envio> _listaEnvios = new List<Envio>();

            try
            {
                using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();

                    SqlCommand _command = new SqlCommand("BuscarEnvioPorCorreo", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Correo", pCorreo);
                    _command.Parameters.AddWithValue("@Parametro", pParametro);
                    SqlDataReader _reader = _command.ExecuteReader();


                    while (_reader.Read())
                    {
                        Envio _Envio = new Envio();

                        _Envio.Id = _reader.GetInt64(0);
                        _Envio.Hora = _reader.GetDateTime(1);
                        _Envio.Fecha = _reader.GetDateTime(2);
                        _Envio.Direccion = _reader.GetString(3);
                        _Envio.IdPedido = _reader.GetInt64(4);
                        _Envio.Estado = _reader.GetString(5);
                        _Envio.Telefono = _reader.GetString(6);
                        _Envio.Mail = _reader.GetString(7);
                        _Envio.PrecioEnvio = _reader.GetDecimal(8);

                        _listaEnvios.Add(_Envio);
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

            return _listaEnvios;
        }

        #endregion

        #region ORDENAR ENVIO...
        public static List<Envio> OrdenarEnvio(string pParametro)
        {
            List<Envio> _listaEnvios = new List<Envio>();

            try
            {
                using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();

                    SqlCommand _command = new SqlCommand("OrdenarEnvio", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Parametro", pParametro);
                    SqlDataReader _reader = _command.ExecuteReader();


                    while (_reader.Read())
                    {
                        Envio _Envio = new Envio();

                        _Envio.Id = _reader.GetInt64(0);
                        _Envio.Hora = _reader.GetDateTime(1);
                        _Envio.Fecha = _reader.GetDateTime(2);
                        _Envio.Direccion = _reader.GetString(3);
                        _Envio.IdPedido = _reader.GetInt64(4);
                        _Envio.Estado = _reader.GetString(5);
                        _Envio.Telefono = _reader.GetString(6);
                        _Envio.Mail = _reader.GetString(7);
                        _Envio.PrecioEnvio = _reader.GetDecimal(8);

                        _listaEnvios.Add(_Envio);

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

            return _listaEnvios;
        }

        #endregion

        public static List<Envio> ObtenerEnviosActivos()
        {
            List<Envio> _ListaEnvios = new List<Envio>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ObtenerEnvioActivo", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Envio _Envio = new Envio();

                        _Envio.Id = _reader.GetInt64(0);
                        _Envio.Hora = _reader.GetDateTime(1);
                        _Envio.Fecha = _reader.GetDateTime(2);
                        _Envio.Direccion = _reader.GetString(3);
                        _Envio.IdPedido = _reader.GetInt64(4);
                        _Envio.Estado = _reader.GetString(5);
                        _Envio.Telefono = _reader.GetString(6);
                        _Envio.Mail = _reader.GetString(7);
                        _Envio.PrecioEnvio = _reader.GetDecimal(8);

                        _ListaEnvios.Add(_Envio);
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

            return _ListaEnvios;
        }

    }
}
