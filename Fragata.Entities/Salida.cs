using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fragata.Entities;

namespace Fragata.Entities
{
    public class Salida
    {
        public Int64 Id { get; set; }

        public DateTime Fecha { get; set; }

        public string Motivo { get; set; }

        public Decimal Monto { get; set; }

        public Salida() { }

        public Salida(Int64 pId, DateTime pFecha, string pMotivo, Decimal pMonto)
        {
            Id = pId;
            Fecha = pFecha;
            Motivo = pMotivo;
            Monto = pMonto;
        }

    }
}
