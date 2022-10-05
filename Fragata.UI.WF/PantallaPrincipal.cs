using Fragata.Entities;
using Fragata.UI.WF.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fragata.Entities.Cache;
using System.Configuration;
using Fragata.BL;


namespace Fragata.UI.WF
{
    public partial class PantallaPrincipal : Form
    {
        //FORMULARIOS

        ObtenerEmpleado obtenerEmpleado = new ObtenerEmpleado();
        Tablero _Tablero = new Tablero();
        ObtenerProductos _OProductos = new ObtenerProductos();
        ObtenerExistencias _formExistencias = new ObtenerExistencias();
        ObtenerEnvios _ObtenerEnvios = new ObtenerEnvios();
        ObtenerPedido _obtenerPedido = new ObtenerPedido();
        ObtenerVentas _obtenerVentas = new ObtenerVentas();
        ObtenerFacturas obtenerFacturas = new ObtenerFacturas();
     


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


        public static string ConfiguracionGV;
        public PantallaPrincipal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            

            //DIAS EN ESPAÑOL
            CultureInfo ci = new CultureInfo("Es-Es");

            //OBTENER LA HORA ACTUAL
            string _mes = ci.DateTimeFormat.GetMonthName(DateTime.Now.Month);
            string _diaSemana = ci.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
            string _year = DateTime.Now.Year.ToString();
            string _dia = DateTime.Now.Day.ToString();

            lblDia.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(_diaSemana);


            lblDiaActual.Text = _dia + " de " + _mes + ", " + _year;

            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(@".\Test.txt");
                
                byte[] encrytedId = System.Text.Encoding.Unicode.GetBytes(Session.Id.ToString());
                string Id = Convert.ToBase64String(encrytedId);

               
                byte[] encrytedMail = System.Text.Encoding.Unicode.GetBytes(Session.Mail);
                string Mail = Convert.ToBase64String(encrytedMail);

                
                byte[] encrytedPassword = System.Text.Encoding.Unicode.GetBytes(Session.Clave.ToString());
                string Password = Convert.ToBase64String(encrytedPassword);

                //Write a line of text
                sw.WriteLine(Id.ToString());
                sw.WriteLine(Password.ToString());
                sw.WriteLine(Mail.ToString());
                
               
                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

           

            EditarEmpleado eE = new EditarEmpleado();
            eE.FormClosed += Timer1_Tick;

            String line;
            StreamReader sr = new StreamReader(@".\Settings.txt");
            //Read the first line of text
            line = sr.ReadLine();
            List<string> list = new List<string>();
            //Continue to read until you reach end of file
            while (line != null)
            {
                //write the line to console window
                Console.WriteLine(line);
                //Read the next line
                line = sr.ReadLine();
                list.Add(line);
            }

            //close the file
            sr.Close();
            Console.ReadLine();

            if (list[0].ToString() == "nocturne-mode: true")
            {
                ConfiguracionGV = "YES";
                ChangeTheme(Controls);
            }
            else
            {
                ConfiguracionGV = "NO";
            }

           

        }

        






