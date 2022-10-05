using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragata.Entities
{
    public class Pago
    {
     //Propiedades de clase//

        public Int64 Id { get; set; }

        public DateTime HoraRecibido { get; set; }

        public DateTime FechaRecibido { get; set; }

        public Int64 IdPedido { get; set; }

        public string Estado { get; set; }

        public Pago() { }

        public Pago(Int64 pId, DateTime PHoraRecibido, DateTime pFechaRecibido, Int64 pIdPedido, string pEstado)
        {
            Id = pId;
            HoraRecibido = PHoraRecibido;
            FechaRecibido = pFechaRecibido;
            IdPedido = pIdPedido;
            Estado = pEstado;
        }


    }
}
