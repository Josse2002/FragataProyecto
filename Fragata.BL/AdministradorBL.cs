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
    public class AdministradorBL
    {
        public List<Administrador> ObtenerAdministrador()
        {
            try
            {
                return AdministradorDAL.ObtenerAdministrador();
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

        public int AgregarAdministrador(Administrador pAdministrador)
        {

            try
            {
                return AdministradorDAL.AgregarAdministrador(pAdministrador);
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
        public int ModificarAdministrador(Administrador pAdministrador)
        {

            try
            {
                return AdministradorDAL.ModificarAdministrador(pAdministrador);
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
        public int EliminarAdministrador(Int64 pId)
        {

            try
            {
                return AdministradorDAL.EliminarAdministrador(pId);
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
        
        public List<Administrador> BuscarAdministradorPorNombres(string pNombre)
        {

            try
            {
                return AdministradorDAL.BuscarAdministradorPorNombres(pNombre);
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
    }
}


