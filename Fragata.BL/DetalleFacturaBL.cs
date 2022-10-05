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
    public class DetalleFacturaBL
    {
        #region AGREGAR DETALLE FACTURA...

        public  int AgregarDetalleFactura(DetalleFactura pDetalleFactura)
        {

            try
            {
                return DetalleFacturaDAL.AgregarDetalleFactura(pDetalleFactura);
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

        #region ANULAR DETALLE FACTURA...

        public static int AnularDetalleFactura(Int64 pId)
        {

            try
            {
                return DetalleFacturaDAL.AnularDetalleFactura(pId);
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

        #region ORDENAR DETALLE FACTURA POR MONTO

        public  List<DetalleFactura> OrdenarDetalleFacturaPorMonto()
        {
            try
            {
                return DetalleFacturaDAL.OrdenarDetalleFacturaPorMonto();
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

        #region VER DETALLE FACTURAS ANULADAS Y ACTIVAS
        public int OrdenarPorEstado(string pEstado)
        {
            try
            {
                return DetalleFacturaDAL.OrdenarPorEstado(pEstado);
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

        #region EDITAR DETALLE FACTURA...


        public int ModificarDetalleFactura(DetalleFactura pDetalleFactura)
        {
            try
            {
                return DetalleFacturaDAL.ModificarDetalleFactura(pDetalleFactura);
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
    }
}
