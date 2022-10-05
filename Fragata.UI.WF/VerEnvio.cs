using Fragata.BL;
using Fragata.Entities;
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

namespace Fragata.UI.WF
{
    public partial class VerEnvio : Form
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
        public VerEnvio()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public VerEnvio(Envio _envio)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
           
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            DateTime Hora = Convert.ToDateTime(_envio.Hora);
            string textoHora = Hora.Hour + ":" + Hora.Minute;
            lblHora.Text = Hora.ToShortTimeString();
            lblFecha.Text = Hora.ToShortDateString();
            lblIdPedido.Text = _envio.IdPedido.ToString();

            lblDireccion.Text = _envio.Direccion;
            PedidoBL _PedidoBL = new PedidoBL();

            //DECLARANDO LOS STRINGS
            string _Producto = "";
            string _CantidadP = "";
            foreach (var item in _PedidoBL.ObtenerPedidos())
            {
                if (item.Id == _envio.IdPedido)
                {
                    lblCliente.Text = item.Usuario;
                    _Producto = item.Productos;
                    _CantidadP = item.CantidadProductos;
                    
                }
            }

            string[] stringProductos = _Producto.Split(',');
            string[] stringCantidad = _CantidadP.Split(',');
            Decimal PrecioProductos = 0;
            ProductosBL _PbL = new ProductosBL();
            for (int i = 0; i < stringProductos.Length; i++)
            {
                foreach (var producto in _PbL.ObtenerProduto())
                {
                    if (producto.Id == Convert.ToInt64(stringProductos[i]))
                    {
                        string[] row2 = { producto.Nombre, stringCantidad[i], "$" + producto.Precio.ToString() };
                        dgvMateriales.Rows.Add(row2);
                        PrecioProductos = PrecioProductos + (producto.Precio * Convert.ToInt64(stringCantidad[i]));
                        
                    }
                }
            }
            

            lblTelefono.Text = _envio.Telefono;
            lblCorreo.Text = _envio.Mail;
            lblPEnvio.Text = "$" + _envio.PrecioEnvio.ToString(); 
            Decimal Total = PrecioProductos + _envio.PrecioEnvio;
            lblPrecioTotal.Text = "$" + Total.ToString();

            if (_envio.Estado == "A")
            {
                lblActive.Text = "Activo";
                lblActive.ForeColor = Color.Gold;
              

            }
            else if (_envio.Estado == "E")
            {
                lblActive.Text = "Enviado";
                lblActive.ForeColor = Color.Green;
                lblIDireccion.Text = "Direccion enviada:";
                lblAPro.Text = "Productos Adquiridos:";
                lblPagado.Text = "Total pagado:";
                btnEditar.Enabled = false;
                btnComplete.Enabled = false;
                btnCancelarEnvio.Enabled = false;


            }
            else if (_envio.Estado == "C")
            {
                lblActive.Text = "Cancelado";
                lblActive.ForeColor = Color.Red;
                lblIDireccion.Text = "Direccion:";
                lblAPro.Text = "Productos:";
                lblPagado.Text = "Total:";
                btnEditar.Enabled = false;
                btnComplete.Enabled = false;
                btnCancelarEnvio.Enabled = false;


            }
            lblId.Text = _envio.Id.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Envio envio = new Envio();
            envio.Id = Convert.ToInt64(lblId.Text);
            envio.Hora = Convert.ToDateTime(lblFecha.Text + " " + lblHora.Text);
            envio.Fecha = Convert.ToDateTime(lblFecha.Text + " " + lblHora.Text);
            envio.Direccion = lblDireccion.Text.ToString();
            envio.IdPedido = Convert.ToInt64(lblIdPedido.Text);

            if (lblActive.Text == "Activo")
            {
                envio.Estado = "A";
            }
            
            
            envio.Telefono = lblTelefono.Text.ToString();
            envio.Mail = lblCorreo.Text.ToString(); ;
            envio.PrecioEnvio = Convert.ToDecimal(lblPEnvio.Text.Replace("$", ""));

            EditarEnvio editarEnvio = new EditarEnvio(envio);
            editarEnvio.ShowDialog();
            this.Hide();
   
            
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea marcar el progreso del pedido de activo a finalizado? \nUna vez realizado no se puede editar ni cancelar",
                            "Completar Envio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                EnvioBL envioBL = new EnvioBL();
                envioBL.MarcarProgreso(Convert.ToInt64(lblId.Text), "E");
                btnEditar.Enabled = false;
                btnComplete.Enabled = false;
                btnCancelarEnvio.Enabled = false;
                this.Close();
                ObtenerEnvios.RecargarDgv = 1;


                Envio envio = new Envio();
                envio.Id = Convert.ToInt64(lblId.Text);
                envio.Hora = Convert.ToDateTime(lblFecha.Text + " " + lblHora.Text);
                envio.Fecha = Convert.ToDateTime(lblFecha.Text + " " + lblHora.Text);
                envio.Direccion = lblDireccion.Text.ToString();
                envio.IdPedido = Convert.ToInt64(lblIdPedido.Text);

                if (lblActive.Text == "Activo")
                {
                    envio.Estado = "A";
                }


                envio.Telefono = lblTelefono.Text.ToString();
                envio.Mail = lblCorreo.Text.ToString(); ;
                envio.PrecioEnvio = Convert.ToDecimal(lblPrecioTotal.Text.Replace("$", ""));

                AgregarVenta _AgregarVenta = new AgregarVenta(envio);
                _AgregarVenta.ShowDialog();
            }
              
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea cancelar el envio? \nUna vez realizado no se puede editar ni cancelar",
                           "Completar Envio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                EnvioBL envioBL = new EnvioBL();
                envioBL.MarcarProgreso(Convert.ToInt64(lblId.Text), "C");
                btnEditar.Enabled = false;
                btnComplete.Enabled = false;

            }
        }
    }
}
