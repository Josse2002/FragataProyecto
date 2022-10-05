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
    public partial class ObtenerProveedor : Form
    {
        public ObtenerProveedor()
        {
            InitializeComponent();
        }



        private void txtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            ProveedorBL _ProveedorBL = new ProveedorBL();

            //TODO EN VEZ DE EMPLEADO SERIA PARA CLIENTE
            if (cmbFiltros.SelectedIndex == 0)
            {
                if (txtBuscarProveedor.Text.Trim() != "")
                {
                    dgvObtenerProveedor.DataSource = _ProveedorBL.BuscarProveedorPorNombre(txtBuscarProveedor.Text, cmbProveedor.Text);

                    dgvObtenerProveedor.Columns[10].Visible = false;
                    dgvObtenerProveedor.Columns[9].Visible = false;
                }
                else
                {
                    dgvObtenerProveedor.DataSource = _ProveedorBL.ObtenerProveedor();
                }
            }
            else if (cmbFiltros.SelectedIndex == 1)
            {
                if (txtBuscarProveedor.Text.Trim() != "")
                {
                    dgvObtenerProveedor.DataSource = _ProveedorBL.BuscarProveedorPorEmpresa(txtBuscarProveedor.Text, cmbProveedor.Text);

                    dgvObtenerProveedor.Columns[10].Visible = false;
                    dgvObtenerProveedor.Columns[9].Visible = false;
                }
                else
                {
                    dgvObtenerProveedor.DataSource = _ProveedorBL.ObtenerProveedor();
                }
            }
        }





        private void pboxButtonLupa_Click(object sender, EventArgs e)
        {
            if (txtBuscarProveedor.Visible == true)
            {
                TranscisionProveedor.HideSync(txtBuscarProveedor);

            }
            else
            {
                TranscisionProveedor.ShowSync(txtBuscarProveedor);
            }
        }



        public void ChangeTheme(Control.ControlCollection container);

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProveedorBL _ClienteBL = new ProveedorBL();

            if (cmbFiltros.SelectedIndex == 0)
            {
                if (txtBuscarProveedor.Text.Trim() != "")
                {
                    dgvObtenerProveedor.DataSource = _ClienteBL.BuscarProveedorPorNombre(txtBuscarProveedor.Text, cmbProveedor.Text);

                    dgvObtenerProveedor.Columns[10].Visible = false;
                }
                else if (txtBuscarProveedor.Text.Trim() == "")
                {
                    dgvObtenerProveedor.DataSource = _ClienteBL.OrdenarProveedor(cmbProveedor.Text);
                }
                else
                {
                    dgvObtenerProveedor.DataSource = _ClienteBL.ObtenerProveedor();
                }
            }
            else if (cmbFiltros.SelectedIndex == 1)
            {
                if (txtBuscarProveedor.Text.Trim() != "")
                {
                    dgvObtenerProveedor.DataSource = _ClienteBL.BuscarProveedorPorEmpresa(txtBuscarProveedor.Text, cmbProveedor.Text);

                    dgvObtenerProveedor.Columns[10].Visible = false;
                }
                else if (txtBuscarProveedor.Text.Trim() == "")
                {
                    dgvObtenerProveedor.DataSource = _ClienteBL.OrdenarProveedor(cmbProveedor.Text);
                }
                else
                {
                    dgvObtenerProveedor.DataSource = _ClienteBL.ObtenerProveedor();
                }
            }
        }

        private void dgvObtenerProveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvObtenerProveedor.CurrentRow != null)
                {
                    Proveedor _Proveedor = new Proveedor();

                    _Proveedor.Id = Convert.ToInt64(dgvObtenerProveedor.CurrentRow.Cells[0].Value);
                    _Proveedor.NombreEncargado = dgvObtenerProveedor.CurrentRow.Cells[1].Value.ToString();
                    _Proveedor.Empresa = dgvObtenerProveedor.CurrentRow.Cells[3].Value.ToString();
                    _Proveedor.Direccion = dgvObtenerProveedor.CurrentRow.Cells[5].Value.ToString();

                    DataGridViewImageCell cell = dgvObtenerProveedor.CurrentRow.Cells[10] as DataGridViewImageCell;
                    byte[] imagen = (byte[])cell.Value;
                    _Proveedor.Fotografia = imagen;

                   

                    //VerCliente _form = new VerCliente(_Cliente);
                    // _form.Show();

                }
                else
                {
                    MessageBox.Show("No se ha seleccionado un registro para modificar.",
                        "Ver Empleado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



        private void ObtenerProveedor_Shown(object sender, EventArgs e)
        {
            if (PantallaPrincipal.ConfiguracionGV != "NO")
            {
                ChangeTheme(Controls);

            }
        }

    }
}
