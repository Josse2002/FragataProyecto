using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fragata.BL;
using Fragata.Entities;

namespace Fragata.UI.WF
{
    public partial class SeleccionarMaterial : Form
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
        public SeleccionarMaterial()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void SeleccionarMaterial_Load(object sender, EventArgs e)
        {
            ExistenciaBL _existenciaBL = new ExistenciaBL();
            dgvObtenerMateriales.DataSource = _existenciaBL.ObtenerExistencia();
            dgvObtenerMateriales.Columns[2].Visible = false;
            dgvObtenerMateriales.Columns[0].Visible = false;
            dgvObtenerMateriales.Columns[5].Visible = false;
            dgvObtenerMateriales.Columns[6].Visible = false;
            dgvObtenerMateriales.Columns[7].Visible = false;
            DataGridViewImageCell cell = dgvObtenerMateriales.Rows[0].Cells[6] as DataGridViewImageCell;
            byte[] imagen = (byte[])cell.Value;
            MemoryStream ms = new MemoryStream(imagen);
            pboxImage.Image = Image.FromStream(ms);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvObtenerMateriales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewImageCell cell = dgvObtenerMateriales.CurrentRow.Cells[6] as DataGridViewImageCell;
            byte[] imagen = (byte[])cell.Value;

            MemoryStream ms = new MemoryStream(imagen);
            pboxImage.Image = Image.FromStream(ms);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtCantidad.Text.Length >= 4)
            {
                lblErrorCantidad.Visible = true;
            }
            else
            {
                lblErrorCantidad.Visible = false;
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCantidad.Text != "" && txtCantidad.Text.Length <= 3)
                {

                    AgregarProductos.IdMaterial = dgvObtenerMateriales.CurrentRow.Cells[0].Value.ToString();
                    AgregarProductos.NombreMaterial = dgvObtenerMateriales.CurrentRow.Cells[1].Value.ToString();
                    AgregarProductos.CantidadMaterial = txtCantidad.Text;

                    EditarProducto.IdMaterial = dgvObtenerMateriales.CurrentRow.Cells[0].Value.ToString();
                    EditarProducto.NombreMaterial = dgvObtenerMateriales.CurrentRow.Cells[1].Value.ToString();
                    EditarProducto.CantidadMaterial = txtCantidad.Text;

                    this.Close();

                }
                else
                {
                    MessageBox.Show("No se ha especificado la cantidad de elementos a usar o esta erroneo",
                 "Guardar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtBuscarExistencia_TextChanged(object sender, EventArgs e)
        {
            ExistenciaBL _ex = new ExistenciaBL();
            dgvObtenerMateriales.DataSource = _ex.BuscarExistenciaPorNombre(txtBuscarExistencia.Text);
            dgvObtenerMateriales.Columns[2].Visible = false;
            dgvObtenerMateriales.Columns[0].Visible = false;
            dgvObtenerMateriales.Columns[5].Visible = false;
            dgvObtenerMateriales.Columns[6].Visible = false;
            dgvObtenerMateriales.Columns[7].Visible = false;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        public void ChangeTheme(Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                this.BackColor = Color.FromArgb(18, 18, 18);

                if (component is Label)
                {
                    component.ForeColor = Color.White;
                }

                else if (component is Guna.UI2.WinForms.Guna2TextBox)
                {
                    txtBuscarExistencia.ForeColor = Color.Gray;
                    txtBuscarExistencia.BackColor = Color.FromArgb(18, 18, 18);
                    txtCantidad.BackColor = Color.FromArgb(18, 18, 18);
                    txtBuscarExistencia.FillColor = Color.FromArgb(10, 10, 10);
                    txtCantidad.FillColor = Color.FromArgb(10, 10, 10);
                }
               
                else if (component is Guna.UI2.WinForms.Guna2Button)
                {
                    component.BackColor = Color.FromArgb(18, 18, 18);
                    component.ForeColor = Color.White;
                }

                dgvObtenerMateriales.BackgroundColor = Color.FromArgb(18, 18, 18);
                dgvObtenerMateriales.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerMateriales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvObtenerMateriales.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerMateriales.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerMateriales.DefaultCellStyle.ForeColor = Color.Gray;
                dgvObtenerMateriales.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerMateriales.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;


            }
        }

        private void SeleccionarMaterial_Shown(object sender, EventArgs e)
        {
            if (PantallaPrincipal.ConfiguracionGV != "NO")
            {
                ChangeTheme(Controls);
            }
        }
    }
}
