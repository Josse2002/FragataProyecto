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

namespace Fragata.UI.WF
{
    public partial class ObtenerFacturas : Form
    {
        public ObtenerFacturas()
        {
            InitializeComponent();
            FacturaBL factura = new FacturaBL();
            dgvObtenerProductos.DataSource = factura.ObtenerFacturas();
            dgvObtenerProductos.Columns[4].Visible = false;
            dgvObtenerProductos.Columns[8].Visible = false;
            dgvObtenerProductos.Columns[9].Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtBuscarEmpleado.Visible == true)
            {
                transitionBusqueda.HideSync(txtBuscarEmpleado);

            }
            else
            {
                transitionBusqueda.ShowSync(txtBuscarEmpleado);
            }
        }

        private void txtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            FacturaBL _FBL = new FacturaBL();

            if (cmbFiltros.SelectedIndex == 0)
            {
                if (txtBuscarEmpleado.Text.Trim() != "")
                {
                    dgvObtenerProductos.DataSource = _FBL.BuscarFacturaNombre(txtBuscarEmpleado.Text, cmbOrdenn.Text);

                }
                else
                {
                    dgvObtenerProductos.DataSource = _FBL.ObtenerFacturas();
                }
            }
            else if (cmbFiltros.SelectedIndex == 1)
            {
                if (txtBuscarEmpleado.Text.Trim() != "")
                {
                    dgvObtenerProductos.DataSource = _FBL.BuscarFacturaNumero(txtBuscarEmpleado.Text, cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerProductos.DataSource = _FBL.ObtenerFacturas();
                }
            }

        }

        private void cmbOrdenn_SelectedIndexChanged(object sender, EventArgs e)
        {
            FacturaBL _FBL = new FacturaBL();

            if (cmbFiltros.SelectedIndex == 0)
            {
                if (txtBuscarEmpleado.Text.Trim() != "")
                {
                    dgvObtenerProductos.DataSource = _FBL.BuscarFacturaNombre(txtBuscarEmpleado.Text, cmbOrdenn.Text);

                }
                else if (txtBuscarEmpleado.Text.Trim() == "")
                {
                    dgvObtenerProductos.DataSource = _FBL.OrdenarFactura(cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerProductos.DataSource = _FBL.ObtenerFacturas();
                }
            }
            else if (cmbFiltros.SelectedIndex == 1)
            {
                if (txtBuscarEmpleado.Text.Trim() != "")
                {
                    dgvObtenerProductos.DataSource = _FBL.BuscarFacturaNumero(txtBuscarEmpleado.Text, cmbOrdenn.Text);
                }
                else if (txtBuscarEmpleado.Text.Trim() == "")
                {
                    dgvObtenerProductos.DataSource = _FBL.OrdenarFactura(cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerProductos.DataSource = _FBL.ObtenerFacturas();
                }
            }
        }
    }
}
