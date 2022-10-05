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
    public class EmpleadoBL
    {
        #region OBTENER EMPLEADOS...
        public List<Empleado> ObtenerEmpleados()
        {
            try
            {
                return EmpleadoDAL.ObtenerEmpleados();
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

        #region ELIMINAR EMPLEADOS...
        public int EliminarEmpleado(Int64 pId)
        {
            try
            {
                return EmpleadoDAL.EliminarEmpleado(pId);
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

        #region AGREGAR EMPLEADOS...

        public int AgregarEmpleado(Empleado pEmpleado)
        {
            try
            {
                return EmpleadoDAL.AgregarEmpleado(pEmpleado);
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

        #region EDITAR EMPLEADOS...

        public int EditarEmpleado(Empleado pEmpleado)
        {
            try
            {
                return EmpleadoDAL.ModificarEmpleado(pEmpleado);
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

        #region BUSCAR EMPLEADO POR NOMBRE..
        public List<Empleado> BuscarEmpleadoPorNombre(string pNombre, string pParametro)
        {
            try
            {
                return EmpleadoDAL.BuscarEmpleadoPorNombre(pNombre, pParametro);
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

        #region BUSCAR EMPLEADO POR DUI..
        public List<Empleado> BuscarEmpleadoPorDui(string pDUI, string pParametro)
        {
            try
            {
                return EmpleadoDAL.BuscarEmpleadosPorDui(pDUI, pParametro);
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

        public  List<Empleado> OrdenarEmpleado(string pParametro)
        {
           

            try
            {
                return EmpleadoDAL.OrdenarEmpleado(pParametro);
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
        public bool Login(string pCorreo, string Ppassword)
        {
            try
            {
                return EmpleadoDAL.Login(pCorreo, Ppassword);
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
        #region BUSCAR EMPLEADO POR ID..
        public List<Empleado> BuscarEmpleadoPorId(Int64 pId)
        {
            try
            {
                return EmpleadoDAL.BuscarEmpleadosPorID(pId);
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
