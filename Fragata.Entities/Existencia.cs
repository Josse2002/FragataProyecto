using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fragata.Entities
{
    public class Existencia
    {
        public Int64 Id { get; set; }

        public string Nombre { get; set; }

        public string Codigo { get; set; }

        public Int64 Cantidad { get; set; }

        public string Categoria { get; set; }

        public DateTime UltimaFechaAgregado { get; set; }

        public Byte[] Imagen { get; set; }

        public Int64 IdProveedor { get; set; }

        public Existencia() { }

        public Existencia(Int64 pId, string pNombre, string pCodigo, Int64 pCantidad, DateTime pUltimo,
            Byte[] pImagen, Int64 pIdProveedor)
        {
            Id = pId;
            Nombre = pNombre;
            Codigo = pCodigo;
            Cantidad = pCantidad;
            UltimaFechaAgregado = pUltimo;
            Imagen = pImagen;
            IdProveedor = pIdProveedor;
        }
    }
}
