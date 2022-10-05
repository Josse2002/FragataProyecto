using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragata.Entities
{
    public class Cliente
    {
        //Propiedad de clase

        public Int64 Id { get; set; }

        public string Nombre { get; set; }

        public Int64 Edad { get; set; }

        public string Apellidos { get; set; }

        public string Genero { get; set; }

        public string Ciudad { get; set; }

        public string Telefono { get; set; }

        public string Clave { get; set;}

        public string CorreoElectronico { get; set; }

        public byte[] Fotografia { get; set; }

        public Cliente() { }


        public Cliente(Int64 pId, string pNombre,Int64 pEdad, string pApellidos,
             string pGenero, string pCiudad, string pTelefono, string pClave, string pCorreoElectronico, byte[] pFotografia)
        {
            Id = pId;
            Nombre = pNombre;
            Edad = pEdad;
            Apellidos = pApellidos;
            Genero = pGenero;
            Ciudad = pCiudad;
            Telefono = pTelefono;
            Clave = pClave;
            CorreoElectronico = pCorreoElectronico;
            Fotografia = pFotografia;

        }
      }
  }

