using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fragata.Entities
{
    public class Pedido
    {
        public Int64 Id { get; set; }

   

        public DateTime Fecha { get; set; }

        public DateTime Hora { get; set; }

        public String CodigoPedido { get; set; }

        public String FormaEntrega { get; set; }

      

        public string Estado { get; set; }

        public Decimal precioPedido { get; set; }

        public string Productos { get; set; }

        public string Usuario { get; set; }

        public string CantidadProductos { get; set; }

        public Pedido() { }

        public Pedido(Int64 pId, DateTime pFecha, DateTime  pHora, String pCodigoPedido, String pFormaEntrega, string pProductos, string
             pUsuario, string pCantidadProductos)
        {
            Id = pId;
  
            Fecha = pFecha;
            Hora = pHora;
            CodigoPedido = pCodigoPedido;
            FormaEntrega = pFormaEntrega;
           
            Productos = pProductos;
            Usuario = pUsuario;
            CantidadProductos = pCantidadProductos;
        }
    }
}
