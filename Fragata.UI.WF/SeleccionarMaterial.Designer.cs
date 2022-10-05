
namespace Fragata.UI.WF
{
    partial class SeleccionarMaterial
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
            this.lblSeleccionarMaterial = new System.Windows.Forms.Label();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.txtBuscarExistencia = new Guna.UI2.WinForms.Guna2TextBox();
            this.pboxImage = new System.Windows.Forms.PictureBox();
            this.dgvObtenerMateriales = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.lblErrorCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObtenerMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeleccionarMaterial
            // 
            this.lblSeleccionarMaterial.AutoSize = true;
            this.lblSeleccionarMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(255)))), ((int)(((byte)(117)))));
            this.lblSeleccionarMaterial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarMaterial.ForeColor = System.Drawing.Color.White;
            this.lblSeleccionarMaterial.Location = new System.Drawing.Point(206, 9);
            this.lblSeleccionarMaterial.Margin = new System.Windows.Forms.Padding(0);
            this.lblSeleccionarMaterial.Name = "lblSeleccionarMaterial";
            this.lblSeleccionarMaterial.Size = new System.Drawing.Size(166, 21);
            this.lblSeleccionarMaterial.TabIndex = 65;
            this.lblSeleccionarMaterial.Text = "Seleccionar Material";
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
            this.guna2Shapes1.Size = new System.Drawing.Size(596, 38);
            this.guna2Shapes1.TabIndex = 66;
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
            this.txtBuscarExistencia.Location = new System.Drawing.Point(113, 74);
            this.txtBuscarExistencia.Name = "txtBuscarExistencia";
            this.txtBuscarExistencia.Padding = new System.Windows.Forms.Padding(4, 4, 8, 4);
            this.txtBuscarExistencia.PasswordChar = '\0';
            this.txtBuscarExistencia.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBuscarExistencia.PlaceholderText = "Buscar Existencia";
            this.txtBuscarExistencia.SelectedText = "";
            this.txtBuscarExistencia.ShadowDecoration.Parent = this.txtBuscarExistencia;
            this.txtBuscarExistencia.Size = new System.Drawing.Size(357, 23);
            this.txtBuscarExistencia.TabIndex = 67;
            this.txtBuscarExistencia.TextChanged += new System.EventHandler(this.txtBuscarExistencia_TextChanged);
            // 
            // pboxImage
            // 
            this.pboxImage.Location = new System.Drawing.Point(415, 115);
            this.pboxImage.Name = "pboxImage";
            this.pboxImage.Size = new System.Drawing.Size(169, 204);
            this.pboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxImage.TabIndex = 68;
            this.pboxImage.TabStop = false;
            // 
            // dgvObtenerMateriales
            // 
            this.dgvObtenerMateriales.AllowDrop = true;
            this.dgvObtenerMateriales.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dgvObtenerMateriales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvObtenerMateriales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvObtenerMateriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObtenerMateriales.BackgroundColor = System.Drawing.Color.White;
            this.dgvObtenerMateriales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvObtenerMateriales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvObtenerMateriales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObtenerMateriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvObtenerMateriales.ColumnHeadersHeight = 32;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObtenerMateriales.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvObtenerMateriales.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvObtenerMateriales.EnableHeadersVisualStyles = false;
            this.dgvObtenerMateriales.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvObtenerMateriales.Location = new System.Drawing.Point(27, 115);
            this.dgvObtenerMateriales.MultiSelect = false;
            this.dgvObtenerMateriales.Name = "dgvObtenerMateriales";
            this.dgvObtenerMateriales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObtenerMateriales.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvObtenerMateriales.RowHeadersVisible = false;
            this.dgvObtenerMateriales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dgvObtenerMateriales.RowTemplate.Height = 27;
            this.dgvObtenerMateriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObtenerMateriales.Size = new System.Drawing.Size(372, 204);
            this.dgvObtenerMateriales.TabIndex = 69;
            this.dgvObtenerMateriales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObtenerMateriales_CellClick);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtCantidad.BorderRadius = 10;
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.DefaultText = "";
            this.txtCantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.DisabledState.Parent = this.txtCantidad;
            this.txtCantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidad.FocusedState.Parent = this.txtCantidad;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidad.HoverState.Parent = this.txtCantidad;
            this.txtCantidad.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.Location = new System.Drawing.Point(141, 334);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(0);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.PlaceholderText = "Cantidad";
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.ShadowDecoration.Parent = this.txtCantidad;
            this.txtCantidad.Size = new System.Drawing.Size(93, 28);
            this.txtCantidad.TabIndex = 72;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 73;
            this.label1.Text = "Cantidad a usar:";
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
            this.btnAgregarProducto.Location = new System.Drawing.Point(123, 404);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.ShadowDecoration.Parent = this.btnAgregarProducto;
            this.btnAgregarProducto.Size = new System.Drawing.Size(135, 45);
            this.btnAgregarProducto.TabIndex = 84;
            this.btnAgregarProducto.Text = "Aceptar";
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
            this.btnCancelar.Location = new System.Drawing.Point(279, 404);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(135, 45);
            this.btnCancelar.TabIndex = 85;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseTransparentBackground = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblErrorCantidad
            // 
            this.lblErrorCantidad.AutoSize = true;
            this.lblErrorCantidad.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCantidad.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCantidad.Location = new System.Drawing.Point(138, 371);
            this.lblErrorCantidad.Name = "lblErrorCantidad";
            this.lblErrorCantidad.Size = new System.Drawing.Size(136, 13);
            this.lblErrorCantidad.TabIndex = 86;
            this.lblErrorCantidad.Text = "El numero es muy grande";
            this.lblErrorCantidad.Visible = false;
            // 
            // SeleccionarMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 461);
            this.Controls.Add(this.lblErrorCantidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvObtenerMateriales);
            this.Controls.Add(this.pboxImage);
            this.Controls.Add(this.txtBuscarExistencia);
            this.Controls.Add(this.lblSeleccionarMaterial);
            this.Controls.Add(this.guna2Shapes1);
            this.Name = "SeleccionarMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionarMaterial";
            this.Load += new System.EventHandler(this.SeleccionarMaterial_Load);
            this.Shown += new System.EventHandler(this.SeleccionarMaterial_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObtenerMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeleccionarMaterial;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2TextBox txtBuscarExistencia;
        private System.Windows.Forms.PictureBox pboxImage;
        private System.Windows.Forms.DataGridView dgvObtenerMateriales;
        private Guna.UI2.WinForms.Guna2TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnAgregarProducto;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private System.Windows.Forms.Label lblErrorCantidad;
    }
}