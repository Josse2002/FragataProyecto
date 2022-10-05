using Fragata.DAL;
using Fragata.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragata.BL
{
   public  class VentaBL
    {
        public List<Venta> ObtenerVentas()
        {
          

            try
            {
                return VentaDAL.ObtenerVentas();
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
        public List<Venta> BuscarVentaPorFecha(DateTime dateTime, string pParametro)
        {


            try
            {
                return VentaDAL.ObtenerVentasPorFecha(dateTime, pParametro);
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

        public List<Venta> OrdenarVenta(string pParametro)
        {


            try
            {
                return VentaDAL.OrdenarVenta(pParametro);
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

        public int AgregarVenta(Venta pVenta)
        {
            try
            {

                return VentaDAL.AgregarVenta(pVenta);
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
    }
}
