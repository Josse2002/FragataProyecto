using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Fragata.BL;
using Fragata.Entities;

namespace Fragata.Web
{
    public partial class index : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {
           
            ProductosBL _productosBL = new ProductosBL();
            carrusel.DataSource = _productosBL.ObtenerUltimosProductos();
            carrusel.DataBind();
            

            if ((string)Session["SesionCorreoCliente"] != null && (string)Session["SessionPassCliente"] != null)
            {
                if ((string)Session["Mensaje"] != "" && (string)Session["Mensaje"] != null)
                {
                     Notification.Visible = true;
                     Label2.Text = (string)Session["Mensaje"];
                }
                else
                {
                    Session["Mensaje"] = "";
                }

            }
            else
            {
                if ((string)Session["Mensaje"] != "" && (string)Session["Mensaje"] != null)
                {
                    Notification.Visible = true;
                    Label2.Text = (string)Session["Mensaje"];
                }
                else
                {
                    Session["Mensaje"] = "";
                }
            }
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            if ((string)Session["SesionCorreoCliente"] != null && (string)Session["SessionPassCliente"] != null)
            {
                Session["Mensaje"] = "¡Producto agregado a carrito!";
                string Id = HiddenField1.Value; //OBTENIENDO EL ID DEL PRODUCTO SELECCIONADO
                ProductosBL _pBl = new ProductosBL(); //INSTANCIANDO EL BL

                foreach (var item in _pBl.ObtenerProduto()) //RECORRIENDO LOS DATOS DE LA CONSULTA 
                {
                    if (Id == item.Id.ToString()) //VALIDANDO QUE EXISTA EL PRODUCTO SELECCIONADO
                    {
                        //ASIGNANDO EL VALOR DE LA SESION CON LOS NUEVOS
                        Session["Id"] = Session["Id"] + "," + item.Id;
                        Session["Nombre"] = Session["Nombre"] + "," + item.Nombre;
                        Session["Precio"] = Session["Precio"] + item.Precio.ToString();
                        Session["Mensaje"] = "¡Producto agregado a carrito!";
                    }
                    

                }
            }
            else
            {
                Session["Mensaje"] = "Funcion no disponible hasta iniciar sesion";
                Response.Redirect("index.aspx");
            }
           
        }
    }
}