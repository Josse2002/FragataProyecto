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
using Fragata.Entities.Cache;
using System.Runtime.InteropServices;

namespace Fragata.UI.WF
{
    public partial class EditarPedido : Form
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

        //RECIBIR LOS DATOS DE BUSCAR PRODUCTO
        public static string IdProducto;
        public static string NombreProducto;
        public static string CantidadProductos;
        public static string PrecioProducto;
        public EditarPedido()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            dtpcFecha.Value = DateTime.Now;
        }

        public EditarPedido(Pedido _pedido)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            lblId.Text = _pedido.Id.ToString();
            txtCodigoPedido.Text = _pedido.CodigoPedido;
            txtNombreUsuario.Text = _pedido.Usuario;
            cmbEntrega.SelectedItem = _pedido.FormaEntrega;
            dtpcFecha.Value = Convert.ToDateTime(_pedido.Fecha);

            string _Producto = _pedido.Productos;
            string _CantidadP = _pedido.CantidadProductos;


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

            lblPrecio.Text = _pedido.precioPedido.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            BuscarProducto buscarProducto = new BuscarProducto();
            buscarProducto.ShowDialog();
        }

        private void EditarPedido_Activated(object sender, EventArgs e)
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

                        lblPrecio.Text = precio.ToString();

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
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnAgregarProducto_Click(sender, e);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string seMostro = "no";

                PedidoBL _pedidoBl = new PedidoBL();
                Pedido pedido = new Pedido();
                if (txtCodigoPedido.Text != "" && txtCodigoPedido.Text != null && txtNombreUsuario.Text != ""
                    && txtNombreUsuario.Text != null && dtpcFecha.Value != null
                    && dgvMateriales.Rows.Count > 1)
                {
                    pedido.Fecha = Convert.ToDateTime(dtpcFecha.Value);
                    pedido.Hora = Convert.ToDateTime(dtpcFecha.Value);
                    pedido.CodigoPedido = txtCodigoPedido.Text;
                    pedido.FormaEntrega = cmbEntrega.SelectedText;
                    pedido.precioPedido = Convert.ToDecimal(lblPrecio.Text.Replace("$", ""));
                    pedido.FormaEntrega = cmbEntrega.SelectedItem.ToString();
                    pedido.Id = Convert.ToInt64(lblId.Text);
                    string[] ColumnaId = new string[dgvMateriales.Rows.Count];
                    string[] ColumnaCantidad = new string[dgvMateriales.Rows.Count];
                    int i = 0;

                    foreach (DataGridViewRow row in dgvMateriales.Rows)
                    {
                        ColumnaId[i] = row.Cells[0].Value != null && row.Cells[0].Value.ToString() != "" ? row.Cells[0].Value.ToString() : string.Empty;
                        ColumnaCantidad[i] = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : string.Empty;
                        i++;
                    }

                    string resultId = string.Join(",", ColumnaId);
                    string resultCan = string.Join(",", ColumnaCantidad);

                    if (resultId.Length > 0 && resultCan.Length > 0)
                    {
                        resultId = resultId.Remove(resultId.Length - 1);
                        resultCan = resultCan.Remove(resultCan.Length - 1);
                    }
                    else
                    {
                        MessageBox.Show("No se han especificado productos en el pedido",
                            "Agregar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        seMostro = "si";
                    }

                    pedido.Productos = resultId;
                    pedido.Usuario = txtNombreUsuario.Text;
                    pedido.CantidadProductos = resultCan;

                    int _resultado = _pedidoBl.EditarPedido(pedido);

                    if (_resultado != 0)
                    {
                        MessageBox.Show("Se ha guardado el pedido correctamente",
                        "Editar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Notificacion _N = new Notificacion();
                        _N.Fecha = DateTime.Now.Date;
                        _N.Hora = DateTime.Now;

                        _N.IdEmpleado = Session.Id;
                        _N.Descripcion = "Se ha editado el pedido con el codigo " + txtCodigoPedido.Text;
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
                    if (seMostro == "no")
                    {
                        MessageBox.Show("No se puede gaurdar el pedido, por favor revise los campos",
                                          "Editar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dtpcFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime actual = DateTime.Now;

            if (dtpcFecha.Value < actual)
            {

                dtpcFecha.Value = DateTime.Now;
                System.Media.SystemSounds.Exclamation.Play();

            }
        }

        private void cmbEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEntrega.SelectedIndex == 1)
            {
                dtpcFecha.Enabled = false;

            }
            else
            {
                dtpcFecha.Enabled = true;
            }
        }
    }
}
