using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragata.Entities
{
    public class Envio
    {
        public Int64 Id { get; set; }

        public DateTime Hora { get; set; }

        public DateTime Fecha {get; set;}

        public string Direccion { get; set; }

        public Int64 IdPedido { get; set; }

        public string Estado { get; set; }

        public string Telefono { get; set; }

        public string Mail { get; set; }

        public Decimal PrecioEnvio { get; set; }
        
        public Envio() { }

        public Envio(Int64 pId, DateTime pHora, DateTime pFecha,  
            string pDireccion, Int64 pIdPedido, string pEstado, string pTelefono, string pMail, Decimal pPrecioEnvio)
        {
            Id = pId;
            Hora = pHora;
            Fecha = pFecha;
            Direccion = pDireccion;
            IdPedido = pIdPedido;
            Estado = pEstado;
            Telefono = pTelefono;
            Mail = pMail;
            PrecioEnvio = pPrecioEnvio;
        }
    }
}
