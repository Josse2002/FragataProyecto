using Fragata.BL;
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
    public partial class SplashScreen : Form
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
        public SplashScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            lblInformation.Text = "Fragata Gift ·" + DateTime.Now.Year + "· v1.0 Tim Developers";
             label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            guna2ProgressBar1.Increment(5);
            if (guna2ProgressBar1.Value > 90)
            {
                label1.Text = "Afinando detalles...";
                
            }
            else if (guna2ProgressBar1.Value > 60)
            {
                label1.Text = "Diseñando nuevos regalos...";
            }
            else if (guna2ProgressBar1.Value > 30)
            {
                label1.Text = "Creando ideas...";
            }


            if (guna2ProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                String line;
                try
                {
                    //Pass the file path and file name to the StreamReader constructor
                    StreamReader sr = new StreamReader(@".\Test.txt");
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
                    string password = list[0].ToString();
                    string correo = list[1].ToString();
                    
                    byte[] decrytedMail = Convert.FromBase64String(correo);
                    string resultMail = System.Text.Encoding.Unicode.GetString(decrytedMail);
                    byte[] decrytedPass = Convert.FromBase64String(password);
                    string resultPass = System.Text.Encoding.Unicode.GetString(decrytedPass);

                    EmpleadoBL empleadoBL = new EmpleadoBL();
                    if (resultMail != " " && resultMail != null && resultPass != null && resultPass != " " && resultMail != ""
                        && resultPass != "")
                    {
                        var ValidLogin = empleadoBL.Login(resultMail, resultPass);
                        // Saves settings in application configuration file
                        if (ValidLogin == true)
                        {
                            PantallaPrincipal mainMenu = new PantallaPrincipal();
                            mainMenu.Show();
                            this.Hide();
                        }
                        else
                        {
                            InicioDeSesion InicioDeSesion = new InicioDeSesion();
                            InicioDeSesion.Show();
                            this.Hide();
                        }

                    }
                    else
                    {
                        InicioDeSesion InicioDeSesion = new InicioDeSesion();
                        InicioDeSesion.Show();
                        this.Hide();
                    }

                }
                catch (Exception eX)
                {
                    Console.WriteLine("Exception: " + eX.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");

                }
            }
        }
    }
}
