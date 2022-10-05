using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Fragata.Entities;
using System.IO;
using Fragata.Entities.Cache;

namespace Fragata.DAL
{
    public class EmpleadoDAL
    {
        #region OBTENER EMPLEADOS...
        //METODO PARA OBTENER EMPLEADOS

        public static List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> _listaEmpleados = new List<Empleado>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ConsultarEmpleado", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                   

                    while (_reader.Read())
                    {

                        Empleado _empleado = new Empleado();
                        _empleado.Id = _reader.GetInt64(0);
                        _empleado.Nombre = _reader.GetString(1);
                        _empleado.Edad = _reader.GetInt32(2);
                        _empleado.Apellidos = _reader.GetString(3);
                        _empleado.Genero = _reader.GetString(4);
                        _empleado.DUI = _reader.GetString(5);
                        _empleado.Cargo = _reader.GetString(6);
                        _empleado.Telefono = _reader.GetString(7);
                        _empleado.HorasTrabajo = _reader.GetDecimal(8);
                        _empleado.Clave = _reader.GetString(9);


                        //IMAGEN
                        _empleado.Imagen = (byte[])_reader[10];
                        _empleado.Permiso = _reader.GetString(11);
                        _empleado.Mail = _reader.GetString(12);

                        _listaEmpleados.Add(_empleado);
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

            return _listaEmpleados;
        }

        #endregion //METODO PARA OBTENER LOS EMPLEADOS

        #region AGREGAR EMPLEADOS...

        //METODO PARA AGREGAR UN NUEVO REGISTRO EN LA BASE DE DATOS

