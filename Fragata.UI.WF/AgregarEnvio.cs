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
using Fragata.Entities;
using Fragata.BL;
using Fragata.Entities.Cache;

namespace Fragata.UI.WF
{
    public partial class AgregarEnvio : Form
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

        public static string CodigoProducto;
        public static Int64 IdPedido;
        public static string NombreUsuario;

        public AgregarEnvio()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            
            
        }

        public AgregarEnvio(string codigo)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            PedidoBL _pedido = new PedidoBL();
            foreach (var item in _pedido.BuscarPedidoPorCodigo(codigo, "Ver Activos"))
            {
                lblIdPedido.Text = item.Id.ToString();
            }
        }

        private void dtpcFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime actual = DateTime.Now;

            if (dtpcFecha.Value < actual)
            {

                dtpcFecha.Value = DateTime.Now;
                System.Media.SystemSounds.Exclamation.Play();

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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            BuscarPedidoEnvio _bpe = new BuscarPedidoEnvio();
            _bpe.ShowDialog();
        }

        private void AgregarEnvio_Activated(object sender, EventArgs e)
        {
            txtCodigoPedido.Text = CodigoProducto;
            txtNombreUser.Text = NombreUsuario;
         
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

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' &&
                e.KeyChar != '@' && e.KeyChar != '.')
            {
                e.Handled = true;

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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDireccion.Text != "" && txtMail.Text != "" && txtNombreUser.Text != "" && txtNombreUser.Text != null
                    && txtCodigoPedido.Text != "" && txtCodigoPedido.Text != null && txtMail.Text.Count(c => c == '@') == 1
                    && txtPrecio.Text.Count(c => c == '.') == 1 &&
                    txtPrecio.Text.Length <= 8 && txtPrecio.Text.StartsWith(".") == false && txtMail.Text.StartsWith("@") == false
                    && txtMail.Text.EndsWith("@") == false && txtMail.Text.EndsWith(".") == false
                    && txtMail.Text.StartsWith(".") == false && dtpcFecha.Value != null)
                {
                    Envio _envio = new Envio();
                    _envio.Hora = dtpcFecha.Value;
                    _envio.Fecha = dtpcFecha.Value;
                    _envio.Direccion = txtDireccion.Text;

                    if (lblIdPedido.Text != "Pedido")
                    {
                        _envio.IdPedido = Convert.ToInt64(lblIdPedido.Text);
                    }
                    else
                    {
                        _envio.IdPedido = IdPedido;
                    }

                    _envio.Mail = txtMail.Text;
                    _envio.Telefono = txtTelefono.Text;
                    _envio.PrecioEnvio = Convert.ToDecimal(txtPrecio.Text);

                    EnvioBL envioBL = new EnvioBL();
                    int _resultado = envioBL.AgregarEnvio(_envio);
                    if (_resultado != 0)
                    {
                        MessageBox.Show("El envio se ha registrado exitosamente",
                        "Envios", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Notificacion _N = new Notificacion();
                        _N.Fecha = DateTime.Now.Date;
                        _N.Hora = DateTime.Now;

                        _N.IdEmpleado = Session.Id;
                        _N.Descripcion = "Se ha agregado un nuevo envio para el dia " + dtpcFecha.Value.ToShortDateString() + " a las " + dtpcFecha.Value.ToShortTimeString();
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
                else
                {
                    MessageBox.Show("Hay campos sin llenar o escritos de forma incorrecta, por favor revisarlos",
                        "Envios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
