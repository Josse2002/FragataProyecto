using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragata.Entities
{
    public class Venta
    {

        public Int64 Id { get; set; }

        public DateTime FechaAgregado { get; set; }

        public Decimal CantidadPagada { get; set; }

        public Decimal Cambio { get; set; }

        public Decimal CantidadPagar { get; set; }

        public string AtentidoPor { get; set; }

        public string NombreUsuario { get; set; }

        public string Productos { get; set;  }

        public Venta() { }

        public Venta(Int64 pId, DateTime pFechaAgregado, Decimal pCantidadPagada, Decimal pCambio, Decimal pCantidadPagar, 
            string pNombreU, string pProducts, string pAtentido)
        {
            Id = pId;
            FechaAgregado = pFechaAgregado;
            CantidadPagada = pCantidadPagada;
            Cambio = pCambio;
            CantidadPagar = pCantidadPagar;
            AtentidoPor = pAtentido;
            NombreUsuario = pNombreU;
            Productos = pProducts;

        }
    }
}
