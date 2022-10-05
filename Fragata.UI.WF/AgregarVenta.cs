using Fragata.BL;
using Fragata.Entities;
using Fragata.Entities.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fragata.UI.WF
{
    public partial class AgregarVenta : Form
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

        public static string IdProducto;
        public static string NombreProducto;
        public static string CantidadProductos;
        public static string PrecioProducto;

        public AgregarVenta(Pedido _pedido)
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //CONSTRUCTOR SI SE ENVIA DE PEDIDO LA SOLICITUD
            txtNombreUsuario.Text = _pedido.Usuario.ToString();
            txtNombreUsuario.Enabled = false;
            lblFE.Text = _pedido.FormaEntrega;
            string _Producto = _pedido.Productos;
            string _CantidadP = _pedido.CantidadProductos;
            lblid.Text = _pedido.Id.ToString();
            #region PRODUCTOS...
            string[] stringProductos = _Producto.Split(',');
            string[] stringCantidad = _CantidadP.Split(',');

            ProductosBL _PbL = new ProductosBL();

            for (int i = 0; i < stringProductos.Length; i++)
            {
                if (stringProductos[i] != "" && stringCantidad[i] != "")
                {
                    foreach (var producto in _PbL.ObtenerProduto())
                    {
                        if (producto.Id == Convert.ToInt64(stringProductos[i]))
                        {
                            string[] row2 = { stringProductos[i], producto.Nombre, stringCantidad[i], producto.Precio.ToString() };
                            dgvMateriales.Rows.Add(row2);
                        }
                    }
                }

            }
            #endregion
            lblPrecio.Text = _pedido.precioPedido.ToString();
            btnAgregarProducto.Enabled = false;
        }
        public AgregarVenta(Envio _Envio)
        {
            InitializeComponent();
        
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            //CONSTRUCTOR SI SE ENVIA DE ENVIO LA SOLICITUD
            PedidoBL _PedidoBL = new PedidoBL();
            lblFE.Text = "Envio";
            foreach (var item in _PedidoBL.ObtenerPedidos())
            {
                if (item.Id == _Envio.IdPedido)
                {
                    txtNombreUsuario.Text = item.Usuario;
                    lblPrecio.Text = _Envio.PrecioEnvio.ToString();
                    lblid.Text = item.Id.ToString();
                    string _Producto = item.Productos;
                    string _CantidadP = item.CantidadProductos;

                    #region PRODUCTOS...
                    string[] stringProductos = _Producto.Split(',');
                    string[] stringCantidad = _CantidadP.Split(',');

                    ProductosBL _PbL = new ProductosBL();

                    for (int i = 0; i < stringProductos.Length; i++)
                    {
                        if (stringProductos[i] != "" && stringCantidad[i] != "")
                        {
                            foreach (var producto in _PbL.ObtenerProduto())
                            {
                                if (producto.Id == Convert.ToInt64(stringProductos[i]))
                                {
                                    string[] row2 = { stringProductos[i], producto.Nombre, stringCantidad[i], producto.Precio.ToString() };
                                    dgvMateriales.Rows.Add(row2);
                                }
                            }
                        }

                    }

                    #endregion

                    btnAgregarProducto.Enabled = false;
                    txtNombreUsuario.Enabled = false;
                }
            }
            
            
        }
        
        public AgregarVenta()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            lblid.Text = "NA";
            
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            BuscarProducto buscarProducto = new BuscarProducto();
            buscarProducto.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AgregarVenta_Activated(object sender, EventArgs e)
        {
            Decimal precio = 0;

            if (IdProducto != null && NombreProducto != null && PrecioProducto != null && CantidadProductos != null)
            {
                if (dgvMateriales.Rows.Count != 0)
                {
                    bool exist = dgvMateriales.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["MNombre"].Value) == NombreProducto);
                    if (!exist)
                    {

                        string[] row2 = { IdProducto, NombreProducto, CantidadProductos, PrecioProducto };
                        dgvMateriales.Rows.Add(row2);


                        for (int i = 0; i < dgvMateriales.Rows.Count - 1; i++)
                        {

                            precio = precio + Convert.ToDecimal(dgvMateriales.Rows[i].Cells[3].Value) * Convert.ToInt64(dgvMateriales.Rows[i].Cells[2].Value);

                        }

                        

                        lblPrecio.Text = "$" + precio.ToString();



                    }
                    else
                    {
                        MessageBox.Show("No se pueden agregar dos veces el mismo producto ",
                                            "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {

                    btnEliminar.Visible = false;

                }

                if (dgvMateriales.Rows.Count == 1 || dgvMateriales.Rows.Count == 0)
                {
                    btnEliminar.Visible = false;
                }
                else
                {
                    btnEliminar.Visible = true;
                }



                IdProducto = null;
                NombreProducto = null;
                PrecioProducto = null;
                CantidadProductos = null;

                if (txtCantidadPagada.Text != "")
                {
                    Decimal devolucion = Convert.ToDecimal(txtCantidadPagada.Text.Replace("$", "")) - Convert.ToDecimal(lblPrecio.Text.Replace("$", ""));
                    if (devolucion < 0)
                    {
                        lblDevolucion.ForeColor = Color.Red;
                    }
                    else
                    {
                        lblDevolucion.ForeColor = Color.FromArgb(52, 84, 173);
                    }
                    lblDevolucion.Text = "$" + devolucion.ToString();

                    lblErrorPrecio2.Visible = false;
                }
                else
                {
                    lblErrorPrecio2.Visible = true;
                }
            }
        }

        private void txtCantidadPagada_TextChanged(object sender, EventArgs e)
        {
            
            if (txtCantidadPagada.Text != "")
            {
                Decimal devolucion = Convert.ToDecimal(txtCantidadPagada.Text.Replace("$", "")) - Convert.ToDecimal(lblPrecio.Text.Replace("$", ""));
                if (devolucion < 0)
                {
                    lblDevolucion.ForeColor = Color.Red;
                }
                else
                {
                    lblDevolucion.ForeColor = Color.FromArgb(52, 84, 173);
                }
                lblDevolucion.Text = "$" + devolucion.ToString();

                lblErrorPrecio2.Visible = false;
            }
            else
            {
                lblErrorPrecio2.Visible = true;
            }
            
        }
        private void AgregarVenta_Load(object sender, EventArgs e)
        {
            lblAtentido.Text = Session.Nombre + " " + Session.Apellidos;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMateriales.Rows.Count != 0)
            {
                if (dgvMateriales.CurrentRow.Cells[2] == null && dgvMateriales.CurrentRow.Cells[2].Value.ToString() != "" || dgvMateriales.CurrentRow.Cells[2].Value != null)
                {

                    dgvMateriales.Rows.Remove(dgvMateriales.CurrentRow);
                    Decimal precio = 0;

                    for (int i = 0; i < dgvMateriales.Rows.Count - 1; i++)
                    {

                        precio = precio + Convert.ToDecimal(dgvMateriales.Rows[i].Cells[3].Value) * Convert.ToInt64(dgvMateriales.Rows[i].Cells[2].Value);

                    }

                    lblPrecio.Text = precio.ToString();
                }
                else
                {
                    MessageBox.Show("No se puede eliminar una fila vacia ",
                                            "Eliminar Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (dgvMateriales.Rows.Count == 1 || dgvMateriales.Rows.Count == 0)
            {
                btnEliminar.Visible = false;
            }
            else
            {
                btnEliminar.Visible = true;
            }

            if (txtCantidadPagada.Text != "")
            {
                Decimal devolucion = Convert.ToDecimal(txtCantidadPagada.Text.Replace("$", "")) - Convert.ToDecimal(lblPrecio.Text.Replace("$", ""));
                
                if (devolucion < 0)
                {
                    lblDevolucion.ForeColor = Color.Red;
                }
                else
                {
                    lblDevolucion.ForeColor = Color.FromArgb(52, 84, 173);
                }

                lblDevolucion.Text = "$" + devolucion.ToString();

                lblErrorPrecio2.Visible = false;

                
            }
            else
            {
                lblErrorPrecio2.Visible = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnAgregarProducto_Click(sender, e);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string seMostro = "no";
            VentaBL ventaBL = new VentaBL();
            try
            {
                if ( txtNombreUsuario.Text != "" && txtNombreUsuario.Text != null && dgvMateriales.Rows.Count > 1
                    && lblDevolucion.Text.Contains("-") == false)
                {
                    
                    Venta venta = new Venta();
                    venta.FechaAgregado = DateTime.Now;
                    venta.CantidadPagada = Convert.ToDecimal(txtCantidadPagada.Text.Replace("$", ""));
                    venta.Cambio = Convert.ToDecimal(lblDevolucion.Text.Replace("$", ""));
                    venta.CantidadPagar = Convert.ToDecimal(lblPrecio.Text.Replace("$", ""));
                    venta.AtentidoPor = lblAtentido.Text;
                    venta.NombreUsuario = txtNombreUsuario.Text;
                    #region Obteniendo Productos....
                    string[] ColumnaId = new string[dgvMateriales.Rows.Count];
                    string[] ColumnaCantidad = new string[dgvMateriales.Rows.Count];
                    string[] ColumnaPrecio = new string[dgvMateriales.Rows.Count];
                    int i = 0;

                    foreach (DataGridViewRow row in dgvMateriales.Rows)
                    {
                        ColumnaId[i] = row.Cells[0].Value != null && row.Cells[0].Value.ToString() != "" ? row.Cells[0].Value.ToString() : string.Empty;
                        ColumnaCantidad[i] = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : string.Empty;
                        ColumnaPrecio[i] = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : string.Empty;
                        i++;
                    }

                    string resultId = string.Join(",", ColumnaId);
                    string resultCan = string.Join(",", ColumnaCantidad);
                    string resultPrice = string.Join("," ,ColumnaPrecio);

                    if (resultId.Length > 0 )
                    {
                        resultId = resultId.Remove(resultId.Length - 1);
                        resultCan = resultCan.Remove(resultCan.Length - 1);
                        resultPrice = resultPrice.Remove(resultPrice.Length - 1);
                    }
                    else
                    {
                        MessageBox.Show("No se han especificado productos en el pedido",
                            "Agregar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        seMostro = "si";
                    }
                    #endregion
                    venta.Productos = resultId;

                    int _resultado = ventaBL.AgregarVenta(venta);

                    if (_resultado != 0)
                    {
                        MessageBox.Show("La venta se ha guardado exitosamente",
                        "Guardar Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        #region Notificacion...
                        Notificacion _N = new Notificacion();
                        _N.Fecha = DateTime.Now.Date;
                        _N.Hora = DateTime.Now;

                        _N.IdEmpleado = Session.Id;
                        _N.Descripcion = "Se ha agregado una venta nueva con un valor de " + lblPrecio.Text; 
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
                        #endregion

                        Pedido pedido = new Pedido();

                        if (lblid.Text == "NA")
                        {
                            pedido.Id = 0;
                        }
                        else
                        {
                            pedido.Id = Convert.ToInt64(lblid.Text);
                        }

                        
                        pedido.Usuario = txtNombreUsuario.Text;
                        pedido.Productos = resultId;
                        pedido.CantidadProductos = resultCan;
                        pedido.precioPedido = Convert.ToDecimal(lblPrecio.Text);
                        pedido.FormaEntrega = lblFE.Text ;
                        Factura fa = new Factura(pedido);
                        fa.Show();
                        this.Close();
                    }


                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtCantidadPagada_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCantidadPagada_TextChanged(sender, e);
            if (!char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                string str = e.KeyChar.ToString();
                int s = str.Count(c => c == '.');

                if (s < 1)
                {
                    e.Handled = true;
                }
            }
        }

        private void AgregarT(object sender, KeyPressEventArgs e)
        {
            txtCantidadPagada_TextChanged(sender, e);
            if (!char.IsNumber(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                string str = e.KeyChar.ToString();
                int s = str.Count(c => c == '.');

                if (s < 1)
                {
                    e.Handled = true;
                }


            }
        }
    }
}
