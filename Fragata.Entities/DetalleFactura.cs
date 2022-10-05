using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragata.Entities
{
    public class DetalleFactura
    {
        public Int64 Id { get; set; }

        public Int32 Cantidad { get; set; }

        public Int64 IdProducto { get; set; }

        public Decimal PrecioUnitario { get; set; }

        public Decimal VentasNoSujetas { get; set; }

        public Decimal VentasExentas { get; set; }

        public Decimal VentasAfectas { get; set; }

        public Int64 IdFactura { get; set; }

        public string Estado { get; set; }



        public DetalleFactura() { }

        public DetalleFactura(Int64 pId, Int32 pCantidad,
           Int64 pIdFactura, String pEstado, Int64 pIdProducto, Decimal pVentasNS, Decimal pVentasEX,
           Decimal pPrecioUnitario, Decimal pVentasAF)
        {
            Id = pId;
            Cantidad = pCantidad;
            IdProducto = pIdProducto;
            PrecioUnitario = pPrecioUnitario;
            VentasNoSujetas = pVentasNS;
            VentasExentas = pVentasEX;
            IdFactura = pIdFactura;
            Estado = pEstado;
            VentasAfectas = pVentasAF;
            
           
            

        }
    }
        
}
