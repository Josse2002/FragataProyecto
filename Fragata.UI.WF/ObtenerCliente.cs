
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
    public partial class ObtenerCliente : Form
    {
        public ObtenerCliente()
        {
            InitializeComponent();
        }





        private void txtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            ClienteBL _ClienteBL = new ClienteBL();

            //TODO EN VEZ DE EMPLEADO SERIA PARA CLIENTE
            if (cmbFiltros.SelectedIndex == 0)
            {
                if (txtBuscarClientes.Text.Trim() != "")
                {
                    dgvObtenerClientes.DataSource = _ClienteBL.BuscarClientePorNombre(txtBuscarClientes.Text, cmbOrdenn.Text);

                    dgvObtenerClientes.Columns[10].Visible = false;
                    dgvObtenerClientes.Columns[9].Visible = false;
                }
                else
                {
                    dgvObtenerClientes.DataSource = _ClienteBL.ObtenerClientes();
                }
            }
            else if (cmbFiltros.SelectedIndex == 1)
            {
                if (txtBuscarClientes.Text.Trim() != "")
                {
                    dgvObtenerClientes.DataSource = _ClienteBL.BuscarClientePorCorreo(txtBuscarClientes.Text, cmbOrdenn.Text);

                    dgvObtenerClientes.Columns[10].Visible = false;
                    dgvObtenerClientes.Columns[9].Visible = false;
                }
                else
                {
                    dgvObtenerClientes.DataSource = _ClienteBL.ObtenerClientes();
                }
            }
        }



        private void pboxButtonLupa_Click(object sender, EventArgs e)
        {
            if (txtBuscarClientes.Visible == true)
            {
                TranscisionBusqueda.HideSync(txtBuscarClientes);

            }
            else
            {
                TranscisionBusqueda.ShowSync(txtBuscarClientes);
            }
        }




        public void ChangeTheme(Control.ControlCollection container);


        private void cmbOrdenn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClienteBL _ClienteBL = new ClienteBL();

            if (cmbFiltros.SelectedIndex == 0)
            {
                if (txtBuscarClientes.Text.Trim() != "")
                {
                    dgvObtenerClientes.DataSource = _ClienteBL.BuscarClientePorNombre(txtBuscarClientes.Text, cmbOrdenn.Text);

                    dgvObtenerClientes.Columns[10].Visible = false;
                }
                else if (txtBuscarClientes.Text.Trim() == "")
                {
                    dgvObtenerClientes.DataSource = _ClienteBL.OrdenarCliente(cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerClientes.DataSource = _ClienteBL.ObtenerClientes();
                }
            }
            else if (cmbFiltros.SelectedIndex == 1)
            {
                if (txtBuscarClientes.Text.Trim() != "")
                {
                    dgvObtenerClientes.DataSource = _ClienteBL.BuscarClientePorCorreo(txtBuscarClientes.Text, cmbOrdenn.Text);

                    dgvObtenerClientes.Columns[10].Visible = false;
                }
                else if (txtBuscarClientes.Text.Trim() == "")
                {
                    dgvObtenerClientes.DataSource = _ClienteBL.OrdenarCliente(cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerClientes.DataSource = _ClienteBL.ObtenerClientes();
                }
            }
        }





        private void dgvObtenerClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            try
            {
                if (dgvObtenerClientes.CurrentRow != null)
                {
                    Cliente _Cliente = new Cliente();

                    _Cliente.Id = Convert.ToInt64(dgvObtenerClientes.CurrentRow.Cells[0].Value);
                    _Cliente.Nombre = dgvObtenerClientes.CurrentRow.Cells[1].Value.ToString();
                    _Cliente.Apellidos = dgvObtenerClientes.CurrentRow.Cells[3].Value.ToString();
                    _Cliente.Edad = Convert.ToInt64(dgvObtenerClientes.CurrentRow.Cells[2].Value);
                    _Cliente.Genero = dgvObtenerClientes.CurrentRow.Cells[4].Value.ToString();
                    _Cliente.Ciudad = dgvObtenerClientes.CurrentRow.Cells[5].Value.ToString();
                    _Cliente.Telefono = dgvObtenerClientes.CurrentRow.Cells[7].Value.ToString();
                    _Cliente.Clave = dgvObtenerClientes.CurrentRow.Cells[9].Value.ToString();
                    DataGridViewImageCell cell = dgvObtenerClientes.CurrentRow.Cells[10] as DataGridViewImageCell;
                    byte[] imagen = (byte[])cell.Value;
                    _Cliente.Fotografia = imagen;

                    _Cliente.CorreoElectronico = dgvObtenerClientes.CurrentRow.Cells[11].Value.ToString();

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




        private void ObtenerClientes_Shown(object sender, EventArgs e)
        {
            if (PantallaPrincipal.ConfiguracionGV != "NO")
            {
                ChangeTheme(Controls);

            }
        }






    }
}
