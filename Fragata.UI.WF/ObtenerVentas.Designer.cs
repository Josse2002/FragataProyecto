
namespace Fragata.UI.WF
{
    partial class ObtenerVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObtenerVentas));
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
            this.transitionBuscar = new Guna.UI2.WinForms.Guna2Transition();
            this.dtpcFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObtenerProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Transparent;
            this.transitionBuscar.SetDecoration(this.guna2Shapes1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(184)))));
            this.guna2Shapes1.Location = new System.Drawing.Point(12, 12);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.RoundedRadius = 30;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.guna2Shapes1.Size = new System.Drawing.Size(831, 219);
            this.guna2Shapes1.TabIndex = 23;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 100;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(184)))));
            this.transitionBuscar.SetDecoration(this.lblInfo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Transparent;
            this.lblInfo.Location = new System.Drawing.Point(40, 198);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(473, 17);
            this.lblInfo.TabIndex = 38;
            this.lblInfo.Text = "*Los datos se han mostrado de acuerdo con su información proporcionada.";
            // 
            // lblOrdenarPor
            // 
            this.lblOrdenarPor.AutoSize = true;
            this.lblOrdenarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(184)))));
            this.transitionBuscar.SetDecoration(this.lblOrdenarPor, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblOrdenarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOrdenarPor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenarPor.ForeColor = System.Drawing.Color.White;
            this.lblOrdenarPor.Location = new System.Drawing.Point(213, 134);
            this.lblOrdenarPor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblOrdenarPor.Name = "lblOrdenarPor";
            this.lblOrdenarPor.Size = new System.Drawing.Size(88, 17);
            this.lblOrdenarPor.TabIndex = 36;
            this.lblOrdenarPor.Text = "Ordenar por:";
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(184)))));
            this.transitionBuscar.SetDecoration(this.lblBuscarPor, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblBuscarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscarPor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.ForeColor = System.Drawing.Color.White;
            this.lblBuscarPor.Location = new System.Drawing.Point(54, 134);
            this.lblBuscarPor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(78, 17);
            this.lblBuscarPor.TabIndex = 35;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(184)))));
            this.transitionBuscar.SetDecoration(this.lblTittle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblTittle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTittle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.White;
            this.lblTittle.Location = new System.Drawing.Point(51, 37);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(201, 32);
            this.lblTittle.TabIndex = 34;
            this.lblTittle.Text = "Todas las Ventas";
            // 
            // cmbOrdenn
            // 
            this.cmbOrdenn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(184)))));
            this.cmbOrdenn.BorderRadius = 10;
            this.transitionBuscar.SetDecoration(this.cmbOrdenn, Guna.UI2.AnimatorNS.DecorationType.None);
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
            "Cantidad a pagar",
            "Cantidad pagada",
            "Atencion",
            "Fecha"});
            this.cmbOrdenn.ItemsAppearance.Parent = this.cmbOrdenn;
            this.cmbOrdenn.Location = new System.Drawing.Point(216, 159);
            this.cmbOrdenn.Name = "cmbOrdenn";
            this.cmbOrdenn.ShadowDecoration.Parent = this.cmbOrdenn;
            this.cmbOrdenn.Size = new System.Drawing.Size(170, 24);
            this.cmbOrdenn.StartIndex = 0;
            this.cmbOrdenn.TabIndex = 31;
            this.cmbOrdenn.SelectedIndexChanged += new System.EventHandler(this.cmbOrdenn_SelectedIndexChanged);
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(184)))));
            this.cmbFiltros.BorderRadius = 10;
            this.transitionBuscar.SetDecoration(this.cmbFiltros, Guna.UI2.AnimatorNS.DecorationType.None);
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
            "Fecha"});
            this.cmbFiltros.ItemsAppearance.Parent = this.cmbFiltros;
            this.cmbFiltros.Location = new System.Drawing.Point(57, 159);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.ShadowDecoration.Parent = this.cmbFiltros;
            this.cmbFiltros.Size = new System.Drawing.Size(124, 24);
            this.cmbFiltros.StartIndex = 0;
            this.cmbFiltros.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(59)))), ((int)(((byte)(184)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionBuscar.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::Fragata.UI.WF.Properties.Resources.search__4_;
            this.pictureBox1.Location = new System.Drawing.Point(57, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.transitionBuscar.SetDecoration(this.guna2CirclePictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(164)))), ((int)(((byte)(252)))));
            this.guna2CirclePictureBox1.Image = global::Fragata.UI.WF.Properties.Resources.Wallet_Isometric;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(566, -14);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(267, 272);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 33;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // dgvObtenerProductos
            // 
            this.dgvObtenerProductos.AllowDrop = true;
            this.dgvObtenerProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvObtenerProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvObtenerProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvObtenerProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObtenerProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvObtenerProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvObtenerProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvObtenerProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObtenerProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvObtenerProductos.ColumnHeadersHeight = 32;
            this.transitionBuscar.SetDecoration(this.dgvObtenerProductos, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObtenerProductos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvObtenerProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvObtenerProductos.EnableHeadersVisualStyles = false;
            this.dgvObtenerProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvObtenerProductos.Location = new System.Drawing.Point(12, 246);
            this.dgvObtenerProductos.MultiSelect = false;
            this.dgvObtenerProductos.Name = "dgvObtenerProductos";
            this.dgvObtenerProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObtenerProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvObtenerProductos.RowHeadersVisible = false;
            this.dgvObtenerProductos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvObtenerProductos.RowTemplate.Height = 27;
            this.dgvObtenerProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObtenerProductos.Size = new System.Drawing.Size(828, 274);
            this.dgvObtenerProductos.TabIndex = 39;
            // 
            // transitionBuscar
            // 
            this.transitionBuscar.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizBlind;
            this.transitionBuscar.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.transitionBuscar.DefaultAnimation = animation2;
            // 
            // dtpcFecha
            // 
            this.dtpcFecha.Animated = true;
            this.dtpcFecha.AutoRoundedCorners = true;
            this.dtpcFecha.BackColor = System.Drawing.Color.Transparent;
            this.dtpcFecha.BorderColor = System.Drawing.Color.Gray;
            this.dtpcFecha.BorderRadius = 17;
            this.dtpcFecha.CheckedState.Parent = this.dtpcFecha;
            this.dtpcFecha.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.transitionBuscar.SetDecoration(this.dtpcFecha, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dtpcFecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpcFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpcFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpcFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpcFecha.HoverState.Parent = this.dtpcFecha;
            this.dtpcFecha.Location = new System.Drawing.Point(83, 80);
            this.dtpcFecha.MaxDate = new System.DateTime(2300, 12, 31, 0, 0, 0, 0);
            this.dtpcFecha.MinDate = new System.DateTime(2009, 12, 25, 0, 0, 0, 0);
            this.dtpcFecha.Name = "dtpcFecha";
            this.dtpcFecha.Padding = new System.Windows.Forms.Padding(4);
            this.dtpcFecha.ShadowDecoration.Parent = this.dtpcFecha;
            this.dtpcFecha.Size = new System.Drawing.Size(232, 36);
            this.dtpcFecha.TabIndex = 154;
            this.dtpcFecha.UseTransparentBackground = true;
            this.dtpcFecha.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpcFecha.Visible = false;
            this.dtpcFecha.ValueChanged += new System.EventHandler(this.dtpcFecha_ValueChanged);
            // 
            // ObtenerVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 546);
            this.Controls.Add(this.dtpcFecha);
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
            this.transitionBuscar.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ObtenerVentas";
            this.Text = "ObtenerVentas";
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
        private Guna.UI2.WinForms.Guna2Transition transitionBuscar;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpcFecha;
    }
}