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
   public class DetallePedidoBL
    {
        #region AGREGAR DETALLEPEDIDOS...

        public int AgregarDetallePedido(DetallePedido pDetallePedido)
        {
            try
            {
                return DetallePedidoDAL.AgregarDetallePedido(pDetallePedido);
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

        #endregion

        #region ANULAR DETALLE PEDIDO...
        public int AnularDetallePedido(Int64 pId)
        {
            try
            {
                return DetallePedidoDAL.AnularDetallerPedido(pId);
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
        #endregion

        #region ORDENAR POR ESTADO...
        public int OrdenarPorEstado(string pEstado)
        {
            try
            {
                return DetallePedidoDAL.OrdenarPorEstado(pEstado);
                
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

        #region EDITAR DETALLE PEDIDO...
        public int ModificarDetallePedido(DetallePedido pDetallePedido)
        {

            try
            {
                return DetallePedidoDAL.ModificarDetallePedido(pDetallePedido);
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

        #region OBTENER DETALLE PEDIDO...
       

        public List<DetallePedido> ObtenerDetallePedido()
        {
            try
            {
                return DetallePedidoDAL.ObtenerDetallePedido();
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
    }
}
