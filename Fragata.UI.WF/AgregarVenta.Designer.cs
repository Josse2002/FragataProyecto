
namespace Fragata.UI.WF
{
    partial class AgregarVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAgregarEmpleado = new System.Windows.Forms.Label();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.txtNombreUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.MId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.btnEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new Guna.UI2.WinForms.Guna2Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadPagada = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDevolucion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAtentido = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lblErrorPrecio2 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblFE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAgregarEmpleado
            // 
            this.lblAgregarEmpleado.AutoSize = true;
            this.lblAgregarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(184)))));
            this.lblAgregarEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblAgregarEmpleado.Location = new System.Drawing.Point(164, 7);
            this.lblAgregarEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.lblAgregarEmpleado.Name = "lblAgregarEmpleado";
            this.lblAgregarEmpleado.Size = new System.Drawing.Size(119, 21);
            this.lblAgregarEmpleado.TabIndex = 120;
            this.lblAgregarEmpleado.Text = "Agregar Venta";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Animated = true;
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMinimize.DisabledState.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(184)))));
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(184)))));
            this.btnMinimize.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Image = global::Fragata.UI.WF.Properties.Resources.minimized_hover;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = global::Fragata.UI.WF.Properties.Resources.remove;
            this.btnMinimize.ImageSize = new System.Drawing.Size(15, 15);
            this.btnMinimize.Location = new System.Drawing.Point(380, 7);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(184)))));
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(24, 19);
            this.btnMinimize.TabIndex = 119;
            this.btnMinimize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.DisabledState.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(184)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(184)))));
            this.btnClose.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.Image = global::Fragata.UI.WF.Properties.Resources.close_hover;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = global::Fragata.UI.WF.Properties.Resources.close__2_;
            this.btnClose.ImageSize = new System.Drawing.Size(10, 10);
            this.btnClose.Location = new System.Drawing.Point(407, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0, 2, 3, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(184)))));
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 118;
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BackColor = System.Drawing.Color.White;
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(184)))));
            this.guna2Shapes1.Location = new System.Drawing.Point(0, 0);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.guna2Shapes1.Size = new System.Drawing.Size(442, 38);
            this.guna2Shapes1.TabIndex = 121;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 100;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtNombreUsuario.BorderRadius = 10;
            this.txtNombreUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreUsuario.DefaultText = "";
            this.txtNombreUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreUsuario.DisabledState.Parent = this.txtNombreUsuario;
            this.txtNombreUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreUsuario.FocusedState.Parent = this.txtNombreUsuario;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreUsuario.HoverState.Parent = this.txtNombreUsuario;
            this.txtNombreUsuario.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreUsuario.Location = new System.Drawing.Point(101, 49);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.PasswordChar = '\0';
            this.txtNombreUsuario.PlaceholderText = "Cliente";
            this.txtNombreUsuario.SelectedText = "";
            this.txtNombreUsuario.ShadowDecoration.Parent = this.txtNombreUsuario;
            this.txtNombreUsuario.Size = new System.Drawing.Size(200, 25);
            this.txtNombreUsuario.TabIndex = 142;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 143;
            this.label1.Text = "Cliente:";
            // 
            // dgvMateriales
            // 
            this.dgvMateriales.AllowDrop = true;
            this.dgvMateriales.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvMateriales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMateriales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMateriales.BackgroundColor = System.Drawing.Color.White;
            this.dgvMateriales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMateriales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMateriales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(84)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMateriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMateriales.ColumnHeadersHeight = 32;
            this.dgvMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MId,
            this.MNombre,
            this.MCantidad,
            this.PrecioUnitario});
            this.dgvMateriales.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMateriales.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMateriales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvMateriales.EnableHeadersVisualStyles = false;
            this.dgvMateriales.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvMateriales.Location = new System.Drawing.Point(21, 131);
            this.dgvMateriales.MultiSelect = false;
            this.dgvMateriales.Name = "dgvMateriales";
            this.dgvMateriales.ReadOnly = true;
            this.dgvMateriales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMateriales.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMateriales.RowHeadersVisible = false;
            this.dgvMateriales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvMateriales.RowTemplate.Height = 27;
            this.dgvMateriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMateriales.Size = new System.Drawing.Size(409, 231);
            this.dgvMateriales.TabIndex = 147;
            // 
            // MId
            // 
            this.MId.HeaderText = "Numero";
            this.MId.Name = "MId";
            this.MId.ReadOnly = true;
            this.MId.Visible = false;
            // 
            // MNombre
            // 
            this.MNombre.HeaderText = "Nombre";
            this.MNombre.Name = "MNombre";
            this.MNombre.ReadOnly = true;
            // 
            // MCantidad
            // 
            this.MCantidad.HeaderText = "Cantidad";
            this.MCantidad.Name = "MCantidad";
            this.MCantidad.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.DropShadowEnabled = false;
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditar,
            this.btnEliminar});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.Empty;
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(84)))), ((int)(((byte)(173)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(182, 48);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(84)))), ((int)(((byte)(173)))));
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.btnEditar.ShowShortcutKeys = false;
            this.btnEditar.Size = new System.Drawing.Size(181, 22);
            this.btnEditar.Text = "Agregar Registro";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.ToolTipText = "Agrega nuevos materiales";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(84)))), ((int)(((byte)(173)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(181, 22);
            this.btnEliminar.Text = "Eliminar Registro";
            this.btnEliminar.ToolTipText = "Elimina el registro seleccionado";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(21, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 150;
            this.label4.Text = "Productos:";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Animated = true;
            this.btnAgregarProducto.AutoRoundedCorners = true;
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProducto.BorderRadius = 14;
            this.btnAgregarProducto.CheckedState.Parent = this.btnAgregarProducto;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.CustomImages.Parent = this.btnAgregarProducto;
            this.btnAgregarProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarProducto.DisabledState.Parent = this.btnAgregarProducto;
            this.btnAgregarProducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(84)))), ((int)(((byte)(173)))));
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarProducto.HoverState.Parent = this.btnAgregarProducto;
            this.btnAgregarProducto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAgregarProducto.Location = new System.Drawing.Point(101, 94);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.ShadowDecoration.Parent = this.btnAgregarProducto;
            this.btnAgregarProducto.Size = new System.Drawing.Size(154, 31);
            this.btnAgregarProducto.TabIndex = 149;
            this.btnAgregarProducto.Text = "Buscar Productos";
            this.btnAgregarProducto.UseTransparentBackground = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(84)))), ((int)(((byte)(173)))));
            this.lblPrecio.Location = new System.Drawing.Point(156, 365);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(30, 23);
            this.lblPrecio.TabIndex = 152;
            this.lblPrecio.Text = "$0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(30, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 151;
            this.label5.Text = "Cantidad a pagar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(30, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 153;
            this.label2.Text = "Cantidad Pagada:";
            // 
            // txtCantidadPagada
            // 
            this.txtCantidadPagada.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtCantidadPagada.BorderRadius = 10;
            this.txtCantidadPagada.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidadPagada.DefaultText = "0.00";
            this.txtCantidadPagada.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCantidadPagada.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCantidadPagada.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidadPagada.DisabledState.Parent = this.txtCantidadPagada;
            this.txtCantidadPagada.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidadPagada.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidadPagada.FocusedState.Parent = this.txtCantidadPagada;
            this.txtCantidadPagada.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCantidadPagada.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidadPagada.HoverState.Parent = this.txtCantidadPagada;
            this.txtCantidadPagada.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidadPagada.Location = new System.Drawing.Point(160, 401);
            this.txtCantidadPagada.Margin = new System.Windows.Forms.Padding(0);
            this.txtCantidadPagada.Name = "txtCantidadPagada";
            this.txtCantidadPagada.PasswordChar = '\0';
            this.txtCantidadPagada.PlaceholderText = "Cantidad Pagada";
            this.txtCantidadPagada.SelectedText = "";
            this.txtCantidadPagada.SelectionStart = 4;
            this.txtCantidadPagada.ShadowDecoration.Parent = this.txtCantidadPagada;
            this.txtCantidadPagada.Size = new System.Drawing.Size(115, 25);
            this.txtCantidadPagada.TabIndex = 154;
            this.txtCantidadPagada.TextChanged += new System.EventHandler(this.txtCantidadPagada_TextChanged);
            this.txtCantidadPagada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadPagada_KeyPress);
            // 
            // lblDevolucion
            // 
            this.lblDevolucion.AutoSize = true;
            this.lblDevolucion.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevolucion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(84)))), ((int)(((byte)(173)))));
            this.lblDevolucion.Location = new System.Drawing.Point(156, 446);
            this.lblDevolucion.Name = "lblDevolucion";
            this.lblDevolucion.Size = new System.Drawing.Size(30, 23);
            this.lblDevolucion.TabIndex = 156;
            this.lblDevolucion.Text = "$0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(30, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 155;
            this.label6.Text = "Devolucion:";
            // 
            // lblAtentido
            // 
            this.lblAtentido.AutoSize = true;
            this.lblAtentido.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtentido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(84)))), ((int)(((byte)(173)))));
            this.lblAtentido.Location = new System.Drawing.Point(156, 484);
            this.lblAtentido.Name = "lblAtentido";
            this.lblAtentido.Size = new System.Drawing.Size(15, 19);
            this.lblAtentido.TabIndex = 158;
            this.lblAtentido.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(30, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 157;
            this.label8.Text = "Atentido por";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Location = new System.Drawing.Point(140, 514);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(135, 45);
            this.guna2Button1.TabIndex = 159;
            this.guna2Button1.Text = "Confirmar Compra";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lblErrorPrecio2
            // 
            this.lblErrorPrecio2.AutoSize = true;
            this.lblErrorPrecio2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPrecio2.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrecio2.Location = new System.Drawing.Point(157, 426);
            this.lblErrorPrecio2.Name = "lblErrorPrecio2";
            this.lblErrorPrecio2.Size = new System.Drawing.Size(186, 13);
            this.lblErrorPrecio2.TabIndex = 161;
            this.lblErrorPrecio2.Text = "Este campo no puede quedar vacio";
            this.lblErrorPrecio2.Visible = false;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(339, 70);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(26, 13);
            this.lblid.TabIndex = 162;
            this.lblid.Text = "lblId";
            this.lblid.Visible = false;
            // 
            // lblFE
            // 
            this.lblFE.AutoSize = true;
            this.lblFE.Location = new System.Drawing.Point(339, 102);
            this.lblFE.Name = "lblFE";
            this.lblFE.Size = new System.Drawing.Size(73, 13);
            this.lblFE.TabIndex = 163;
            this.lblFE.Text = "FormaEntrega";
            this.lblFE.Visible = false;
            // 
            // AgregarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 571);
            this.ControlBox = false;
            this.Controls.Add(this.lblFE);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lblErrorPrecio2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.lblAtentido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDevolucion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCantidadPagada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvMateriales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblAgregarEmpleado);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2Shapes1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarVenta";
            this.Activated += new System.EventHandler(this.AgregarVenta_Activated);
            this.Load += new System.EventHandler(this.AgregarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarEmpleado;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMateriales;
        private System.Windows.Forms.DataGridViewTextBoxColumn MId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnAgregarProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtCantidadPagada;
        private System.Windows.Forms.Label lblDevolucion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAtentido;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnEditar;
        private System.Windows.Forms.ToolStripMenuItem btnEliminar;
        private System.Windows.Forms.Label lblErrorPrecio2;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblFE;
    }
}