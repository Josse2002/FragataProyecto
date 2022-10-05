using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragata.Entities
{
   public class Recibo
    {
        public Int64 Id { get; set; }


       public string NombreCliente { get; set; }

        public DateTime Fecha { get; set; }

        public string Numero { get; set; }

        public string Productos { get; set; }

        public string Estado { get; set; }

        public Decimal Total { get; set; }

        public string VentasAfectas { get; set; }

        public Int64 IdPedido { get; set; }

        public Int64 IdEnvio { get; set; }

        public Recibo() { }

        public Recibo(Int64 pId, string pNombre, DateTime pFecha, string pNumero, string pProductos, string pEstado, Decimal pTotal,
            string pVA, Int64 pIdPedido, Int64 pIdEnvio)
        {

            Id = pId;
            NombreCliente = pNombre;
            Fecha = pFecha;
            Numero = pNumero;
            Productos = pProductos;
            Estado = pEstado;
            Total = pTotal;
            VentasAfectas = pVA;
            IdPedido = pIdPedido;
            IdEnvio = pIdEnvio;
        }
    }
}
