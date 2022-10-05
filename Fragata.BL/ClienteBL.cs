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
    public class ClienteBL
    {
        public List<Cliente> ObtenerClientes()
        {
            try
            {
                return ClienteDAL.ObtenerClientes();
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

        public int AgregarCliente(Cliente pCliente)
        {

            try
            {
                return ClienteDAL.AgregarCliente(pCliente);
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
        public int ModificarCliente(Cliente pCliente)
        {

            try
            {
                return ClienteDAL.ModificarCliente(pCliente);
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
        public int EliminarCliente(Int64 pId)
        {

            try
            {
                return ClienteDAL.EliminarCliente(pId);
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



        //BUSCAR CLIENTE POR NOMBRE


        public List<Cliente> BuscarClientePorNombre(string pNombre, string pParametro)
        {
           
            try
            {
                return ClienteDAL.BuscarClientePorNombre(pNombre, pParametro);
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




        //BUSCAR CLIENTE POR CORREO

        public List<Cliente> BuscarClientePorCorreo(string pCorreo, string pParametro)
        {

            try
            {
                return ClienteDAL.BuscarClientePorCorreo(pCorreo, pParametro);
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



        //ORDENRA CLIENTE


        public List<Cliente> OrdenarCliente(string pParametro)
        {
            
            try
            {
                return ClienteDAL.OrdenarCliente(pParametro);
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
                return ClienteDAL.Login(pCorreo, Ppassword);
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

        public  List<Cliente> BuscarClientePorCredenciales(string pCorreo, string Ppassword)
        {
            try
            {
                return ClienteDAL.BuscarClientePorCredenciales(pCorreo, Ppassword);
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