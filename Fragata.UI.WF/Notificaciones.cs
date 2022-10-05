using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fragata.BL;
using Fragata.Entities;
using Fragata.Entities.Cache;

namespace Fragata.UI.WF
{
    public partial class Notificaciones : Form
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

        public Notificaciones()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            NotificacionBL _nbl = new NotificacionBL();

            foreach (var item in _nbl.ObtenerNotificaciones())
            {

                
                #region CREANDO LOS CONTROLES...
                //SHAPE
                Guna.UI2.WinForms.Guna2Shapes guna2Shapes = new Guna.UI2.WinForms.Guna2Shapes();
                if (PantallaPrincipal.ConfiguracionGV != "NO")
                {
                    guna2Shapes.BackColor = this.BackColor = Color.FromArgb(18, 18, 18); 

                }
                else
                {
                    guna2Shapes.BackColor = this.BackColor = Color.White;
                }
                
                guna2Shapes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(209)))), ((int)(((byte)(224)))));
                guna2Shapes.Dock = System.Windows.Forms.DockStyle.Top;
                guna2Shapes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(209)))), ((int)(((byte)(224)))));
               
                guna2Shapes.Name = "shape";
                guna2Shapes.PolygonSkip = 1;
                guna2Shapes.Rotate = 0F;
                guna2Shapes.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
                guna2Shapes.Size = new System.Drawing.Size(542, 98);
                guna2Shapes.TabIndex = 6;
           
                guna2Shapes.Zoom = 100;

                //DESCRIPCION
                Label lblDescription = new Label();
                lblDescription.AutoSize = true;
                lblDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(209)))), ((int)(((byte)(224)))));
                lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(96)))), ((int)(((byte)(109)))));
                lblDescription.Location = new System.Drawing.Point(13, 39);
                lblDescription.MaximumSize = new System.Drawing.Size(530, 0);
                lblDescription.Name = "lblDescripcion";
                lblDescription.Size = new System.Drawing.Size(468, 51);
                lblDescription.TabIndex = 7;
                lblDescription.Text = item.Descripcion;

                //HACE TANTOS MINUTOS
                Label Minutes = new Label();
                Minutes.AutoSize = true;
                Minutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(209)))), ((int)(((byte)(224)))));
                Minutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Minutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(141)))));
                Minutes.Location = new System.Drawing.Point(374, 12);
                Minutes.Name = "lblMinutes";
                Minutes.Size = new System.Drawing.Size(129, 17);
                Minutes.TabIndex = 9;
                int hora = DateTime.Now.Hour;
                int seconds = DateTime.Now.Second;
                int Minutos = DateTime.Now.Minute;

               
                DateTime HoraActual = Convert.ToDateTime(hora + ":" + Minutos + ":" + seconds);
                HoraActual.ToString("HH:mm:ss");
                DateTime HoraAnterior = item.Hora;
                HoraAnterior.ToString("HH:mm:ss");
                double minutos= HoraActual.Subtract(HoraAnterior).Minutes;
                double segundos = HoraActual.Subtract(HoraAnterior).Seconds;
                double horas = HoraActual.Subtract(HoraAnterior).Hours;
                double dias = HoraActual.Subtract(HoraAnterior).Days;
                if (dias >= 1)
                {
                    Minutes.Location = new System.Drawing.Point(430, 12);
                    if (dias == 1)
                    {
                        Minutes.Text = "Hace " + dias.ToString() + " dia";

                    }
                    else
                    {
                        Minutes.Text = "Hace " + dias.ToString() + " dias";
                    }

                }
                else if (horas != 0 && horas <= 24 && dias == 0)
                {
                    Minutes.Text = "Hace " + horas.ToString() + " horas";
                }
                else if (minutos >= 0 && minutos <= 60 && horas == 0)
                {
                    if (segundos >= 0 && segundos <= 60 && minutos == 1)
                    {
                        Minutes.Text = "Hace un momento";
                    }
                    else
                    {
                        Minutes.Text = "Hace " + minutos.ToString() + " minutos";
                    }
                }
               
                
                 
                
                

                //NOMBRE EMPLEADO
                Label Empleoyee = new Label();

                Empleoyee.AutoSize = true;
                Empleoyee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(209)))), ((int)(((byte)(224)))));
                Empleoyee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                Empleoyee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(121)))), ((int)(((byte)(141)))));
                Empleoyee.Location = new System.Drawing.Point(37, 12);
                Empleoyee.Name = "lblNombreEmpleado";
                Empleoyee.Size = new System.Drawing.Size(50, 17);
                Empleoyee.TabIndex = 8;
                EmpleadoBL empleadoBL = new EmpleadoBL();
                empleadoBL.BuscarEmpleadoPorId(item.IdEmpleado);
                foreach (var empleado in empleadoBL.BuscarEmpleadoPorId(item.IdEmpleado))
                {
                    Empleoyee.Text = empleado.Nombre;
                }
                

                // pboxEmpleado
                // 
                PictureBox pbox = new PictureBox();
                pbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(209)))), ((int)(((byte)(224)))));
                pbox.Image = global::Fragata.UI.WF.Properties.Resources.gift;
                pbox.Location = new System.Drawing.Point(16, 12);
                pbox.Name = "pboxEmpleado";
                pbox.Size = new System.Drawing.Size(20, 20);
                pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                pbox.TabIndex = 10;
                pbox.TabStop = false;

                //PANEL QUE TIENE LA NOTIFICACION
                Panel _panel = new Panel();

                _panel.Dock = System.Windows.Forms.DockStyle.Top;
                _panel.Location = new System.Drawing.Point(0, 0);
                _panel.Name = "panelContainerNotification";
                _panel.Size = new System.Drawing.Size(542, 103);
                _panel.TabIndex = 11;

                _panel.Controls.Add(pbox);
                _panel.Controls.Add(Minutes);
                _panel.Controls.Add(Empleoyee);
                _panel.Controls.Add(lblDescription);
                _panel.Controls.Add(guna2Shapes);

                if (item.Visualizacion == "T" && Session.Permiso == "E" || Session.Permiso == "A")
                {
                    panelNotification.Controls.Add(_panel);
                }
                else if (item.Visualizacion == "A" && Session.Permiso == "A")
                {
                    panelNotification.Controls.Add(_panel);
                }
                else if (item.Visualizacion == "E" && Session.Permiso == "E")
                {
                    panelNotification.Controls.Add(_panel);
                }

                #endregion

                NotificacionBL notificacion = new NotificacionBL();
                if (item.Vista.Contains(Session.Id.ToString()) == false)
                {
                    string Vista = item.Vista + "," + Session.Id.ToString();

                    notificacion.ModificarVista(Vista);
                }
                
                
            }


        }
        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public void ChangeTheme(Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                this.BackColor = Color.FromArgb(18, 18, 18);

                if (component is Guna.UI2.WinForms.Guna2Shapes)
                {
                    component.BackColor = Color.FromArgb(18, 18, 18);
                }
            }
        }

        private void Notificaciones_Shown(object sender, EventArgs e)
        {
            if (PantallaPrincipal.ConfiguracionGV != "NO")
            {
                ChangeTheme(Controls);

            }
        }
    }
}
