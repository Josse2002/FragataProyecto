using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragata.Entities
{
  public class Administrador
    {
        public Int64 Id { get; set; }


        public string Nombre { get; set; }


        public Int64 Edad { get; set; }


        public string Apellidos { get; set; }


        public string Genero { get; set; }


        public string DUI { get; set; }


        public string Clave { get; set; }


        public byte[] Fotografia { get; set; }

        public Administrador() { }


        public Administrador(Int64 pId, string pNombre,Int64 pEdad, string pApellidos, string pGenero,
             string pDUI, string pClave, byte[] pFotografia)
        {

            Id = pId;
            Nombre = pNombre;
            Edad = pEdad;
            Apellidos = pApellidos;
            Genero = pGenero;
            DUI = pDUI;
            Clave = pClave;
            Fotografia = pFotografia;
        


        }
    }

}


