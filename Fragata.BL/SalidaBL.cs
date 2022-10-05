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
    public class SalidaBL
    {


        //OBTENER SALIDA


        public List<Salida> ObtenerSalida()
        {

            try
            {
                return SalidaDAL.ObtenerSalida();
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


        //AGREGAR SALIDA


        public int AgregarSalida(Salida pSalida)
        {

            try
            {
                return SalidaDAL.AgregarSalida(pSalida);
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


        //ANULAR SALIDA


        public int AnularSalida(Int64 pId)
        {

            try
            {
                return SalidaDAL.AnularSalida(pId);
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


        //BUSCAR SALIDA POR FECHA

        public List<Salida> BuscarSalidaPorFecha(DateTime pFecha, string pParametro)
        {

            try
            {
                return SalidaDAL.BuscarSalidaPorFecha(pFecha, pParametro);
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


        //ORDENAR SALIDA


        public List<Salida> OrdenarSalida(string pParametro)
        {


            try
            {
                return SalidaDAL.OrdenarSalida(pParametro);
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
