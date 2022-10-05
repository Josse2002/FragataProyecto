using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fragata.Entities;
using Fragata.DAL;
using System.Data.SqlClient;
using System.Data;

namespace Fragata.BL
{
    public class EnvioBL
    {

        #region OBTENER ENVIOS...
        public List<Envio> ObtenerEnvios()
        {
            try
            {
                return EnvioDAL.ObtenerEnvios();
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

        #region OBTENER ENVIOS ACTIVOS...
        public List<Envio> ObtenerEnviosActivos()
        {
            try
            {
                return EnvioDAL.ObtenerEnviosActivos();
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

        #region CANCELAR ENVIOS...
        public int CancelarEnvio(Int64 pId)
        {
            try
            {
                return EnvioDAL.CancelarEnvio(pId);
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

        #region AGREGAR ENVIOS...

        public int AgregarEnvio(Envio pEnvio)
        {
            try
            {
                return EnvioDAL.AgregarEnvios(pEnvio);
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

        #region EDITAR ENVIO...

        public int EditarEnvio(Envio pEnvio)
        {
            try
            {
                return EnvioDAL.EditarEnvio(pEnvio);
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (ArgumentException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion

        public int MarcarProgreso(Int64 pId, string pEstado)
        {
            

            try
            {
                return EnvioDAL.MarcarCompletado(pId, pEstado);
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (ArgumentException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #region BUSCAR ENVIO POR DIRECCION..
        public List<Envio> BuscarEmpleadoPorDireccion(string pDireccion, string pParametro)
        {
            try
            {
                return EnvioDAL.BuscarEnvioPorDireccion(pDireccion, pParametro);
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (TimeoutException ex)
            {
                throw;
            }
            catch (FormatException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region BUSCAR ENVIO POR TELEFONO..
        public List<Envio> BuscarEmpleadoPorTelefono(string pTelefono, string pParametro)
        {
            try
            {
                return EnvioDAL.BuscarEnvioPorTelefono(pTelefono, pParametro);
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (TimeoutException ex)
            {
                throw;
            }
            catch (FormatException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region BUSCAR ENVIO POR CORREO..
        public List<Envio> BuscarEmpleadoPorCorreo(string pCorreo, string pParametro)
        {
            try
            {
                return EnvioDAL.BuscarEnvioPorCorreo(pCorreo, pParametro);
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (TimeoutException ex)
            {
                throw;
            }
            catch (FormatException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region BUSCAR ENVIO POR TELEFONO..
        public List<Envio> OrdenarEnvio(string pParametro)
        {
            try
            {
                return EnvioDAL.OrdenarEnvio(pParametro);
            }
            catch (SqlException ex)
            {
                throw;
            }
            catch (TimeoutException ex)
            {
                throw;
            }
            catch (FormatException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion
    }

}
