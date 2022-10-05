using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fragata.Entities;
using Fragata.BL;
using System.Data.SqlClient;
using Fragata.Entities.Cache;
using System.IO;

namespace Fragata.UI.WF
{
    public partial class Tablero : Form
    {
        
        public Tablero()
        {
            InitializeComponent();
           
        }

        private void Tablero_Load(object sender, EventArgs e)
        {
            EmpleadoBL empleadoBL = new EmpleadoBL();
            Int32 numeroEmpleado =empleadoBL.ObtenerEmpleados().Count();
            lblNumeroEmpleados.Text = numeroEmpleado.ToString();

            ClienteBL clienteBL = new ClienteBL();
            int NumeroClientes = clienteBL.ObtenerClientes().Count();
            lblContadorClientes.Text = NumeroClientes.ToString() ;

            PedidoBL pedidoBL = new PedidoBL();
            Int32 NumeroPedidos = pedidoBL.ObtenerPedidosActivos().Count();
            lblContadorPedidos.Text = NumeroPedidos.ToString();

            EnvioBL envio = new EnvioBL();
            Int32 numeroenvios = envio.ObtenerEnviosActivos().Count();
            lblContadorEnvios.Text = numeroenvios.ToString();

            EnvioBL _envioBL = new EnvioBL();
            Int32 NumeroEnviosActivos = _envioBL.ObtenerEnviosActivos().Count();
            lblContadorEnvios.Text = NumeroEnviosActivos.ToString();

            ProductosBL _product = new ProductosBL();
            Int32 NumeroProductos = _product.ObtenerProduto().Count();
            lblProductos.Text = NumeroProductos.ToString();
            string cadena = Convert.ToString(Session.Nombre);
            List<String> s = new List<String>(cadena.Split("".ToCharArray()));
            lblWelcome.Text = "¡Bienvenido " + s[0] + "!";

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
            

        }
        public static string ConfiguracionGV;
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

                lblOverview.BackColor = Color.FromArgb(18, 18, 18);
                lblEntradas.BackColor = Color.FromArgb(18, 18, 18);
                labelEntries.BackColor = Color.FromArgb(18, 18, 18);
                label12.BackColor = Color.FromArgb(18, 18, 18);
                label10.BackColor = Color.FromArgb(18, 18, 18);
                label13.BackColor = Color.FromArgb(18, 18, 18);
                label11.BackColor = Color.FromArgb(18, 18, 18);
            }
        }

        
       
    }
}
