using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Fragata.BL;
using Fragata.Entities;
using Fragata.Entities.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fragata.UI.WF
{
    public partial class Factura : Form
    {
        #region HACIENDO VENTANA SIN BORDE Y REDONDEADA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        #endregion

        FacturaCR facturaCR = null;
        List<Pedido> _pedidoLista = new List<Pedido>();
        string Numero = "";
        public Factura()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            crystalReportViewer2.Zoom(70);

        }
        List<Pedido> _pedidoList = new List<Pedido>();
        
        public Factura(Pedido _pedido)
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            btnAnular.Visible = false;
            _pedidoLista.Add(_pedido);
            crystalReportViewer2.Zoom(70);
            ProductosBL _p = new ProductosBL();
            _pedidoList.Add(_pedido);
            var names = _pedido.Productos;
            List<string> nameList = names.Split(',').ToList();

            var cantidad = _pedido.CantidadProductos;
            List<string> cantidadList = cantidad.Split(',').ToList();

            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            dt.Columns.Add("Cantidad", typeof(Int16));
            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Precio", typeof(string));
            dt.Columns.Add("Afectas", typeof(string));


            for (int i = 0; i < nameList.Count; i++)
            {
                foreach (var item in _p.ObtenerProduto())
                {
                    if (nameList[i] == item.Id.ToString())
                    {
                        dt.Rows.Add(cantidadList[i], item.Nombre, "$" + item.Precio, item.Precio * Convert.ToInt64(cantidadList[i]) );
                        
                    }

                }

            }

            ds.Tables.Add(dt);

            FacturaCR crystalReport2 = new FacturaCR();
           
            crystalReport2.SetDataSource(ds);
            crystalReport2.SetParameterValue("NombreUsuario", _pedido.Usuario);

            EnvioBL _envio = new EnvioBL();

            if (_pedido.FormaEntrega == "Envio")
            {
                foreach (var item in _envio.ObtenerEnvios())
                {
                    if (_pedido.Id == item.IdPedido)
                    {
                        crystalReport2.SetParameterValue("Direccion", item.Direccion);
                        crystalReport2.SetParameterValue("Telefono", item.Telefono);
                        crystalReport2.SetParameterValue("PedidoPrecio", "$" + (_pedido.precioPedido - item.PrecioEnvio).ToString());
                        crystalReport2.SetParameterValue("EnvioPrecio", "$" + item.PrecioEnvio.ToString());
                        txtNombreUsuario.Text = item.Mail;
                        txtNombreUsuario.Enabled = false;
                    }
                }
            }
            else
            {
                crystalReport2.SetParameterValue("Direccion", "");
                crystalReport2.SetParameterValue("Telefono", "");
                crystalReport2.SetParameterValue("PedidoPrecio", "$" + _pedido.precioPedido);
                crystalReport2.SetParameterValue("EnvioPrecio", "$" + "0.00");

            }

            crystalReport2.SetParameterValue("Total", "$" + _pedido.precioPedido);
            crystalReportViewer2.ReportSource = crystalReport2;
            facturaCR = crystalReport2;

            
            crystalReportViewer2.Zoom(68);
            FacturaBL fBl = new FacturaBL();
            int facturas = fBl.ObtenerFacturas().Count;
            if (facturas == 0)
            {
                crystalReport2.SetParameterValue("NumeroFactura", "00001");
                Numero = "00001";
            }
            else
            {
                foreach (var item in fBl.ObtenerFacturas())
                {
                    string ceros = "";
                    int numero = item.Id.ToString().Length;

                    for (int i = 0; i < 5 - numero; i++)
                    {
                        ceros = ceros + "0";
                    }

                    crystalReport2.SetParameterValue("NumeroFactura", ceros + Convert.ToInt64(item.Id + 1));
                    Numero = ceros + Convert.ToInt64(item.Id + 1);


                }
            }
            

            ds.WriteXmlSchema("Sample.xml");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           
            facturaCR.PrintToPrinter(1, false, 0, 0);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (crystalReportViewer2.DisplayToolbar == true)
            {
                guna2Button2.Text = "Mostrar mas opciones";
                crystalReportViewer2.DisplayToolbar = false;
            }
            else
            {
                crystalReportViewer2.DisplayToolbar = true;
                guna2Button2.Text = "Ocultar mas opciones";
            }
            
        }
        int i = 0;

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Button3.Enabled = false;
            lblStateF.Visible = true;
            lblStateF.Text = "Enviando Factura...";

           
            foreach (var item in _pedidoList)
            {
                EnvioBL _envio = new EnvioBL();
                string mail = "";
                if (item.FormaEntrega == "Envio")
                {
                    foreach (var valor in _envio.ObtenerEnvios())
                    {
                        if (item.Id == valor.IdPedido)
                        {
                            mail = valor.Mail;
                        }
                        else
                        {
                            mail = txtNombreUsuario.Text;
                        }
                    }
                }

                var names = item.Productos;
                string[] nameList = names.Split(',');

                var cantidad = item.CantidadProductos;
                List<string> cantidadList = cantidad.Split(',').ToList();
                ProductosBL _p = new ProductosBL();
                string Productos = "";

                for (int i = 0; i < nameList.Length; i++)
                {
                    foreach (var producto in _p.ObtenerProduto())
                    {
                        if (nameList[i] == producto.Id.ToString())
                        {
                            string valorProductos =

                               "<tr>" +

                                 "<th scope='row'>" + nameList[i] + "</th >" +

                                  "<td>"+ producto.Nombre +"</td>" +

                                  "<td>"+ "$" + producto.Precio +"</td >" +

                                  "<td>"+ "$" + producto.Precio * Convert.ToDecimal(cantidadList[i]) + "</td >" +

                                "</tr>" ;

                            Productos = Productos + " " + valorProductos;
                        }

                    }

                }

                


                string pdfFile = @".\Factura"+ i+1 + item.CodigoPedido +".pdf";
                
                ExportOptions CrExportOptions;
                DiskFileDestinationOptions CrDiskFileDestinationOptions = new DiskFileDestinationOptions();
                PdfRtfWordFormatOptions CrFormatTypeOptions = new PdfRtfWordFormatOptions();
                CrDiskFileDestinationOptions.DiskFileName = pdfFile;
                CrExportOptions = facturaCR.ExportOptions;//Report document  object has to be given here
                CrExportOptions.ExportDestinationType = ExportDestinationType.DiskFile;
                CrExportOptions.ExportFormatType = ExportFormatType.PortableDocFormat;
                CrExportOptions.DestinationOptions = CrDiskFileDestinationOptions;
                CrExportOptions.FormatOptions = CrFormatTypeOptions;
                facturaCR.Export();

                #region mail...

                MailMessage correo = new MailMessage();

                correo.Attachments.Add(new Attachment(pdfFile));

                correo.From = new MailAddress("AtencionFragata@gmail.com", "Fragata Gift Service Worker", System.Text.Encoding.UTF8);//Correo de salida
                correo.To.Add(mail); //Correo destino?
                correo.Subject = "Fragata Gift - Factura"; //Asunto

                correo.Body = "<link href='https://bootswatch.com/5/solar/bootstrap.min.css' rel='stylesheet'crossorigin='anonymous'>" +
                    "<section >" +
                    "<div style='width:20%; margin: 0% 40%'>" +
                    "<img style='width: 200px' src='https://scontent.fsal1-1.fna.fbcdn.net/v/t1.15752-9/245203631_595219308190390_5776026127206082625_n.png?_nc_cat=111&ccb=1-5&_nc_sid=ae9488&_nc_ohc=pUvhWlj6VAYAX8qJvSg&_nc_ht=scontent.fsal1-1.fna&oh=c7f69bb50c3a385e0ab99e964b600d17&oe=6188FB09' alt='MDN'>" +
                    "</div>" +
                    "<h2 style='text-align:center;'>¡Gracias por tu compra!</h2>" +
                    "<p>!Muchas gracias por tu compra <strong>"+ item.Usuario + "</strong> la compra se ha realizado con exito! Te entregamos un resumen de tu compra por medio de esta pequeña factura: <br></p>" +

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


                //ACA ENVIARE EL CODIGO DE CONFIRMACION

                correo.Priority = MailPriority.Normal;
                SmtpClient smtp = new SmtpClient();
                smtp.UseDefaultCredentials = false;
                smtp.Host = "smtp.gmail.com"; //Host del servidor de correo
                smtp.Port = 587; //Puerto de salida
                smtp.Credentials = new System.Net.NetworkCredential("jcastillo10h@gmail.com", "Kakaroto10");//Cuenta de correo
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                smtp.EnableSsl = true;//True si el servidor de correo permite ssl
                smtp.Send(correo);
                lblStateF.Text = "¡La factura se ha enviado!";

                #endregion
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                Recibo _recibo = new Recibo();
                FacturaBL fBl = new FacturaBL();

                foreach (var item in _pedidoLista)
                {
                    _recibo.NombreCliente = item.Usuario;
                    _recibo.Fecha = DateTime.Now;
                    _recibo.Numero = Numero;
                    _recibo.Productos = item.Productos;
                    _recibo.Total = item.precioPedido;

                    #region PrecioProductos...
                    //Guardando el precio de los productos en ese entonces (Por si llegan a cambiar)
                    string[] stringProductos = item.Productos.Split(',');
                    string precios = "";
                    ProductosBL productosBL = new ProductosBL();

                    for (int i = 0; i < stringProductos.Length; i++)
                    {
                        foreach (var producto in productosBL.ObtenerProduto())
                        {
                            if (producto.Id.ToString() == stringProductos[i])
                            {
                                precios = precios + producto.Precio.ToString() + ",";
                            }
                        }
                    }
                    _recibo.VentasAfectas = precios;

                    #endregion

                    _recibo.IdPedido = item.Id;

                    EnvioBL _ebl = new EnvioBL();

                    foreach (var envio in _ebl.ObtenerEnvios())
                    {
                        if (envio.IdPedido == item.Id)
                        {
                            _recibo.IdEnvio = envio.Id;
                        }
                        else
                        {
                            _recibo.IdEnvio = 0;
                        }
                    }
                }

                int _resultado = fBl.AgregarFactura(_recibo);

                if (_resultado != 0)
                {
                    MessageBox.Show("Se ha agregado la factura satisfactoriamente",
                           "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Parece que hubo un error al guardar la factura",
                                           "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                throw;
            }
            

        }


    }
}
