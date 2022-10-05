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
using Fragata.Entities.Cache;

namespace Fragata.UI.WF
{
    public partial class VerPedido : Form
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
        public VerPedido()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        public VerPedido(Pedido _pedido)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            lblId.Text = _pedido.Id.ToString();
            lblFecha.Text = _pedido.Fecha.ToString();
            lblCodigo.Text = _pedido.CodigoPedido;
            lblCliente.Text = _pedido.Usuario;
            lblPrecio.Text = _pedido.precioPedido.ToString();
            lblFormaEntrega.Text = _pedido.FormaEntrega.ToString();

            //DECLARANDO LOS STRINGS
            string _Producto = _pedido.Productos;
            string _CantidadP = _pedido.CantidadProductos;


            string[] stringProductos = _Producto.Split(',');
            string[] stringCantidad = _CantidadP.Split(',');

            ProductosBL _PbL = new ProductosBL();

            for (int i = 0; i < stringProductos.Length; i++)
            {
                foreach (var producto in _PbL.ObtenerProduto())
                {
                    if (producto.Id == Convert.ToInt64(stringProductos[i]))
                    {
                        string[] row2 = { stringProductos[i], producto.Nombre, stringCantidad[i], "$" + producto.Precio.ToString() };
                        dgvMateriales.Rows.Add(row2);
                    }
                }
            }

            if (_pedido.Estado == "C")
            {
                lblEstado.Text = "Completado";
                lblEstado.ForeColor = Color.Blue;
                guna2Button1.Enabled = false;
                btnEditar.Enabled = false;
                guna2Button2.Enabled = false;
            }
            else if (_pedido.Estado == "X")
            {
                lblEstado.Text = "Cancelado";
                lblEstado.ForeColor = Color.Red;
                guna2Button1.Enabled = false;
                btnEditar.Enabled = false;
                guna2Button2.Enabled = false;
            }
            else
            {
                lblEstado.Text = "Activo";
                lblEstado.ForeColor = Color.Gold;

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Pedido _pedido = new Pedido();

            _pedido.Id = Convert.ToInt64(lblId.Text);
            _pedido.CodigoPedido = lblCodigo.Text;
            _pedido.Usuario = lblCliente.Text;
            _pedido.FormaEntrega = lblFormaEntrega.Text;
            _pedido.Fecha = Convert.ToDateTime(lblFecha.Text);

            string[] Productos = new string[dgvMateriales.Rows.Count];
            string[] Cantidad = new string[dgvMateriales.Rows.Count];
            int i = 0;

            foreach (DataGridViewRow row in dgvMateriales.Rows)
            {

                Productos[i] = row.Cells[0].Value != null && row.Cells[0].Value.ToString() != "" && row.Cells[0].Value.ToString() != "" ? row.Cells[0].Value.ToString() : string.Empty;
                Cantidad[i] = row.Cells[2].Value != null && row.Cells[2].Value.ToString() != "" ? row.Cells[2].Value.ToString() : string.Empty;
                i++;
            }
            //AÑADIENDOLE COMAS
            string resultId = string.Join(",", Productos);
            string resultCan = string.Join(",", Cantidad);

            _pedido.Productos = resultId;
            _pedido.CantidadProductos = resultCan;
            _pedido.precioPedido = Convert.ToDecimal(lblPrecio.Text);

            EditarPedido _ep = new EditarPedido(_pedido);
            _ep.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea cancelar el pedido? \nUna vez realizado no se puede editar ni cancelar, ademas se cancelaran los envios relacionados con este pedido",
                          "Cancelar Envio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                PedidoBL _p = new PedidoBL();
                _p.CambiarEstado(Convert.ToInt64(lblId.Text), "X");
                lblEstado.Text = "Cancelado";
                lblEstado.ForeColor = Color.Red;
                guna2Button1.Enabled = false;
                btnEditar.Enabled = false;
                guna2Button2.Enabled = false;

                Notificacion _N = new Notificacion();
                _N.Fecha = DateTime.Now.Date;
                _N.Hora = DateTime.Now;

                _N.IdEmpleado = Session.Id;
                _N.Descripcion = "Se ha cancelado el pedido con el codigo " + lblCodigo.Text;
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

                EnvioBL _envio = new EnvioBL();

                foreach (var item in _envio.ObtenerEnvios())
                {
                    if (item.IdPedido.ToString() == lblId.Text)
                    {
                        _envio.MarcarProgreso(Convert.ToInt64(item.Id), "C");
                    }
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Desea cambiar el estado del pedido a completado? \nUna vez realizado no se puede editar ni cancelar, ademas se completaran los envios relacionados con este pedido",
                         "Cancelar Envio", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                PedidoBL _p = new PedidoBL();
                _p.CambiarEstado(Convert.ToInt64(lblId.Text), "C");
                lblEstado.Text = "Completado";
                lblEstado.ForeColor = Color.Blue;
                guna2Button2.Enabled = false;
                guna2Button1.Enabled = false;
                btnEditar.Enabled = false;

                Notificacion _N = new Notificacion();
                _N.Fecha = DateTime.Now.Date;
                _N.Hora = DateTime.Now;

                _N.IdEmpleado = Session.Id;
                _N.Descripcion = "Se ha completado el pedido con el codigo " + lblCodigo.Text;
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

                EnvioBL _envio = new EnvioBL();

                foreach (var item in _envio.ObtenerEnvios())
                {
                    if (item.IdPedido.ToString() == lblId.Text)
                    {
                        _envio.MarcarProgreso(Convert.ToInt64(item.Id), "E");
                    }
                }

                Pedido _pedido = new Pedido();
                _pedido.Id = Convert.ToInt64(lblId.Text);
                _pedido.CodigoPedido = lblCodigo.Text;
                _pedido.Usuario = lblCliente.Text;
                _pedido.FormaEntrega = lblFormaEntrega.Text;
                _pedido.Fecha = Convert.ToDateTime(lblFecha.Text);
                _pedido.Estado = "E";
                string[] Productos = new string[dgvMateriales.Rows.Count];
                string[] Cantidad = new string[dgvMateriales.Rows.Count];
                int i = 0;

                foreach (DataGridViewRow row in dgvMateriales.Rows)
                {

                    Productos[i] = row.Cells[0].Value != null && row.Cells[0].Value.ToString() != "" && row.Cells[0].Value.ToString() != "" ? row.Cells[0].Value.ToString() : string.Empty;
                    Cantidad[i] = row.Cells[2].Value != null && row.Cells[2].Value.ToString() != "" ? row.Cells[2].Value.ToString() : string.Empty;
                    i++;
                }
                //AÑADIENDOLE COMAS
                string resultId = string.Join(",", Productos);
                string resultCan = string.Join(",", Cantidad);

                _pedido.Productos = resultId;
                _pedido.CantidadProductos = resultCan;
                _pedido.precioPedido = Convert.ToDecimal(lblPrecio.Text);

                AgregarVenta _ep = new AgregarVenta(_pedido);
                _ep.ShowDialog();
            }

        }
    }
}
