using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragata.Entities
{
   public class DetallePedido
    {
        public Int64 Id { get; set; }

        public Decimal CostoEnvio { get; set; }

        public Int64 Cantidad { get; set; }

        public string DescripcionPersonalizado { get; set; }

        public Int64 IdPedido { get; set; }

        public string Estado { get; set; }

        public DetallePedido() { }

        public DetallePedido(Int64 pId, Decimal pCostoEnvio, Int64 pCantidad, 
            String pDescripcionPersonalizado, Int64 pIdPedido, string pEstado)
        {
            Id = pId;
            CostoEnvio = pCostoEnvio;
            Cantidad = pCantidad;
            DescripcionPersonalizado = pDescripcionPersonalizado;
            IdPedido = pIdPedido;
            Estado = pEstado;

        }



    }
}
