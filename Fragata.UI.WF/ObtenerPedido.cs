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

namespace Fragata.UI.WF
{
    public partial class ObtenerPedido : Form
    {
        PedidoBL _pedidoBL = new PedidoBL();
        public ObtenerPedido()
        {
            InitializeComponent();
            
        }

        //CARGAR DATAGRIDVIEW Y OCULTAR ALGUNOS DATOS
        private void ObtenerPedido_Load(object sender, EventArgs e)
        {
            try
            {
                dgvObtenerPedidos.DataSource = _pedidoBL.ObtenerPedidos();
                DataGridViewColumn column = dgvObtenerPedidos.Columns[0];

                DataGridViewCell cell = new DataGridViewTextBoxCell();

                cell.Style.ForeColor = Color.FromArgb(52, 84, 173);
                cell.Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

                dgvObtenerPedidos.Columns[1].Visible = false;
                dgvObtenerPedidos.Columns[2].Visible = false;
                dgvObtenerPedidos.Columns[7].Visible = false;
                dgvObtenerPedidos.Columns[9].Visible = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("¡Vaya! Parece que algo ha salido mal. "
                    + ex.Message,
                    "Error en el proceso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show("¡Vaya! Al parecer existe un error al conectar al servidor, revisa tu conexion"
                    + ex.Message,
                    "Error en el proceso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("¡Vaya! Un formato no esta correcto.",
                     "Error en el proceso",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Vaya! Parece que algo salio mal..."
                    + ex.Message,
                     "Error en el proceso",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //EVENTO DE TEXT-CHANGED BUSCAR
        private void txtBuscarPedidos_TextChanged(object sender, EventArgs e)
        {
            PedidoBL _pedidoBL = new PedidoBL();


            if (cmbFiltros.SelectedIndex == 0)
            {
                if (txtBuscarPedidos.Text.Trim() != "")
                {
                    dgvObtenerPedidos.DataSource = _pedidoBL.BuscarPedidoPorNombre(txtBuscarPedidos.Text, cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerPedidos.DataSource = _pedidoBL.ObtenerPedidos();
                }
            }
            else if (cmbFiltros.SelectedIndex == 1)
            {
                if (txtBuscarPedidos.Text.Trim() != "")
                {
                    dgvObtenerPedidos.DataSource = _pedidoBL.BuscarPedidoPorCodigo(txtBuscarPedidos.Text, cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerPedidos.DataSource = _pedidoBL.ObtenerPedidos();
                }
            }
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

                dgvObtenerPedidos.BackgroundColor = Color.FromArgb(18, 18, 18);
                dgvObtenerPedidos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerPedidos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvObtenerPedidos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerPedidos.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerPedidos.DefaultCellStyle.ForeColor = Color.Gray;
                dgvObtenerPedidos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerPedidos.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void ObtenerPedido_Shown(object sender, EventArgs e)
        {
            if (PantallaPrincipal.ConfiguracionGV != "NO")
            {
                ChangeTheme(Controls);

            }
        }

        private void cmbOrdenn_SelectedIndexChanged(object sender, EventArgs e)
        {

            PedidoBL _pedidoBL = new PedidoBL();


            if (cmbFiltros.SelectedIndex == 0)
            {
                if (txtBuscarPedidos.Text.Trim() != "")
                {
                    dgvObtenerPedidos.DataSource = _pedidoBL.BuscarPedidoPorNombre(txtBuscarPedidos.Text, cmbOrdenn.Text);
                }
                else if (txtBuscarPedidos.Text == "")
                {
                    dgvObtenerPedidos.DataSource = _pedidoBL.OrdenarPedido(cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerPedidos.DataSource = _pedidoBL.ObtenerPedidos();
                }
            }
            else if (cmbFiltros.SelectedIndex == 1)
            {
                if (txtBuscarPedidos.Text.Trim() != "")
                {
                    dgvObtenerPedidos.DataSource = _pedidoBL.BuscarPedidoPorCodigo(txtBuscarPedidos.Text, cmbOrdenn.Text);
                }
                else if (txtBuscarPedidos.Text == "")
                {
                    dgvObtenerPedidos.DataSource = _pedidoBL.OrdenarPedido(cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerPedidos.DataSource = _pedidoBL.ObtenerPedidos();
                }
            }
        }

        private void pboxButtonLupa_Click(object sender, EventArgs e)
        {
            if (txtBuscarPedidos.Visible == true)
            {
                trancisionBusqueda.HideSync(txtBuscarPedidos);

            }
            else
            {
                trancisionBusqueda.ShowSync(txtBuscarPedidos);
            }
        }

        private void dgvObtenerPedidos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Pedido pedido = new Pedido();
            if (dgvObtenerPedidos.CurrentRow != null)
            {
                pedido.Id = Convert.ToInt64(dgvObtenerPedidos.CurrentRow.Cells[0].Value);
                pedido.Fecha = Convert.ToDateTime(dgvObtenerPedidos.CurrentRow.Cells[1].Value);
                pedido.Hora = Convert.ToDateTime(dgvObtenerPedidos.CurrentRow.Cells[2].Value);
                pedido.CodigoPedido = dgvObtenerPedidos.CurrentRow.Cells[3].Value.ToString();
                pedido.FormaEntrega = dgvObtenerPedidos.CurrentRow.Cells[4].Value.ToString();
                pedido.Estado = dgvObtenerPedidos.CurrentRow.Cells[5].Value.ToString();
                pedido.precioPedido = Convert.ToDecimal(dgvObtenerPedidos.CurrentRow.Cells[6].Value);
                pedido.Productos = dgvObtenerPedidos.CurrentRow.Cells[7].Value.ToString();
                pedido.Usuario = dgvObtenerPedidos.CurrentRow.Cells[8].Value.ToString();
                pedido.CantidadProductos = dgvObtenerPedidos.CurrentRow.Cells[9].Value.ToString();

                VerPedido _vp = new VerPedido(pedido);
                _vp.ShowDialog();
            }
            else
            {
                MessageBox.Show("¡Vaya! Has seleccionado una fila erronea o inexistente",
                     "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
