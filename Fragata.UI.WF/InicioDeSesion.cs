using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fragata.BL;

namespace Fragata.UI.WF
{
    public partial class InicioDeSesion : Form
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

        public InicioDeSesion()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            PantallaPrincipal mainMenu = new PantallaPrincipal();
            mainMenu.FormClosed += Logout;
            this.AcceptButton = guna2Button1;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text != "")
            {
                if (txtPassword.Text != "")
                {
                    EmpleadoBL empleadoBL = new EmpleadoBL();

                    byte[] encryted = System.Text.Encoding.Unicode.GetBytes(txtPassword.Text);
                    string result = Convert.ToBase64String(encryted);

                    var ValidLogin = empleadoBL.Login(txtCorreo.Text, result);
               
                    // Saves settings in application configuration file
                    if (ValidLogin == true)
                    {
                        

                        PantallaPrincipal mainMenu = new PantallaPrincipal();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        lblError.Text = "Los datos ingresados son invalidos \n Por favor ingreselos nuevamente";
                        lblError.Visible = true;
                        errorIcon.Visible = true;
                        txtPassword.Clear();
                        txtCorreo.Focus();
                    }
                }
                else
                {
                    lblError.Text = "Ingrese una contraseña";
                    lblError.Visible = true;
                    errorIcon.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Ingrese un correo electronico";
                lblError.Visible = true;
                errorIcon.Visible = true;
            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPassword.Clear();
            txtCorreo.Clear();
            lblError.Visible = false;
            errorIcon.Visible = false;
            this.Show();
            txtCorreo.Focus();
        }

       
    }
}
