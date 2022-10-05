using Fragata.BL;
using Fragata.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fragata.UI.WF
{
    public partial class EditarProducto : Form
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

        //VARIABLES DEL DGV
        public static string IdMaterial;
        public static string NombreMaterial;
        public static string CantidadMaterial;
        public EditarProducto()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public EditarProducto(Producto _producto)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            lblId.Text = _producto.Id.ToString();
            txtNombreProducto.Text = _producto.Nombre;
            txtCodigoProducto.Text = _producto.CodigoProducto;
            txtPrecio.Text = _producto.Precio.ToString();
            txtDescripcion.Text = _producto.Descripccion.ToString();
            cmbEvento.SelectedItem = _producto.TipoEvento.ToString();
            lblAgregarEmpleado.Text = "Editar" + " " + _producto.TipoProducto;

            MemoryStream ms = new MemoryStream(_producto.Fotografia);
            Image returnImage = Image.FromStream(ms);
            pboxProductImage.Image = returnImage;

            //VALIDAR SI ES UN PRODUCTO O ES UN ARREGLO
            if (_producto.TipoProducto == "Arreglo")
            {
                lblMaterial.Visible = true;
                btnAgregarMaterial.Visible = true;
                dgvMateriales.Visible = true;
                btnAgregarProducto.Text = "Guardar\n\rCambios";
                this.Size = new Size(659, 647);
                chbxValidatorType.Checked = true;
                btnAgregarProducto.Location = new Point(351, 536);
                btnCancelar.Location = new Point(496, 536);
                this.Size = new Size(659, 647);
            }
            else
            {
                lblMaterial.Visible = false;
                btnAgregarMaterial.Visible = false;
                chbxValidatorType.Checked = false;
                dgvMateriales.Visible = false;
                this.StartPosition = FormStartPosition.CenterScreen;
                btnAgregarProducto.Text = "Guardar\n\rCambios";
                btnAgregarProducto.Location = new Point(119, 426);
                btnCancelar.Location = new Point(330, 426);
                this.Size = new Size(659, 541);
            }

            //AGREGANDO LAS EXISTENCIAS EN LOS DGV
            string _String = _producto.Existencias;
            string[] stringArray = _String.Split(',');

            string _String2 = _producto.NumeroExistencias;
            string[] stringArray2 = _String2.Split(',');

            ExistenciaBL existenciaBL = new ExistenciaBL();

            for (int i = 0; i < stringArray.Count(); i++)
            {
                foreach (var item in existenciaBL.BuscarExistenciaPoId(Convert.ToInt64(stringArray[i])))
                {
                    string[] row2 = { stringArray[i], item.Nombre, stringArray2[i] };
                    dgvMateriales.Rows.Add(row2);
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    pboxProductImage.Image = Image.FromFile(dialog.FileName);
                }
            }
            catch (OutOfMemoryException)
            {

                MessageBox.Show("El formato de imagen no es el correcto, solo se permiten imagenes JPG/JPEG/PNG",
                    "Guardar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en la aplicacion" + ex,
                "Guardar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Producto _product = new Producto();
                ProductosBL productosBL = new ProductosBL();

                #region SI ES UN ARREGLO...
                if (chbxValidatorType.Checked == true)
                {
                    _product.Id = Convert.ToInt64(lblId.Text);
                    _product.CodigoProducto = txtCodigoProducto.Text;
                    _product.Nombre = txtNombreProducto.Text;
                    _product.Precio = Convert.ToDecimal(txtPrecio.Text);
                    _product.Descripccion = txtDescripcion.Text;
                    _product.TipoEvento = cmbEvento.SelectedItem.ToString();

                    //Fecha de Agregado (Today)
                    CultureInfo ci = new CultureInfo("Es-Es");
                    string _mes = ci.DateTimeFormat.GetMonthName(DateTime.Now.Month);
                    string _year = DateTime.Now.Year.ToString();
                    string _dia = DateTime.Now.Day.ToString();
                    DateTime DiaHoy = Convert.ToDateTime(_dia + "-" + _mes + "-" + _year);
                    _product.FechaAgregado = DiaHoy;

                    //DATAGRIDVIEW OBTENER DATOS EN FORMA DE ARRAY


                    string[] ColumnaId = new string[dgvMateriales.Rows.Count];
                    string[] ColumnaCantidad = new string[dgvMateriales.Rows.Count];
                    int i = 0;

                    foreach (DataGridViewRow row in dgvMateriales.Rows)
                    {
                        ColumnaId[i] = row.Cells[0].Value != null && row.Cells[0].Value.ToString() != "" ? row.Cells[0].Value.ToString() : string.Empty;
                        ColumnaCantidad[i] = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : string.Empty;
                        i++;
                    }
                    //AÑADIENDOLE COMAS
                    string resultId = string.Join(",", ColumnaId);
                    string resultCan = string.Join(",", ColumnaCantidad);

                    string seMostro = "no";
                    //QUITANDOLE LA ULTIMA COMA
                    if (resultId.Length > 0 && resultCan.Length > 0)
                    {
                        resultId = resultId.Remove(resultId.Length - 1);
                        resultCan = resultCan.Remove(resultCan.Length - 1);
                    }
                    else
                    {
                        MessageBox.Show("El arreglo no se ha agregado, no se han especificado los materiales usados",
                            "Guardar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        seMostro = "si";
                    }

                    _product.Existencias = resultId;
                    _product.NumeroExistencias = resultCan;


                    _product.TipoProducto = "Arreglo";




                    System.IO.MemoryStream _ms = new System.IO.MemoryStream();
                    pboxProductImage.Image.Save(_ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    _product.Fotografia = _ms.GetBuffer();

                    if (txtNombreProducto.Text != "" && txtNombreProducto.Text.Length < 20 &&
                        txtDescripcion.Text.Length < 500 && txtPrecio.Text.Count(c => c == '.') == 1 &&
                        txtPrecio.Text.Length <= 8 && txtPrecio.Text.StartsWith(".") == false &&
                        cmbEvento.SelectedIndex != 0 && resultCan.Length > 0)
                    {
                        int _resultado = productosBL.ModificarProducto(_product);

                        if (_resultado != 0)
                        {
                            MessageBox.Show("El producto se ha modificado exitosamente ",
                            "Guardar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
                    }
                    else
                    {
                        if (seMostro == "no")
                        {
                            MessageBox.Show("Hay campos incorrectos o erroneos, revise el formulario",
                            "Cliente no guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }


                #endregion

                #region SI ES UN PRODUCTO..
                if (chbxValidatorType.Checked == false)
                {
                    _product.Id = Convert.ToInt64(lblId.Text);
                    _product.CodigoProducto = txtCodigoProducto.Text;
                    _product.Nombre = txtNombreProducto.Text;
                    _product.Precio = Convert.ToDecimal(txtPrecio.Text);
                    _product.Descripccion = txtDescripcion.Text;
                    _product.TipoEvento = cmbEvento.SelectedItem.ToString();

                    //Fecha de Agregado (Today)
                    CultureInfo ci = new CultureInfo("Es-Es");
                    string _mes = ci.DateTimeFormat.GetMonthName(DateTime.Now.Month);
                    string _year = DateTime.Now.Year.ToString();
                    string _dia = DateTime.Now.Day.ToString();
                    DateTime DiaHoy = Convert.ToDateTime(_dia + "-" + _mes + "-" + _year);
                    _product.FechaAgregado = DiaHoy;

                    _product.Existencias = "0";
                    _product.NumeroExistencias = "0";


                    _product.TipoProducto = "Producto";




                    System.IO.MemoryStream _ms = new System.IO.MemoryStream();
                    pboxProductImage.Image.Save(_ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    _product.Fotografia = _ms.GetBuffer();

                    if (txtNombreProducto.Text != "" && txtNombreProducto.Text.Length < 20 &&
                        txtDescripcion.Text.Length < 500 && txtPrecio.Text.Count(c => c == '.') == 1 &&
                        txtPrecio.Text.Length <= 8 && txtPrecio.Text.StartsWith(".") == false &&
                        cmbEvento.SelectedIndex != 0)
                    {
                        int _resultado = productosBL.ModificarProducto(_product);

                        if (_resultado != 0)
                        {
                            MessageBox.Show("El producto se ha modificado exitosamente ",
                            "Guardar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hay campos incorrectos o erroneos, revise el formulario",
                        "Cliente no guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


                #endregion
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
                MessageBox.Show("Hay campos sin llenar o con datos erroneos, reviselos e intente de nuevo",
                    "Error en la aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El array uwu " + ex.Message,
                    "Error en la aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarMaterial_Click(object sender, EventArgs e)
        {
            SeleccionarMaterial _form = new SeleccionarMaterial();
            _form.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvMateriales.Rows.Remove(dgvMateriales.CurrentRow);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            SeleccionarMaterial _form = new SeleccionarMaterial();
            _form.ShowDialog();
        }

        private void EditarProducto_Activated(object sender, EventArgs e)
        {
            if (IdMaterial != null && NombreMaterial != null && CantidadMaterial != null && CantidadMaterial != "")
            {
                if (dgvMateriales.Rows.Count != 0)
                {
                    bool exist = dgvMateriales.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["MNombre"].Value) == NombreMaterial);
                    if (!exist)
                    {

                        string[] row2 = { IdMaterial, NombreMaterial, CantidadMaterial };
                        dgvMateriales.Rows.Add(row2);

                    }
                    else
                    {
                        MessageBox.Show("No se pueden agregar dos veces la misma existencia ",
                                            "Error en la aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            IdMaterial = null;
            NombreMaterial = null;
            CantidadMaterial = null;
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {

            int numero = txtNombreProducto.Text.Length;
            lblContadorNombres.Text = numero + "/20";

            if (txtNombreProducto.Text == "")
            {
                lblContadorNombres.Text = "0/20";
            }

            if (numero > 20)
            {
                lblContadorNombres.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblContadorNombres.ForeColor = System.Drawing.Color.Gray;
            }
        }

        

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            string str = txtPrecio.Text;
            int s = str.Count(c => c == '.');

            if (txtPrecio.Text.Length >= 6)
            {
                lblErrorPrecio.Text = "Se excede de caracteres";
                lblErrorPrecio.Visible = true;


            }
            else
            {
                lblErrorPrecio.Visible = false;
            }

            if (txtPrecio.Text.StartsWith(".") == true)
            {
                lblErrorPrecio.Text = "No se puede comenzar con un punto decimal";
                lblErrorPrecio.Visible = true;
            }

            if (txtPrecio.Text.EndsWith(".") == true)
            {
                lblErrorPrecio.Text = "El formato ingresado no es correcto";
                lblErrorPrecio.Visible = true;
            }

            if (s > 1)
            {
                if (lblErrorPrecio.Visible == true)
                {
                    lblErrorPrecio2.Visible = false;
                }
                else
                {
                    lblErrorPrecio2.Text = "Solo se puede poner un punto decimal";
                    lblErrorPrecio2.Visible = true;
                }

            }
            else
            {
                lblErrorPrecio2.Visible = false;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPrecio_TextChanged(sender, e);

            if (!char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;

            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            int numero = txtDescripcion.Text.Length;
            lblContadorDescripcion.Text = numero + "/500";

            if (txtDescripcion.Text == "")
            {
                lblContadorDescripcion.Text = "0/500";
            }

            if (numero > 500)
            {
                lblContadorDescripcion.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblContadorDescripcion.ForeColor = System.Drawing.Color.Gray;
            }
        }

        public void ChangeTheme(Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                this.BackColor = Color.FromArgb(18, 18, 18);


                if (component is Tablero)
                {
                    component.BackColor = Color.FromArgb(18, 18, 18);

                }
                else if (component is Label)
                {
                    component.ForeColor = Color.White;
                }

                else if (component is Guna.UI2.WinForms.Guna2TextBox)
                {
                    component.BackColor = Color.FromArgb(18, 18, 18);
                    txtNombreProducto.FillColor = Color.FromArgb(10, 10, 10);
                    txtDescripcion.FillColor = Color.FromArgb(10, 10, 10);
                    txtPrecio.FillColor = Color.FromArgb(10, 10, 10);
                    txtCodigoProducto.FillColor = Color.FromArgb(10, 10, 10);


                }
                else if (component is Guna.UI2.WinForms.Guna2ComboBox)
                {
                    component.BackColor = Color.FromArgb(18, 18, 18);
                    cmbEvento.FillColor = Color.FromArgb(10, 10, 10);
                    component.ForeColor = Color.White;

                }
                else if (component is Guna.UI2.WinForms.Guna2Button)
                {
                    component.BackColor = Color.FromArgb(18, 18, 18);
                    component.ForeColor = Color.White;
                }

                dgvMateriales.BackgroundColor = Color.FromArgb(18, 18, 18);
                dgvMateriales.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvMateriales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgvMateriales.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(18, 18, 18);
                dgvMateriales.DefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvMateriales.DefaultCellStyle.ForeColor = Color.Gray;
                dgvMateriales.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(18, 18, 18);
                dgvMateriales.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
                txtNombreProducto.IconRight = Properties.Resources.icon_nm;
                lblContadorNombres.BackColor = Color.FromArgb(18, 18, 18);

                txtDescripcion.IconRight = Properties.Resources.icon_nm;
                lblContadorDescripcion.BackColor = Color.FromArgb(18, 18, 18);
                txtCodigoProducto.BackColor = Color.FromArgb(18, 18, 18);
            }
        }

        private void EditarProducto_Shown(object sender, EventArgs e)
        {
            if (PantallaPrincipal.ConfiguracionGV != "NO")
            {
                ChangeTheme(Controls);

            }
        }
    }
}
