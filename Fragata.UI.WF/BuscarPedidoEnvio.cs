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

namespace Fragata.UI.WF
{
    public partial class BuscarPedidoEnvio : Form
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
        PedidoBL _pedidoBL = new PedidoBL();
        public BuscarPedidoEnvio()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            
            dgvObtenerMateriales.DataSource = _pedidoBL.ObtenerPedidosActivos();
            dgvObtenerMateriales.Columns[1].Visible = false;
            dgvObtenerMateriales.Columns[2].Visible = false;
           
            
            
            dgvObtenerMateriales.Columns[4].Visible = false;
            dgvObtenerMateriales.Columns[5].Visible = false;
        
            dgvObtenerMateriales.Columns[7].Visible = false;
        
            dgvObtenerMateriales.Columns[9].Visible = false;

            dgvObtenerMateriales.Rows[0].Selected = true;

        }

        private void txtBuscarExistencia_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarExistencia.Text.Trim() != "" & txtBuscarExistencia.Text != "")
            {
                dgvObtenerMateriales.DataSource = _pedidoBL.BuscarPedidoEnEnvio(txtBuscarExistencia.Text, cmbOrdenn.Text);
            }
            else
            {
                dgvObtenerMateriales.DataSource = _pedidoBL.ObtenerPedidosActivos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (dgvObtenerMateriales.CurrentRow != null)
            {
                AgregarEnvio.CodigoProducto = dgvObtenerMateriales.CurrentRow.Cells[3].Value.ToString();
                AgregarEnvio.NombreUsuario = dgvObtenerMateriales.CurrentRow.Cells[8].Value.ToString();
                AgregarEnvio.IdPedido = Convert.ToInt64(dgvObtenerMateriales.CurrentRow.Cells[0].Value);

                AgregarFactura.CodigoProducto = dgvObtenerMateriales.CurrentRow.Cells[3].Value.ToString();
                AgregarFactura.NombreUsuario = dgvObtenerMateriales.CurrentRow.Cells[8].Value.ToString();
                AgregarFactura.IdPedido = Convert.ToInt64(dgvObtenerMateriales.CurrentRow.Cells[0].Value);
                this.Hide();
            }
        }
    }
}
