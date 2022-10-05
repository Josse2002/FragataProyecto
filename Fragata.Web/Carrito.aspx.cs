using Fragata.BL;
using Fragata.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fragata.Web
{
    public partial class Carrito : System.Web.UI.Page
    {
        ProductosBL producto = new ProductosBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Mensaje"] = "";
            if ((string)Session["Id"] != null)
            {
                string ProductosId = (string)Session["Id"];
                string[] ProductosCodigos = ProductosId.Split(',');
                List<Producto> listP = new List<Producto>();

                Decimal precioTotal = 0;
                for (int i = 0; i < ProductosCodigos.Length; i++)
                {
                    foreach (var item in producto.ObtenerProduto())
                    {
                        if (item.Id.ToString() == ProductosCodigos[i])
                        {
                            Producto _pr = new Producto();
                            _pr.Id = item.Id;
                            _pr.Nombre = item.Nombre;
                            _pr.CodigoProducto = item.CodigoProducto;
                            _pr.Descripccion = item.Descripccion;
                            _pr.Fotografia = item.Fotografia;
                            _pr.Precio = item.Precio;
                            precioTotal = precioTotal + item.Precio;

                            listP.Add(_pr);

                        }
                    }

                }
                Total.InnerText = precioTotal.ToString();
                Repeater1.DataSource = listP;
                Repeater1.DataBind();


            }
            else
            {
                Session["Mensaje"] = "Funcion disponible al iniciar sesion";
                Response.Redirect("index.aspx");
            }


        }

        protected void botonEliminar_ServerClick(object sender, EventArgs e)
        {
            string Id = Campo.Value.ToString();

            string texto = (string)Session["Id"];
            string[] ids = texto.Split(','); 
            string sesion = "";
            for (int i = 0; i < ids.Length; i++)
            {
                if (Id != ids[i])
                {
                    sesion = sesion + "," + ids[i].ToString();
                    Console.WriteLine(texto[i]);
                    Label1.Text = Id;
                }
            }
            

            Session["Id"] = sesion;
            Campo.Value = "";
        }
    }
}