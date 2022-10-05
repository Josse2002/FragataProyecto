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
    public class ProveedorBL
    {
        //OBTENER PROVEEDOR
        public List<Proveedor> ObtenerProveedor()
        {
            try
            {
                return ProveedorDAL.ObtenerProveedor();
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
        //ELIMINAR PROVEEDOR
        public List<Proveedor> BuscarProveedorPorId(Int64 pId)
        {


            try
            {
                return ProveedorDAL.BuscarProveedorPorId(pId);

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




        //BUSCAR PROVEEDOR POR NOMBRE


        public List<Proveedor> BuscarProveedorPorNombre(string pNombre, string pParametro)
        {

            try
            {
                return ProveedorDAL.BuscarProveedorPorNombre(pNombre, pParametro);
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


        //BUSCAR PROVEEDOR POR EMPRESA 


        public List<Proveedor> BuscarProveedorPorEmpresa(string pEmpresa, string pParametro)
        {

            try
            {
                return ProveedorDAL.BuscarProveedorPorEmpresa(pEmpresa, pParametro);
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


        //ORDENAR PROVEEDOR

        public List<Proveedor> OrdenarProveedor(string pParametro)
        {

            try
            {
                return ProveedorDAL.OrdenarProveedor(pParametro);
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












