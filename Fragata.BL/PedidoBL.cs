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
    public class PedidoBL
    {
        public List<Pedido> ObtenerPedidos()
        {
            try
            {
                return PedidoDAL.ObtenerPedidos();
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
        public int AgregarPedido(Pedido pedido)
        {
            try
            {
                return PedidoDAL.AgregarPedido(pedido);
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

        public int EditarPedido(Pedido pedido)
        {
            try
            {
                return PedidoDAL.EditarPedido(pedido);
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
        public List<Pedido> ObtenerPedidosActivos()
        {
            try
            {
                return PedidoDAL.ObtenerPedidosActivos();
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

        public List<Pedido> BuscarPedidoEnEnvio(string pTexto, string pParametro)
        {
            try
            {
                return PedidoDAL.BuscarPedidoEnEnvio(pTexto, pParametro);
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


        public List<Pedido> BuscarPedidoPorNombre(string pNombre, string pParametro)
        {
            try
            {
                return PedidoDAL.BuscarPedidoPorCliente(pNombre, pParametro);
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

        public List<Pedido> BuscarPedidoPorCodigo(string pCodigo, string pParametro)
        {
            try
            {
                return PedidoDAL.BuscarPedidoPorCodigo(pCodigo, pParametro);
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

        public List<Pedido> OrdenarPedido(string pParametro)
        {
            try
            {
                return PedidoDAL.OrdenarPedido(pParametro);
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

        public int CambiarEstado(Int64 pId, string pEstado)
        {
            try
            {
                return PedidoDAL.CambiarEstado(pId, pEstado);
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
