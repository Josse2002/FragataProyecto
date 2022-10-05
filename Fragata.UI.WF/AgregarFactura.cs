using Fragata.BL;
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
    public partial class AgregarFactura : Form
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

        public AgregarFactura()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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

        private void AgregarFactura_Activated(object sender, EventArgs e)
        {
            lblPedido.Text = IdPedido.ToString();
            txtNombres.Text = NombreUsuario;
            txtPedido.Text = CodigoProducto;
            EnvioBL envio = new EnvioBL();
            PedidoBL _pedido = new PedidoBL();

            foreach (var item in _pedido.ObtenerPedidosActivos())
            {
                if (item.Id.ToString() == IdPedido.ToString())
                {
                    foreach (var envioo in envio.ObtenerEnvios())
                    {
                        if (envioo.IdPedido.ToString() == item.Id.ToString())
                        {
                            lblTP.Text = "$" + (envioo.PrecioEnvio + item.precioPedido).ToString();
                        }
                        else
                        {
                            lblTP.Text = "$" + item.precioPedido.ToString();
                        }
                    }
                }
            }
        }
    }
}
