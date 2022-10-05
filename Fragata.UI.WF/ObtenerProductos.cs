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
using System.IO;

namespace Fragata.UI.WF
{
    public partial class ObtenerProductos : Form
    {
        public ObtenerProductos()
        {
            InitializeComponent();
        }

        private void ObtenerProductos_Load(object sender, EventArgs e)
        {
            ProductosBL product = new ProductosBL();
            dgvObtenerProductos.DataSource = product.ObtenerProduto();
            dgvObtenerProductos.Columns[5].Visible = false;
            dgvObtenerProductos.Columns[9].Visible = false;
            dgvObtenerProductos.Columns[8].Visible = false;

            DataGridViewColumn column = dgvObtenerProductos.Columns[0];

            DataGridViewCell cell = new DataGridViewTextBoxCell();

            cell.Style.ForeColor = Color.FromArgb(124, 255, 117);
            cell.Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            column.CellTemplate = cell;
          
        }
        public void ChangeTheme(Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                this.BackColor = Color.FromArgb(18, 18, 18);
                if (component is Panel)
                {
                    ChangeTheme(component.Controls);
                    component.BackColor = Color.FromArgb(18, 18, 18);
                    component.ForeColor = Color.FromArgb(18, 18, 18);
                }

                else if (component is Tablero)
                {
                    component.BackColor = Color.FromArgb(18, 18, 18);

                }

                else if (component is TextBox)
                {
                    component.BackColor = Color.FromArgb(18, 18, 18);
                    component.ForeColor = Color.FromArgb(18, 18, 18);
                }
                else if (component is Guna.UI2.WinForms.Guna2Button)
                {
                    component.BackColor = Color.FromArgb(18, 18, 18);
                    component.ForeColor = Color.White;
                }

                dgvObtenerProductos.BackgroundColor = Color.FromArgb(18, 18, 18);
                dgvObtenerProductos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerProductos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvObtenerProductos.ColumnHeadersDefaultCellStyle.SelectionBackColor= Color.FromArgb(18, 18, 18);
                dgvObtenerProductos.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerProductos.DefaultCellStyle.ForeColor = Color.Gray;
                dgvObtenerProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerProductos.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtBuscarProducto.Visible == true)
            {
                transitionBuscar.HideSync(txtBuscarProducto);

            }
            else
            {
                transitionBuscar.ShowSync(txtBuscarProducto);
            }
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
        public void ObtenerProductosAgain()
        {
            ProductosBL _producto = new ProductosBL();
            dgvObtenerProductos.DataSource = _producto.ObtenerProduto();

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

        private void dgvObtenerProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvObtenerProductos.CurrentRow != null)
                {
                    Producto _product = new Producto();
                    _product.Id = Convert.ToInt64(dgvObtenerProductos.CurrentRow.Cells[0].Value);
                    _product.Nombre = dgvObtenerProductos.CurrentRow.Cells[1].Value.ToString();
                    _product.Precio = Convert.ToDecimal(dgvObtenerProductos.CurrentRow.Cells[2].Value);
                    _product.CodigoProducto = dgvObtenerProductos.CurrentRow.Cells[3].Value.ToString();
                    _product.Descripccion = dgvObtenerProductos.CurrentRow.Cells[4].Value.ToString();
                    DataGridViewImageCell cell = dgvObtenerProductos.CurrentRow.Cells[5] as DataGridViewImageCell;
                    byte[] imagen = (byte[])cell.Value;
                    _product.Fotografia = imagen;
                    _product.FechaAgregado = Convert.ToDateTime(dgvObtenerProductos.CurrentRow.Cells[6].Value);
                    _product.TipoEvento = dgvObtenerProductos.CurrentRow.Cells[7].Value.ToString();
                    _product.Existencias = dgvObtenerProductos.CurrentRow.Cells[8].Value.ToString();
                    _product.NumeroExistencias = dgvObtenerProductos.CurrentRow.Cells[9].Value.ToString();
                    _product.TipoProducto = dgvObtenerProductos.CurrentRow.Cells[10].Value.ToString();

                    VerProducto _form = new VerProducto(_product);
                    _form.Show();

                  

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ObtenerProductos_Shown(object sender, EventArgs e)
        {
            if (PantallaPrincipal.ConfiguracionGV != "NO")
            {
                ChangeTheme(Controls);

            }
        }

    }
}