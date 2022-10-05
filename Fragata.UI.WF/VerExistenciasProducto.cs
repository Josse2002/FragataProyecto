using Fragata.BL;
using Fragata.Entities;
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

namespace Fragata.UI.WF
{
    public partial class VerExistenciasProducto : Form
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

        public VerExistenciasProducto()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public VerExistenciasProducto(Producto _product)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

           
            string _String = _product.Existencias;
            string[] stringArray = _String.Split(',');

            string _String2 = _product.NumeroExistencias;
            string[] stringArray2 = _String2.Split(',');

            ExistenciaBL existenciaBL = new ExistenciaBL();
            ProveedorBL _pBL = new ProveedorBL();
            


            for (int i = 0; i < stringArray.Length; i++)
            {
                

                foreach (var item in existenciaBL.BuscarExistenciaPoId(Convert.ToInt64(stringArray[i])))
                {
                    #region Creando los controles...

                    //LABELS
                    Label _label = new Label();
                    _label.BackColor = Color.FromArgb(128, 255, 128);
                    _label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
                    _label.ForeColor = System.Drawing.Color.Transparent;
                    _label.Size = new System.Drawing.Size(102, 17);
                    _label.Location = new Point(234, 13);
                    _label.Text = "Cantidad Usado";

                    //Proveedor
                    Label _label2 = new Label();
                    _label2.Location = new System.Drawing.Point(263, 30);
                    _label2.BackColor = Color.FromArgb(128, 255, 128);
                    _label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
                    _label2.ForeColor = System.Drawing.Color.Transparent;
                    _label2.Location = new Point(69, 42);
                    _label2.Size = new System.Drawing.Size(111, 17);
                    foreach (var proveedor in _pBL.BuscarProveedorPorId(Convert.ToInt64(item.IdProveedor)))
                    {
                       _label2.Text = proveedor.Nombre.ToString();
                    }


                    //Numero
                    Label _labelN = new Label();
                    _labelN.Location = new System.Drawing.Point(69, 41);
                    _labelN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    _labelN.ForeColor = System.Drawing.Color.Transparent;
                    _labelN.Location = new Point(263, 30);
                    _labelN.BackColor = Color.FromArgb(128, 255, 128);
                    _labelN.Size = new System.Drawing.Size(43, 32);
                    _labelN.Text = stringArray2[i];


                    //Nombre
                    Label _name = new Label();
                    _name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                    _name.Size = new System.Drawing.Size(112, 17);
                    _name.BackColor = Color.FromArgb(128, 255, 128);
                    _name.ForeColor = System.Drawing.Color.Transparent;
                    _name.Location = new Point(69, 13);
                    _name.Text = item.Nombre;

                    //BACKGROUND 
                    Guna.UI2.WinForms.Guna2Shapes backg = new Guna.UI2.WinForms.Guna2Shapes();
                    backg.FillColor = Color.FromArgb(128, 255, 128);
                    backg.BorderColor = Color.Transparent;
                    backg.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
                    backg.Size = new System.Drawing.Size(334, 71);
                    backg.Zoom = 100;
                    backg.Dock = System.Windows.Forms.DockStyle.Top;
                    //FOTO
                    Guna.UI2.WinForms.Guna2CirclePictureBox img = new Guna.UI2.WinForms.Guna2CirclePictureBox();
                    img.BackColor = System.Drawing.Color.Transparent;
                    img.Size = new System.Drawing.Size(50, 45);
                    img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                    img.UseTransparentBackground = true;
                    img.Location = new Point(13, 13);

                    MemoryStream ms = new MemoryStream(item.Imagen);
                    Image returnImage = Image.FromStream(ms);
                    img.Image = returnImage;


                    //PANEL HIJO
                    Panel PanelHijo = new Panel();
                    PanelHijo.Dock = DockStyle.Top;
                    PanelHijo.Margin = new Padding(3, 3, 3, 10);
                    PanelHijo.Size = new Size(350, 74);
                    PanelHijo.Controls.Add(_label2);
                    PanelHijo.Controls.Add(_label);
                    PanelHijo.Controls.Add(_labelN);
                    PanelHijo.Controls.Add(img);
                    PanelHijo.Controls.Add(_name);
                    PanelHijo.Controls.Add(backg);

                    //PANEL GRANDE
                    panelContainerDad.Controls.Add(PanelHijo);

                    #endregion
                }


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

        public void ChangeTheme(Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                this.BackColor = Color.FromArgb(18, 18, 18);

            }
        }

        private void VerExistenciasProducto_Shown(object sender, EventArgs e)
        {
            if (PantallaPrincipal.ConfiguracionGV != "NO")
            {
                ChangeTheme(Controls);
            }
        }
    }
}
