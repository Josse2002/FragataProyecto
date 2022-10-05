using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fragata.Entities
{
    public class Notificacion
    {
        public Int64 Id { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime Hora { get; set; }

        public Int64 IdEmpleado { get; set; }
        
        public string Visualizacion { get; set; }

        public string Descripcion { get; set; }
        
        public string Vista { get; set; }

        public Notificacion() { }

        public Notificacion(Int64 pId, DateTime pFecha, DateTime pHora, Int64 pIdEmpleado, string pVisualizacion,
            string pDescripcion, string pVista)
        {
            Id = pId;
            Fecha = pFecha;
            Hora = pHora;
            IdEmpleado = pIdEmpleado;
            Visualizacion = pVisualizacion;
            Descripcion = pDescripcion;
            Vista = pVista;
        }

    }
}
