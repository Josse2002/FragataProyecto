using Fragata.BL;
using Fragata.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fragata.UI.WF
{
    public partial class VerProducto : Form
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

        public VerProducto()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));




            #region Creando los controles...


            #endregion
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public VerProducto(Producto _producto)
        {
            //CONSTRUCTOR
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            lblId.Text = _producto.Id.ToString();
            lblNombre.Text = _producto.Nombre;
            lblCodigo.Text = _producto.CodigoProducto;
            lblPrice.Text = _producto.Precio.ToString();
            lblFecha.Text = _producto.FechaAgregado.ToShortDateString();
            lblTypeEvent.Text = _producto.TipoEvento;
            lblTypeProduct.Text = _producto.TipoProducto;
            lblDescription.Text = _producto.Descripccion;
            lblExistencia.Text = _producto.Existencias;
            lblNumeroE.Text = _producto.NumeroExistencias;


            MemoryStream ms = new MemoryStream(_producto.Fotografia);
            Image returnImage = Image.FromStream(ms);
            pboxPerfil.Image = returnImage;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            

            string existencias = _producto.Existencias;
            string NExistencias = _producto.NumeroExistencias;

            if (lblTypeProduct.Text == "Arreglo")
            {
                btnExistencias.Visible = true;
                btnEditar.Location = new System.Drawing.Point(11, 426);
                btnEliminar.Location = new System.Drawing.Point(152, 426);
                btnExistencias.Location = new System.Drawing.Point(293, 426);
                this.Size = new Size(466, 533);
            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult _respuesta = MessageBox.Show("¿Esta seguro de eliminar el producto?",
                   lblNombre.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (_respuesta == DialogResult.Yes)
                {
                    ProductosBL _ProductosBL = new ProductosBL();

                    int _resultado = _ProductosBL.EliminarProducto(Convert.ToInt64(lblId.Text));

                    if (_resultado != 0)
                    {
                        MessageBox.Show("El producto se ha eliminado satisfactoriamente",
                         lblNombre.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ActiveForm.Close();

                      


                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error en la aplicacion: " + ex.Message,
                    "Error en la aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TimeoutException ex)
            {
                MessageBox.Show("Ha ocurrido un error en los campos: " + ex.Message,
                    "Error en la aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ha ocurrido un error en la aplicacion: " + ex.Message,
                    "Error en la aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en la aplicacion: " + ex.Message,
                    "Error en la aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnExistencias_Click(object sender, EventArgs e)
        {
            Producto _product = new Producto();

            _product.Id = Convert.ToInt64(lblId.Text);
            _product.Nombre = lblNombre.Text.ToString();
            _product.CodigoProducto = lblCodigo.Text.ToString();
            _product.Existencias = lblExistencia.Text;
            _product.NumeroExistencias = lblNumeroE.Text;

            System.IO.MemoryStream _ms = new System.IO.MemoryStream();
            pboxPerfil.Image.Save(_ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            _product.Fotografia = _ms.GetBuffer();

            VerExistenciasProducto _form = new VerExistenciasProducto(_product);
            _form.Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Producto _product = new Producto();

            _product.Id = Convert.ToInt64(lblId.Text);
            _product.Nombre = lblNombre.Text.ToString();
            _product.FechaAgregado = Convert.ToDateTime(lblFecha.Text);
            _product.Precio = Convert.ToDecimal(lblPrice.Text);
            _product.TipoEvento = lblTypeEvent.Text;
            _product.TipoProducto = lblTypeProduct.Text;
            _product.Descripccion = lblDescription.Text;
            _product.CodigoProducto = lblCodigo.Text.ToString();
            _product.Existencias = lblExistencia.Text;
            _product.NumeroExistencias = lblNumeroE.Text;

            System.IO.MemoryStream _ms = new System.IO.MemoryStream();
            pboxPerfil.Image.Save(_ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            _product.Fotografia = _ms.GetBuffer();

            EditarProducto editar = new EditarProducto(_product);
            editar.ShowDialog();
        }

        public void ChangeTheme(Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                this.BackColor = Color.FromArgb(18, 18, 18);

                
                lblId.ForeColor = Color.White;
                lblNombre.ForeColor = Color.White;
               
                lblPrice.ForeColor = Color.White;
                lblFecha.ForeColor = Color.White;
                lblTypeEvent.ForeColor = Color.White;
                lblTypeProduct.ForeColor = Color.White;
                lblDescription.ForeColor = Color.White;
                lblExistencia.ForeColor = Color.White;
                lblNumeroE.ForeColor = Color.White;
            }
        }

        private void VerProducto_Shown(object sender, EventArgs e)
        {
            if (PantallaPrincipal.ConfiguracionGV != "NO")
            {
                ChangeTheme(Controls);
            }
        }
    }
}
