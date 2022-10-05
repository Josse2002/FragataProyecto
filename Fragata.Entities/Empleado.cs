using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragata.Entities
{
    public  class Empleado
    {
        //Propiedades de clase

        public   Int64 Id { get; set; }
        
        public   string Nombre { get; set; }

        public  Int64 Edad { get; set; }

        public   string Apellidos { get; set; }

        public   string Genero { get; set; }

        public  string DUI { get; set; }

        public  string Cargo { get; set; }

        public  string Telefono { get; set; }

        public   Decimal HorasTrabajo { get; set; }

        public   string Clave { get; set; }

        public   Byte[] Imagen { get; set; }

        public   string Mail { get; set; }

        public   string Permiso { get; set; }

        public Empleado() { }
        public Empleado(Int64 pId, string pNombre, Int64 pEdad, string pApellidos, string pGenero,
            string pDUI, string pCargo , string pTelefono, Decimal pHorasTrabajo, string pClave, Byte[] pImagen,
            string pMail, string pPermiso)
        {
            Id = pId;
            Nombre = pNombre;
            Edad = pEdad;
            Apellidos = pApellidos;
            Genero = pGenero;
            DUI = pDUI;
            Cargo = pCargo;
            Telefono = pTelefono;
            HorasTrabajo = pHorasTrabajo;
            Clave = pClave;
            Imagen = pImagen;
            Mail = pMail;
            Permiso = pPermiso;
        }

        

    }
}
