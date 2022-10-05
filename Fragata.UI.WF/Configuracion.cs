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
    public partial class Configuracion : Form
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
        public Configuracion()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
                chckNocturneMode.Checked = true;
               
               
            }
            else
            {
                chckNocturneMode.Checked = false;
                
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
        public static string Nm = "";
        private void guna2CustomCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Pass the filepath and filename to the StreamWriter Constructor


            StreamWriter sw = new StreamWriter(@".\Settings.txt");
            if (chckNocturneMode.Checked == true)
            {
                sw.WriteLine(" ");
                sw.WriteLine("nocturne-mode: true");
                Nm = "nocturne-mode: true";
                //ACA IRAN LOS DIFERENTES FORMULARIOS QUE CAMBIARAN CUANDO SE ACTIVE ESTO

            }
            else
            {
                sw.WriteLine(" ");
                sw.WriteLine("nocturne-mode: false");
                Nm = "nocturne-mode: false";


            }



            //Close the file
            sw.Close();
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
            }
        }

        public static string Configuration;
        private void Configuracion_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (PantallaPrincipal.ConfiguracionGV == "YES" && Nm == "nocturne-mode: false" || PantallaPrincipal.ConfiguracionGV == "NO" && Nm == "nocturne-mode: true")
            {
                DialogResult result = MessageBox.Show("Se necesita reiniciar la aplicacion para aplicar los cambios ¿Reiniciar ya?"
              , "Configuracion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
           
        }

        private void Configuracion_Shown(object sender, EventArgs e)
        {
            if (PantallaPrincipal.ConfiguracionGV != "NO")
            {
                ChangeTheme(Controls);

            }
        }
    }
}
