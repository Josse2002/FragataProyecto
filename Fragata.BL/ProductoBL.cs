using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fragata.Entities;
using Fragata.DAL;
using System.Data.SqlClient;
using System.Data;


namespace Fragata.BL
{
    public class ProductosBL
    {
        //OBTENER PRODUCTOS
        public List<Producto> ObtenerProduto()
        {
            try
            {
                return ProductoDAL.ObtenerProducto();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (TimeoutException)
            {
                throw;
            }
            catch (FormatException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //OBTENER PRODUCTOS
        public List<Producto> ObtenerUltimosProductos()
        {
            try
            {
                return ProductoDAL.ObtenerultimosProductos();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (TimeoutException)
            {
                throw;
            }
            catch (FormatException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //ELIMINAR PRODUCTO
        public int EliminarProducto(Int64 pId)
        {
            try
            {
                return ProductoDAL.EliminarProducto(pId);
            }
            catch (SqlException)
            {
                throw;
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }

        }
        //AGREGAR PRODUCTO
        public int AgregarProducto(Producto pProducto)
        {
            try
            {
                return ProductoDAL.AgregarProducto(pProducto);
            }
            catch (SqlException)
            {
                throw;
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;

            }
        }

        //MODIFICAR PRODUCTO
        public int ModificarProducto(Producto pProducto)
        {
            try
            {
                return ProductoDAL.ModificarProducto(pProducto);
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

        //BUSCAR PRODUCTO POR NOMBRE
        public List<Producto> BuscarProductoPorNombre(string pNombre, string pParametro)
        {
            try
            {
                return ProductoDAL.BuscarProductoPorNombre(pNombre, pParametro);
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
        //BUSCAR POR CODIGO
        public List<Producto> BuscarProductoPorCodigo(string pNombre, string pParametro)
        {
            try
            {
                return ProductoDAL.BuscarProductoPorCodigo(pNombre, pParametro);
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

        public List<Producto> OrdenarProducto(string pParametro)
        {


            try
            {
                return ProductoDAL.OrdenarProducto(pParametro);
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


        public List<Producto> ObtenerOrdenarProducto(string pParametro, string pNombre)
        {
            try
            {
                return ProductoDAL.ObtenerCategoriaBusqueda(pParametro, pNombre);
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
        public List<Producto> FiltrarCategoria(string pParametro)
        {
            try
            {
                return ProductoDAL.FiltrarCategoria(pParametro);
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
    }
}