        public static int AgregarEmpleado(Empleado pEmpleado)
        {
            int _resultado = 0;
            

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarEmpleado", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    //PARAMETROS

                    _command.Parameters.AddWithValue("@Nombre", pEmpleado.Nombre);
                    _command.Parameters.AddWithValue("@Edad", pEmpleado.Edad);
                    _command.Parameters.AddWithValue("@Apellidos", pEmpleado.Apellidos);
                    _command.Parameters.AddWithValue("@Genero", pEmpleado.Genero);
                    _command.Parameters.AddWithValue("@DUI", pEmpleado.DUI);
                    _command.Parameters.AddWithValue("@Cargo", pEmpleado.Cargo);
                    _command.Parameters.AddWithValue("@Telefono", pEmpleado.Telefono);
                    _command.Parameters.AddWithValue("@HorasDeTrabajo", pEmpleado.HorasTrabajo);
                    _command.Parameters.AddWithValue("@Clave", pEmpleado.Clave);
                    _command.Parameters.AddWithValue("@Fotografia", pEmpleado.Imagen);
                    _command.Parameters.AddWithValue("@Email", pEmpleado.Mail);

                    _resultado =_command.ExecuteNonQuery();

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

        #region EDITAR EMPLEADOS...

        //MODIFICAR EMPLEADO

        public static int ModificarEmpleado(Empleado pEmpleado)
        {
            int resultado = 0;

            try
            {
                using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();

                    SqlCommand _command = new SqlCommand("EditarEmpleado", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Id", pEmpleado.Id);
                    _command.Parameters.AddWithValue("@Nombre", pEmpleado.Nombre);
                    _command.Parameters.AddWithValue("@Edad", pEmpleado.Edad);
                    _command.Parameters.AddWithValue("@Apellidos", pEmpleado.Apellidos);
                    _command.Parameters.AddWithValue("@Genero", pEmpleado.Genero);
                    _command.Parameters.AddWithValue("@DUI", pEmpleado.DUI);
                    _command.Parameters.AddWithValue("@Cargo", pEmpleado.Cargo);
                    _command.Parameters.AddWithValue("@Telefono", pEmpleado.Telefono);
                    _command.Parameters.AddWithValue("@HorasDeTrabajo", pEmpleado.HorasTrabajo);
                    _command.Parameters.AddWithValue("@Clave", pEmpleado.Clave);
                    _command.Parameters.AddWithValue("@Fotografia", pEmpleado.Imagen);
                    _command.Parameters.AddWithValue("@Email", pEmpleado.Mail);
                    

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

        #endregion

        #region ELIMINAR EMPLEADOS...
        //ELIMINAR REGISTROS DE LA BD

        public static int EliminarEmpleado(Int64 pId)
        {
            int _resultado = 0;

            try
            {
                using(SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarEmpleado", _connection);
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
        #endregion

        #region BUSCAR EMPLEADOS POR NOMBRE...
        //BUSCAR EMPLEADOS

        public static List<Empleado> BuscarEmpleadoPorNombre(string pNombre, string pParametro)
        {
            List<Empleado> _listaEmpleados = new List<Empleado>();

            try
            {
                using(SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();

                    SqlCommand _command = new SqlCommand("BuscarEmpleadoPorNombre", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Nombre", pNombre);
                    _command.Parameters.AddWithValue("@Parametro", pParametro);

                    SqlDataReader _reader = _command.ExecuteReader();
                   

                    while (_reader.Read())
                    {

                        Empleado _empleado = new Empleado();
                        _empleado.Id = _reader.GetInt64(0);
                        _empleado.Nombre = _reader.GetString(1);
                        _empleado.Edad = _reader.GetInt32(2);
                        _empleado.Apellidos = _reader.GetString(3);
                        _empleado.Genero = _reader.GetString(4);
                        _empleado.DUI = _reader.GetString(5);
                        _empleado.Cargo = _reader.GetString(6);
                        _empleado.Telefono = _reader.GetString(7);
                        _empleado.HorasTrabajo = _reader.GetDecimal(8);
                        _empleado.Clave = _reader.GetString(9);

                        //IMAGEN
                        _empleado.Imagen = (byte[])_reader[10];
                        _empleado.Permiso = _reader.GetString(11);
                        _empleado.Mail = _reader.GetString(12);
                        _listaEmpleados.Add(_empleado);
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

            return _listaEmpleados;
        }

        #endregion

        #region BUSCAR EMPLEADOS POR DUI...
        //BUSCAR EMPLEADOS

        public static List<Empleado> BuscarEmpleadosPorDui(string pDUI, string pParametro)
        {
            List<Empleado> _listaEmpleados = new List<Empleado>();

            try
            {
                using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();

                    SqlCommand _command = new SqlCommand("BuscarEmpleadoPorDUI", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@DUI", pDUI);
                    _command.Parameters.AddWithValue("@Parametro", pParametro);
                    SqlDataReader _reader = _command.ExecuteReader();


                    while (_reader.Read())
                    {

                        Empleado _empleado = new Empleado();
                        _empleado.Id = _reader.GetInt64(0);
                        _empleado.Nombre = _reader.GetString(1);
                        _empleado.Edad = _reader.GetInt32(2);
                        _empleado.Apellidos = _reader.GetString(3);
                        _empleado.Genero = _reader.GetString(4);
                        _empleado.DUI = _reader.GetString(5);
                        _empleado.Cargo = _reader.GetString(6);
                        _empleado.Telefono = _reader.GetString(7);
                        _empleado.HorasTrabajo = _reader.GetDecimal(8);
                        _empleado.Clave = _reader.GetString(9);
                       

                        //IMAGEN
                        _empleado.Imagen = (byte[])_reader[10];
                        _empleado.Permiso = _reader.GetString(11);
                        _empleado.Mail = _reader.GetString(12);

                        _listaEmpleados.Add(_empleado);
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

            return _listaEmpleados;
        }

        #endregion

        #region ORDENAR EMPLEADO...
        public static List<Empleado> OrdenarEmpleado(string pParametro)
        {
            List<Empleado> _listaEmpleados = new List<Empleado>();

            try
            {
                using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();

                    SqlCommand _command = new SqlCommand("OrdenarEmpleado", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Parametro", pParametro);
                    SqlDataReader _reader = _command.ExecuteReader();


                    while (_reader.Read())
                    {

                        Empleado _empleado = new Empleado();
                        _empleado.Id = _reader.GetInt64(0);
                        _empleado.Nombre = _reader.GetString(1);
                        _empleado.Edad = _reader.GetInt32(2);
                        _empleado.Apellidos = _reader.GetString(3);
                        _empleado.Genero = _reader.GetString(4);
                        _empleado.DUI = _reader.GetString(5);
                        _empleado.Cargo = _reader.GetString(6);
                        _empleado.Telefono = _reader.GetString(7);
                        _empleado.HorasTrabajo = _reader.GetDecimal(8);
                        _empleado.Clave = _reader.GetString(9);

                        //IMAGEN
                        _empleado.Imagen = (byte[])_reader[10];
                        _empleado.Permiso = _reader.GetString(11);
                        _empleado.Mail = _reader.GetString(12);


                        _listaEmpleados.Add(_empleado);
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

            return _listaEmpleados;
        }

    #endregion

        public static bool Login(string pCorreo, string Ppassword)
        {
            try
            {
                using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();

                    SqlCommand _command = new SqlCommand("IniciarSesion", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Correo", pCorreo);
                    _command.Parameters.AddWithValue("@Password", Ppassword);
                    
                    SqlDataReader _reader = _command.ExecuteReader();

                    if (_reader.HasRows)
                    {

                        while (_reader.Read())
                        {
                           
                            Session.Id = _reader.GetInt64(0);
                            Session.Nombre = _reader.GetString(1);
                            Session.Edad = _reader.GetInt32(2);
                            Session.Apellidos = _reader.GetString(3);
                            Session.Genero = _reader.GetString(4);
                            Session.DUI = _reader.GetString(5);
                            Session.Cargo = _reader.GetString(6);
                            Session.Telefono = _reader.GetString(7);
                            Session.HorasTrabajo = _reader.GetDecimal(8);
                            Session.Clave = _reader.GetString(9);
                            //IMAGEN
                            Session.Imagen = (byte[])_reader[10];
                            Session.Permiso = _reader.GetString(11);
                            Session.Mail = _reader.GetString(12);

                           
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

        #region BUSCAR EMPLEADOS POR ID...
        //BUSCAR EMPLEADOS

        public static List<Empleado> BuscarEmpleadosPorID(Int64 pId)
        {
            List<Empleado> _listaEmpleados = new List<Empleado>();

            try
            {
                using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();

                    SqlCommand _command = new SqlCommand("BuscarEmpleadoPorId", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Id", pId);
                   
                    SqlDataReader _reader = _command.ExecuteReader();


                    while (_reader.Read())
                    {

                        Empleado _empleado = new Empleado();
                        _empleado.Id = _reader.GetInt64(0);
                        _empleado.Nombre = _reader.GetString(1);
                        _empleado.Edad = _reader.GetInt32(2);
                        _empleado.Apellidos = _reader.GetString(3);
                        _empleado.Genero = _reader.GetString(4);
                        _empleado.DUI = _reader.GetString(5);
                        _empleado.Cargo = _reader.GetString(6);
                        _empleado.Telefono = _reader.GetString(7);
                        _empleado.HorasTrabajo = _reader.GetDecimal(8);
                        _empleado.Clave = _reader.GetString(9);


                        //IMAGEN
                        _empleado.Imagen = (byte[])_reader[10];
                        _empleado.Permiso = _reader.GetString(11);
                        _empleado.Mail = _reader.GetString(12);

                        _listaEmpleados.Add(_empleado);
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

            return _listaEmpleados;
        }

        #endregion







    }
}
