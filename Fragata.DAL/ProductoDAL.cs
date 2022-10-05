using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Fragata.Entities;
using System.IO;

namespace Fragata.DAL
{
    
        public class ProductoDAL
        {
            //OBTENER PRODUCTO
            public static List<Producto> ObtenerProducto()
            {
                List<Producto> _listaProducto = new List<Producto>();
                try
                {
                    using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                    {
                        _connection.Open();

                        SqlCommand _command = new SqlCommand("ObtenerProducto", _connection);
                        _command.CommandType = CommandType.StoredProcedure;

                        SqlDataReader _reader = _command.ExecuteReader();

                        while (_reader.Read())
                        {
                            Producto _Producto = new Producto();
                            _Producto.Id = _reader.GetInt64(0);
                            _Producto.Nombre = _reader.GetString(1);
                            _Producto.Precio = _reader.GetDecimal(2);
                            _Producto.CodigoProducto = _reader.GetString(3);
                            _Producto.Descripccion = _reader.GetString(4);
                            _Producto.Fotografia = (byte[])_reader[5];
                            _Producto.FechaAgregado = _reader.GetDateTime(6);
                            _Producto.TipoEvento = _reader.GetString(7);
                            _Producto.Existencias = _reader.GetString(8);
                            _Producto.NumeroExistencias = _reader.GetString(9);
                            _Producto.TipoProducto = _reader.GetString(10);

                            _listaProducto.Add(_Producto);
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

                return _listaProducto;
            }

        //OBTENER ULTIMOS PRODUCTOS
        public static List<Producto> ObtenerultimosProductos()
        {
            List<Producto> _listaProducto = new List<Producto>();
            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ObtenerNuevosProductos", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Producto _Producto = new Producto();
                        _Producto.Id = _reader.GetInt64(0);
                        _Producto.Nombre = _reader.GetString(1);
                        _Producto.Precio = _reader.GetDecimal(2);
                        _Producto.CodigoProducto = _reader.GetString(3);
                        _Producto.Descripccion = _reader.GetString(4);
                        _Producto.Fotografia = (byte[])_reader[5];
                        _Producto.FechaAgregado = _reader.GetDateTime(6);
                        _Producto.TipoEvento = _reader.GetString(7);
                        _Producto.Existencias = _reader.GetString(8);
                        _Producto.NumeroExistencias = _reader.GetString(9);
                        _Producto.TipoProducto = _reader.GetString(10);

                        _listaProducto.Add(_Producto);
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

            return _listaProducto;
        }


        // AGREGAR PRODUCTO
        public static int AgregarProducto(Producto pProducto)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("AgregarProducto", _connection);
                    _command.CommandType = CommandType.StoredProcedure;

                    //PARAMETROS
                    _command.Parameters.AddWithValue("@Nombre", pProducto.Nombre);
                    _command.Parameters.AddWithValue("@Precio", pProducto.Precio);
                    _command.Parameters.AddWithValue("@CodigoProducto", pProducto.CodigoProducto);
                    _command.Parameters.AddWithValue("@Descripcion", pProducto.Descripccion);

                    _command.Parameters.AddWithValue("@Fotografia", pProducto.Fotografia);
                    _command.Parameters.AddWithValue("@FechaAgregado", pProducto.FechaAgregado);
                    _command.Parameters.AddWithValue("@TipoEvento", pProducto.TipoEvento);
                    _command.Parameters.AddWithValue("@Existencias", pProducto.Existencias);
                    _command.Parameters.AddWithValue("@NExistencias", pProducto.NumeroExistencias);
                    _command.Parameters.AddWithValue("@TipoProducto", pProducto.TipoProducto);

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
        //MODIFICAR PRODUCTO
        public static int ModificarProducto(Producto pProducto)
        {
            int resultado = 0;

            try
            {
                using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();
                    SqlCommand _command = new SqlCommand("ModificarProducto", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Id", pProducto.Id);
                    _command.Parameters.AddWithValue("@Nombre", pProducto.Nombre);
                    _command.Parameters.AddWithValue("@Precio", pProducto.Precio);
                    _command.Parameters.AddWithValue("@CodigoProducto", pProducto.CodigoProducto);
                    _command.Parameters.AddWithValue("@Descripcion", pProducto.Descripccion);
                    _command.Parameters.AddWithValue("@Fotografia", pProducto.Fotografia);
                    _command.Parameters.AddWithValue("@FechaAgregado", pProducto.FechaAgregado);
                    _command.Parameters.AddWithValue("@TipoEvento", pProducto.TipoEvento);
                    _command.Parameters.AddWithValue("@Existencias", pProducto.Existencias);
                    _command.Parameters.AddWithValue("@NExistencias", pProducto.NumeroExistencias);
                    _command.Parameters.AddWithValue("@TipoProducto", pProducto.TipoProducto);

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
        //ELIMINAR PRODUCTO
        public static int EliminarProducto(Int64 pId)
        {
            int _resultado = 0;

            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("EliminarProducto", _connection);
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

    //BUSCAR PRODUCTO POR NOMBRES
    public static List<Producto> BuscarProductoPorNombre(string pNombre, string pParametro)
    {
        List<Producto> _listaProducto = new List<Producto>();

        try
        {
            using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
            {
                _conn.Open();

                SqlCommand _command = new SqlCommand("BuscarProductoPorNombre", _conn);
                _command.CommandType = CommandType.StoredProcedure;

                _command.Parameters.AddWithValue("@Nombre", pNombre);
                _command.Parameters.AddWithValue("@Parametro", pParametro);

                SqlDataReader _reader = _command.ExecuteReader();

                while (_reader.Read())
                {

                    Producto _Producto = new Producto();

                    _Producto.Id = _reader.GetInt64(0);
                    _Producto.Nombre = _reader.GetString(1);
                    _Producto.Precio = _reader.GetDecimal(2);
                    _Producto.CodigoProducto = _reader.GetString(3);
                    _Producto.Descripccion = _reader.GetString(4);
                    _Producto.Fotografia = (byte[])_reader[5];
                    _Producto.FechaAgregado = _reader.GetDateTime(6);
                    _Producto.TipoEvento = _reader.GetString(7);
                    _Producto.Existencias = _reader.GetString(8);
                    _Producto.NumeroExistencias = _reader.GetString(9);


                    _listaProducto.Add(_Producto);
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

        return _listaProducto;
    }

        public static List<Producto> BuscarProductoPorCodigo(string pCodigo, string pParametro)
        {
            List<Producto> _listaProducto = new List<Producto>();

            try
            {
                using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();

                    SqlCommand _command = new SqlCommand("BuscarProductoPorCodigo", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@CodigoProducto", pCodigo);
                    _command.Parameters.AddWithValue("@Parametro", pParametro);

                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {

                        Producto _Producto = new Producto();

                        _Producto.Id = _reader.GetInt64(0);
                        _Producto.Nombre = _reader.GetString(1);
                        _Producto.Precio = _reader.GetDecimal(2);
                        _Producto.CodigoProducto = _reader.GetString(3);
                        _Producto.Descripccion = _reader.GetString(4);
                        _Producto.Fotografia = (byte[])_reader[5];
                        _Producto.FechaAgregado = _reader.GetDateTime(6);
                        _Producto.TipoEvento = _reader.GetString(7);
                        _Producto.Existencias = _reader.GetString(8);
                        _Producto.NumeroExistencias = _reader.GetString(9);
                        _Producto.TipoProducto = _reader.GetString(10);


                        _listaProducto.Add(_Producto);
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

            return _listaProducto;
        }

        public static List<Producto> OrdenarProducto(string pParametro)
        {
            List<Producto> _listaProductos = new List<Producto>();

            try
            {
                using (SqlConnection _conn = ComunDB.GetConnection() as SqlConnection)
                {
                    _conn.Open();

                    SqlCommand _command = new SqlCommand("OrdenarProducto", _conn);
                    _command.CommandType = CommandType.StoredProcedure;

                    _command.Parameters.AddWithValue("@Parametro", pParametro);
                    SqlDataReader _reader = _command.ExecuteReader();


                    while (_reader.Read())
                    {

                        Producto _Producto = new Producto();
                        _Producto.Id = _reader.GetInt64(0);
                        _Producto.Nombre = _reader.GetString(1);
                        _Producto.Precio = _reader.GetDecimal(2);
                        _Producto.CodigoProducto = _reader.GetString(3);
                        _Producto.Descripccion = _reader.GetString(4);
                        _Producto.Fotografia = (byte[])_reader[5];
                        _Producto.FechaAgregado = _reader.GetDateTime(6);
                        _Producto.TipoEvento = _reader.GetString(7);
                        _Producto.Existencias = _reader.GetString(8);
                        _Producto.NumeroExistencias = _reader.GetString(9);
                        _Producto.TipoProducto = _reader.GetString(10);

                        _listaProductos.Add(_Producto);
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

            return _listaProductos;
        }


        public static List<Producto> ObtenerCategoriaBusqueda(string pParametro, string pNombre)
        {
            List<Producto> _listaProducto = new List<Producto>();
            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("ObtenerProductosPreelaborados", _connection);
                    _command.CommandType = CommandType.StoredProcedure;
                    _command.Parameters.AddWithValue("@Parametro", pParametro);
                    _command.Parameters.AddWithValue("@Nombre", pNombre);
                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Producto _Producto = new Producto();
                        _Producto.Id = _reader.GetInt64(0);
                        _Producto.Nombre = _reader.GetString(1);
                        _Producto.Precio = _reader.GetDecimal(2);
                        _Producto.CodigoProducto = _reader.GetString(3);
                        _Producto.Descripccion = _reader.GetString(4);
                        _Producto.Fotografia = (byte[])_reader[5];
                        _Producto.FechaAgregado = _reader.GetDateTime(6);
                        _Producto.TipoEvento = _reader.GetString(7);
                        _Producto.Existencias = _reader.GetString(8);
                        _Producto.NumeroExistencias = _reader.GetString(9);
                        _Producto.TipoProducto = _reader.GetString(10);

                        _listaProducto.Add(_Producto);
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

            return _listaProducto;
        }

        public static List<Producto> FiltrarCategoria(string pParametro)
        {
            List<Producto> _listaProducto = new List<Producto>();
            try
            {
                using (SqlConnection _connection = ComunDB.GetConnection() as SqlConnection)
                {
                    _connection.Open();

                    SqlCommand _command = new SqlCommand("BuscarProductoPorCategoria", _connection);
                    _command.CommandType = CommandType.StoredProcedure;
                    _command.Parameters.AddWithValue("@Categoria", pParametro);
                 
                    SqlDataReader _reader = _command.ExecuteReader();

                    while (_reader.Read())
                    {
                        Producto _Producto = new Producto();
                        _Producto.Id = _reader.GetInt64(0);
                        _Producto.Nombre = _reader.GetString(1);
                        _Producto.Precio = _reader.GetDecimal(2);
                        _Producto.CodigoProducto = _reader.GetString(3);
                        _Producto.Descripccion = _reader.GetString(4);
                        _Producto.Fotografia = (byte[])_reader[5];
                        _Producto.FechaAgregado = _reader.GetDateTime(6);
                        _Producto.TipoEvento = _reader.GetString(7);
                        _Producto.Existencias = _reader.GetString(8);
                        _Producto.NumeroExistencias = _reader.GetString(9);
                        _Producto.TipoProducto = _reader.GetString(10);

                        _listaProducto.Add(_Producto);
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

            return _listaProducto;
        }
    }



}






