using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fragata.Entities;
using Fragata.BL;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.IO;

namespace Fragata.UI.WF
{
    public partial class VerEmpleado : Form
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
        public VerEmpleado()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public VerEmpleado(Empleado _empleado)
        {
            //CONSTRUCTOR
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            lblClave.Text = _empleado.Clave.ToString();

            lbld.Text = _empleado.Id.ToString();
            lblNombre.Text = _empleado.Nombre.ToString();
            lblApellidos.Text = _empleado.Apellidos.ToString();
            lblGenero.Text = _empleado.Genero.ToString();
            lblEdad.Text = _empleado.Edad.ToString();
            lblCargo.Text = _empleado.Cargo.ToString();
            lblDUI.Text = _empleado.DUI.ToString();
            lblTelefono.Text = _empleado.Telefono.ToString();
            lblHorasTrabajo.Text = _empleado.HorasTrabajo.ToString();
            MemoryStream ms = new MemoryStream(_empleado.Imagen);
            Image returnImage = Image.FromStream(ms);
            pboxPerfil.Image = returnImage;
            lblCorreo.Text = _empleado.Mail;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult _respuesta = MessageBox.Show("¿Esta seguro de eliminar el empleado?",
                   "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (_respuesta == DialogResult.Yes)
                {
                    EmpleadoBL _EmpleadoBL = new EmpleadoBL();

                    int _resultado = _EmpleadoBL.EliminarEmpleado(Convert.ToInt64(lbld.Text));

                    if (_resultado != 0)
                    {
                        MessageBox.Show("El empleado se ha eliminado satisfactoriamente",
                         "Eliminar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ActiveForm.Close();
                        
                    }
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
                MessageBox.Show("Ha ocurrido un error en la aplicacion: " + ex.Message,
                    "Error en la aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en la aplicacion: " + ex.Message,
                    "Error en la aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();

            empleado.Clave = lblClave.Text;
            empleado.Id = Convert.ToInt64(lbld.Text);
            empleado.Nombre = lblNombre.Text;
            empleado.Apellidos = lblApellidos.Text;
            empleado.Genero = lblGenero.Text;
            empleado.Edad = Convert.ToInt64(lblEdad.Text);
            empleado.DUI = lblDUI.Text;
            empleado.Cargo = lblCargo.Text;
            empleado.Telefono = lblTelefono.Text;
            empleado.HorasTrabajo = Convert.ToDecimal(lblHorasTrabajo.Text);

            System.IO.MemoryStream _ms = new System.IO.MemoryStream();
            pboxPerfil.Image.Save(_ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            empleado.Imagen = _ms.GetBuffer();
            empleado.Mail = lblCorreo.Text;

            EditarEmpleado _form = new EditarEmpleado(empleado);
            _form.Show();
            this.Close();
        }
        public void ChangeTheme(Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                this.BackColor = Color.FromArgb(18, 18, 18);

                lbld.ForeColor = Color.White;
                lblGenero.ForeColor = Color.White;
                lblEdad.ForeColor = Color.White;
                lblDUI.ForeColor = Color.White;
                lblCargo.ForeColor = Color.White;
                lblTelefono.ForeColor = Color.White;
                lblHorasTrabajo.ForeColor = Color.White;
                lblCorreo.ForeColor = Color.White;
               
            }
        }

        private void VerEmpleado_Shown(object sender, EventArgs e)
        {
            if (PantallaPrincipal.ConfiguracionGV != "NO")
            {
                ChangeTheme(Controls);
            }
        }
    }
}
