using Fragata.BL;
using Fragata.Entities;
using Fragata.Entities.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fragata.UI.WF
{
    public partial class RecuperarClave : Form
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

        public RecuperarClave()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public RecuperarClave(string _codigo)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            lblCodeOriginal.Text = _codigo;
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro que desea cerrar la recuperacion de contraseña?",
                    "Recuperar Contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void chVNC_CheckedChanged(object sender, EventArgs e)
        {
            string text = txtPN.Text;


            if (chVNC.Checked)
            {
                txtPN.UseSystemPasswordChar = false;
                txtPN.Text = text;

            }
            else
            {
                txtPN.UseSystemPasswordChar = true;
                txtPN.Text = text;
            }
        }

        private void chbxViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            string text = txtRepeatPassword.Text;


            if (chbxViewPassword.Checked)
            {
                txtRepeatPassword.UseSystemPasswordChar = false;
                txtRepeatPassword.Text = text;

            }
            else
            {
                txtRepeatPassword.UseSystemPasswordChar = true;
                txtRepeatPassword.Text = text;
            }
        }

        private void txtRepeatPassword_TextChanged(object sender, EventArgs e)
        {
            bool result = txtPN.Text.Equals(txtRepeatPassword.Text);
            if (result == false)
            {
                lblErrorPassword.Visible = true;
            }
            else
            {
                lblErrorPassword.Visible = false;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado _emp = new Empleado();

                _emp.Id = Session.Id;
                _emp.Nombre = Session.Nombre;
                _emp.Apellidos = Session.Apellidos;
                _emp.Edad = Session.Edad;
                _emp.DUI = Session.DUI;
                _emp.Genero = Session.Genero;
                _emp.Cargo = Session.Cargo;
                _emp.Telefono = Session.Telefono;
                _emp.HorasTrabajo = Session.HorasTrabajo;
                string result = string.Empty;
                byte[] encryted = System.Text.Encoding.Unicode.GetBytes(txtPN.Text);
                result = Convert.ToBase64String(encryted);
                _emp.Clave = result;
                _emp.Imagen = Session.Imagen;
                _emp.Mail = Session.Mail;

                EmpleadoBL _empBL = new EmpleadoBL();
                int _resultado = _empBL.EditarEmpleado(_emp);

                if (_resultado != 0)
                {
                    MessageBox.Show("La contraseña se ha modificado ",
                    "Cambiar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error en la aplicacion: " + ex.Message,
                    "Error en la aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show("Ha ocurrido un error en los campos: " + ex.Message,
                    "Error en la aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ha ocurrido un error en los campos:" + ex.Message,
                    "Error en la aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en la aplicacion: " + ex.Message,
                    "Error en la aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecuperarClave_Load(object sender, EventArgs e)
        {
            lblText.Text = "Se ha enviado un codigo al correo " + Session.Mail + "\n Revise su correo y digite el codigo" ;
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (txtCode.Text.Equals(lblCodeOriginal.Text))
            {
                lblPassN.Visible = true;
                txtPN.Visible = true;
                chVNC.Visible = true;
                txtRepeatPassword.Visible = true;
                chbxViewPassword.Visible = true;
                lblRecuperar.Visible = true;
                btnChangePassword.Visible = true;
                lblText.Visible = false;
                txtCode.Visible = false;
                lblErrorCode.Visible = false;
            }
            else
            {
                lblErrorCode.Visible = true;
            }
        }

        public void ChangeTheme(Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                this.BackColor = Color.FromArgb(18, 18, 18);

                if (component is Label)
                {
                    component.ForeColor = Color.White;
                }

                else if (component is Guna.UI2.WinForms.Guna2TextBox)
                {
                    component.BackColor = Color.FromArgb(18, 18, 18);
                    txtCode.BackColor = Color.FromArgb(18, 18, 18);
                    txtPN.BackColor = Color.FromArgb(18, 18, 18);
                    txtRepeatPassword.BackColor = Color.FromArgb(18, 18, 18);

                    txtCode.FillColor = Color.FromArgb(10, 10, 10);
                    txtPN.FillColor = Color.FromArgb(10, 10, 10);
                    txtRepeatPassword.FillColor = Color.FromArgb(10, 10, 10);

                }
                else if (component is Guna.UI2.WinForms.Guna2ComboBox)
                {
                    

                }
                else if (component is Guna.UI2.WinForms.Guna2Button)
                {
                    component.BackColor = Color.FromArgb(18, 18, 18);
                    component.ForeColor = Color.White;
                }

                
            }
        }

        private void RecuperarClave_Shown(object sender, EventArgs e)
        {
            if (PantallaPrincipal.ConfiguracionGV != "NO")
            {
                ChangeTheme(Controls);
            }
        }
    }
}