        public void ChangeTheme(Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                if (component is Panel)
                {
                    ChangeTheme(component.Controls);
                    component.BackColor = Color.FromArgb(18,18,18);
                    component.ForeColor = Color.FromArgb(18, 18, 18);
                }else if (component is PictureBox)
                {
                    component.BackColor = Color.FromArgb(18, 18, 18);
                    component.ForeColor = Color.FromArgb(18, 18, 18);
                }
                else if (component is Label)
                {
                    component.BackColor = Color.FromArgb(18, 18, 18);
                    component.ForeColor = Color.White;
                }
                else if (component is Button)
                {
                    component.BackColor = Color.FromArgb(18, 18, 18);
                    component.ForeColor = Color.FromArgb(18, 18, 18);
                }
                else if (component is TextBox)
                {
                    component.BackColor = Color.FromArgb(18, 18, 18);
                    component.ForeColor = Color.FromArgb(18, 18, 18);
                }

                btnAgregarProducto.FillColor = Color.FromArgb(30, 30, 30);
                btnAgregarProducto.ForeColor = Color.FromArgb(80, 80,80);

    }
        }






        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      

        private void pnlTopApp_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        public void btnEmpleados_Click(object sender, EventArgs e)
        {

            btnInicio.Image = Resources.dashboard__2_;
            btnInicio.ForeColor = Color.FromArgb(67, 69, 70);
            btnProdutos.Image = Resources.gift;
            btnPedidos.Image = Resources.carrito_de_compras;
            btnPedidos.ForeColor = Color.FromArgb(67, 69, 70);
            btnProdutos.ForeColor = Color.FromArgb(67, 69, 70);
            btnExistencia.Image = Resources.maquina_elevadora;
            btnExistencia.ForeColor = Color.FromArgb(67, 69, 70);
            btnEnvios.Image = Resources.entrega;
            btnEnvios.ForeColor = Color.FromArgb(67, 69, 70);
            btnVentas.Image = Resources.ventas;
            btnVentas.ForeColor = Color.FromArgb(67, 69, 70);
            btnFacturas.Image = Resources.factura;
            btnFacturas.ForeColor = Color.FromArgb(67, 69, 70);

            btnEmpleados.Image = Resources.portafolio__1_;
            lblTittle.Text = "Empleados";
            btnEmpleados.ForeColor = Color.FromArgb(255, 128, 128);
            btnAgregarProducto.Text = "Agregar\r\nNuevo Empleado";

            obtenerEmpleado.TopLevel = false;
            
            pnlImformacion.Controls.Add(obtenerEmpleado);
            pnlImformacion.Controls.Remove(_Tablero);
            pnlImformacion.Controls.Remove(_OProductos);
            pnlImformacion.Controls.Remove(_formExistencias);
            pnlImformacion.Controls.Remove(_ObtenerEnvios);
            pnlImformacion.Controls.Remove(_obtenerPedido);
            pnlImformacion.Controls.Remove(_obtenerVentas);
            pnlImformacion.Controls.Remove(obtenerFacturas);

            obtenerEmpleado.Show();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (lblTittle.Text == "Empleados")
            {
                AgregarEmpleados _formAgregarEmpleado = new AgregarEmpleados();

                _formAgregarEmpleado.ShowDialog();

            }
            else if(lblTittle.Text == "Productos")
            {
               
                AgregarProductos _form = new AgregarProductos();
                _form.ShowDialog();
            }
            else if (lblTittle.Text == "Factura")
            {
                AgregarFactura _form = new AgregarFactura();
                _form.ShowDialog();
            }
            else if (lblTittle.Text == "Existencias")
            {
                //AgregarNuevaExistencia _Existences = new AgregarNuevaExistencia();
                //_Existences.ShowDialog();
            }
            else if (lblTittle.Text == "Envíos")
            {
                AgregarEnvio _agregarEnvios = new AgregarEnvio();
                _agregarEnvios.ShowDialog();
            }
            else if (lblTittle.Text == "Pedidos")
            {
                AgregarPedido _agregarPedidos = new AgregarPedido();
                _agregarPedidos.ShowDialog();
            }
            else if (lblTittle.Text == "Ventas")
            {
                AgregarVenta _agregarVentas= new AgregarVenta();
                _agregarVentas.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(Timer1_Tick);

            // Enable timer.  
            timer1.Enabled = true;
            lblNombre.Text = Session.Nombre;
            MemoryStream ms = new MemoryStream(Session.Imagen);
            Image returnImage = Image.FromStream(ms);
            imgProfilePicture.Image = returnImage;

            btnEmpleados.Image = Resources.portafolio;
            btnEmpleados.ForeColor = Color.FromArgb(67, 69, 70);
            btnProdutos.Image = Resources.gift;
            btnProdutos.ForeColor = Color.FromArgb(67, 69, 70);
            btnEnvios.Image = Resources.entrega;
            btnEnvios.ForeColor = Color.FromArgb(67, 69, 70);
            btnFacturas.Image = Resources.factura;
            btnFacturas.ForeColor = Color.FromArgb(67, 69, 70);

            btnPedidos.Image = Resources.carrito_de_compras;
            btnPedidos.ForeColor = Color.FromArgb(67, 69, 70);
            btnVentas.Image = Resources.ventas;
            btnVentas.ForeColor = Color.FromArgb(67, 69, 70);

            btnInicio.Image = Resources.dashboard__1_;
            lblTittle.Text = "Tablero";
            btnInicio.ForeColor = Color.FromArgb(255, 128, 128);
            btnAgregarProducto.Text = "Imprimir\r\nEstado";

            _Tablero.TopLevel = false;
            pnlImformacion.Controls.Add(_Tablero);
            pnlImformacion.Controls.Remove(obtenerEmpleado);
            pnlImformacion.Controls.Remove(_formExistencias);
            pnlImformacion.Controls.Remove(_obtenerPedido);
            pnlImformacion.Controls.Remove(_ObtenerEnvios);
            pnlImformacion.Controls.Remove(_obtenerVentas);
            pnlImformacion.Controls.Remove(obtenerFacturas);

            _Tablero.Show();

            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            btnEmpleados.Image = Resources.portafolio;
            btnEmpleados.ForeColor = Color.FromArgb(67, 69, 70);
            btnProdutos.Image = Resources.gift;
            btnProdutos.ForeColor = Color.FromArgb(67, 69, 70);
            btnExistencia.Image = Resources.maquina_elevadora;
            btnExistencia.ForeColor = Color.FromArgb(67, 69, 70);
            btnEnvios.Image = Resources.entrega;
            btnPedidos.Image = Resources.carrito_de_compras;
            btnPedidos.ForeColor = Color.FromArgb(67, 69, 70);
            btnEnvios.ForeColor = Color.FromArgb(67, 69, 70);
            btnVentas.Image = Resources.ventas;
            btnVentas.ForeColor = Color.FromArgb(67, 69, 70);

            btnFacturas.Image = Resources.factura;
            btnFacturas.ForeColor = Color.FromArgb(67, 69, 70);

            btnInicio.Image = Resources.dashboard__1_;
            lblTittle.Text = "Tablero";
            btnInicio.ForeColor = Color.FromArgb(255, 128, 128);
            btnAgregarProducto.Text = "Imprimir\r\nEstado";


            _Tablero.TopLevel = false;
            pnlImformacion.Controls.Add(_Tablero);
            pnlImformacion.Controls.Remove(obtenerEmpleado);
            pnlImformacion.Controls.Remove(_OProductos);
            pnlImformacion.Controls.Remove(_formExistencias);
            pnlImformacion.Controls.Remove(_ObtenerEnvios);
            pnlImformacion.Controls.Remove(_obtenerPedido);
            pnlImformacion.Controls.Remove(_obtenerVentas);
            pnlImformacion.Controls.Remove(obtenerFacturas);

            _Tablero.Show();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            btnInicio.Image = Resources.dashboard__2_;
            btnEmpleados.Image = Resources.portafolio;
            btnExistencia.Image = Resources.maquina_elevadora;
            btnPedidos.Image = Resources.carrito_de_compras;
            btnPedidos.ForeColor = Color.FromArgb(67, 69, 70);
            btnExistencia.ForeColor = Color.FromArgb(67, 69, 70);
            btnEmpleados.ForeColor = Color.FromArgb(67, 69, 70);
            btnInicio.ForeColor = Color.FromArgb(67, 69, 70);
            btnEnvios.Image = Resources.entrega;
            btnEnvios.ForeColor = Color.FromArgb(67, 69, 70);
            btnVentas.Image = Resources.ventas;
            btnVentas.ForeColor = Color.FromArgb(67, 69, 70);
            btnFacturas.Image = Resources.factura;
            btnFacturas.ForeColor = Color.FromArgb(67, 69, 70);



            btnProdutos.Image = Resources.gift__1_;
            lblTittle.Text = "Productos";
            btnProdutos.ForeColor = Color.FromArgb(255, 128, 128);
            btnAgregarProducto.Text = "Agregar\r\nNuevo Producto";

            _OProductos.TopLevel = false;
            pnlImformacion.Controls.Add(_OProductos);
            pnlImformacion.Controls.Remove(obtenerEmpleado);
            pnlImformacion.Controls.Remove(_formExistencias);
            pnlImformacion.Controls.Remove(_Tablero);
            pnlImformacion.Controls.Remove(_ObtenerEnvios);
            pnlImformacion.Controls.Remove(_obtenerPedido);
            pnlImformacion.Controls.Remove(_obtenerVentas);
            pnlImformacion.Controls.Remove(obtenerFacturas);



            _OProductos.Show();
        }

        private void btnExistencia_Click(object sender, EventArgs e)
        {
            btnEmpleados.Image = Resources.portafolio;
            btnEmpleados.ForeColor = Color.FromArgb(67, 69, 70);

            btnProdutos.Image = Resources.gift;
            btnProdutos.ForeColor = Color.FromArgb(67, 69, 70);

            btnEnvios.Image = Resources.entrega;
            btnEnvios.ForeColor = Color.FromArgb(67, 69, 70);

            btnFacturas.Image = Resources.factura;
            btnFacturas.ForeColor = Color.FromArgb(67, 69, 70);

            btnPedidos.Image = Resources.carrito_de_compras;
            btnPedidos.ForeColor = Color.FromArgb(67, 69, 70);

            btnInicio.Image = Resources.dashboard__2_;
            btnInicio.ForeColor = Color.FromArgb(67, 69, 70);

            btnVentas.Image = Resources.ventas;
            btnVentas.ForeColor = Color.FromArgb(67, 69, 70);

            btnExistencia.Image = Resources.maquina_elevadora__1_;
            lblTittle.Text = "Existencias";
            btnExistencia.ForeColor = Color.FromArgb(255, 128, 128);
            btnAgregarProducto.Text = "Agregar\r\nExistencia";

            _formExistencias.TopLevel = false;
            pnlImformacion.Controls.Add(_formExistencias);
            pnlImformacion.Controls.Remove(obtenerEmpleado);
            pnlImformacion.Controls.Remove(_OProductos);
            pnlImformacion.Controls.Remove(_Tablero);
            pnlImformacion.Controls.Remove(_ObtenerEnvios);
            pnlImformacion.Controls.Remove(_obtenerPedido);
            pnlImformacion.Controls.Remove(_obtenerVentas);
            pnlImformacion.Controls.Remove(obtenerFacturas);

            _formExistencias.Show();
        }

        private void imgProfilePicture_Click(object sender, EventArgs e)
        {
            panelAccount.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            InicioDeSesion _va = new InicioDeSesion();
            _va.Show();
            this.Close();
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(@".\Test.txt");
                //Write a line of text
                sw.WriteLine(" ");
                sw.WriteLine(" ");
                sw.WriteLine(" ");

                //Close the file
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            panelAccount.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            VerCuenta _va = new VerCuenta();
            _va.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Notificaciones _form = new Notificaciones();
            _form.ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            NotificacionBL nBL = new NotificacionBL();
            int NumeroVistas = 0;

            foreach (var item in nBL.ObtenerNotificaciones())
            {
                string _Vista = item.Vista;
                string[] VistaArray = _Vista.Split(',');

                for (int i = 0; i < VistaArray.Length; i++)
                {
                    if (Convert.ToInt64(VistaArray[i]) == Session.Id || VistaArray[i] == " ")
                    {
                        NumeroVistas = NumeroVistas + 1;
                    }
                }

            }
            int TotalDB = nBL.ObtenerNotificaciones().Count;
            int TotalVista = TotalDB - NumeroVistas;

            if (TotalVista == 0)
            {
                ContadorCircle.Visible = false;
                lblContador.Visible = false;
            }
            else
            {
                lblContador.Text = TotalVista.ToString();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Configuracion _cfs = new Configuracion();
            _cfs.ShowDialog();
        }

        private void PantallaPrincipal_Validated(object sender, EventArgs e)
        {
            String line;
            StreamReader sr = new StreamReader(@".\Settings.txt");
            //Read the first line of text
            line = sr.ReadLine();
            List<string> list = new List<string>();
            //Continue to read until you reach end of file
            while (line != null)
            {
                //write the line to console window
                Console.WriteLine(line);
                //Read the next line
                line = sr.ReadLine();
                list.Add(line);
            }

            //close the file
            sr.Close();
            Console.ReadLine();

            if (list[0].ToString() == "nocturne-mode: true")
            {
                ChangeTheme(Controls);
            }
        }

        private void btnEnvios_Click(object sender, EventArgs e)
        {
            btnEmpleados.Image = Resources.portafolio;
            btnEmpleados.ForeColor = Color.FromArgb(67, 69, 70);

            
            btnExistencia.Image = Resources.maquina_elevadora;
            btnExistencia.ForeColor = Color.FromArgb(67, 69, 70);

            btnExistencia.ForeColor = Color.FromArgb(67, 69, 70);
            btnProdutos.Image = Resources.gift;
            btnProdutos.ForeColor = Color.FromArgb(67, 69, 70);
            btnVentas.Image = Resources.ventas;
            btnVentas.ForeColor = Color.FromArgb(67, 69, 70);

            btnPedidos.Image = Resources.carrito_de_compras;
            btnPedidos.ForeColor = Color.FromArgb(67, 69, 70);

            btnFacturas.Image = Resources.factura;
            btnFacturas.ForeColor = Color.FromArgb(67, 69, 70);


            btnInicio.Image = Resources.dashboard__2_;
            btnInicio.ForeColor = Color.FromArgb(67, 69, 70);

            btnEnvios.Image = Resources.entrega__1_;
            lblTittle.Text = "Envíos";

            btnEnvios.ForeColor = Color.FromArgb(255, 128, 128);
            btnAgregarProducto.Text = "Agregar\r\nEnvio";

            _ObtenerEnvios.TopLevel = false;
            pnlImformacion.Controls.Add(_ObtenerEnvios);
            pnlImformacion.Controls.Remove(obtenerEmpleado);
            pnlImformacion.Controls.Remove(_OProductos);
            pnlImformacion.Controls.Remove(_Tablero);
            pnlImformacion.Controls.Remove(_formExistencias);
            pnlImformacion.Controls.Remove(_obtenerPedido);
            pnlImformacion.Controls.Remove(_obtenerVentas);
            pnlImformacion.Controls.Remove(obtenerFacturas);

            _ObtenerEnvios.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            btnEmpleados.Image = Resources.portafolio;
            btnEmpleados.ForeColor = Color.FromArgb(67, 69, 70);

            btnPedidos.Image = Resources.carrito_de_compras;
            btnPedidos.ForeColor = Color.FromArgb(67, 69, 70);

            btnExistencia.Image = Resources.maquina_elevadora;
            btnExistencia.ForeColor = Color.FromArgb(67, 69, 70);

            btnExistencia.ForeColor = Color.FromArgb(67, 69, 70);
            btnProdutos.Image = Resources.gift;
            btnProdutos.ForeColor = Color.FromArgb(67, 69, 70);

            btnVentas.Image = Resources.ventas;
            btnVentas.ForeColor = Color.FromArgb(67, 69, 70);

            btnInicio.Image = Resources.dashboard__2_;
            btnInicio.ForeColor = Color.FromArgb(67, 69, 70);

            btnEnvios.Image = Resources.entrega;
            btnEnvios.ForeColor = Color.FromArgb(67, 69, 70);
            btnFacturas.Image = Resources.factura;
            btnFacturas.ForeColor = Color.FromArgb(67, 69, 70);

            btnPedidos.Image = Resources.carrito_de_compras__1_;
            lblTittle.Text = "Pedidos";
            btnPedidos.ForeColor = Color.FromArgb(255, 128, 128);
            btnAgregarProducto.Text = "Agregar\r\nPedidos";

            _obtenerPedido.TopLevel = false;
            pnlImformacion.Controls.Add(_obtenerPedido);
            pnlImformacion.Controls.Remove(obtenerEmpleado);
            pnlImformacion.Controls.Remove(_OProductos);
            pnlImformacion.Controls.Remove(_ObtenerEnvios);
            pnlImformacion.Controls.Remove(_Tablero);
            pnlImformacion.Controls.Remove(_formExistencias);
            pnlImformacion.Controls.Remove(_obtenerVentas);
            pnlImformacion.Controls.Remove(obtenerFacturas);
            _obtenerPedido.Show();

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            btnEmpleados.Image = Resources.portafolio;
            btnEmpleados.ForeColor = Color.FromArgb(67, 69, 70);


            btnExistencia.Image = Resources.maquina_elevadora;
            btnExistencia.ForeColor = Color.FromArgb(67, 69, 70);

            btnExistencia.ForeColor = Color.FromArgb(67, 69, 70);
            btnProdutos.Image = Resources.gift;
            btnProdutos.ForeColor = Color.FromArgb(67, 69, 70);
            btnPedidos.Image = Resources.carrito_de_compras;
            btnPedidos.ForeColor = Color.FromArgb(67, 69, 70);
            btnInicio.Image = Resources.dashboard__2_;
            btnInicio.ForeColor = Color.FromArgb(67, 69, 70);

            btnFacturas.Image = Resources.factura;
            btnFacturas.ForeColor = Color.FromArgb(67, 69, 70);

            btnEnvios.Image = Resources.entrega;
            btnEnvios.ForeColor = Color.FromArgb(67, 69, 70);

            btnVentas.Image = Resources.ventas__1_;
            lblTittle.Text = "Ventas";
            btnVentas.ForeColor = Color.FromArgb(255, 128, 128);
            btnAgregarProducto.Text = "Agregar\r\nVenta";

            _obtenerVentas.TopLevel = false;
            pnlImformacion.Controls.Add(_obtenerVentas);
            pnlImformacion.Controls.Remove(obtenerEmpleado);
            pnlImformacion.Controls.Remove(_OProductos);
            pnlImformacion.Controls.Remove(_ObtenerEnvios);
            pnlImformacion.Controls.Remove(_Tablero);
            pnlImformacion.Controls.Remove(_formExistencias);
            pnlImformacion.Controls.Remove(_obtenerPedido);
            pnlImformacion.Controls.Remove(obtenerFacturas);

            _obtenerVentas.Show();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            btnEmpleados.Image = Resources.portafolio;
            btnEmpleados.ForeColor = Color.FromArgb(67, 69, 70);


            btnExistencia.Image = Resources.maquina_elevadora;
            btnExistencia.ForeColor = Color.FromArgb(67, 69, 70);

            btnExistencia.ForeColor = Color.FromArgb(67, 69, 70);
            btnProdutos.Image = Resources.gift;
            btnProdutos.ForeColor = Color.FromArgb(67, 69, 70);
            btnPedidos.Image = Resources.carrito_de_compras;
            btnPedidos.ForeColor = Color.FromArgb(67, 69, 70);
            btnInicio.Image = Resources.dashboard__2_;
            btnInicio.ForeColor = Color.FromArgb(67, 69, 70);

            btnEnvios.Image = Resources.entrega;
            btnEnvios.ForeColor = Color.FromArgb(67, 69, 70);

            btnVentas.Image = Resources.ventas;
            btnVentas.ForeColor = Color.FromArgb(67, 69, 70);

            btnFacturas.Image = Resources.factura__1_;
            lblTittle.Text = "Factura";
            btnFacturas.ForeColor = Color.FromArgb(255, 128, 128);
            btnAgregarProducto.Text = "Agregar\r\nFactura";

            obtenerFacturas.TopLevel = false;
            pnlImformacion.Controls.Add(obtenerFacturas);
            pnlImformacion.Controls.Remove(obtenerEmpleado);
            pnlImformacion.Controls.Remove(_OProductos);
            pnlImformacion.Controls.Remove(_ObtenerEnvios);
            pnlImformacion.Controls.Remove(_Tablero);
            pnlImformacion.Controls.Remove(_formExistencias);
            pnlImformacion.Controls.Remove(_obtenerPedido);
            pnlImformacion.Controls.Remove(_obtenerVentas);
            obtenerFacturas.Show();
        }
    }
}
