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

        #region OBTENER ENVIOS POR PROXIMIDAD...
        public List<Envio> ObtenerEnviosPorProximidad()
        {
            try
            {
                return EnvioDAL.OrdenarEnvioPorProximidad();
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


    }
}
