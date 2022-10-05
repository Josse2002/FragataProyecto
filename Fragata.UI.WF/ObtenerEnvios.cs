using Fragata.BL;
using Fragata.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fragata.UI.WF
{
    public partial class ObtenerEnvios : Form
    {
        public static int RecargarDgv;
        public ObtenerEnvios()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }

        private void ObtenerEnvios_Load(object sender, EventArgs e)
        {
            try
            {
                EnvioBL _Envios = new EnvioBL();
                dgvObtenerEnvios.DataSource = _Envios.ObtenerEnvios();
                dgvObtenerEnvios.Columns[2].Visible = false;
                dgvObtenerEnvios.Columns[4].Visible = false;
               
                
      
                cmbFiltros.SelectedIndex = 0;
                cmbOrdenn.SelectedIndex = 0;
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

        private void dgvObtenerEnvios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvObtenerEnvios.CurrentRow != null)
                {
                    Envio _envio = new Envio();
                    _envio.Id = Convert.ToInt64(dgvObtenerEnvios.CurrentRow.Cells[0].Value);
                    _envio.Hora = Convert.ToDateTime(dgvObtenerEnvios.CurrentRow.Cells[1].Value);
                    _envio.Fecha = Convert.ToDateTime(dgvObtenerEnvios.CurrentRow.Cells[2].Value);
                    _envio.Direccion = dgvObtenerEnvios.CurrentRow.Cells[3].Value.ToString();
                    _envio.IdPedido = Convert.ToInt64(dgvObtenerEnvios.CurrentRow.Cells[4].Value);
                    _envio.Estado = dgvObtenerEnvios.CurrentRow.Cells[5].Value.ToString();
                    _envio.Telefono = dgvObtenerEnvios.CurrentRow.Cells[6].Value.ToString();
                    _envio.Mail = dgvObtenerEnvios.CurrentRow.Cells[7].Value.ToString();
                    _envio.PrecioEnvio = Convert.ToDecimal(dgvObtenerEnvios.CurrentRow.Cells[8].Value.ToString());

                    VerEnvio _verEnvio = new VerEnvio(_envio);
                    _verEnvio.ShowDialog();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pboxButtonLupa_Click(object sender, EventArgs e)
        {
            if (txtBuscarExistencia.Visible == true)
            {
                trancisionBusqueda.HideSync(txtBuscarExistencia);

            }
            else
            {
                trancisionBusqueda.ShowSync(txtBuscarExistencia);
            }
        }

        private void txtBuscarExistencia_TextChanged(object sender, EventArgs e)
        {
            EnvioBL envio = new EnvioBL();


            if (cmbFiltros.SelectedIndex == 0)
            {
                if (txtBuscarExistencia.Text.Trim() != "")
                {
                    dgvObtenerEnvios.DataSource = envio.BuscarEmpleadoPorDireccion(txtBuscarExistencia.Text, cmbOrdenn.Text);
               
                }
                else
                {
                    dgvObtenerEnvios.DataSource = envio.ObtenerEnvios();
                }
            }
            else if (cmbFiltros.SelectedIndex == 1)
            {
                if (txtBuscarExistencia.Text.Trim() != "")
                {
                    dgvObtenerEnvios.DataSource = envio.BuscarEmpleadoPorTelefono(txtBuscarExistencia.Text, cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerEnvios.DataSource = envio.ObtenerEnvios();
                }
            }
            else if (cmbFiltros.SelectedIndex == 2)
            {
                if (txtBuscarExistencia.Text.Trim() != "")
                {
                    dgvObtenerEnvios.DataSource = envio.BuscarEmpleadoPorCorreo(txtBuscarExistencia.Text, cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerEnvios.DataSource = envio.ObtenerEnvios();
                }
            }
            

            
        }

        private void cmbOrdenn_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnvioBL envio = new EnvioBL();


            if (cmbFiltros.SelectedIndex == 0)
            {
                if (txtBuscarExistencia.Text.Trim() != "")
                {
                    dgvObtenerEnvios.DataSource = envio.BuscarEmpleadoPorDireccion(txtBuscarExistencia.Text, cmbOrdenn.Text);

                }
                else if (txtBuscarExistencia.Text.Trim() == "")
                {
                    dgvObtenerEnvios.DataSource = envio.OrdenarEnvio(cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerEnvios.DataSource = envio.ObtenerEnvios();
                }
            }
            else if (cmbFiltros.SelectedIndex == 1)
            {
                if (txtBuscarExistencia.Text.Trim() != "")
                {
                    dgvObtenerEnvios.DataSource = envio.BuscarEmpleadoPorTelefono(txtBuscarExistencia.Text, cmbOrdenn.Text);
                }
                else if (txtBuscarExistencia.Text.Trim() == "")
                {
                    dgvObtenerEnvios.DataSource = envio.OrdenarEnvio(cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerEnvios.DataSource = envio.ObtenerEnvios();
                }
            }
            else if (cmbFiltros.SelectedIndex == 2)
            {
                if (txtBuscarExistencia.Text.Trim() != "")
                {
                    dgvObtenerEnvios.DataSource = envio.BuscarEmpleadoPorCorreo(txtBuscarExistencia.Text, cmbOrdenn.Text);
                }
                else if (txtBuscarExistencia.Text.Trim() == "")
                {
                    dgvObtenerEnvios.DataSource = envio.OrdenarEnvio(cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerEnvios.DataSource = envio.ObtenerEnvios();
                }
            }
        }

        private void dgvObtenerEnvios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
