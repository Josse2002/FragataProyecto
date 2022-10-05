using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragata.Entities.Cache
{
    public static class Session
    {
        //Propiedades de clase

        public static Int64 Id { get; set; }

        public static string Nombre { get; set; }

        public static Int64 Edad { get; set; }

        public static string Apellidos { get; set; }

        public static string Genero { get; set; }

        public static string DUI { get; set; }

        public static string Cargo { get; set; }

        public static string Telefono { get; set; }

        public static Decimal HorasTrabajo { get; set; }

        public static string Clave { get; set; }

        public static Byte[] Imagen { get; set; }

        public static string Mail { get; set; }

        public static string Permiso { get; set; }
    }
}
