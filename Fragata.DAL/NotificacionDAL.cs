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
    public class NotificacionDAL
    {
        #region OBTENER NOTIFICACIONES...

        public static List<Notificacion> ObtenerNotificaciones()
        {
            List<Notificacion> _listaNotificaciones = new List<Notificacion>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ObtenerNotificaciones", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Notificacion notificacion = new Notificacion();

                        notificacion.Id = _reader.GetInt64(0);
                        notificacion.Fecha = _reader.GetDateTime(1);
                        notificacion.Hora = _reader.GetDateTime(2);
                        notificacion.IdEmpleado = _reader.GetInt64(3);
                        notificacion.Descripcion = _reader.GetString(4);
                        notificacion.Visualizacion = _reader.GetString(5);
                        notificacion.Vista = _reader.GetString(6);

                        _listaNotificaciones.Add(notificacion);
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

            return _listaNotificaciones;
        }

        #endregion

        #region AGREGAR NOTIFICACIONES...

        public static int AgregarNotificaciones(Notificacion notificacion)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarNotificacion", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Fecha", notificacion.Fecha);
                    _command.Parameters.AddWithValue("@Hora", notificacion.Hora);
                    _command.Parameters.AddWithValue("@IdEmpleado", notificacion.IdEmpleado);
                    _command.Parameters.AddWithValue("@Descripcion", notificacion.Descripcion);
                    _command.Parameters.AddWithValue("@Visualizacion", notificacion.Visualizacion);
                    
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

        public static int ModificarVista(string pVista)
        {
            int resultado = 0;

            try
            {
                using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();
                    SqlCommand _command = new SqlCommand("ModificarVista", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Vista", pVista);
                    

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
    }
}
