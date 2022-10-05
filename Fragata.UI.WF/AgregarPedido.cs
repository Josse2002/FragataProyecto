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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fragata.UI.WF
{
    public partial class AgregarPedido : Form
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
        public AgregarPedido()
        {
            InitializeComponent();
            

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            dtpcFecha.Value = DateTime.Now;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AgregarPedido_Load(object sender, EventArgs e)
        {
            int longitud = 3;
            const string alfabeto = "abcdefghijklmnoprstuvwxyzABCDEFGHIJKLMNOPQRSTUWXYZ1234567890";
            StringBuilder token = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int indice = rnd.Next(alfabeto.Length);
                token.Append(alfabeto[indice]);
            }

            txtCodigoPedido.Text = DateTime.Now.Month.ToString() + token + DateTime.Now.Day.ToString()+ DateTime.Now.Hour.ToString() + DateTime.Now.Second.ToString();
            
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            BuscarProducto buscarProducto = new BuscarProducto();
            buscarProducto.ShowDialog();
        }

        private void AgregarPedido_Activated(object sender, EventArgs e)
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
            if(dgvMateriales.Rows.Count == 1 || dgvMateriales.Rows.Count == 0)
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

                    int _resultado = _pedidoBl.AgregarPedido(pedido);

                    if (_resultado != 0)
                    {
                        MessageBox.Show("Se ha guardado el pedido correctamente",
                        "Guardar Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Notificacion _N = new Notificacion();
                        _N.Fecha = DateTime.Now.Date;
                        _N.Hora = DateTime.Now;

                        _N.IdEmpleado = Session.Id;
                        _N.Descripcion = "Se ha agregado un nuevo pedido con el codigo "+ txtCodigoPedido.Text;
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

                        DialogResult result = MessageBox.Show(@"El pedido tiene un formato de entrega de pedido, ¿Desea agregar el envio de una vez?"
                          , "Abrir Pedidos", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes)
                        {
                            AgregarEnvio.NombreUsuario = txtNombreUsuario.Text;
                            AgregarEnvio.CodigoProducto = txtCodigoPedido.Text;

                            PedidoBL pedidoBL = new PedidoBL();

                            

                            AgregarEnvio agregarEnvio = new AgregarEnvio(txtCodigoPedido.Text);
                            agregarEnvio.Show();
                            this.Hide();
                        }

                        this.Close();
                    }


                }
                else
                {
                    if (seMostro == "no")
                    {
                        MessageBox.Show("No se puede agregar el pedido, por favor revise los campos",
                                          "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnFactura_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Fecha = Convert.ToDateTime(dtpcFecha.Value);
            pedido.Hora = Convert.ToDateTime(dtpcFecha.Value);
            pedido.CodigoPedido = txtCodigoPedido.Text;
            pedido.FormaEntrega = cmbEntrega.SelectedText;
            pedido.precioPedido = Convert.ToDecimal(lblPrecio.Text.Replace("$", ""));
            pedido.FormaEntrega = cmbEntrega.SelectedItem.ToString();
            pedido.Estado = "A";
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
        
            pedido.Productos = resultId;
            pedido.Usuario = txtNombreUsuario.Text;
            pedido.CantidadProductos = resultCan;
            Factura fa = new Factura(pedido);
            fa.Show();
        }
    }
}
