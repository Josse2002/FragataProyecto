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
    public partial class ObtenerExistencias : Form
    {
        public ObtenerExistencias()
        {
            InitializeComponent();
            String line;
            StreamReader sr = new StreamReader(@".\Settings.txt");
            //Read the first line of text
            line = sr.ReadLine();
            List<string> list = new List<string>();
            //Continue to read until you reach end of file
            while (line != null)
            {
                //write the line to console window
                Console.WriteLine(line);
                //Read the next line
                line = sr.ReadLine();
                list.Add(line);
            }

            //close the file
            sr.Close();
            Console.ReadLine();

            if (list[0].ToString() == "nocturne-mode: true")
            {
                ChangeTheme(Controls);
            }
            ExistenciaBL existenciaBL = new ExistenciaBL();

            dgvObtenerExistencias.DataSource = existenciaBL.ObtenerExistencia();
            dgvObtenerExistencias.Columns[6].Visible = false;
            dgvObtenerExistencias.Columns[7].Visible = false;

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

                dgvObtenerExistencias.BackgroundColor = Color.FromArgb(18, 18, 18);
                dgvObtenerExistencias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerExistencias.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvObtenerExistencias.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerExistencias.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerExistencias.DefaultCellStyle.ForeColor = Color.Gray;
                dgvObtenerExistencias.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerExistencias.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void ObtenerExistencias_Shown(object sender, EventArgs e)
        {
            if (PantallaPrincipal.ConfiguracionGV != "NO")
            {
                ChangeTheme(Controls);

            }
        }

        private void txtBuscarExistencia_TextChanged(object sender, EventArgs e)
        {
            ExistenciaBL _ExistenciaBL = new ExistenciaBL();


            if (cmbFiltros.SelectedIndex == 0)
            {
                if (txtBuscarExistencia.Text.Trim() != "")
                {
                    dgvObtenerExistencias.DataSource = _ExistenciaBL.BuscarExistenciaPorNombreId(txtBuscarExistencia.Text, cmbOrdenn.Text);

                    dgvObtenerExistencias.Columns[10].Visible = false;
                    dgvObtenerExistencias.Columns[9].Visible = false;
                }
                else
                {
                    dgvObtenerExistencias.DataSource = _ExistenciaBL.ObtenerExistencia();
                }
            }
            else if (cmbFiltros.SelectedIndex == 1)
            {
                if (txtBuscarExistencia.Text.Trim() != "")
                {
                    dgvObtenerExistencias.DataSource = _ExistenciaBL.BuscarExistenciaPorNombreId(txtBuscarExistencia.Text, cmbOrdenn.Text);

                    dgvObtenerExistencias.Columns[10].Visible = false;
                    dgvObtenerExistencias.Columns[9].Visible = false;
                }
                else
                {
                    dgvObtenerExistencias.DataSource = _ExistenciaBL.ObtenerExistencia();
                }
            }
        }

        private void cmbOrdenn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExistenciaBL _ExistenciaBL = new ExistenciaBL();

            if (cmbFiltros.SelectedIndex == 0)
            {
                if (txtBuscarExistencia.Text.Trim() != "")
                {
                    dgvObtenerExistencias.DataSource = _ExistenciaBL.BuscarExistenciaPorNombreId(txtBuscarExistencia.Text, cmbOrdenn.Text);

                    dgvObtenerExistencias.Columns[10].Visible = false;
                }
                else if (txtBuscarExistencia.Text.Trim() == "")
                {
                    dgvObtenerExistencias.DataSource = _ExistenciaBL.OrdenarExistencia(cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerExistencias.DataSource = _ExistenciaBL.ObtenerExistencia();
                }
            }
            else if (cmbFiltros.SelectedIndex == 1)
            {
                if (txtBuscarExistencia.Text.Trim() != "")
                {
                    dgvObtenerExistencias.DataSource = _ExistenciaBL.BuscarExistenciaPorCodigo(txtBuscarExistencia.Text, cmbOrdenn.Text);

                    dgvObtenerExistencias.Columns[10].Visible = false;
                }
                else if (txtBuscarExistencia.Text.Trim() == "")
                {
                    dgvObtenerExistencias.DataSource = _ExistenciaBL.OrdenarExistencia(cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerExistencias.DataSource = _ExistenciaBL.ObtenerExistencia();
                }
            }

        }

        private void dgvObtenerExistencia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvObtenerExistencias.CurrentRow != null)
                {
                    Existencia _Existencia = new Existencia();

                    _Existencia.Id = Convert.ToInt64(dgvObtenerExistencias.CurrentRow.Cells[0].Value);
                    _Existencia.Nombre = dgvObtenerExistencias.CurrentRow.Cells[1].Value.ToString();
                    _Existencia.Codigo = dgvObtenerExistencias.CurrentRow.Cells[2].Value.ToString();
                    _Existencia.Cantidad = Convert.ToInt32(dgvObtenerExistencias.CurrentRow.Cells[3].Value);
                    _Existencia.Categoria = dgvObtenerExistencias.CurrentRow.Cells[4].Value.ToString();
                    _Existencia.UltimaFechaAgregado = Convert.ToDateTime(dgvObtenerExistencias.CurrentRow.Cells[5].Value);
                    DataGridViewImageCell cell = dgvObtenerExistencias.CurrentRow.Cells[6] as DataGridViewImageCell;
                    byte[] imagen = (byte[])cell.Value;
                    _Existencia.Imagen = imagen;

                   // Existencia _form = new (_Existencia);

                    //_form.Show();

                }
                else
                {
                    MessageBox.Show("No se ha seleccionado un registro para modificar.",
                        "Ver Existencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                transitionBuscar.HideSync(txtBuscarExistencia);

            }
            else
            {
                transitionBuscar.ShowSync(txtBuscarExistencia);
            }
        }

        private void dgvObtenerExistencias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvObtenerExistencias.CurrentRow != null)
                {
                    Existencia _Existencia = new Existencia();

                    _Existencia.Id = Convert.ToInt64(dgvObtenerExistencias.CurrentRow.Cells[0].Value);
                    _Existencia.Nombre = dgvObtenerExistencias.CurrentRow.Cells[1].Value.ToString();
                    _Existencia.Codigo = dgvObtenerExistencias.CurrentRow.Cells[2].Value.ToString();
                    _Existencia.Cantidad = Convert.ToInt32(dgvObtenerExistencias.CurrentRow.Cells[3].Value);
                    _Existencia.Categoria = dgvObtenerExistencias.CurrentRow.Cells[4].Value.ToString();
                    _Existencia.UltimaFechaAgregado = Convert.ToDateTime(dgvObtenerExistencias.CurrentRow.Cells[5].Value);
                    DataGridViewImageCell cell = dgvObtenerExistencias.CurrentRow.Cells[6] as DataGridViewImageCell;
                    byte[] imagen = (byte[])cell.Value;
                    _Existencia.Imagen = imagen;

                    //EditarExistencia _ee = new EditarExistencia();
                    //_ee.ShowDialog();

                }
                else
                {
                    MessageBox.Show("No se ha seleccionado un registro para modificar.",
                        "Ver Existencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
           
               



























