using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragata.Entities
{
    public class Proveedor
    {
        //Propiedades de clase//
        public Int64 Id { get; set; }

        public string Nombre { get; set; }

        public string Empresa { get; set; }

        public string NombreEncargado { get; set; }

        public string Direccion { get; set; }

        public Byte[] Fotografia { get; set; }

        public Proveedor() { }

        public Proveedor(Int64 pId, string pNombre, string pEmpresa, string pNombreEncargado,
            string pDireccion, Byte[] pFotografia)
        {
            Id = pId;
            Nombre = pNombre;
            Empresa = pEmpresa;
            NombreEncargado = pNombreEncargado;
            Direccion = pDireccion;
            Fotografia = pFotografia;
        }
    }
}
