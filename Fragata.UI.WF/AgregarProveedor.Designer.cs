
namespace Fragata.UI.WF
{
    partial class AgregarProveedor
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
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.lblAgregarEmpleado = new System.Windows.Forms.Label();
            this.lblContadorApellidos = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.pboxImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAgregarImagen = new Guna.UI2.WinForms.Guna2Button();
            this.txtApellidos = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Shapes1.Location = new System.Drawing.Point(0, 0);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.guna2Shapes1.Size = new System.Drawing.Size(627, 38);
            this.guna2Shapes1.TabIndex = 63;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 100;
            // 
            // lblAgregarEmpleado
            // 
            this.lblAgregarEmpleado.AutoSize = true;
            this.lblAgregarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAgregarEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblAgregarEmpleado.Location = new System.Drawing.Point(239, 9);
            this.lblAgregarEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.lblAgregarEmpleado.Name = "lblAgregarEmpleado";
            this.lblAgregarEmpleado.Size = new System.Drawing.Size(154, 21);
            this.lblAgregarEmpleado.TabIndex = 64;
            this.lblAgregarEmpleado.Text = "Agregar Proveedor";
            // 
            // lblContadorApellidos
            // 
            this.lblContadorApellidos.AutoSize = true;
            this.lblContadorApellidos.BackColor = System.Drawing.Color.White;
            this.lblContadorApellidos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorApellidos.ForeColor = System.Drawing.Color.Gray;
            this.lblContadorApellidos.Location = new System.Drawing.Point(310, 106);
            this.lblContadorApellidos.Name = "lblContadorApellidos";
            this.lblContadorApellidos.Size = new System.Drawing.Size(29, 13);
            this.lblContadorApellidos.TabIndex = 99;
            this.lblContadorApellidos.Text = "0/50";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(26, 98);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(87, 21);
            this.lblApellidos.TabIndex = 95;
            this.lblApellidos.Text = "Encargado";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(26, 198);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(83, 21);
            this.lblTelefono.TabIndex = 93;
            this.lblTelefono.Text = "Dirección:";
            // 
            // pboxImage
            // 
            this.pboxImage.BackColor = System.Drawing.Color.Transparent;
            this.pboxImage.BorderRadius = 20;
            this.pboxImage.Image = global::Fragata.UI.WF.Properties.Resources.mistery_man_gravatar_wordpress_avatar_persona_misteriosa_510x510;
            this.pboxImage.ImageRotate = 0F;
            this.pboxImage.Location = new System.Drawing.Point(418, 86);
            this.pboxImage.Name = "pboxImage";
            this.pboxImage.ShadowDecoration.Parent = this.pboxImage;
            this.pboxImage.Size = new System.Drawing.Size(172, 196);
            this.pboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxImage.TabIndex = 96;
            this.pboxImage.TabStop = false;
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Animated = true;
            this.btnAgregarImagen.AutoRoundedCorners = true;
            this.btnAgregarImagen.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarImagen.BorderRadius = 21;
            this.btnAgregarImagen.CheckedState.Parent = this.btnAgregarImagen;
            this.btnAgregarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarImagen.CustomImages.Parent = this.btnAgregarImagen;
            this.btnAgregarImagen.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarImagen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarImagen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarImagen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarImagen.DisabledState.Parent = this.btnAgregarImagen;
            this.btnAgregarImagen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAgregarImagen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarImagen.ForeColor = System.Drawing.Color.White;
            this.btnAgregarImagen.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAgregarImagen.HoverState.Parent = this.btnAgregarImagen;
            this.btnAgregarImagen.Image = global::Fragata.UI.WF.Properties.Resources.folder;
            this.btnAgregarImagen.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAgregarImagen.Location = new System.Drawing.Point(440, 288);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.ShadowDecoration.Parent = this.btnAgregarImagen;
            this.btnAgregarImagen.Size = new System.Drawing.Size(135, 45);
            this.btnAgregarImagen.TabIndex = 86;
            this.btnAgregarImagen.Text = "Agregar foto \r\n de la empresa";
            this.btnAgregarImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAgregarImagen.UseTransparentBackground = true;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtApellidos.BorderRadius = 10;
            this.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidos.DefaultText = "";
            this.txtApellidos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtApellidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtApellidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidos.DisabledState.Parent = this.txtApellidos;
            this.txtApellidos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtApellidos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidos.FocusedState.Parent = this.txtApellidos;
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtApellidos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtApellidos.HoverState.Parent = this.txtApellidos;
            this.txtApellidos.IconRight = global::Fragata.UI.WF.Properties.Resources.icon;
            this.txtApellidos.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellidos.IconRightSize = new System.Drawing.Size(40, 20);
            this.txtApellidos.Location = new System.Drawing.Point(127, 98);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(0);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.PlaceholderText = "Apellidos";
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.ShadowDecoration.Parent = this.txtApellidos;
            this.txtApellidos.Size = new System.Drawing.Size(225, 28);
            this.txtApellidos.TabIndex = 78;
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
            this.btnCancelar.Location = new System.Drawing.Point(180, 288);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(135, 45);
            this.btnCancelar.TabIndex = 110;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseTransparentBackground = true;
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Animated = true;
            this.btnAgregarEmpleado.AutoRoundedCorners = true;
            this.btnAgregarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarEmpleado.BorderRadius = 21;
            this.btnAgregarEmpleado.CheckedState.Parent = this.btnAgregarEmpleado;
            this.btnAgregarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarEmpleado.CustomImages.Parent = this.btnAgregarEmpleado;
            this.btnAgregarEmpleado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarEmpleado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarEmpleado.DisabledState.Parent = this.btnAgregarEmpleado;
            this.btnAgregarEmpleado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEmpleado.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarEmpleado.HoverState.Parent = this.btnAgregarEmpleado;
            this.btnAgregarEmpleado.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(30, 288);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.ShadowDecoration.Parent = this.btnAgregarEmpleado;
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(135, 45);
            this.btnAgregarEmpleado.TabIndex = 109;
            this.btnAgregarEmpleado.Text = "Agregar Proveedor";
            this.btnAgregarEmpleado.UseTransparentBackground = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 111;
            this.label2.Text = "Empresa";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.BorderRadius = 10;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconRight = global::Fragata.UI.WF.Properties.Resources.icon;
            this.guna2TextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.IconRightSize = new System.Drawing.Size(40, 20);
            this.guna2TextBox1.Location = new System.Drawing.Point(127, 145);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Empresa";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(225, 28);
            this.guna2TextBox1.TabIndex = 112;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.BorderRadius = 10;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "Dirección";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.IconRight = global::Fragata.UI.WF.Properties.Resources.icon;
            this.guna2TextBox2.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.IconRightSize = new System.Drawing.Size(40, 20);
            this.guna2TextBox2.Location = new System.Drawing.Point(127, 198);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "Dirección";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(225, 28);
            this.guna2TextBox2.TabIndex = 113;
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
            this.btnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(255)))), ((int)(((byte)(117)))));
            this.btnMinimize.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Image = global::Fragata.UI.WF.Properties.Resources.minimized_hover;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = global::Fragata.UI.WF.Properties.Resources.remove;
            this.btnMinimize.ImageSize = new System.Drawing.Size(15, 15);
            this.btnMinimize.Location = new System.Drawing.Point(566, 9);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0, 5, 7, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(252)))));
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(24, 19);
            this.btnMinimize.TabIndex = 115;
            this.btnMinimize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(255)))), ((int)(((byte)(117)))));
            this.btnClose.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.Image = global::Fragata.UI.WF.Properties.Resources.close_hover;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = global::Fragata.UI.WF.Properties.Resources.close__2_;
            this.btnClose.ImageSize = new System.Drawing.Size(10, 10);
            this.btnClose.Location = new System.Drawing.Point(588, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0, 5, 3, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(252)))));
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 114;
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AgregarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 384);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.lblContadorApellidos);
            this.Controls.Add(this.pboxImage);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblAgregarEmpleado);
            this.Controls.Add(this.guna2Shapes1);
            this.Name = "AgregarProveedor";
            this.Text = "AgregarProveedor";
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private System.Windows.Forms.Label lblAgregarEmpleado;
        private System.Windows.Forms.Label lblContadorApellidos;
        private Guna.UI2.WinForms.Guna2PictureBox pboxImage;
        private Guna.UI2.WinForms.Guna2Button btnAgregarImagen;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblTelefono;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnAgregarEmpleado;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}