
namespace Fragata.UI.WF
{
    partial class BuscarPedidoEnvio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSeleccionarMaterial = new System.Windows.Forms.Label();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.txtBuscarExistencia = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvObtenerMateriales = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarProducto = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOrdenn = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObtenerMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeleccionarMaterial
            // 
            this.lblSeleccionarMaterial.AutoSize = true;
            this.lblSeleccionarMaterial.BackColor = System.Drawing.Color.Tomato;
            this.lblSeleccionarMaterial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarMaterial.ForeColor = System.Drawing.Color.White;
            this.lblSeleccionarMaterial.Location = new System.Drawing.Point(171, 9);
            this.lblSeleccionarMaterial.Margin = new System.Windows.Forms.Padding(0);
            this.lblSeleccionarMaterial.Name = "lblSeleccionarMaterial";
            this.lblSeleccionarMaterial.Size = new System.Drawing.Size(156, 21);
            this.lblSeleccionarMaterial.TabIndex = 67;
            this.lblSeleccionarMaterial.Text = "Seleccionar Pedido";
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Shapes1.FillColor = System.Drawing.Color.Tomato;
            this.guna2Shapes1.Location = new System.Drawing.Point(0, 0);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.guna2Shapes1.Size = new System.Drawing.Size(526, 38);
            this.guna2Shapes1.TabIndex = 68;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 100;
            // 
            // txtBuscarExistencia
            // 
            this.txtBuscarExistencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtBuscarExistencia.BackColor = System.Drawing.Color.White;
            this.txtBuscarExistencia.BorderRadius = 10;
            this.txtBuscarExistencia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarExistencia.DefaultText = "";
            this.txtBuscarExistencia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBuscarExistencia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBuscarExistencia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarExistencia.DisabledState.Parent = this.txtBuscarExistencia;
            this.txtBuscarExistencia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBuscarExistencia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBuscarExistencia.FocusedState.Parent = this.txtBuscarExistencia;
            this.txtBuscarExistencia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBuscarExistencia.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarExistencia.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.txtBuscarExistencia.HoverState.Parent = this.txtBuscarExistencia;
            this.txtBuscarExistencia.IconLeft = global::Fragata.UI.WF.Properties.Resources.search_black;
            this.txtBuscarExistencia.IconLeftOffset = new System.Drawing.Point(3, 0);
            this.txtBuscarExistencia.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtBuscarExistencia.Location = new System.Drawing.Point(15, 70);
            this.txtBuscarExistencia.Name = "txtBuscarExistencia";
            this.txtBuscarExistencia.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.txtBuscarExistencia.PasswordChar = '\0';
            this.txtBuscarExistencia.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBuscarExistencia.PlaceholderText = "Buscar Existencia";
            this.txtBuscarExistencia.SelectedText = "";
            this.txtBuscarExistencia.ShadowDecoration.Parent = this.txtBuscarExistencia;
            this.txtBuscarExistencia.Size = new System.Drawing.Size(312, 23);
            this.txtBuscarExistencia.TabIndex = 69;
            this.txtBuscarExistencia.TextChanged += new System.EventHandler(this.txtBuscarExistencia_TextChanged);
            // 
            // dgvObtenerMateriales
            // 
            this.dgvObtenerMateriales.AllowDrop = true;
            this.dgvObtenerMateriales.AllowUserToAddRows = false;
            this.dgvObtenerMateriales.AllowUserToDeleteRows = false;
            this.dgvObtenerMateriales.AllowUserToResizeRows = false;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvObtenerMateriales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvObtenerMateriales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvObtenerMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObtenerMateriales.BackgroundColor = System.Drawing.Color.White;
            this.dgvObtenerMateriales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvObtenerMateriales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvObtenerMateriales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObtenerMateriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvObtenerMateriales.ColumnHeadersHeight = 32;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObtenerMateriales.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgvObtenerMateriales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvObtenerMateriales.EnableHeadersVisualStyles = false;
            this.dgvObtenerMateriales.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvObtenerMateriales.Location = new System.Drawing.Point(12, 107);
            this.dgvObtenerMateriales.MultiSelect = false;
            this.dgvObtenerMateriales.Name = "dgvObtenerMateriales";
            this.dgvObtenerMateriales.ReadOnly = true;
            this.dgvObtenerMateriales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObtenerMateriales.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvObtenerMateriales.RowHeadersVisible = false;
            this.dgvObtenerMateriales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvObtenerMateriales.RowTemplate.Height = 27;
            this.dgvObtenerMateriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObtenerMateriales.Size = new System.Drawing.Size(502, 229);
            this.dgvObtenerMateriales.TabIndex = 70;
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
            this.btnCancelar.Location = new System.Drawing.Point(271, 352);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(135, 45);
            this.btnCancelar.TabIndex = 87;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseTransparentBackground = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnAgregarProducto.Location = new System.Drawing.Point(118, 352);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.ShadowDecoration.Parent = this.btnAgregarProducto;
            this.btnAgregarProducto.Size = new System.Drawing.Size(135, 45);
            this.btnAgregarProducto.TabIndex = 86;
            this.btnAgregarProducto.Text = "Aceptar";
            this.btnAgregarProducto.UseTransparentBackground = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 139;
            this.label1.Text = "Buscar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(367, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 140;
            this.label2.Text = "Buscar por:";
            // 
            // cmbOrdenn
            // 
            this.cmbOrdenn.BackColor = System.Drawing.Color.White;
            this.cmbOrdenn.BorderRadius = 10;
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
            "Codigo",
            "Usuario"});
            this.cmbOrdenn.ItemsAppearance.Parent = this.cmbOrdenn;
            this.cmbOrdenn.Location = new System.Drawing.Point(370, 70);
            this.cmbOrdenn.Name = "cmbOrdenn";
            this.cmbOrdenn.ShadowDecoration.Parent = this.cmbOrdenn;
            this.cmbOrdenn.Size = new System.Drawing.Size(133, 24);
            this.cmbOrdenn.StartIndex = 0;
            this.cmbOrdenn.TabIndex = 141;
            // 
            // BuscarPedidoEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 409);
            this.Controls.Add(this.cmbOrdenn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvObtenerMateriales);
            this.Controls.Add(this.txtBuscarExistencia);
            this.Controls.Add(this.lblSeleccionarMaterial);
            this.Controls.Add(this.guna2Shapes1);
            this.Name = "BuscarPedidoEnvio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvObtenerMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionarMaterial;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarExistencia;
        private System.Windows.Forms.DataGridView dgvObtenerMateriales;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnAgregarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbOrdenn;
    }
}