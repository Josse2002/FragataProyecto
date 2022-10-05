
namespace Fragata.UI.WF
{
    partial class ObtenerSalida
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblOrdenarPor = new System.Windows.Forms.Label();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.cmbSalida = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbFiltros = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtBuscarSalida = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.pboxButtonLupa = new System.Windows.Forms.PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.dgvObtenerSalida = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pboxButtonLupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObtenerSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Gold;
            this.lblInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Transparent;
            this.lblInfo.Location = new System.Drawing.Point(36, 205);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(473, 17);
            this.lblInfo.TabIndex = 59;
            this.lblInfo.Text = "*Los datos se han mostrado de acuerdo con su información proporcionada.";
            // 
            // lblOrdenarPor
            // 
            this.lblOrdenarPor.AutoSize = true;
            this.lblOrdenarPor.BackColor = System.Drawing.Color.Gold;
            this.lblOrdenarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOrdenarPor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenarPor.ForeColor = System.Drawing.Color.White;
            this.lblOrdenarPor.Location = new System.Drawing.Point(226, 141);
            this.lblOrdenarPor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblOrdenarPor.Name = "lblOrdenarPor";
            this.lblOrdenarPor.Size = new System.Drawing.Size(88, 17);
            this.lblOrdenarPor.TabIndex = 57;
            this.lblOrdenarPor.Text = "Ordenar por:";
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.BackColor = System.Drawing.Color.Gold;
            this.lblBuscarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscarPor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.ForeColor = System.Drawing.Color.White;
            this.lblBuscarPor.Location = new System.Drawing.Point(50, 141);
            this.lblBuscarPor.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(78, 17);
            this.lblBuscarPor.TabIndex = 56;
            this.lblBuscarPor.Text = "Buscar por:";
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.BackColor = System.Drawing.Color.Gold;
            this.lblTittle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTittle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.White;
            this.lblTittle.Location = new System.Drawing.Point(47, 44);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(203, 32);
            this.lblTittle.TabIndex = 55;
            this.lblTittle.Text = "Todas las salidas";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // cmbSalida
            // 
            this.cmbSalida.BackColor = System.Drawing.Color.Gold;
            this.cmbSalida.BorderRadius = 10;
            this.cmbSalida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalida.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSalida.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSalida.FocusedState.Parent = this.cmbSalida;
            this.cmbSalida.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSalida.HoverState.Parent = this.cmbSalida;
            this.cmbSalida.ItemHeight = 18;
            this.cmbSalida.Items.AddRange(new object[] {
            "Proximos",
            "Ver activos",
            "Ver cancelados",
            "Ver completados",
            "Precio de envío"});
            this.cmbSalida.ItemsAppearance.Parent = this.cmbSalida;
            this.cmbSalida.Location = new System.Drawing.Point(229, 166);
            this.cmbSalida.Name = "cmbSalida";
            this.cmbSalida.ShadowDecoration.Parent = this.cmbSalida;
            this.cmbSalida.Size = new System.Drawing.Size(153, 24);
            this.cmbSalida.StartIndex = 0;
            this.cmbSalida.TabIndex = 52;
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.BackColor = System.Drawing.Color.Gold;
            this.cmbFiltros.BorderRadius = 10;
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
            "Direccion",
            "Telefono",
            "Correo Electronico"});
            this.cmbFiltros.ItemsAppearance.Parent = this.cmbFiltros;
            this.cmbFiltros.Location = new System.Drawing.Point(53, 166);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.ShadowDecoration.Parent = this.cmbFiltros;
            this.cmbFiltros.Size = new System.Drawing.Size(153, 24);
            this.cmbFiltros.StartIndex = 0;
            this.cmbFiltros.TabIndex = 51;
            // 
            // txtBuscarSalida
            // 
            this.txtBuscarSalida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtBuscarSalida.BackColor = System.Drawing.Color.Gold;
            this.txtBuscarSalida.BorderRadius = 10;
            this.txtBuscarSalida.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarSalida.DefaultText = "";
            this.txtBuscarSalida.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarSalida.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarSalida.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarSalida.DisabledState.Parent = this.txtBuscarSalida;
            this.txtBuscarSalida.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarSalida.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarSalida.FocusedState.Parent = this.txtBuscarSalida;
            this.txtBuscarSalida.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarSalida.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarSalida.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.txtBuscarSalida.HoverState.Parent = this.txtBuscarSalida;
            this.txtBuscarSalida.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.txtBuscarSalida.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtBuscarSalida.Location = new System.Drawing.Point(79, 96);
            this.txtBuscarSalida.Name = "txtBuscarSalida";
            this.txtBuscarSalida.Padding = new System.Windows.Forms.Padding(4);
            this.txtBuscarSalida.PasswordChar = '\0';
            this.txtBuscarSalida.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(252)))));
            this.txtBuscarSalida.PlaceholderText = "Buscar salidas";
            this.txtBuscarSalida.SelectedText = "";
            this.txtBuscarSalida.ShadowDecoration.Parent = this.txtBuscarSalida;
            this.txtBuscarSalida.Size = new System.Drawing.Size(357, 23);
            this.txtBuscarSalida.TabIndex = 50;
            this.txtBuscarSalida.Visible = false;

            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.FillColor = System.Drawing.Color.Gold;
            this.guna2Shapes1.Location = new System.Drawing.Point(12, 12);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.RoundedRadius = 30;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.guna2Shapes1.Size = new System.Drawing.Size(841, 219);
            this.guna2Shapes1.TabIndex = 53;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 100;
            // 
            // pboxButtonLupa
            // 
            this.pboxButtonLupa.BackColor = System.Drawing.Color.Gold;
            this.pboxButtonLupa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxButtonLupa.Image = global::Fragata.UI.WF.Properties.Resources.search__4_;
            this.pboxButtonLupa.Location = new System.Drawing.Point(53, 96);
            this.pboxButtonLupa.Name = "pboxButtonLupa";
            this.pboxButtonLupa.Size = new System.Drawing.Size(20, 20);
            this.pboxButtonLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxButtonLupa.TabIndex = 58;
            this.pboxButtonLupa.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(164)))), ((int)(((byte)(252)))));
            this.guna2CirclePictureBox1.Image = global::Fragata.UI.WF.Properties.Resources.Finance_app_Monochromatic;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(552, 0);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(254, 247);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 54;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // dgvObtenerSalida
            // 
            this.dgvObtenerSalida.AllowDrop = true;
            this.dgvObtenerSalida.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvObtenerSalida.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvObtenerSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvObtenerSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObtenerSalida.BackgroundColor = System.Drawing.Color.White;
            this.dgvObtenerSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvObtenerSalida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvObtenerSalida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObtenerSalida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvObtenerSalida.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObtenerSalida.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvObtenerSalida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvObtenerSalida.EnableHeadersVisualStyles = false;
            this.dgvObtenerSalida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvObtenerSalida.Location = new System.Drawing.Point(12, 271);
            this.dgvObtenerSalida.MultiSelect = false;
            this.dgvObtenerSalida.Name = "dgvObtenerSalida";
            this.dgvObtenerSalida.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObtenerSalida.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvObtenerSalida.RowHeadersVisible = false;
            this.dgvObtenerSalida.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvObtenerSalida.RowTemplate.Height = 27;
            this.dgvObtenerSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObtenerSalida.Size = new System.Drawing.Size(844, 233);
            this.dgvObtenerSalida.TabIndex = 60;
            // 
            // ObtenerSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 516);
            this.Controls.Add(this.dgvObtenerSalida);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pboxButtonLupa);
            this.Controls.Add(this.lblOrdenarPor);
            this.Controls.Add(this.lblBuscarPor);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.cmbSalida);
            this.Controls.Add(this.cmbFiltros);
            this.Controls.Add(this.txtBuscarSalida);
            this.Controls.Add(this.guna2Shapes1);
            this.Name = "ObtenerSalida";
            this.Text = "ObtenerSalida";
            ((System.ComponentModel.ISupportInitialize)(this.pboxButtonLupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObtenerSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pboxButtonLupa;
        private System.Windows.Forms.Label lblOrdenarPor;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.Label lblTittle;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSalida;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFiltros;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarSalida;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private System.Windows.Forms.DataGridView dgvObtenerSalida;
    }
}