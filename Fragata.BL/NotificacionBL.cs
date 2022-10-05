using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fragata.Entities;
using Fragata.DAL;
using System.Data.SqlClient;

namespace Fragata.BL
{
    public class NotificacionBL
    {
        #region OBTENER NOTIFICACIONES...
        public List<Notificacion> ObtenerNotificaciones()
        {
            try
            {
                return NotificacionDAL.ObtenerNotificaciones();
            }
            catch (SqlException)
            {
                throw;
            }
            catch (TimeoutException)
            {
                throw;
            }
            catch (FormatException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region AGREGAR NOTIFICACIONES...

        public int AgregarNotificaciones(Notificacion pNotificacion)
        {
            try
            {
                return NotificacionDAL.AgregarNotificaciones(pNotificacion);
            }
            catch (SqlException)
            {
                throw;
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (ArgumentException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;

            }
        }

        #endregion

        public int ModificarVista(string pVista)
        {
            try
            {
                return NotificacionDAL.ModificarVista(pVista);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
