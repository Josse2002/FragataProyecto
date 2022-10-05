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
    public class PagoBL
    {
        //OBTENER DATOS DE LA BASE DE DATOS
        public List<Pago> ObtenerPago()
        {
            try
            {
                return PagoDAL.ObtenerPago();
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

        public int EditarPago(Pago pPago)
        {
            try
            {
                return PagoDAL.ModificarPago(pPago);
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

        public int AnularPago(Int64 pId)
        {
            try
            {
                return PagoDAL.AnularPago(pId);
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

//FALTA


