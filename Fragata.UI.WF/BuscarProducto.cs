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
    public partial class BuscarProducto : Form
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
        public BuscarProducto()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarProducto_Load(object sender, EventArgs e)
        {
            ProductosBL productosBL = new ProductosBL();
            dgvObtenerProductos.DataSource = productosBL.ObtenerProduto();
            dgvObtenerProductos.Columns[5].Visible = false;
            dgvObtenerProductos.Columns[9].Visible = false;
            dgvObtenerProductos.Columns[8].Visible = false;

            DataGridViewColumn column = dgvObtenerProductos.Columns[0];

            DataGridViewCell cell = new DataGridViewTextBoxCell();

            cell.Style.ForeColor = Color.FromArgb(124, 255, 117);
            cell.Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            column.CellTemplate = cell;

            dgvObtenerProductos.Rows[0].Selected = true;
            lblIdProducto.Text = dgvObtenerProductos.Rows[0].Cells[0].Value.ToString();
            txtNombreProducto.Text = dgvObtenerProductos.Rows[0].Cells[1].Value.ToString();
            txtPrecioProducto.Text = dgvObtenerProductos.Rows[0].Cells[2].Value.ToString();
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            ProductosBL _ProductoBL = new ProductosBL();


            if (cmbFiltros.SelectedIndex == 0)
            {
                if (txtBuscarProducto.Text.Trim() != "")
                {
                    dgvObtenerProductos.DataSource = _ProductoBL.BuscarProductoPorNombre(txtBuscarProducto.Text, cmbOrdenn.Text);
                    dgvObtenerProductos.Columns[5].Visible = false;
                }
                else
                {
                    dgvObtenerProductos.DataSource = _ProductoBL.ObtenerProduto();
                    dgvObtenerProductos.Columns[5].Visible = false;
                }
            }
            else if (cmbFiltros.SelectedIndex == 1)
            {
                if (txtBuscarProducto.Text.Trim() != "")
                {
                    dgvObtenerProductos.DataSource = _ProductoBL.BuscarProductoPorCodigo(txtBuscarProducto.Text, cmbOrdenn.Text);
                    dgvObtenerProductos.Columns[5].Visible = false;
                }
                else
                {
                    dgvObtenerProductos.DataSource = _ProductoBL.ObtenerProduto();
                    dgvObtenerProductos.Columns[5].Visible = false;
                }
            }
        }

        private void cmbOrdenn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductosBL _ProductoBL = new ProductosBL();

            if (cmbFiltros.SelectedIndex == 0)
            {
                if (txtBuscarProducto.Text.Trim() != "")
                {
                    dgvObtenerProductos.DataSource = _ProductoBL.BuscarProductoPorNombre(txtBuscarProducto.Text, cmbOrdenn.Text);


                }
                else if (txtBuscarProducto.Text.Trim() == "")
                {
                    dgvObtenerProductos.DataSource = _ProductoBL.OrdenarProducto(cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerProductos.DataSource = _ProductoBL.ObtenerProduto();
                }
            }
            else if (cmbFiltros.SelectedIndex == 1)
            {
                if (txtBuscarProducto.Text.Trim() != "")
                {
                    dgvObtenerProductos.DataSource = _ProductoBL.BuscarProductoPorCodigo(txtBuscarProducto.Text, cmbOrdenn.Text);


                }
                else if (txtBuscarProducto.Text.Trim() == "")
                {
                    dgvObtenerProductos.DataSource = _ProductoBL.OrdenarProducto(cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerProductos.DataSource = _ProductoBL.ObtenerProduto();
                }
            }
        }

        private void dgvObtenerProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdProducto.Text = dgvObtenerProductos.CurrentRow.Cells[0].Value.ToString();
            txtNombreProducto.Text = dgvObtenerProductos.CurrentRow.Cells[1].Value.ToString();
            txtPrecioProducto.Text = dgvObtenerProductos.CurrentRow.Cells[2].Value.ToString();
        }

        private void txtCantidadProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtPrecioProducto_TextChanged(object sender, EventArgs e)
        {
            string str = txtPrecioProducto.Text;
            int s = str.Count(c => c == '.');

            if (txtPrecioProducto.Text.Length >= 6)
            {
                lblErrorPrecio.Text = "Se excede de caracteres";
                lblErrorPrecio.Visible = true;


            }
            else
            {
                lblErrorPrecio.Visible = false;
            }

            if (txtPrecioProducto.Text.StartsWith(".") == true)
            {
                lblErrorPrecio.Text = "No se puede comenzar con un punto decimal";
                lblErrorPrecio.Visible = true;
            }

            if (txtPrecioProducto.Text.EndsWith(".") == true)
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

        private void txtPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;

            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblIdProducto.Text != "" && lblIdProducto.Text != null && txtNombreProducto.Text !=""
                    && txtNombreProducto.Text != null && txtPrecioProducto.Text != "" && txtPrecioProducto.Text != null
                    && txtCantidadProducto.Text != null && txtCantidadProducto.Text != ""
                    && txtPrecioProducto.Text.Count(c => c == '.') == 1 &&
                    txtPrecioProducto.Text.Length <= 8 && txtPrecioProducto.Text.StartsWith(".") == false
                     )
                {
                    AgregarPedido.IdProducto = lblIdProducto.Text;
                    AgregarPedido.NombreProducto = txtNombreProducto.Text;
                    AgregarPedido.CantidadProductos = txtCantidadProducto.Text;
                    AgregarPedido.PrecioProducto = txtPrecioProducto.Text;

                    AgregarVenta.IdProducto = lblIdProducto.Text;
                    AgregarVenta.NombreProducto = txtNombreProducto.Text;
                    AgregarVenta.CantidadProductos = txtCantidadProducto.Text;
                    AgregarVenta.PrecioProducto = txtPrecioProducto.Text; 

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hubo un error al agregar el producto al pedido, por favor verifique los campos",
                          "Buscar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

       
    }
}
