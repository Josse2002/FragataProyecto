
namespace Fragata.UI.WF
{
    partial class ObtenerPedido
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObtenerPedido));
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblOrdenarPor = new System.Windows.Forms.Label();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.cmbOrdenn = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbFiltros = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBuscarPedidos = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvObtenerPedidos = new System.Windows.Forms.DataGridView();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.trancisionBusqueda = new Guna.UI2.WinForms.Guna2Transition();
            this.pboxButtonLupa = new System.Windows.Forms.PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObtenerPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxButtonLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(84)))), ((int)(((byte)(173)))));
            this.trancisionBusqueda.SetDecoration(this.lblInfo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Transparent;
            this.lblInfo.Location = new System.Drawing.Point(36, 205);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(473, 17);
            this.lblInfo.TabIndex = 39;
            this.lblInfo.Text = "*Los datos se han mostrado de acuerdo con su información proporcionada.";
            // 
            // lblOrdenarPor
            // 
            this.lblOrdenarPor.AutoSize = true;
            this.lblOrdenarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(84)))), ((int)(((byte)(173)))));
            this.trancisionBusqueda.SetDecoration(this.lblOrdenarPor, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblOrdenarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOrdenarPor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenarPor.ForeColor = System.Drawing.Color.White;
            this.lblOrdenarPor.Location = new System.Drawing.Point(226, 141);
            this.lblOrdenarPor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblOrdenarPor.Name = "lblOrdenarPor";
            this.lblOrdenarPor.Size = new System.Drawing.Size(88, 17);
            this.lblOrdenarPor.TabIndex = 37;
            this.lblOrdenarPor.Text = "Ordenar por:";
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(84)))), ((int)(((byte)(173)))));
            this.trancisionBusqueda.SetDecoration(this.lblBuscarPor, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblBuscarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscarPor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.ForeColor = System.Drawing.Color.White;
            this.lblBuscarPor.Location = new System.Drawing.Point(50, 141);
            this.lblBuscarPor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(78, 17);
            this.lblBuscarPor.TabIndex = 36;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(84)))), ((int)(((byte)(173)))));
            this.trancisionBusqueda.SetDecoration(this.lblTittle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblTittle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTittle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.White;
            this.lblTittle.Location = new System.Drawing.Point(47, 44);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(221, 32);
            this.lblTittle.TabIndex = 35;
            this.lblTittle.Text = "Todos los pedidos";
            // 
            // cmbOrdenn
            // 
            this.cmbOrdenn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(84)))), ((int)(((byte)(173)))));
            this.cmbOrdenn.BorderRadius = 10;
            this.trancisionBusqueda.SetDecoration(this.cmbOrdenn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cmbOrdenn.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOrdenn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdenn.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbOrdenn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbOrdenn.FocusedState.Parent = this.cmbOrdenn;
            this.cmbOrdenn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbOrdenn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbOrdenn.HoverState.Parent = this.cmbOrdenn;
            this.cmbOrdenn.ItemHeight = 18;
            this.cmbOrdenn.Items.AddRange(new object[] {
            "Recientes",
            "Ver Activos",
            "Ver Cancelados",
            "Ver Completados",
            "Precio"});
            this.cmbOrdenn.ItemsAppearance.Parent = this.cmbOrdenn;
            this.cmbOrdenn.Location = new System.Drawing.Point(229, 166);
            this.cmbOrdenn.Name = "cmbOrdenn";
            this.cmbOrdenn.ShadowDecoration.Parent = this.cmbOrdenn;
            this.cmbOrdenn.Size = new System.Drawing.Size(153, 24);
            this.cmbOrdenn.StartIndex = 0;
            this.cmbOrdenn.TabIndex = 32;
            this.cmbOrdenn.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenn_SelectedIndexChanged);
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(84)))), ((int)(((byte)(173)))));
            this.cmbFiltros.BorderRadius = 10;
            this.trancisionBusqueda.SetDecoration(this.cmbFiltros, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cmbFiltros.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltros.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltros.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFiltros.FocusedState.Parent = this.cmbFiltros;
            this.cmbFiltros.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFiltros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFiltros.HoverState.Parent = this.cmbFiltros;
            this.cmbFiltros.ItemHeight = 18;
            this.cmbFiltros.Items.AddRange(new object[] {
            "Cliente",
            "Codigo"});
            this.cmbFiltros.ItemsAppearance.Parent = this.cmbFiltros;
            this.cmbFiltros.Location = new System.Drawing.Point(53, 166);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.ShadowDecoration.Parent = this.cmbFiltros;
            this.cmbFiltros.Size = new System.Drawing.Size(153, 24);
            this.cmbFiltros.StartIndex = 0;
            this.cmbFiltros.TabIndex = 31;
            // 
            // txtBuscarPedidos
            // 
            this.txtBuscarPedidos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtBuscarPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(84)))), ((int)(((byte)(173)))));
            this.txtBuscarPedidos.BorderRadius = 10;
            this.txtBuscarPedidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.trancisionBusqueda.SetDecoration(this.txtBuscarPedidos, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtBuscarPedidos.DefaultText = "";
            this.txtBuscarPedidos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarPedidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarPedidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarPedidos.DisabledState.Parent = this.txtBuscarPedidos;
            this.txtBuscarPedidos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarPedidos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarPedidos.FocusedState.Parent = this.txtBuscarPedidos;
            this.txtBuscarPedidos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarPedidos.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarPedidos.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.txtBuscarPedidos.HoverState.Parent = this.txtBuscarPedidos;
            this.txtBuscarPedidos.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.txtBuscarPedidos.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtBuscarPedidos.Location = new System.Drawing.Point(79, 96);
            this.txtBuscarPedidos.Name = "txtBuscarPedidos";
            this.txtBuscarPedidos.Padding = new System.Windows.Forms.Padding(4);
            this.txtBuscarPedidos.PasswordChar = '\0';
            this.txtBuscarPedidos.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(252)))));
            this.txtBuscarPedidos.PlaceholderText = "Buscar Envios";
            this.txtBuscarPedidos.SelectedText = "";
            this.txtBuscarPedidos.ShadowDecoration.Parent = this.txtBuscarPedidos;
            this.txtBuscarPedidos.Size = new System.Drawing.Size(357, 23);
            this.txtBuscarPedidos.TabIndex = 30;
            this.txtBuscarPedidos.Visible = false;
            this.txtBuscarPedidos.TextChanged += new System.EventHandler(this.txtBuscarPedidos_TextChanged);
            // 
            // dgvObtenerPedidos
            // 
            this.dgvObtenerPedidos.AllowDrop = true;
            this.dgvObtenerPedidos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvObtenerPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvObtenerPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvObtenerPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObtenerPedidos.BackgroundColor = System.Drawing.Color.White;
            this.dgvObtenerPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvObtenerPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvObtenerPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObtenerPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvObtenerPedidos.ColumnHeadersHeight = 32;
            this.trancisionBusqueda.SetDecoration(this.dgvObtenerPedidos, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObtenerPedidos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvObtenerPedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvObtenerPedidos.EnableHeadersVisualStyles = false;
            this.dgvObtenerPedidos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvObtenerPedidos.Location = new System.Drawing.Point(12, 257);
            this.dgvObtenerPedidos.MultiSelect = false;
            this.dgvObtenerPedidos.Name = "dgvObtenerPedidos";
            this.dgvObtenerPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObtenerPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvObtenerPedidos.RowHeadersVisible = false;
            this.dgvObtenerPedidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvObtenerPedidos.RowTemplate.Height = 27;
            this.dgvObtenerPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObtenerPedidos.Size = new System.Drawing.Size(844, 285);
            this.dgvObtenerPedidos.TabIndex = 29;
            this.dgvObtenerPedidos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObtenerPedidos_CellContentDoubleClick);
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Transparent;
            this.trancisionBusqueda.SetDecoration(this.guna2Shapes1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(84)))), ((int)(((byte)(173)))));
            this.guna2Shapes1.Location = new System.Drawing.Point(12, 12);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.RoundedRadius = 30;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.guna2Shapes1.Size = new System.Drawing.Size(841, 219);
            this.guna2Shapes1.TabIndex = 33;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 100;
            // 
            // trancisionBusqueda
            // 
            this.trancisionBusqueda.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.trancisionBusqueda.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.trancisionBusqueda.DefaultAnimation = animation1;
            // 
            // pboxButtonLupa
            // 
            this.pboxButtonLupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(84)))), ((int)(((byte)(173)))));
            this.pboxButtonLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trancisionBusqueda.SetDecoration(this.pboxButtonLupa, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pboxButtonLupa.Image = global::Fragata.UI.WF.Properties.Resources.search__4_;
            this.pboxButtonLupa.Location = new System.Drawing.Point(53, 96);
            this.pboxButtonLupa.Name = "pboxButtonLupa";
            this.pboxButtonLupa.Size = new System.Drawing.Size(20, 20);
            this.pboxButtonLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxButtonLupa.TabIndex = 38;
            this.pboxButtonLupa.TabStop = false;
            this.pboxButtonLupa.Click += new System.EventHandler(this.pboxButtonLupa_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.trancisionBusqueda.SetDecoration(this.guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(164)))), ((int)(((byte)(252)))));
            this.guna2CirclePictureBox1.Image = global::Fragata.UI.WF.Properties.Resources.Online_store__Isometric__1_;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(585, -2);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(259, 253);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 34;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // ObtenerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 525);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pboxButtonLupa);
            this.Controls.Add(this.lblOrdenarPor);
            this.Controls.Add(this.lblBuscarPor);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.cmbOrdenn);
            this.Controls.Add(this.cmbFiltros);
            this.Controls.Add(this.txtBuscarPedidos);
            this.Controls.Add(this.dgvObtenerPedidos);
            this.Controls.Add(this.guna2Shapes1);
            this.trancisionBusqueda.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ObtenerPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ObtenerExistencias";
            this.Load += new System.EventHandler(this.ObtenerPedido_Load);
            this.Shown += new System.EventHandler(this.ObtenerPedido_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObtenerPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxButtonLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pboxButtonLupa;
        private System.Windows.Forms.Label lblOrdenarPor;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.Label lblTittle;
        private Guna.UI2.WinForms.Guna2ComboBox cmbOrdenn;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltros;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarPedidos;
        private System.Windows.Forms.DataGridView dgvObtenerPedidos;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Transition trancisionBusqueda;
    }
}