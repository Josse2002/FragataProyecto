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
    public class ProveedorDAL
    {
        public static List<Proveedor> ObtenerProveedor()
        {
            List<Proveedor> _listaProveedor = new List<Proveedor>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ObtenerProveedor", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();



                    while (_reader.Read())
                    {

                        Proveedor _proveedor = new Proveedor();
                        _proveedor.Id = _reader.GetInt64(0);
                        _proveedor.Nombre = _reader.GetString(1);
                        _proveedor.Empresa = _reader.GetString(2);
                        _proveedor.NombreEncargado = _reader.GetString(3);
                        _proveedor.Direccion = _reader.GetString(4);
                        _proveedor.Fotografia = (byte[])_reader[5];

                        _listaProveedor.Add(_proveedor);
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

            return _listaProveedor;
        }

        public static List<Proveedor> BuscarProveedorPorId(Int64 pId)
        {
            List<Proveedor> _listaProveedor = new List<Proveedor>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ObtenerProveedorPorId", _connection);
                    _command.CommandType = CommandType.StoredProcedure;
                    _command.Parameters.AddWithValue("@Id", pId);

                    SqlDataReader _reader = _command.ExecuteReader();



                    while (_reader.Read())
                    {

                        Proveedor _proveedor = new Proveedor();
                        _proveedor.Id = _reader.GetInt64(0);
                        _proveedor.Nombre = _reader.GetString(1);
                        _proveedor.Empresa = _reader.GetString(2);
                        _proveedor.NombreEncargado = _reader.GetString(3);
                        _proveedor.Direccion = _reader.GetString(4);
                        _proveedor.Fotografia = (byte[])_reader[5];

                        _listaProveedor.Add(_proveedor);
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

            return _listaProveedor;
        }



        //BUSCAR PROVEEDOR POR NOMBRE


        public static List<Proveedor> BuscarProveedorPorNombre(string pNombre, string pParametro)
        {
            List<Proveedor> _listaProveedor = new List<Proveedor>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("BuscarProveedorPorNombre", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    _command.Parameters.AddWithValue("@Nombre", pNombre);
                    _command.Parameters.AddWithValue("@Parametro", pParametro);



                    while (_reader.Read())
                    {

                        Proveedor _proveedor = new Proveedor();
                        _proveedor.Id = _reader.GetInt64(0);
                        _proveedor.Nombre = _reader.GetString(1);
                        _proveedor.Empresa = _reader.GetString(2);
                        _proveedor.NombreEncargado = _reader.GetString(3);
                        _proveedor.Direccion = _reader.GetString(4);
                        _proveedor.Fotografia = (byte[])_reader[5];

                        _listaProveedor.Add(_proveedor);
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

            return _listaProveedor;
        }


        //BUSCAR PROVEEDOR POR EMPRESA 


        public static List<Proveedor> BuscarProveedorPorEmpresa(string pEmpresa, string pParametro)
        {
            List<Proveedor> _listaProveedor = new List<Proveedor>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("BuscarProveedorPorEmpresa", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    _command.Parameters.AddWithValue("@Empresa", pEmpresa);
                    _command.Parameters.AddWithValue("@Parametro", pParametro);



                    while (_reader.Read())
                    {

                        Proveedor _proveedor = new Proveedor();
                        _proveedor.Id = _reader.GetInt64(0);
                        _proveedor.Nombre = _reader.GetString(1);
                        _proveedor.Empresa = _reader.GetString(2);
                        _proveedor.NombreEncargado = _reader.GetString(3);
                        _proveedor.Direccion = _reader.GetString(4);
                        _proveedor.Fotografia = (byte[])_reader[5];

                        _listaProveedor.Add(_proveedor);
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

            return _listaProveedor;
        }


        //ORDENAR PROVEEDOR

        public static List<Proveedor> OrdenarProveedor(string pParametro)
        {
            List<Proveedor> _listaProveedor = new List<Proveedor>();

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("OrdenarProvedor", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    _command.Parameters.AddWithValue("@Parametro", pParametro);



                    while (_reader.Read())
                    {

                        Proveedor _proveedor = new Proveedor();
                        _proveedor.Id = _reader.GetInt64(0);
                        _proveedor.Nombre = _reader.GetString(1);
                        _proveedor.Empresa = _reader.GetString(2);
                        _proveedor.NombreEncargado = _reader.GetString(3);
                        _proveedor.Direccion = _reader.GetString(4);
                        _proveedor.Fotografia = (byte[])_reader[5];

                        _listaProveedor.Add(_proveedor);
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

            return _listaProveedor;
        }




    }
}
