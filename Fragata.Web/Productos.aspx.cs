using Fragata.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fragata.Web
{
    public partial class Productos : System.Web.UI.Page
    {
        ProductosBL _productosBL = new ProductosBL();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            Imagenes.DataSource = _productosBL.ObtenerProduto();
            Imagenes.DataBind();
            TextBox1.AutoPostBack = true;
            btnTodos.Style.Add(HtmlTextWriterStyle.Color, "black");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Imagenes.DataSource = _productosBL.BuscarProductoPorNombre(TextBox1.Text, "Nombre");
            TextBox1.AutoPostBack = true;
            Imagenes.DataBind();

            btnsubmit.Style.Add(HtmlTextWriterStyle.Color, "black");
            btnTodos.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnRamos.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnDulceros.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnBisuteria.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnGlobos.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
        }

        protected void Unnamed_ServerClick(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                Imagenes.DataSource = _productosBL.ObtenerOrdenarProducto("Todos", TextBox1.Text);
            }
            else
            {
                Imagenes.DataSource = _productosBL.FiltrarCategoria("Todos");
            }
        }

       

        protected void btnsubmit_ServerClick(object sender, EventArgs e)
        {
            Imagenes.DataSource = _productosBL.FiltrarCategoria("Peluches");
            Imagenes.DataBind();
            btnsubmit.Style.Add(HtmlTextWriterStyle.Color, "black");
            btnTodos.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnRamos.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnDulceros.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnBisuteria.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnGlobos.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
        }

        protected void btnTodos_ServerClick(object sender, EventArgs e)
        {
            Imagenes.DataSource = _productosBL.ObtenerProduto();
            Imagenes.DataBind();
            btnTodos.Style.Add(HtmlTextWriterStyle.Color, "black");
            btnsubmit.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnRamos.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnDulceros.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnBisuteria.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnGlobos.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
        }

        protected void btnRamos_ServerClick(object sender, EventArgs e)
        {
            Imagenes.DataSource = _productosBL.FiltrarCategoria("Ramos");
            Imagenes.DataBind();

            btnRamos.Style.Add(HtmlTextWriterStyle.Color, "black");
            btnsubmit.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnTodos.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnDulceros.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnBisuteria.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnGlobos.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
        }

        protected void btnDulceros_ServerClick(object sender, EventArgs e)
        {
            Imagenes.DataSource = _productosBL.FiltrarCategoria("Dulceros");
            Imagenes.DataBind();
            btnDulceros.Style.Add(HtmlTextWriterStyle.Color, "black");
            btnsubmit.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnTodos.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnRamos.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnBisuteria.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnGlobos.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
        }

        protected void btnBisuteria_ServerClick(object sender, EventArgs e)
        {
            Imagenes.DataSource = _productosBL.FiltrarCategoria("Bisuteria");
            Imagenes.DataBind();

            btnBisuteria.Style.Add(HtmlTextWriterStyle.Color, "black");
            btnsubmit.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnTodos.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnDulceros.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnRamos.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnGlobos.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
        }

        protected void btnGlobos_ServerClick(object sender, EventArgs e)
        {
            Imagenes.DataSource = _productosBL.FiltrarCategoria("Globos");
            Imagenes.DataBind();

            btnGlobos.Style.Add(HtmlTextWriterStyle.Color, "black");
            btnsubmit.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnTodos.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnDulceros.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnBisuteria.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
            btnRamos.Style.Add(HtmlTextWriterStyle.Color, "#c4c3c3");
           
        }
    }
}