
namespace Fragata.UI.WF
{
    partial class EditarProducto
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
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContadorNombres = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEvento = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.btnAgregarMaterial = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarProducto = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.MId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuD = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.btnEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.pboxProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAgregarFoto = new Guna.UI2.WinForms.Guna2Button();
            this.txtPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombreProducto = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblErrorPrecio = new System.Windows.Forms.Label();
            this.lblErrorPrecio2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNE = new System.Windows.Forms.Label();
            this.lblEx = new System.Windows.Forms.Label();
            this.chbxValidatorType = new System.Windows.Forms.CheckBox();
            this.lblContadorDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            this.MenuD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgregarEmpleado
            // 
            this.lblAgregarEmpleado.AutoSize = true;
            this.lblAgregarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(255)))), ((int)(((byte)(117)))));
            this.lblAgregarEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblAgregarEmpleado.Location = new System.Drawing.Point(245, 9);
            this.lblAgregarEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.lblAgregarEmpleado.Name = "lblAgregarEmpleado";
            this.lblAgregarEmpleado.Size = new System.Drawing.Size(129, 21);
            this.lblAgregarEmpleado.TabIndex = 63;
            this.lblAgregarEmpleado.Text = "Editar Producto";
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BackColor = System.Drawing.Color.White;
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(255)))), ((int)(((byte)(117)))));
            this.guna2Shapes1.Location = new System.Drawing.Point(0, 0);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.guna2Shapes1.Size = new System.Drawing.Size(643, 38);
            this.guna2Shapes1.TabIndex = 64;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 100;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(26, 169);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(60, 21);
            this.lblPrecio.TabIndex = 69;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtCodigoProducto.BorderRadius = 10;
            this.txtCodigoProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoProducto.DefaultText = "";
            this.txtCodigoProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigoProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigoProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoProducto.DisabledState.Parent = this.txtCodigoProducto;
            this.txtCodigoProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoProducto.Enabled = false;
            this.txtCodigoProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoProducto.FocusedState.Parent = this.txtCodigoProducto;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodigoProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoProducto.HoverState.Parent = this.txtCodigoProducto;
            this.txtCodigoProducto.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoProducto.Location = new System.Drawing.Point(149, 75);
            this.txtCodigoProducto.Margin = new System.Windows.Forms.Padding(0);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.PasswordChar = '\0';
            this.txtCodigoProducto.PlaceholderText = "Codigo";
            this.txtCodigoProducto.ReadOnly = true;
            this.txtCodigoProducto.SelectedText = "";
            this.txtCodigoProducto.ShadowDecoration.Parent = this.txtCodigoProducto;
            this.txtCodigoProducto.Size = new System.Drawing.Size(93, 28);
            this.txtCodigoProducto.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 71;
            this.label1.Text = "Codigo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(26, 120);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 21);
            this.lblNombre.TabIndex = 66;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblContadorNombres
            // 
            this.lblContadorNombres.AutoSize = true;
            this.lblContadorNombres.BackColor = System.Drawing.Color.White;
            this.lblContadorNombres.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorNombres.ForeColor = System.Drawing.Color.Gray;
            this.lblContadorNombres.Location = new System.Drawing.Point(330, 127);
            this.lblContadorNombres.Name = "lblContadorNombres";
            this.lblContadorNombres.Size = new System.Drawing.Size(29, 13);
            this.lblContadorNombres.TabIndex = 67;
            this.lblContadorNombres.Text = "0/20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 73;
            this.label3.Text = "Descripcion:";
            // 
            // cmbEvento
            // 
            this.cmbEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.cmbEvento.BorderRadius = 10;
            this.cmbEvento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvento.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEvento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEvento.FocusedState.Parent = this.cmbEvento;
            this.cmbEvento.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEvento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbEvento.HoverState.Parent = this.cmbEvento;
            this.cmbEvento.ItemHeight = 18;
            this.cmbEvento.Items.AddRange(new object[] {
            "Evento...",
            "Graduacion",
            "Cumpleaños",
            "Amor",
            "Mamá",
            "Papá",
            "Niños"});
            this.cmbEvento.ItemsAppearance.Parent = this.cmbEvento;
            this.cmbEvento.Location = new System.Drawing.Point(149, 331);
            this.cmbEvento.Margin = new System.Windows.Forms.Padding(0);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.ShadowDecoration.Parent = this.cmbEvento;
            this.cmbEvento.Size = new System.Drawing.Size(179, 24);
            this.cmbEvento.StartIndex = 1;
            this.cmbEvento.TabIndex = 75;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(26, 334);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 21);
            this.lblGenero.TabIndex = 76;
            this.lblGenero.Text = "Evento:";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(26, 384);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(90, 21);
            this.lblMaterial.TabIndex = 78;
            this.lblMaterial.Text = "Materiales:";
            // 
            // btnAgregarMaterial
            // 
            this.btnAgregarMaterial.Animated = true;
            this.btnAgregarMaterial.AutoRoundedCorners = true;
            this.btnAgregarMaterial.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarMaterial.BorderRadius = 14;
            this.btnAgregarMaterial.CheckedState.Parent = this.btnAgregarMaterial;
            this.btnAgregarMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMaterial.CustomImages.Parent = this.btnAgregarMaterial;
            this.btnAgregarMaterial.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarMaterial.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarMaterial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarMaterial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarMaterial.DisabledState.Parent = this.btnAgregarMaterial;
            this.btnAgregarMaterial.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarMaterial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMaterial.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarMaterial.HoverState.Parent = this.btnAgregarMaterial;
            this.btnAgregarMaterial.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAgregarMaterial.Location = new System.Drawing.Point(149, 384);
            this.btnAgregarMaterial.Name = "btnAgregarMaterial";
            this.btnAgregarMaterial.ShadowDecoration.Parent = this.btnAgregarMaterial;
            this.btnAgregarMaterial.Size = new System.Drawing.Size(154, 31);
            this.btnAgregarMaterial.TabIndex = 79;
            this.btnAgregarMaterial.Text = "Buscar Materiales";
            this.btnAgregarMaterial.UseTransparentBackground = true;
            this.btnAgregarMaterial.Click += new System.EventHandler(this.btnAgregarMaterial_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Animated = true;
            this.btnAgregarProducto.AutoRoundedCorners = true;
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarProducto.BorderRadius = 21;
            this.btnAgregarProducto.CheckedState.Parent = this.btnAgregarProducto;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.CustomImages.Parent = this.btnAgregarProducto;
            this.btnAgregarProducto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarProducto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarProducto.DisabledState.Parent = this.btnAgregarProducto;
            this.btnAgregarProducto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarProducto.HoverState.Parent = this.btnAgregarProducto;
            this.btnAgregarProducto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAgregarProducto.Location = new System.Drawing.Point(334, 531);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.ShadowDecoration.Parent = this.btnAgregarProducto;
            this.btnAgregarProducto.Size = new System.Drawing.Size(135, 45);
            this.btnAgregarProducto.TabIndex = 83;
            this.btnAgregarProducto.Text = "Agregar\n\rArreglo";
            this.btnAgregarProducto.UseTransparentBackground = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Animated = true;
            this.btnCancelar.AutoRoundedCorners = true;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderRadius = 21;
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelar.DisabledState.Parent = this.btnCancelar;
            this.btnCancelar.FillColor = System.Drawing.Color.Crimson;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnCancelar.Location = new System.Drawing.Point(479, 531);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(135, 45);
            this.btnCancelar.TabIndex = 84;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseTransparentBackground = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMateriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMateriales.ColumnHeadersHeight = 32;
            this.dgvMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MId,
            this.MNombre,
            this.MCantidad});
            this.dgvMateriales.ContextMenuStrip = this.MenuD;
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
            this.dgvMateriales.Location = new System.Drawing.Point(23, 421);
            this.dgvMateriales.MultiSelect = false;
            this.dgvMateriales.Name = "dgvMateriales";
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
            this.dgvMateriales.Size = new System.Drawing.Size(305, 163);
            this.dgvMateriales.TabIndex = 85;
            // 
            // MId
            // 
            this.MId.HeaderText = "Numero";
            this.MId.Name = "MId";
            this.MId.Visible = false;
            // 
            // MNombre
            // 
            this.MNombre.HeaderText = "Nombre";
            this.MNombre.Name = "MNombre";
            // 
            // MCantidad
            // 
            this.MCantidad.HeaderText = "Cantidad a usar";
            this.MCantidad.Name = "MCantidad";
            // 
            // MenuD
            // 
            this.MenuD.DropShadowEnabled = false;
            this.MenuD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditar,
            this.btnEliminar});
            this.MenuD.Name = "guna2ContextMenuStrip1";
            this.MenuD.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.MenuD.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MenuD.RenderStyle.ColorTable = null;
            this.MenuD.RenderStyle.RoundedEdges = true;
            this.MenuD.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.MenuD.RenderStyle.SelectionBackColor = System.Drawing.Color.PaleGreen;
            this.MenuD.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MenuD.RenderStyle.SeparatorColor = System.Drawing.Color.White;
            this.MenuD.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.MenuD.Size = new System.Drawing.Size(182, 48);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
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
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(181, 22);
            this.btnEliminar.Text = "Eliminar Registro";
            this.btnEliminar.ToolTipText = "Elimina el registro seleccionado";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pboxProductImage
            // 
            this.pboxProductImage.BackColor = System.Drawing.Color.Transparent;
            this.pboxProductImage.BorderRadius = 20;
            this.pboxProductImage.Image = global::Fragata.UI.WF.Properties.Resources.mistery_man_gravatar_wordpress_avatar_persona_misteriosa_510x510;
            this.pboxProductImage.ImageRotate = 0F;
            this.pboxProductImage.Location = new System.Drawing.Point(445, 87);
            this.pboxProductImage.Name = "pboxProductImage";
            this.pboxProductImage.ShadowDecoration.Parent = this.pboxProductImage;
            this.pboxProductImage.Size = new System.Drawing.Size(172, 241);
            this.pboxProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxProductImage.TabIndex = 82;
            this.pboxProductImage.TabStop = false;
            // 
            // btnAgregarFoto
            // 
            this.btnAgregarFoto.Animated = true;
            this.btnAgregarFoto.AutoRoundedCorners = true;
            this.btnAgregarFoto.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarFoto.BorderRadius = 21;
            this.btnAgregarFoto.CheckedState.Parent = this.btnAgregarFoto;
            this.btnAgregarFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarFoto.CustomImages.Parent = this.btnAgregarFoto;
            this.btnAgregarFoto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarFoto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarFoto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarFoto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarFoto.DisabledState.Parent = this.btnAgregarFoto;
            this.btnAgregarFoto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarFoto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFoto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarFoto.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarFoto.HoverState.Parent = this.btnAgregarFoto;
            this.btnAgregarFoto.Image = global::Fragata.UI.WF.Properties.Resources.folder;
            this.btnAgregarFoto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAgregarFoto.Location = new System.Drawing.Point(461, 334);
            this.btnAgregarFoto.Name = "btnAgregarFoto";
            this.btnAgregarFoto.ShadowDecoration.Parent = this.btnAgregarFoto;
            this.btnAgregarFoto.Size = new System.Drawing.Size(135, 45);
            this.btnAgregarFoto.TabIndex = 81;
            this.btnAgregarFoto.Text = "Agregar foto \r\nde producto";
            this.btnAgregarFoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAgregarFoto.UseTransparentBackground = true;
            this.btnAgregarFoto.Click += new System.EventHandler(this.btnAgregarFoto_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtPrecio.BorderRadius = 10;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.DefaultText = "";
            this.txtPrecio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio.DisabledState.Parent = this.txtPrecio;
            this.txtPrecio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio.FocusedState.Parent = this.txtPrecio;
            this.txtPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecio.HoverState.Parent = this.txtPrecio;
            this.txtPrecio.IconLeft = global::Fragata.UI.WF.Properties.Resources.money_icon;
            this.txtPrecio.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtPrecio.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.Location = new System.Drawing.Point(149, 162);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.PlaceholderText = "Precio";
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.ShadowDecoration.Parent = this.txtPrecio;
            this.txtPrecio.Size = new System.Drawing.Size(93, 28);
            this.txtPrecio.TabIndex = 68;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtNombreProducto.BorderRadius = 10;
            this.txtNombreProducto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreProducto.DefaultText = "";
            this.txtNombreProducto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreProducto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreProducto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProducto.DisabledState.Parent = this.txtNombreProducto;
            this.txtNombreProducto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProducto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProducto.FocusedState.Parent = this.txtNombreProducto;
            this.txtNombreProducto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreProducto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProducto.HoverState.Parent = this.txtNombreProducto;
            this.txtNombreProducto.IconRight = global::Fragata.UI.WF.Properties.Resources.icon;
            this.txtNombreProducto.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreProducto.IconRightSize = new System.Drawing.Size(40, 20);
            this.txtNombreProducto.Location = new System.Drawing.Point(149, 120);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(0);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.PasswordChar = '\0';
            this.txtNombreProducto.PlaceholderText = "Nombres";
            this.txtNombreProducto.SelectedText = "";
            this.txtNombreProducto.ShadowDecoration.Parent = this.txtNombreProducto;
            this.txtNombreProducto.Size = new System.Drawing.Size(225, 28);
            this.txtNombreProducto.TabIndex = 65;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            // 
            // lblErrorPrecio
            // 
            this.lblErrorPrecio.AutoSize = true;
            this.lblErrorPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrecio.Location = new System.Drawing.Point(146, 190);
            this.lblErrorPrecio.Name = "lblErrorPrecio";
            this.lblErrorPrecio.Size = new System.Drawing.Size(160, 13);
            this.lblErrorPrecio.TabIndex = 86;
            this.lblErrorPrecio.Text = "El precio excede de caracteres";
            this.lblErrorPrecio.Visible = false;
            // 
            // lblErrorPrecio2
            // 
            this.lblErrorPrecio2.AutoSize = true;
            this.lblErrorPrecio2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPrecio2.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrecio2.Location = new System.Drawing.Point(146, 190);
            this.lblErrorPrecio2.Name = "lblErrorPrecio2";
            this.lblErrorPrecio2.Size = new System.Drawing.Size(203, 13);
            this.lblErrorPrecio2.TabIndex = 87;
            this.lblErrorPrecio2.Text = "Solo se puede poner un punto decimal";
            this.lblErrorPrecio2.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(382, 54);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(95, 21);
            this.lblId.TabIndex = 88;
            this.lblId.Text = "IdNoVisible";
            this.lblId.Visible = false;
            // 
            // lblNE
            // 
            this.lblNE.AutoSize = true;
            this.lblNE.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNE.Location = new System.Drawing.Point(382, 96);
            this.lblNE.Name = "lblNE";
            this.lblNE.Size = new System.Drawing.Size(125, 21);
            this.lblNE.TabIndex = 89;
            this.lblNE.Text = "NExistenciaNoV";
            this.lblNE.Visible = false;
            // 
            // lblEx
            // 
            this.lblEx.AutoSize = true;
            this.lblEx.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEx.Location = new System.Drawing.Point(382, 75);
            this.lblEx.Name = "lblEx";
            this.lblEx.Size = new System.Drawing.Size(120, 21);
            this.lblEx.TabIndex = 90;
            this.lblEx.Text = "ExistenciasNoV";
            this.lblEx.Visible = false;
            // 
            // chbxValidatorType
            // 
            this.chbxValidatorType.AutoSize = true;
            this.chbxValidatorType.Location = new System.Drawing.Point(268, 44);
            this.chbxValidatorType.Name = "chbxValidatorType";
            this.chbxValidatorType.Size = new System.Drawing.Size(91, 17);
            this.chbxValidatorType.TabIndex = 92;
            this.chbxValidatorType.Text = "ValidatorType";
            this.chbxValidatorType.UseVisualStyleBackColor = true;
            this.chbxValidatorType.Visible = false;
            // 
            // lblContadorDescripcion
            // 
            this.lblContadorDescripcion.AutoSize = true;
            this.lblContadorDescripcion.BackColor = System.Drawing.Color.White;
            this.lblContadorDescripcion.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.lblContadorDescripcion.Location = new System.Drawing.Point(330, 214);
            this.lblContadorDescripcion.Name = "lblContadorDescripcion";
            this.lblContadorDescripcion.Size = new System.Drawing.Size(35, 13);
            this.lblContadorDescripcion.TabIndex = 95;
            this.lblContadorDescripcion.Text = "0/100";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtDescripcion.BorderRadius = 10;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.DefaultText = "";
            this.txtDescripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.DisabledState.Parent = this.txtDescripcion;
            this.txtDescripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.FocusedState.Parent = this.txtDescripcion;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcion.HoverState.Parent = this.txtDescripcion;
            this.txtDescripcion.IconRight = global::Fragata.UI.WF.Properties.Resources.icon;
            this.txtDescripcion.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.IconRightSize = new System.Drawing.Size(40, 20);
            this.txtDescripcion.Location = new System.Drawing.Point(149, 208);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(0);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.PlaceholderText = "Descripcion";
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.ShadowDecoration.Parent = this.txtDescripcion;
            this.txtDescripcion.Size = new System.Drawing.Size(225, 106);
            this.txtDescripcion.TabIndex = 94;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // EditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(643, 608);
            this.Controls.Add(this.lblContadorDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.chbxValidatorType);
            this.Controls.Add(this.lblEx);
            this.Controls.Add(this.lblNE);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblErrorPrecio2);
            this.Controls.Add(this.lblErrorPrecio);
            this.Controls.Add(this.dgvMateriales);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.pboxProductImage);
            this.Controls.Add(this.btnAgregarFoto);
            this.Controls.Add(this.btnAgregarMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.cmbEvento);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblContadorNombres);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblAgregarEmpleado);
            this.Controls.Add(this.guna2Shapes1);
            this.Name = "EditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarProductos";
            this.Activated += new System.EventHandler(this.EditarProducto_Activated);
            this.Shown += new System.EventHandler(this.EditarProducto_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            this.MenuD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarEmpleado;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblContadorNombres;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEvento;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblMaterial;
        private Guna.UI2.WinForms.Guna2Button btnAgregarMaterial;
        private Guna.UI2.WinForms.Guna2PictureBox pboxProductImage;
        private Guna.UI2.WinForms.Guna2Button btnAgregarFoto;
        private Guna.UI2.WinForms.Guna2Button btnAgregarProducto;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvMateriales;
        private System.Windows.Forms.DataGridViewTextBoxColumn MId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCantidad;
        private System.Windows.Forms.Label lblErrorPrecio;
        private System.Windows.Forms.Label lblErrorPrecio2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNE;
        private System.Windows.Forms.Label lblEx;
        private System.Windows.Forms.CheckBox chbxValidatorType;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip MenuD;
        private System.Windows.Forms.ToolStripMenuItem btnEditar;
        private System.Windows.Forms.ToolStripMenuItem btnEliminar;
        private System.Windows.Forms.Label lblContadorDescripcion;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcion;
    }
}