using Fragata.DAL;
using Fragata.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragata.BL
{
    public class FacturaBL
    {
        #region OBTENER FACTURAS...
        //OBTENER ENVIOS DE LA BASE DE DATOS

        public List<Recibo> ObtenerFacturas()
        {
            

            try
            {
                return FacturaDAL.ObtenerFactura();
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
        #endregion

        public int AgregarFactura(Recibo recibo)
        {
         

            try
            {
                return FacturaDAL.AgregarFactura(recibo);
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

        public  List<Recibo> BuscarFacturaNombre(string cliente, string parametro)
        {
 
            try
            {
                return FacturaDAL.BuscarFacturaNombre(cliente, parametro);
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

        public List<Recibo> BuscarFacturaNumero(string numero, string parametro)
        {

            try
            {
                return FacturaDAL.BuscarFacturaCodigo(numero, parametro);
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

        public List<Recibo> OrdenarFactura(string parametro)
        {

            try
            {
                return FacturaDAL.OrdenarFactura(parametro);
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
