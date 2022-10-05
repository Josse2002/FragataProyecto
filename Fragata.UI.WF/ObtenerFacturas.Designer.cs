
namespace Fragata.UI.WF
{
    partial class ObtenerFacturas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.AnimatorNS.Animation animation5 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObtenerFacturas));
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblOrdenarPor = new System.Windows.Forms.Label();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.cmbOrdenn = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbFiltros = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.dgvObtenerProductos = new System.Windows.Forms.DataGridView();
            this.txtBuscarEmpleado = new Guna.UI2.WinForms.Guna2TextBox();
            this.transitionBusqueda = new Guna.UI2.WinForms.Guna2Transition();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObtenerProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Transparent;
            this.transitionBusqueda.SetDecoration(this.guna2Shapes1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.guna2Shapes1.Location = new System.Drawing.Point(12, 12);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.RoundedRadius = 30;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.guna2Shapes1.Size = new System.Drawing.Size(834, 219);
            this.guna2Shapes1.TabIndex = 24;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 100;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.transitionBusqueda.SetDecoration(this.lblInfo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Transparent;
            this.lblInfo.Location = new System.Drawing.Point(34, 193);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(473, 17);
            this.lblInfo.TabIndex = 46;
            this.lblInfo.Text = "*Los datos se han mostrado de acuerdo con su información proporcionada.";
            // 
            // lblOrdenarPor
            // 
            this.lblOrdenarPor.AutoSize = true;
            this.lblOrdenarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.transitionBusqueda.SetDecoration(this.lblOrdenarPor, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblOrdenarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOrdenarPor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenarPor.ForeColor = System.Drawing.Color.White;
            this.lblOrdenarPor.Location = new System.Drawing.Point(207, 129);
            this.lblOrdenarPor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblOrdenarPor.Name = "lblOrdenarPor";
            this.lblOrdenarPor.Size = new System.Drawing.Size(88, 17);
            this.lblOrdenarPor.TabIndex = 44;
            this.lblOrdenarPor.Text = "Ordenar por:";
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.transitionBusqueda.SetDecoration(this.lblBuscarPor, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblBuscarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscarPor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.ForeColor = System.Drawing.Color.White;
            this.lblBuscarPor.Location = new System.Drawing.Point(48, 129);
            this.lblBuscarPor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(78, 17);
            this.lblBuscarPor.TabIndex = 43;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.transitionBusqueda.SetDecoration(this.lblTittle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblTittle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTittle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.White;
            this.lblTittle.Location = new System.Drawing.Point(45, 32);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(220, 32);
            this.lblTittle.TabIndex = 42;
            this.lblTittle.Text = "Todas las Facturas";
            // 
            // cmbOrdenn
            // 
            this.cmbOrdenn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.cmbOrdenn.BorderRadius = 10;
            this.transitionBusqueda.SetDecoration(this.cmbOrdenn, Guna.UI2.AnimatorNS.DecorationType.None);
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
            "Fecha",
            "Numero",
            "Total",
            "Estado"});
            this.cmbOrdenn.ItemsAppearance.Parent = this.cmbOrdenn;
            this.cmbOrdenn.Location = new System.Drawing.Point(210, 154);
            this.cmbOrdenn.Name = "cmbOrdenn";
            this.cmbOrdenn.ShadowDecoration.Parent = this.cmbOrdenn;
            this.cmbOrdenn.Size = new System.Drawing.Size(170, 24);
            this.cmbOrdenn.StartIndex = 0;
            this.cmbOrdenn.TabIndex = 40;
            this.cmbOrdenn.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenn_SelectedIndexChanged);
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.cmbFiltros.BorderRadius = 10;
            this.transitionBusqueda.SetDecoration(this.cmbFiltros, Guna.UI2.AnimatorNS.DecorationType.None);
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
            "Numero"});
            this.cmbFiltros.ItemsAppearance.Parent = this.cmbFiltros;
            this.cmbFiltros.Location = new System.Drawing.Point(51, 154);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.ShadowDecoration.Parent = this.cmbFiltros;
            this.cmbFiltros.Size = new System.Drawing.Size(124, 24);
            this.cmbFiltros.StartIndex = 0;
            this.cmbFiltros.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionBusqueda.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Fragata.UI.WF.Properties.Resources.search__4_;
            this.pictureBox1.Location = new System.Drawing.Point(51, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.transitionBusqueda.SetDecoration(this.guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(164)))), ((int)(((byte)(252)))));
            this.guna2CirclePictureBox1.Image = global::Fragata.UI.WF.Properties.Resources.Online_report_Isometric;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(565, -13);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(267, 272);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 41;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // dgvObtenerProductos
            // 
            this.dgvObtenerProductos.AllowDrop = true;
            this.dgvObtenerProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvObtenerProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvObtenerProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvObtenerProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObtenerProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvObtenerProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvObtenerProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvObtenerProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObtenerProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvObtenerProductos.ColumnHeadersHeight = 32;
            this.transitionBusqueda.SetDecoration(this.dgvObtenerProductos, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObtenerProductos.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvObtenerProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvObtenerProductos.EnableHeadersVisualStyles = false;
            this.dgvObtenerProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvObtenerProductos.Location = new System.Drawing.Point(12, 237);
            this.dgvObtenerProductos.MultiSelect = false;
            this.dgvObtenerProductos.Name = "dgvObtenerProductos";
            this.dgvObtenerProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObtenerProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvObtenerProductos.RowHeadersVisible = false;
            this.dgvObtenerProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvObtenerProductos.RowTemplate.Height = 27;
            this.dgvObtenerProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObtenerProductos.Size = new System.Drawing.Size(834, 258);
            this.dgvObtenerProductos.TabIndex = 47;
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtBuscarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.txtBuscarEmpleado.BorderRadius = 10;
            this.txtBuscarEmpleado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transitionBusqueda.SetDecoration(this.txtBuscarEmpleado, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txtBuscarEmpleado.DefaultText = "";
            this.txtBuscarEmpleado.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarEmpleado.DisabledState.Parent = this.txtBuscarEmpleado;
            this.txtBuscarEmpleado.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarEmpleado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarEmpleado.FocusedState.Parent = this.txtBuscarEmpleado;
            this.txtBuscarEmpleado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarEmpleado.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarEmpleado.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.txtBuscarEmpleado.HoverState.Parent = this.txtBuscarEmpleado;
            this.txtBuscarEmpleado.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.txtBuscarEmpleado.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(77, 84);
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            this.txtBuscarEmpleado.Padding = new System.Windows.Forms.Padding(4);
            this.txtBuscarEmpleado.PasswordChar = '\0';
            this.txtBuscarEmpleado.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(252)))));
            this.txtBuscarEmpleado.PlaceholderText = "Buscar Empleado";
            this.txtBuscarEmpleado.SelectedText = "";
            this.txtBuscarEmpleado.ShadowDecoration.Parent = this.txtBuscarEmpleado;
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(357, 23);
            this.txtBuscarEmpleado.TabIndex = 48;
            this.txtBuscarEmpleado.Visible = false;
            this.txtBuscarEmpleado.TextChanged += new System.EventHandler(this.txtBuscarEmpleado_TextChanged);
            // 
            // transitionBusqueda
            // 
            this.transitionBusqueda.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.transitionBusqueda.DefaultAnimation = animation5;
            // 
            // ObtenerFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 507);
            this.Controls.Add(this.txtBuscarEmpleado);
            this.Controls.Add(this.dgvObtenerProductos);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOrdenarPor);
            this.Controls.Add(this.lblBuscarPor);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.cmbOrdenn);
            this.Controls.Add(this.cmbFiltros);
            this.Controls.Add(this.guna2Shapes1);
            this.transitionBusqueda.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ObtenerFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ObtenerFacturas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObtenerProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOrdenarPor;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.Label lblTittle;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbOrdenn;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltros;
        private System.Windows.Forms.DataGridView dgvObtenerProductos;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarEmpleado;
        private Guna.UI2.WinForms.Guna2Transition transitionBusqueda;
    }
}