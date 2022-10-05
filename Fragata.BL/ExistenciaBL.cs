using Fragata.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fragata.DAL;

namespace Fragata.BL
{
    public class ExistenciaBL
    {
        public List<Existencia> ObtenerExistencia()
        {
            try
            {
                return ExistenciaDAL.ObtenerExistencia();
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
        public List<Existencia> BuscarExistenciaPorNombreId(string pNombre, string pParametro)
        {
            try
            {
                return ExistenciaDAL.BuscarExistenciaPorNombreOrden(pNombre, pParametro);
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

        public List<Existencia> OrdenarExistencia(string pParametro)
        {
            try
            {
                return ExistenciaDAL.OrdenarExistencia(pParametro);
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
        public  List<Existencia> BuscarExistenciaPorNombre(string pNombre)
        {
           

            try
            {
                return ExistenciaDAL.BuscarExistenciaPorNombre(pNombre);
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

        public List<Existencia> BuscarExistenciaPorCodigo(string pCodigo, string pParametro)
        {
            try
            {
                return ExistenciaDAL.BuscarExistenciaPorCodigo(pCodigo, pParametro);
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


        public List<Existencia> BuscarExistenciaPoId(Int64 pId)
        {


            try
            {
                return ExistenciaDAL.BuscarExistenciaPorId(pId);
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

        public Int64 AgregarExistencia(Existencia pExistencia)
        {
       

            try
            {
                return ExistenciaDAL.AgregarExistencia(pExistencia);
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

        public Int64 EditarExistencia(Existencia pExistencia)
        {


            try
            {
                return ExistenciaDAL.EditarExistencia(pExistencia);
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

        public Int64 EliminarExistencia(Int64 pId)
        {

            try
            {
                return ExistenciaDAL.EliminarExistencia(pId);
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
    }
}
