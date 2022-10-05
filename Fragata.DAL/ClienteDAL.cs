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
    public class ClienteDAL
    {
        public static List<Cliente> ObtenerClientes()
        {
            List<Cliente> _listaClientes = new List<Cliente>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ConsultarUsuario", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Cliente _cliente = new Cliente();


                        _cliente.Id = _reader.GetInt64(0);
                        _cliente.Nombre = _reader.GetString(1);
                        _cliente.Edad = _reader.GetInt32(2);
                        _cliente.Apellidos = _reader.GetString(3);
                        _cliente.Genero = _reader.GetString(4);
                        _cliente.Ciudad = _reader.GetString(5);
                        _cliente.Telefono = _reader.GetString(6);
                        _cliente.Clave = _reader.GetString(7);
                        //_cliente.Fotografia = (byte[])_reader[8];
                        _cliente.CorreoElectronico = _reader.GetString(9);


                        _listaClientes.Add(_cliente);
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

            return _listaClientes;

        }

        //AGREGAR UN NUEVO REGISTRO DE CLIENTE EN LA BASE DE DATOS
        public static int AgregarCliente(Cliente pCliente)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarUsuario", _connection);
                    _command.CommandType = CommandType.StoredProcedure;


                    //CONFIGURAR PARÁMETROS
                    _command.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
                    _command.Parameters.AddWithValue("@Telefono", pCliente.Telefono);
                    _command.Parameters.AddWithValue("@Clave", pCliente.Clave);
                    _command.Parameters.AddWithValue("@CorreoElectronico", pCliente.CorreoElectronico);
                    _command.Parameters.AddWithValue("@Imagen", pCliente.CorreoElectronico);

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
        public static int ModificarCliente(Cliente pCliente)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EditarUsuario", _connection);
                    _command.CommandType = CommandType.StoredProcedure;


                    //CONFIGURAR PARÁMETROS

                    _command.Parameters.AddWithValue("@Id", pCliente.Id);
                    _command.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
                    _command.Parameters.AddWithValue("@Edad", pCliente.Edad);
                    _command.Parameters.AddWithValue("@Apel" +
                        "" +
                        "lidos", pCliente.Apellidos);
                    _command.Parameters.AddWithValue("@Genero", pCliente.Genero);
                    _command.Parameters.AddWithValue("@Ciudad", pCliente.Ciudad);
                    _command.Parameters.AddWithValue("@Telefono", pCliente.Telefono);
                    _command.Parameters.AddWithValue("@Clave", pCliente.Clave);
                    _command.Parameters.AddWithValue("@CorreoElectronico", pCliente.CorreoElectronico);
                    _command.Parameters.AddWithValue("@Fotografia", pCliente.Fotografia);

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

        public static int EliminarCliente(Int64 pId)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarUsuario", _connection);
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





        //BUSCAR CLIENTE POR NOMBRE

        public static List<Cliente> BuscarClientePorNombre(string pNombre, string pParametro)
        {
            List<Cliente> _listaClientes = new List<Cliente>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("BuscarClientePorNombre", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();
                    _command.Parameters.AddWithValue("@Nombre", pNombre);
                    _command.Parameters.AddWithValue("@Parametro", pParametro);

                    while (_reader.Read())
                    {
                        Cliente _cliente = new Cliente();

                        _cliente.Id = _reader.GetInt64(0);
                        _cliente.Nombre = _reader.GetString(1);
                        _cliente.Telefono = _reader.GetString(2);
                        _cliente.Clave = _reader.GetString(3);
                        _cliente.CorreoElectronico = _reader.GetString(4);
                        _cliente.Fotografia = (byte[])_reader[5];


                        _listaClientes.Add(_cliente);
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

            return _listaClientes;

        }



        //BUSCAR CLIENTE POR CORREO

        public static List<Cliente> BuscarClientePorCorreo(string pCorreo, string pParametro)
        {
            List<Cliente> _listaClientes = new List<Cliente>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("BuscarClientePorCorreo", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();
                    _command.Parameters.AddWithValue("@Correo", pCorreo);
                    _command.Parameters.AddWithValue("@Parametro", pParametro);

                    while (_reader.Read())
                    {
                        Cliente _cliente = new Cliente();

                        _cliente.Id = _reader.GetInt64(0);
                        _cliente.Nombre = _reader.GetString(1);
                        _cliente.Telefono = _reader.GetString(2);
                        _cliente.Clave = _reader.GetString(3);
                        _cliente.CorreoElectronico = _reader.GetString(4);
                        _cliente.Fotografia = (byte[])_reader[5];


                        _listaClientes.Add(_cliente);
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

            return _listaClientes;

        }




        //ORDENRA CLIENTE


        public static List<Cliente> OrdenarCliente(string pParametro)
        {
            List<Cliente> _listaClientes = new List<Cliente>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("OrdenarCliente", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();
                    
                    _command.Parameters.AddWithValue("@Parametro", pParametro);

                    while (_reader.Read())
                    {
                        Cliente _cliente = new Cliente();

                        _cliente.Id = _reader.GetInt64(0);
                        _cliente.Nombre = _reader.GetString(1);
                        _cliente.Telefono = _reader.GetString(2);
                        _cliente.Clave = _reader.GetString(3);
                        _cliente.CorreoElectronico = _reader.GetString(4);
                        _cliente.Fotografia = (byte[])_reader[5];


                        _listaClientes.Add(_cliente);
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

            return _listaClientes;

        }
        public static bool Login(string pCorreo, string Ppassword)
        {
            try
            {
                using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();

                    SqlCommand _command = new SqlCommand("IniciarSesionClientes", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Correo", pCorreo);
                    _command.Parameters.AddWithValue("@Password", Ppassword);

                    SqlDataReader _reader = _command.ExecuteReader();

                    if (_reader.HasRows)
                    {

                        while (_reader.Read())
                        {
                            Cliente _cliente = new Cliente();
                            _cliente.Id = _reader.GetInt64(0);
                            _cliente.Nombre = _reader.GetString(1);
                            _cliente.Edad = _reader.GetInt32(2);
                            _cliente.Apellidos = _reader.GetString(3);
                            _cliente.Genero = _reader.GetString(4);
                            _cliente.Ciudad = _reader.GetString(5);
                            _cliente.Telefono = _reader.GetString(6);
                            _cliente.Clave = _reader.GetString(7);
                            _cliente.Fotografia = (byte[])_reader[8];
                            _cliente.CorreoElectronico = _reader.GetString(9);


                        }
                        return true;
                    }
                    else
                    {
                        return false;
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


        }

        public static List<Cliente> BuscarClientePorCredenciales(string pCorreo, string Ppassword)
        {
            List<Cliente> _listaClientes = new List<Cliente>();

            try
            {
                using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();

                    SqlCommand _command = new SqlCommand("IniciarSesionClientes", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Correo", pCorreo);
                    _command.Parameters.AddWithValue("@Password", Ppassword);

                    SqlDataReader _reader = _command.ExecuteReader();

                    if (_reader.HasRows)
                    {

                        while (_reader.Read())
                        {
                            Cliente _cliente = new Cliente();
                            _cliente.Id = _reader.GetInt64(0);
                            _cliente.Nombre = _reader.GetString(1);
                            _cliente.Edad = _reader.GetInt32(2);
                            _cliente.Apellidos = _reader.GetString(3);
                            _cliente.Genero = _reader.GetString(4);
                            _cliente.Ciudad = _reader.GetString(5);
                            _cliente.Telefono = _reader.GetString(6);
                            _cliente.Clave = _reader.GetString(7);
                            _cliente.Fotografia = (byte[])_reader[8];
                            _cliente.CorreoElectronico = _reader.GetString(9);

                            _listaClientes.Add(_cliente);
                        }
                        
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

            return _listaClientes;
        }




    }
}
