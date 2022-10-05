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
    public partial class ObtenerVentas : Form
    {
        public ObtenerVentas()
        {
            InitializeComponent();
            VentaBL venta = new VentaBL();
            dgvObtenerProductos.DataSource = venta.ObtenerVentas();
            dgvObtenerProductos.Columns[3].Visible = false;
            dgvObtenerProductos.Columns[5].Visible = false;
            dgvObtenerProductos.Columns[6].Visible = false;
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
                dgvObtenerProductos.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerProductos.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerProductos.DefaultCellStyle.ForeColor = Color.Gray;
                dgvObtenerProductos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvObtenerProductos.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dtpcFecha.Visible == true)
            {
                transitionBuscar.HideSync(dtpcFecha);
                dtpcFecha.Value = Convert.ToDateTime("01/01/2020");

            }
            else
            {
                transitionBuscar.ShowSync(dtpcFecha);
                dtpcFecha.Value = DateTime.Now.Date;
            }
        }

        private void dtpcFecha_ValueChanged(object sender, EventArgs e)
        {
            VentaBL _VentaBL = new VentaBL();


            if (cmbFiltros.SelectedIndex == 0)
            {
                
                    dgvObtenerProductos.DataSource = _VentaBL.BuscarVentaPorFecha(dtpcFecha.Value, cmbOrdenn.Text);
                     
            }
            
        }

        private void cmbOrdenn_SelectedIndexChanged(object sender, EventArgs e)
        {
             VentaBL _VentaBL = new VentaBL();

            if (cmbFiltros.SelectedIndex == 0)
            {

                if (dtpcFecha.Value != DateTime.Now)
                {
                    dgvObtenerProductos.DataSource = _VentaBL.BuscarVentaPorFecha(dtpcFecha.Value, cmbOrdenn.Text);
                }
                else if (dtpcFecha.Value == DateTime.Now || dtpcFecha.Value == null || dtpcFecha.Visible == false)
                {
                    dgvObtenerProductos.DataSource = _VentaBL.OrdenarVenta(cmbOrdenn.Text);
                }
                else
                {
                    dgvObtenerProductos.DataSource =_VentaBL.ObtenerVentas();
                }
            }
            
        }
    }
}
