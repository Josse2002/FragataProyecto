using Fragata.BL;
using Fragata.Entities;
using Fragata.Entities.Cache;
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
    public partial class EditarEmpleado : Form
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
        public EditarEmpleado()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            
        }

        public EditarEmpleado(Empleado _empleado)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //CONTADORES DE LETRAS
            lblContadorNombres.Text = _empleado.Nombre.Length.ToString() + "/50";
            lblContadorApellidos.Text = _empleado.Apellidos.Length.ToString() + "/50";

            //MOSTRAR LOS CAMPOS EN EL FORMULARIO
            lblClave.Text = _empleado.Clave.ToString();
            lblId.Text = _empleado.Id.ToString();
            txtNombres.Text = _empleado.Nombre.ToString();
            txtApellidos.Text = _empleado.Apellidos.ToString();
            cmbGenero.SelectedItem = _empleado.Genero.ToString();
            txtEdad.Text = _empleado.Edad.ToString();
            txtDUI.Text = _empleado.DUI.ToString();
            cmbCargo.SelectedItem = _empleado.Cargo.ToString();
            txtTelefono.Text = _empleado.Telefono.ToString();
            txtHorasTrabajo.Text = _empleado.HorasTrabajo.ToString();
            txtMail.Text = _empleado.Mail;
            MemoryStream ms = new MemoryStream(_empleado.Imagen);
            Image returnImage = Image.FromStream(ms);
            pboxImage.Image = returnImage;
            

            if (Session.Permiso == "E")
            {
                txtHorasTrabajo.Enabled = false;
                txtHorasTrabajo.ReadOnly = true;
                cmbCargo.Enabled = false;
                txtDUI.Enabled = false;
                txtDUI.ReadOnly = true;

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
                    txtNombres.FillColor = Color.FromArgb(10, 10, 10);
                    txtApellidos.FillColor = Color.FromArgb(10, 10, 10);
                    txtEdad.FillColor = Color.FromArgb(10, 10, 10);
                    txtTelefono.FillColor = Color.FromArgb(10, 10, 10);
                    txtHorasTrabajo.FillColor = Color.FromArgb(10, 10, 10);

                    txtMail.FillColor = Color.FromArgb(10, 10, 10); }
                else if (component is Guna.UI2.WinForms.Guna2ComboBox)
                {
                    component.BackColor = Color.FromArgb(18, 18, 18);
                    cmbCargo.FillColor = Color.FromArgb(10, 10, 10);
                    cmbGenero.FillColor = Color.FromArgb(10, 10, 10);
                    component.ForeColor = Color.White;

                }
                else if (component is Guna.UI2.WinForms.Guna2Button)
                {
                    component.BackColor = Color.FromArgb(18, 18, 18);
                    component.ForeColor = Color.White;
                }
                else if (component is Guna.UI2.WinForms.Guna2TextBox)
                {
                    txtDUI.FillColor = Color.FromArgb(10, 10, 10);


                    txtNombres.IconRight = Properties.Resources.icon_nm;
                    lblContadorNombres.BackColor = Color.FromArgb(10, 10, 10);

                    txtApellidos.IconRight = Properties.Resources.icon_nm;
                    lblContadorApellidos.BackColor = Color.FromArgb(10, 10, 10);
                }
                    
                
                else if (component is Guna.UI2.WinForms.Guna2ComboBox)
                {
                    component.BackColor = Color.FromArgb(18, 18, 18);
                    cmbCargo.FillColor = Color.FromArgb(10, 10, 10);
                    cmbGenero.FillColor = Color.FromArgb(10, 10, 10);
                    component.ForeColor = Color.White;

                }
                else if (component is Guna.UI2.WinForms.Guna2Button)
                {
                    component.BackColor = Color.FromArgb(18, 18, 18);
                    component.ForeColor = Color.White;
                }


                txtNombres.IconRight = Properties.Resources.icon_nm;
                lblContadorNombres.BackColor = Color.FromArgb(10, 10, 10);

                txtApellidos.IconRight = Properties.Resources.icon_nm;
                lblContadorApellidos.BackColor = Color.FromArgb(10, 10, 10);


            }

        }
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    pboxImage.Image = Image.FromFile(dialog.FileName);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado _Empleado = new Empleado();
                EmpleadoBL _empleadoBL = new EmpleadoBL();

                _Empleado.Clave = lblClave.Text;
                _Empleado.Id = Convert.ToInt64(lblId.Text);
                _Empleado.Nombre = txtNombres.Text;
                _Empleado.Apellidos = txtApellidos.Text;
                _Empleado.Edad = Convert.ToInt64(txtEdad.Text);
                _Empleado.Genero = cmbGenero.SelectedItem.ToString();
                _Empleado.Cargo = cmbCargo.SelectedItem.ToString();
                _Empleado.Telefono = txtTelefono.Text;
                _Empleado.HorasTrabajo = Convert.ToDecimal(txtHorasTrabajo.Text);
                _Empleado.DUI = txtDUI.Text;
                _Empleado.Mail = txtMail.Text;

                System.IO.MemoryStream _ms = new System.IO.MemoryStream();
                pboxImage.Image.Save(_ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                _Empleado.Imagen = _ms.GetBuffer();

                #region VALIDACION DE DATOS...

                if (txtNombres.Text != "" && txtApellidos.Text != ""
                    && txtEdad.Text != "" && txtEdad.Text.Length <= 2 && cmbGenero.SelectedIndex != 0
                    && cmbCargo.SelectedIndex != 0 && txtTelefono.Text != ""
                    && txtDUI.Text.Contains("-") == true
                    && txtNombres.Text.Length < 50 && txtApellidos.Text.Length < 50
                    && txtEdad.Text.Length < 3 && txtHorasTrabajo.Text.Count(c => c == '.') < 2
                    && txtDUI.Text.Count(c => c == '-') == 1 && txtHorasTrabajo.Text.Length < 8 &&
                    txtHorasTrabajo.Text.EndsWith(".") == false && txtHorasTrabajo.Text.StartsWith(".") == false
                    && txtMail.Text.Count(c => c == '@') == 1
                    && txtMail.Text.Count(c => c == '.') == 1
                    )
                {
                    int _resultado = _empleadoBL.EditarEmpleado(_Empleado);

                    if (_resultado != 0)
                    {
                        MessageBox.Show("El empleado se ha guardado exitosamente ",
                        "Guardar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Notificacion _N = new Notificacion();
                        _N.Fecha = DateTime.Now.Date;
                        _N.Hora = DateTime.Now;
                       /* int hora = DateTime.Now.Hour;
                        int minutos = DateTime.Now.Minute;
                        int Seconds = DateTime.Now.Second;
                        int dia = DateTime.Now.Day;
                        int mes = DateTime.Now.Month;
                        int año = DateTime.Now.Year;
                        _N.Hora = Convert.ToDateTime(dia + "/" + mes + "/" + año + " " + hora  + ":" + minutos + ":" + Seconds);
                       */
                        _N.IdEmpleado = Session.Id;
                        _N.Descripcion = "Se ha editado el empleado " + txtNombres.Text;
                        if (Session.Permiso == "E")
                        {
                            _N.Visualizacion = "T";
                        }
                        else if (Session.Permiso == "A")
                        {
                            _N.Visualizacion = "T";
                        }
                        NotificacionBL _NotificacionBL = new NotificacionBL();
                        _NotificacionBL.AgregarNotificaciones(_N);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Hay campos incorrectos o erroneos, revise el formulario",
                    "Cliente no guardado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ha ocurrido un error en la aplicacion: " + ex.Message,
                    "Error en la aplicacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            if (txtEdad.Text.Length > 2)
            {
                lblErrorEdad.Visible = true;
            }
            else
            {
                lblErrorEdad.Visible = false;
            }
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            int numero = txtNombres.Text.Length;
            lblContadorNombres.Text = numero + "/50";

            if (txtNombres.Text == "")
            {
                lblContadorNombres.Text = "0/50";
            }

            if (numero > 50)
            {
                lblContadorNombres.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblContadorNombres.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            int numero = txtApellidos.Text.Length;
            lblContadorApellidos.Text = numero + "/50";

            if (txtApellidos.Text == "")
            {
                lblContadorApellidos.Text = "0/50";
            }

            if (numero > 50)
            {
                lblContadorApellidos.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblContadorApellidos.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void txtHorasTrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtEdad_TextChanged(sender, e);

            if (!char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;

            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtHorasTrabajo_TextChanged(object sender, EventArgs e)
        {
            string str = txtHorasTrabajo.Text;
            int s = str.Count(c => c == '.');

            if (txtHorasTrabajo.Text.Length >= 8)
            {
                lblErrorHoras.Text = "Se excede de caracteres";
                lblErrorHoras.Visible = true;


            }
            else
            {
                lblErrorHoras.Visible = false;
            }
            if (txtHorasTrabajo.Text.StartsWith(".") == true)
            {
                lblErrorHoras.Text = "No se puede comenzar con un punto decimal";
                lblErrorHoras.Visible = true;
            }

            if (txtHorasTrabajo.Text.EndsWith(".") == true)
            {
                lblErrorHoras.Text = "El formato ingresado no es correcto";
                lblErrorHoras.Visible = true;
            }

            if (s > 1)
            {
                if (lblErrorHoras.Visible == true)
                {
                    lblErrorHoras2.Visible = false;
                }
                else
                {
                    lblErrorHoras2.Text = "Solo se puede poner un punto decimal";
                    lblErrorHoras2.Visible = true;
                }

            }
            else
            {
                lblErrorHoras2.Visible = false;
            }
        }

        private void txtDUI_TextChanged(object sender, EventArgs e)
        {
            string str = txtDUI.Text;
            int s = str.Count(c => c == '-');

            if (txtDUI.Text.Length >= 10)
            {
                lblErrorDUI2.Text = "Se excede de caracteres";
                lblErrorDUI2.Visible = true;
            }
            else
            {
                lblErrorDUI2.Visible = false;
            }

            if (txtDUI.Text.StartsWith("-") == true)
            {
                lblErrorDUI2.Text = "No se puede comenzar con un guion";
                lblErrorDUI2.Visible = true;
            }

            if (txtDUI.Text.EndsWith(".") == true)
            {
                lblErrorDUI2.Text = "El formato ingresado de DUI es erroneo";
                lblErrorDUI2.Visible = true;
            }

            if (s > 1)
            {
                if (lblErrorDUI2.Visible == true)
                {
                    lblDuiError.Visible = false;
                }
                else
                {
                    lblDuiError.Text = "El DUI no tiene el formato correcto";
                    lblDuiError.Visible = true;
                }

            }
            else
            {
                lblDuiError.Visible = false;
            }
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            string str = txtMail.Text;
            int s = str.Count(c => c == '@');
            int p = str.Count(c => c == '.');

            if (txtMail.Text.Length >= 50)
            {
                lblErrorMail.Text = "Se excede de caracteres";
                lblErrorMail.Visible = true;


            }
            else
            {
                lblErrorMail.Visible = false;
            }
            if (txtMail.Text.StartsWith("@") == true || txtMail.Text.StartsWith(".") == true)
            {
                lblErrorMail.Text = "No se puede comenzar con un arroba o un punto";
                lblErrorMail.Visible = true;
            }

            if (txtMail.Text.EndsWith("@") == true || txtMail.Text.EndsWith(".") == true)
            {
                lblErrorMail.Text = "Se debe ingresar una direccion valida (gmail, hotmail, yahoo)";
                lblErrorMail.Visible = true;
            }

            if (s > 1 || p > 1)
            {
                if (lblErrorMail.Visible == true)
                {
                    lblErrorMail2.Visible = false;
                }
                else
                {
                    lblErrorMail2.Text = @"Solo se puede agregar un @ y un punto";
                    lblErrorMail2.Visible = true;
                }

            }
            else
            {
                lblErrorMail2.Visible = false;
            }
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' &&
                e.KeyChar != '@' && e.KeyChar != '.')
            {
                e.Handled = true;

            }
        }

        private void EditarEmpleado_Shown(object sender, EventArgs e)
        {
            if (PantallaPrincipal.ConfiguracionGV != "NO")
            {
                ChangeTheme(Controls);

            }
        }
    }
}
