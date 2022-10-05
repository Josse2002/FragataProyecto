using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragata.Entities
{
    public class Producto
    {
        //Propiedades de clase//
        public Int64 Id { get; set; }

        public string Nombre { get; set; }

        public Decimal Precio { get; set; }

        public string CodigoProducto { get; set; }

        public string Descripccion { get; set; }

        public Byte[] Fotografia { get; set; }

        public DateTime FechaAgregado { get; set; }

        public string TipoEvento { get; set; }

        public string Existencias { get; set; }

        public string NumeroExistencias { get; set; }

        public string TipoProducto { get; set; }

        public Producto() { }

        public Producto(Int64 pId, string pNombre, Decimal pPrecio, string pCodigoProducto,
            string pDescripcion, Byte[] pFotografia, DateTime pFechaAgregado,
            string pTipoEvento,  string pExistencias, string pNumeroE, string pTipoProducto)

        {
            Id = pId;
            Nombre = pNombre;
            Precio = pPrecio;
            CodigoProducto = pCodigoProducto;
            Descripccion = pDescripcion;
            Fotografia = pFotografia;
            FechaAgregado = pFechaAgregado;
            TipoEvento = pTipoEvento;
            Existencias = pExistencias;
            NumeroExistencias = pNumeroE;
            TipoProducto = pTipoProducto;
        }
    }
}
