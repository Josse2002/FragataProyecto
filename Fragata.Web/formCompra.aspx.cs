using Fragata.BL;
using Fragata.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fragata.Web
{
    public partial class formCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region GENERANDO EL CODIGO DEL PEDIDO...
                int longitud = 3;
                const string alfabeto = "abcdefghijklmnoprstuvwxyzABCDEFGHIJKLMNOPQRSTUWXYZ1234567890";
                StringBuilder token = new StringBuilder();
                Random rnd = new Random();

                for (int i = 0; i < longitud; i++)
                {
                    int indice = rnd.Next(alfabeto.Length);
                    token.Append(alfabeto[indice]);
                }
            #endregion
            CodigoPedido.Value = DateTime.Now.Month.ToString() + token + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Second.ToString();
            CodigoPedidoEnvio.Value = DateTime.Now.Month.ToString() + token + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Second.ToString();

            int Año = DateTime.Now.Year;
            int Dia = DateTime.Now.Day + 2;
            int Mes = DateTime.Now.Month;

            string FechaPedido = Año.ToString() + "-" + Mes.ToString() + "-"  + Dia.ToString();
            Label1.Text = FechaPedido;

            Session["Mensaje"] = "";
            if ((string)Session["Id"] != null)
            {
                string ProductosId = (string)Session["Id"];
                string[] ProductosCodigos = ProductosId.Split(',');
                List<Producto> listP = new List<Producto>();
                ProductosBL pbl = new ProductosBL();
                Decimal precioTotal = 0;

                for (int i = 0; i < ProductosCodigos.Length; i++)
                {
                    foreach (var item in pbl.ObtenerProduto())
                    {
                        if (item.Id.ToString() == ProductosCodigos[i])
                        {
                            Producto _pr = new Producto();  
                            _pr.Precio = item.Precio;
                            precioTotal = precioTotal + item.Precio;
                            listP.Add(_pr);

                        }
                    }

                }

                Total.InnerText = precioTotal.ToString();


            }
            else
            {
                Session["Mensaje"] = "Funcion disponible al iniciar sesion";
                Response.Redirect("index.aspx");
            }

        }

        protected void FinalizarPedido_ServerClick(object sender, EventArgs e)
        {
            try
            {
                if (CodigoPedidoEnvio.Value != "" && NombreUser.Value != "" && FechaRetiro.Value != "")
                {
                    PedidoBL _pedidoBL = new PedidoBL();
                    Pedido pedido = new Pedido();

                    pedido.CodigoPedido = Label2.Text;
                    pedido.Fecha = Convert.ToDateTime(Label4.Text);
                    pedido.Hora = Convert.ToDateTime(Label4.Text);
                    pedido.FormaEntrega = "En Fragata Gift";
                    pedido.precioPedido = Convert.ToDecimal(Total.InnerText);

                    string ProductosAgregar = (string)Session["Id"];
                    ProductosAgregar.Replace(" ", "");

                    pedido.Productos = ProductosAgregar.Remove(0, 1);

                    string ProductosString = ProductosAgregar;
                    string[] Productos = ProductosString.Split(',');

                    string Cantidad = "";
                    for (int i = 0; i < Productos.Length - 1 ; i++)
                    {
                        
                        Cantidad = Cantidad + "," + 1;
                    }

                    pedido.CantidadProductos = Cantidad.Remove(0, 1);
                    pedido.Usuario = Label3.Text;

                    int _resultado = _pedidoBL.AgregarPedido(pedido);
                    if (_resultado != 0)
                    {
                        Notificacion _N = new Notificacion();
                        _N.Fecha = DateTime.Now.Date;
                        _N.Hora = DateTime.Now;

                        _N.IdEmpleado = 4;
                        _N.Descripcion = "Se ha agregado un nuevo pedido desde la web con el codigo " + CodigoPedidoEnvio.Value;
                        
                        _N.Visualizacion = "E";
                        
                        
                        NotificacionBL _NotificacionBL = new NotificacionBL();
                        _NotificacionBL.AgregarNotificaciones(_N);

                        Response.Redirect("index.aspx");
                        Session["Id"] = null;
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void BotonEnvio_ServerClick(object sender, EventArgs e)
        {
            try
            {
                if (CodigoPedido.Value != "" && NombreCompleto.Value != "")
                {
                    PedidoBL _pedidoBL = new PedidoBL();
                    Pedido pedido = new Pedido();

                    pedido.CodigoPedido = CodigoPedido.Value;
                    pedido.Fecha = DateTime.Now;
                    pedido.Hora = DateTime.Now;
                    pedido.FormaEntrega = "Envio";
                    pedido.precioPedido = Convert.ToDecimal(TotalPagarEnvio.InnerText.Replace("$", ""));

                    string ProductosAgregar = (string)Session["Id"];
                    ProductosAgregar.Replace(" ", "");

                    pedido.Productos = ProductosAgregar.Remove(0, 1);

                    string ProductosString = ProductosAgregar;
                    string[] Productos = ProductosString.Split(',');

                    string Cantidad = "";
                    for (int i = 0; i < Productos.Length - 1; i++)
                    {

                        Cantidad = Cantidad + "," + 1;
                    }

                    pedido.CantidadProductos = Cantidad.Remove(0, 1);
                    pedido.Usuario = NombreCompleto.Value;

                    int _resultado = _pedidoBL.AgregarPedido(pedido);
                    if (_resultado != 0)
                    {
                        Notificacion _N = new Notificacion();
                        _N.Fecha = DateTime.Now;
                        _N.Hora = DateTime.Now;

                        _N.IdEmpleado = 4;
                        _N.Descripcion = "Se ha agregado un nuevo pedido desde la web con el codigo " + CodigoPedidoEnvio.Value;

                        _N.Visualizacion = "E";


                        NotificacionBL _NotificacionBL = new NotificacionBL();
                        _NotificacionBL.AgregarNotificaciones(_N);

                        Envio _envio = new Envio();
                        EnvioBL _envioBl = new EnvioBL();
                        foreach (var item in _pedidoBL.ObtenerPedidos())
                        {
                            if (item.CodigoPedido.ToString() == CodigoPedido.Value)
                            {
                                _envio.Hora = Convert.ToDateTime(FechaEnvio.Value);
                                _envio.Fecha = Convert.ToDateTime(FechaEnvio.Value);
                                _envio.Direccion = DireccionEnvio.Value;
                                _envio.IdPedido = item.Id;
                                _envio.Telefono = TelefonoEnvio.Value;
                                _envio.Mail = CorreoEnvio.Value;
                                _envio.PrecioEnvio = 0;
                            }
                        }

                        int resultado = _envioBl.AgregarEnvio(_envio);

                        if (resultado != 0)
                        {
                            Notificacion _Ne = new Notificacion();
                            _Ne.Fecha = DateTime.Now;
                            _Ne.Hora = DateTime.Now;

                            _Ne.IdEmpleado = 4;
                            _Ne.Descripcion = "Se ha agregado un nuevo envio y pedido desde la web con el codigo de pedido " + CodigoPedido.Value;

                            _Ne.Visualizacion = "E";


                            NotificacionBL _NotificacionbL = new NotificacionBL();
                            _NotificacionbL.AgregarNotificaciones(_Ne);




                            var names = ProductosString;
                            List<string> nameList = names.Split(',').ToList();

                            var cantidad = Cantidad.Remove(0, 1);
                            List<string> cantidadList = Cantidad.Split(',').ToList();
                            ProductosBL _p = new ProductosBL();
                            string products = "";

                            for (int i = 0; i < nameList.Count; i++)
                            {
                                foreach (var producto in _p.ObtenerProduto())
                                {
                                    if (nameList[i] == producto.Id.ToString())
                                    {
                                        string valorProductos =

                                           "<tr>" +

                                             "<th scope='row'>" + nameList[i] + "</th >" +

                                              "<td>" + producto.Nombre + "</td>" +

                                              "<td>" + "$" + producto.Precio + "</td >" +

                                              "<td>" + "$" + producto.Precio * Convert.ToDecimal(cantidadList[i]) + "</td >" +

                                            "</tr>";

                                        products = products + " " + valorProductos;
                                    }

                                }

                            }

                            MailMessage correo = new MailMessage();
                            correo.From = new MailAddress("AtencionFragata@gmail.com", "Fragata Gift Service Worker", System.Text.Encoding.UTF8);//Correo de salida
                            correo.To.Add(CorreoEnvio.Value);
                            correo.Subject = "Fragata Gift - Factura";
                            correo.Body = "<link href='https://bootswatch.com/5/solar/bootstrap.min.css' rel='stylesheet'crossorigin='anonymous'>" +
                    "<section >" +
                    "<div style='width:20%; margin: 0% 40%'>" +
                    "<img style='width: 200px' src='https://scontent.fsal1-1.fna.fbcdn.net/v/t1.15752-9/245203631_595219308190390_5776026127206082625_n.png?_nc_cat=111&ccb=1-5&_nc_sid=ae9488&_nc_ohc=pUvhWlj6VAYAX8qJvSg&_nc_ht=scontent.fsal1-1.fna&oh=c7f69bb50c3a385e0ab99e964b600d17&oe=6188FB09' alt='MDN'>" +
                    "</div>" +
                    "<h2 style='text-align:center;'>¡Gracias por tu compra!</h2>" +
                    "<p>!Muchas gracias por tu compra <strong>" + NombreCompleto.Value + "</strong> la compra se ha realizado con exito! Te entregamos un resumen de tu compra por medio de esta pequeña factura: <br></p>" +

                   "<div style='width: 100%; font-size: 15px;'>" +
                    "<table class='table'style='width: 100%; margin: 2% 0%; text-align:center;' >" +
                            "<thead style='background: #fddeff ; color:#3d3d3d; ' >" +
                                "<tr>" +
                                    "<th scope ='col'>Codigo</th>" +
                                    "<th scope ='col'>Nombre del producto</th>" +
                                    "<th scope ='col'>Precio Unitario</th>" +
                                    "<th scope ='col'>Ventas Afectas</th>" +
                                "</tr>" +

                             "</thead>" +

                            "<tbody>" +

                            Productos

                            + "</tbody>" +
                        "</table>" +
                        "</div>" +
                        "¡Te esperamos pronto!" +
                        "<h4>Fragata Gift<h4>" +
                        "Direccion: Avenida Morazán, Sonsonate <br>" +
                        "Telefono: 7605-2850 <br>" +
                        "<div style='display: flex; flex-direction: row; justify-content: center;'>" +
                        "<a style='margin: 0px 20px;' href='https://www.facebook.com/Fragata-gift-179955316216920'><img style='width: 30px;' src='https://cdn-icons-png.flaticon.com/512/174/174848.png'>" +
                        "<a style='margin: 0px 20px;' href='https://api.whatsapp.com/send/?phone=+50377981569&text&app_absent=0'><img style='width: 30px;' src='https://cdn-icons-png.flaticon.com/512/2111/2111728.png'>" +
                        "</div>" +
                        "</section" +
                        "<script src ='https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js' integrity = 'sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p' crossorigin='anonymous'></script>";

                            correo.IsBodyHtml = true;

                            correo.Priority = MailPriority.Normal;
                            SmtpClient smtp = new SmtpClient();
                            smtp.UseDefaultCredentials = false;
                            smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
                            smtp.Port = 587; //Puerto de salida
                            smtp.Credentials = new System.Net.NetworkCredential("jcastillo10h@gmail.com", "Kakaroto10");//Cuenta de correo
                            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                            smtp.EnableSsl = true;//True si el servidor de correo permite ssl
                            smtp.Send(correo);


                            Response.Redirect("index.aspx");
                        }
                    }    

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void AgregarEnvio()
        {
            try
            {
                PedidoBL _pedidoBL = new PedidoBL();
               
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}