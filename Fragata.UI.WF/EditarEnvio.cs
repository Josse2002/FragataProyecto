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
    public partial class EditarEnvio : Form
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

        public EditarEnvio()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public EditarEnvio(Envio pEnvio)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.Focus();
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            btnAgregarProducto.BackColor = Color.White;
            btnAgregarProducto.UseTransparentBackground = false;

            lblId.Text = pEnvio.Id.ToString();
            lblPedido.Text = pEnvio.IdPedido.ToString();
            dtpcFecha.Value = pEnvio.Hora;
            txtDireccion.Text = pEnvio.Direccion;
            txtMail.Text = pEnvio.Mail;
            txtTelefono.Text = pEnvio.Telefono;
            lblEstado.Text = pEnvio.Estado;
            txtPrecio.Text = pEnvio.PrecioEnvio.ToString();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' &&
               e.KeyChar != '@' && e.KeyChar != '.')
            {
                e.Handled = true;

            }
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            string str = txtMail.Text;
            int s = str.Count(c => c == '@');
            int p = str.Count(c => c == '.');

            if (txtMail.Text.Length >= 50)
            {
                lblErrorMail.Text = "Se excede de caracteres";
                lblErrorMail.Visible = true;


            }
            else
            {
                lblErrorMail.Visible = false;
            }
            if (txtMail.Text.StartsWith("@") == true || txtMail.Text.StartsWith(".") == true)
            {
                lblErrorMail.Text = "No se puede comenzar con un arroba o un punto";
                lblErrorMail.Visible = true;
            }

            if (txtMail.Text.EndsWith("@") == true || txtMail.Text.EndsWith(".") == true)
            {
                lblErrorMail.Text = "Se debe ingresar una direccion valida (gmail, hotmail, yahoo)";
                lblErrorMail.Visible = true;
            }

            if (s > 1 || p > 1)
            {
                if (lblErrorMail.Visible == true)
                {
                    lblErrorMail2.Visible = false;
                }
                else
                {
                    lblErrorMail2.Text = @"Solo se puede agregar un @ y un punto";
                    lblErrorMail2.Visible = true;
                }

            }
            else
            {
                lblErrorMail2.Visible = false;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            EnvioBL envio = new EnvioBL();
            Envio envio1 = new Envio();

            envio1.Id = Convert.ToInt64(lblId.Text);
            envio1.Hora = dtpcFecha.Value;
            envio1.Fecha = dtpcFecha.Value;
            envio1.Direccion = txtDireccion.Text;
            envio1.IdPedido = Convert.ToInt64(lblPedido.Text);
            envio1.Estado = lblEstado.Text;
            envio1.Mail = txtMail.Text;
            envio1.Telefono = txtTelefono.Text;
            envio1.PrecioEnvio = Convert.ToDecimal(txtPrecio.Text);

            try
            {
                if (txtTelefono.Text != "" && txtDireccion.Text != "" && txtMail.Text != "" && txtTelefono.Text != ""
                 && txtMail.Text.Count(c => c == '@') == 1 && txtMail.Text.Count(c => c == '.') == 1 && txtPrecio.Text.Count(c => c == '.') == 1 &&
                        txtPrecio.Text.Length <= 8 && txtPrecio.Text.StartsWith(".") == false)
                {

                    int _resultado = envio.EditarEnvio(envio1);
                    if (_resultado != 0)
                    {
                        MessageBox.Show("Se ha editado el envio",
                        "Editar Envio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Notificacion _N = new Notificacion();
                        _N.Fecha = DateTime.Now.Date;
                        _N.Hora = DateTime.Now;

                        _N.IdEmpleado = Session.Id;
                        _N.Descripcion = "Se ha editado el envio con el codigo " + lblId.Text + " para el " + dtpcFecha.Value.ToShortDateString() + " a las " + dtpcFecha.Value.ToShortTimeString();
                        if (Session.Permiso == "E")
                        {
                            _N.Visualizacion = "T";
                        }
                        else if (Session.Permiso == "A")
                        {
                            _N.Visualizacion = "T";
                        }
                        NotificacionBL _NotificacionBL = new NotificacionBL();
                        _NotificacionBL.AgregarNotificaciones(_N);
                        this.Close();
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
            catch (FormatException)
            {
                MessageBox.Show("Hay campos sin llenar o con datos erroneos, reviselos e intente de nuevo",
                    "Error en la aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El array uwu " + ex.Message,
                    "Error en la aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            string str = txtPrecio.Text;
            int s = str.Count(c => c == '.');

            if (txtPrecio.Text.Length >= 6)
            {
                lblErrorPrecio.Text = "Se excede de caracteres";
                lblErrorPrecio.Visible = true;


            }
            else
            {
                lblErrorPrecio.Visible = false;
            }

            if (txtPrecio.Text.StartsWith(".") == true)
            {
                lblErrorPrecio.Text = "No se puede comenzar con un punto decimal";
                lblErrorPrecio.Visible = true;
            }

            if (txtPrecio.Text.EndsWith(".") == true)
            {
                lblErrorPrecio.Text = "El formato ingresado no es correcto";
                lblErrorPrecio.Visible = true;
            }

            if (s > 1)
            {
                if (lblErrorPrecio.Visible == true)
                {
                    lblErrorPrecio2.Visible = false;
                }
                else
                {
                    lblErrorPrecio2.Text = "Solo se puede poner un punto decimal";
                    lblErrorPrecio2.Visible = true;
                }

            }
            else
            {
                lblErrorPrecio2.Visible = false;
            }

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecio_TextChanged(sender, e);

            if (!char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;

            }
        }
    }
}
