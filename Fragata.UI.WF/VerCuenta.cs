
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
using System.Net.Mail;
using System.Configuration;
using System.Net.Configuration;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using Fragata.Entities.Cache;
using System.IO;
using Fragata.Entities;

namespace Fragata.UI.WF
{
    public partial class VerCuenta : Form
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
        public VerCuenta()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            lblNombre.Text = Session.Nombre;
            lblApellidos.Text = Session.Apellidos;
            lblGenero.Text = Session.Genero;
            lblEdad.Text = Session.Edad.ToString();
            lblDUI.Text = Session.DUI;
            lblCargo.Text = Session.Cargo;
            lblTelefono.Text = Session.Telefono;
            lblHorasTrabajo.Text = Session.HorasTrabajo.ToString();
            lblCorreo.Text = Session.Mail;
            MemoryStream ms = new MemoryStream(Session.Imagen);
            Image returnImage = Image.FromStream(ms);
            pictureBox1.Image = returnImage;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            var chars = "0123456789";
            var stringChars = new char[5];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            MailMessage correo = new MailMessage();
                correo.From = new MailAddress("AtencionFragata@gmail.com", "Fragata Gift Service Worker", System.Text.Encoding.UTF8);//Correo de salida
                correo.To.Add(Session.Mail); //Correo destino?
                correo.Subject = "Fragata Gift - Change Password"; //Asunto
                correo.Body = "¡Saludos " + Session.Nombre + "! Tu codigo de confirmacion de cambio de contraseña es el sigiuiente:" +
                "" + finalString + "\n Por favor no responda a este correo - Fragata Gift"; //Mensaje del correo
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
                RecuperarClave _form = new RecuperarClave(finalString);
                _form.Show();
 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Empleado _empleado = new Empleado();
            _empleado.Id = Session.Id;
            _empleado.Nombre = Session.Nombre;
            _empleado.Apellidos = Session.Apellidos;
            _empleado.Genero = Session.Genero;
            _empleado.Edad = Session.Edad;
            _empleado.DUI = Session.DUI;
            _empleado.Cargo = Session.Cargo;
            _empleado.Permiso = Session.Permiso;
            _empleado.Telefono = Session.Telefono;
            _empleado.HorasTrabajo = Session.HorasTrabajo;
            _empleado.Mail = Session.Mail;
            _empleado.Clave = Session.Clave;

            System.IO.MemoryStream _ms = new System.IO.MemoryStream();
            pictureBox1.Image.Save(_ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            _empleado.Imagen = _ms.GetBuffer();

            EditarEmpleado _edit = new EditarEmpleado(_empleado);
            _edit.Show();
            this.Hide();
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

                lblGenero.ForeColor = Color.White;
                lblEdad.ForeColor = Color.White;
                lblDUI.ForeColor = Color.White;
                lblCargo.ForeColor = Color.White;
                lblTelefono.ForeColor = Color.White;
                lblHorasTrabajo.ForeColor = Color.White;
                lblCorreo.ForeColor = Color.White;
                btnChangePassword.BackColor = Color.FromArgb(18, 18, 18);
                btnChangePassword.FillColor = Color.FromArgb(18, 18, 18);
            }
        }

        private void VerCuenta_Shown(object sender, EventArgs e)
        {
            if (PantallaPrincipal.ConfiguracionGV != "NO")
            {
                ChangeTheme(Controls);
            }
        }
    }
}
