using Fragata.BL;
using Fragata.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fragata.Web
{
    public partial class registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BtnRegistro_ServerClick(object sender, EventArgs e)
        {
            try
            {
               
                ClienteBL clienteBL = new ClienteBL();
                Cliente _cliente = new Cliente();

                _cliente.Nombre = Nombre.Value;
                _cliente.CorreoElectronico = Mail.Value;
                _cliente.Telefono = Telefono.Value;
                _cliente.Clave = Password.Value;
                if (Nombre.Value != "" && Mail.Value != "" && Telefono.Value != "" && Password.Value != "")
                {
                    int _resultado = clienteBL.AgregarCliente(_cliente);
                    if (_resultado != 0)
                    {
                        Response.Redirect("index.aspx");
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            try
            {

                ClienteBL clienteBL = new ClienteBL();
                Cliente _cliente = new Cliente();

                _cliente.Nombre = Nombre.Value;
                _cliente.CorreoElectronico = Mail.Value;
                _cliente.Telefono = Telefono.Value;
                _cliente.Clave = Password.Value;

                byte[] image = null;
                if (ArchivoImagen.HasFile)
                {
                    using (BinaryReader reader = new BinaryReader(ArchivoImagen.PostedFile.InputStream))
                    {
                        image = reader.ReadBytes(ArchivoImagen.PostedFile.ContentLength);

                    }
                }

                _cliente.Fotografia = image;


                if (Nombre.Value != "" && Mail.Value != "" && Telefono.Value != "" && Password.Value != "")
                {
                    int _resultado = clienteBL.AgregarCliente(_cliente);
                    if (_resultado != 0)
                    {
                        Response.Redirect("index.aspx");
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void botonSesion_ServerClick(object sender, EventArgs e)
        {
            Session["Mensaje"] = "";
            ClienteBL clienteBL = new ClienteBL();
            if (NombreCliente.Value.ToString() != "" && PasswordUsuario.Value.ToString() != "")
            {
                var ValidLogin = clienteBL.Login(NombreCliente.Value.ToString(), PasswordUsuario.Value.ToString());

                if (ValidLogin == true)
                {
                    foreach (var item in clienteBL.BuscarClientePorCredenciales(NombreCliente.Value.ToString(), PasswordUsuario.Value.ToString()))
                    {
                        Session["NombreCliente"] = item.Nombre;
                        Session["EdadCliente"] = item.Edad;
                        Session["ApellidosCliente"] = item.Apellidos;
                        Session["GeneroCliente"] = item.Genero;
                        Session["ClaveCliente"] = item.Genero;
                        Session["ImagenCliente"] = item.Fotografia;
                        Session["CorreoCliente"] = item.CorreoElectronico;
                    }
                    Session["SesionCorreoCliente"] = NombreCliente.Value.ToString();
                    Session["SessionPassCliente"] = PasswordUsuario.Value.ToString();
                    Label1.Text = "Se ha iniciado sesion";
                    Session["Mensaje"] = "Se ha iniciado sesion correctamente";
                    Response.Redirect("index.aspx");
                    
                  
                }
                else
                {
                    Label1.Text = "NO se ha iniciado sesion";
                }
            }   
        }

        protected void botonSesion_ServerClick2(object sender, EventArgs e)
        {
            string Correo = HiddenField1.Value;
            string password = HiddenField2.Value;
            ClienteBL clienteBL = new ClienteBL();
            if (Correo != "" && password != "")
            {
                var ValidLogin = clienteBL.Login(Correo, password);

                if (ValidLogin == true)
                {
                    Session["SesionCorreoCliente"] = Correo;
                    Session["SessionPassCliente"] = password;
                    Label1.Text = "Se ha iniciado sesion";
                    HiddenField1.Value = "";
                    HiddenField2.Value = "";
                    Session["Mensaje"] = "Se ha iniciado sesion correctamente";
                    Response.Redirect("index.aspx");
                   
                }
                else
                {
                    Label1.Text = "Los datos ingresados son incorrectos o erroneos";
                    Label1.ForeColor = System.Drawing.Color.Red;
                    NombreCliente.Value = Correo;
                    PasswordUsuario.Value = "";
                }
            }
            
        }
    }
}