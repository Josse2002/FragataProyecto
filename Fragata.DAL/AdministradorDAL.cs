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
    public class AdministradorDAL
    {
        public static List<Administrador> ObtenerAdministrador()
        {
            List<Administrador> _listaAdministrador = new List<Administrador>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ConsultarAdministrador", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Administrador _Administrador = new Administrador();

                        _Administrador.Id = _reader.GetInt64(0);
                        _Administrador.Nombre = _reader.GetString(1);
                        _Administrador.Edad = _reader.GetInt64(2);
                        _Administrador.Apellidos = _reader.GetString(3);
                        _Administrador.Genero = _reader.GetString(4);
                        _Administrador.DUI = _reader.GetString(5);
                        _Administrador.Clave = _reader.GetString(6);
                        _Administrador.Fotografia = (byte[])_reader[7];


                        _listaAdministrador.Add(_Administrador);
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

            return _listaAdministrador;

        }

        //AGREGAR UN NUEVO REGISTRO DE CLIENTE EN LA BASE DE DATOS
        public static int AgregarAdministrador(Administrador pAdministrador)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarAdministrador", _connection);
                    _command.CommandType = CommandType.StoredProcedure;


                    //CONFIGURAR PARÁMETROS
                    _command.Parameters.AddWithValue("@Nombre", pAdministrador.Nombre);
                    _command.Parameters.AddWithValue("@Edad", pAdministrador.Edad);
                    _command.Parameters.AddWithValue("@Apellidos", pAdministrador.Apellidos);
                    _command.Parameters.AddWithValue("@Genero", pAdministrador.Genero);
                    _command.Parameters.AddWithValue("@DUI", pAdministrador.DUI);
                    _command.Parameters.AddWithValue("@Clave", pAdministrador.Clave);
                    _command.Parameters.AddWithValue("@Fotografia", pAdministrador.Fotografia);

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

        //MODIFICAR EN LA BASE DE DATOS
        public static int ModificarAdministrador(Administrador pAdministrador)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EditarAdministrador", _connection);
                    _command.CommandType = CommandType.StoredProcedure;


                    //CONFIGURAR PARÁMETROS

                    _command.Parameters.AddWithValue("@Id", pAdministrador.Id);
                    _command.Parameters.AddWithValue("@Nombre", pAdministrador.Nombre);
                    _command.Parameters.AddWithValue("@Edad", pAdministrador.Edad);
                    _command.Parameters.AddWithValue("@Apellidos", pAdministrador.Apellidos);
                    _command.Parameters.AddWithValue("@Genero", pAdministrador.Genero);
                    _command.Parameters.AddWithValue("@DUI", pAdministrador.DUI);
                    _command.Parameters.AddWithValue("@Clave", pAdministrador.Clave);
                    _command.Parameters.AddWithValue("@Fotografia", pAdministrador.Fotografia);

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

        //ELIMINAR REGSTROS DE LA BD

        public static int EliminarAdministrador(Int64 pId)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarAdministrador", _connection);
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

        //OBTENER CLIENTES BUSCADOS YA REGISTRADOS EN LA BASE DE DATOS.
        public static List<Administrador> BuscarAdministradorPorNombres(string pNombre)
        {
            List<Administrador> _listaAdministrador = new List<Administrador>();
            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("BuscarAdministradorPorNombre", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Nombre", pNombre);

                    SqlDataReader _reader = _command.ExecuteReader();


                    while (_reader.Read())
                    {
                        Administrador _Administrador = new Administrador();

                        _Administrador.Id = _reader.GetInt64(0);
                        _Administrador.Nombre = _reader.GetString(1);
                        _Administrador.Edad = _reader.GetInt64(2);
                        _Administrador.Apellidos = _reader.GetString(3);
                        _Administrador.Genero = _reader.GetString(4);
                        _Administrador.DUI = _reader.GetString(5);
                        _Administrador.Clave = _reader.GetString(6);
                        _Administrador.Fotografia = (byte[])_reader[7];

                        _listaAdministrador.Add(_Administrador);
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

            return _listaAdministrador;

        }
    }
}