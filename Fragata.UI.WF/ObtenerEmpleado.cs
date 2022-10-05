
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
    public partial class ObtenerEmpleado : Form
    {
        public ObtenerEmpleado()
        {
            InitializeComponent();
        }

        private void ObtenerEmpleado_Load(object sender, EventArgs e) //EVENTO LOAD DEL FORMULARIO
        {
            try
            {
                EmpleadoBL _EmpleadoBL = new EmpleadoBL();
                dgvObtenerEmpleados.DataSource = _EmpleadoBL.ObtenerEmpleados();
                DataGridViewColumn column = dgvObtenerEmpleados.Columns[0];

                DataGridViewCell cell = new DataGridViewTextBoxCell();

                cell.Style.ForeColor = Color.FromArgb(164, 164, 252);
                cell.Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

                //ESTOS DE ABAJO YA NO
                column.CellTemplate = cell;
                dgvObtenerEmpleados.Columns[12].Visible = false;
                dgvObtenerEmpleados.Columns[10].Visible = false;
                dgvObtenerEmpleados.Columns[9].Visible = false;
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






        private void txtBuscarEmpleado_TextChanged(object sender, EventArgs e) //EVENTO TEXT-CHANGED DEL TEXBOX DE BUSCAR
        {

            EmpleadoBL _EmpleadoBL = new EmpleadoBL();

            //TODO EN VEZ DE EMPLEADO SERIA PARA CLIENTE
            if (cmbFiltros.SelectedIndex == 0)
            {
                if (txtBuscarEmpleado.Text.Trim() != "")
                {
                    dgvObtenerEmpleados.DataSource = _EmpleadoBL.BuscarEmpleadoPorNombre(txtBuscarEmpleado.Text, cmbOrdenn.Text);
                                
                    dgvObtenerEmpleados.Columns[10].Visible = false;
                    dgvObtenerEmpleados.Columns[9].Visible = false;
                }
                else
                {
                    dgvObtenerEmpleados.DataSource = _EmpleadoBL.ObtenerEmpleados();
                }
            }
            else if (cmbFiltros.SelectedIndex == 1)
            {
                if (txtBuscarEmpleado.Text.Trim() != "")
                {
                    dgvObtenerEmpleados.DataSource = _EmpleadoBL.BuscarEmpleadoPorDui(txtBuscarEmpleado.Text, cmbOrdenn.Text);

                    dgvObtenerEmpleados.Columns[10].Visible = false;
                    dgvObtenerEmpleados.Columns[9].Visible = false;
                }
                else
                {
                    dgvObtenerEmpleados.DataSource = _EmpleadoBL.ObtenerEmpleados();
                }
            }
        }

        public void ChangeTheme(Control.ControlCollection container) //este codigo puedes copiarl otal cual
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

                dgvObtenerEmpleados.BackgroundColor = Color.FromArgb(18, 18, 18);
                dgvObtenerEmpleados.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerEmpleados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvObtenerEmpleados.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerEmpleados.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerEmpleados.DefaultCellStyle.ForeColor = Color.Gray;
                dgvObtenerEmpleados.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerEmpleados.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void cmbOrdenn_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmpleadoBL _EmpleadoBL = new EmpleadoBL();

            if (cmbFiltros.SelectedIndex == 0)
            {
                if (txtBuscarEmpleado.Text.Trim() != "")
                {
                    dgvObtenerEmpleados.DataSource = _EmpleadoBL.BuscarEmpleadoPorNombre(txtBuscarEmpleado.Text, cmbOrdenn.Text);

                    dgvObtenerEmpleados.Columns[10].Visible = false;
                }
                else if (txtBuscarEmpleado.Text.Trim() == "")
                {
                    dgvObtenerEmpleados.DataSource = _EmpleadoBL.OrdenarEmpleado(cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerEmpleados.DataSource = _EmpleadoBL.ObtenerEmpleados();
                }
            }
            else if (cmbFiltros.SelectedIndex == 1)
            {
                if (txtBuscarEmpleado.Text.Trim() != "")
                {
                    dgvObtenerEmpleados.DataSource = _EmpleadoBL.BuscarEmpleadoPorDui(txtBuscarEmpleado.Text, cmbOrdenn.Text);

                    dgvObtenerEmpleados.Columns[10].Visible = false;
                }
                else if (txtBuscarEmpleado.Text.Trim() == "")
                {
                    dgvObtenerEmpleados.DataSource = _EmpleadoBL.OrdenarEmpleado(cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerEmpleados.DataSource = _EmpleadoBL.ObtenerEmpleados();
                }
            }
        }




        private void pictureBox1_Click(object sender, EventArgs e) //evento clic dela lupa
        {
            if (txtBuscarEmpleado.Visible == true)
            {
                trancisionBuscar.HideSync(txtBuscarEmpleado);

            }
            else
            {
                trancisionBuscar.ShowSync(txtBuscarEmpleado);
            }
        }

        private void ObtenerEmpleado_MouseHover(object sender, EventArgs e) //ESTE CODIGO NO
        {
            EmpleadoBL _EmpleadoBL = new EmpleadoBL();

            dgvObtenerEmpleados.DataSource = _EmpleadoBL.ObtenerEmpleados();
        }

        
        private void dgvObtenerEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //EVENTO CELL DOUBLE CLIC DEL DATAGRIDVIEW
        {
            try
            {
                if (dgvObtenerEmpleados.CurrentRow != null)
                {
                    Empleado _empleado = new Empleado();

                    _empleado.Id = Convert.ToInt64(dgvObtenerEmpleados.CurrentRow.Cells[0].Value);
                    _empleado.Nombre = dgvObtenerEmpleados.CurrentRow.Cells[1].Value.ToString();
                    _empleado.Apellidos = dgvObtenerEmpleados.CurrentRow.Cells[3].Value.ToString();
                    _empleado.Edad = Convert.ToInt64(dgvObtenerEmpleados.CurrentRow.Cells[2].Value);
                    _empleado.Genero = dgvObtenerEmpleados.CurrentRow.Cells[4].Value.ToString();
                    _empleado.DUI = dgvObtenerEmpleados.CurrentRow.Cells[5].Value.ToString();
                    _empleado.Cargo = dgvObtenerEmpleados.CurrentRow.Cells[6].Value.ToString();
                    _empleado.Telefono = dgvObtenerEmpleados.CurrentRow.Cells[7].Value.ToString();
                    _empleado.HorasTrabajo = Convert.ToDecimal(dgvObtenerEmpleados.CurrentRow.Cells[8].Value);
                    _empleado.Clave = dgvObtenerEmpleados.CurrentRow.Cells[9].Value.ToString();
                    DataGridViewImageCell cell = dgvObtenerEmpleados.CurrentRow.Cells[10] as DataGridViewImageCell;
                    byte[] imagen = (byte[])cell.Value;
                    _empleado.Imagen = imagen;
                    _empleado.Permiso = dgvObtenerEmpleados.CurrentRow.Cells[12].Value.ToString();
                    _empleado.Mail = dgvObtenerEmpleados.CurrentRow.Cells[11].Value.ToString();

                    VerEmpleado _form = new VerEmpleado(_empleado);
                    _form.Show();

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
        //este codigo copialo tal cual
        private void ObtenerEmpleado_Shown(object sender, EventArgs e)
        {
            if (PantallaPrincipal.ConfiguracionGV != "NO")
            {
                ChangeTheme(Controls);

            }
        }
    }
}

        
     