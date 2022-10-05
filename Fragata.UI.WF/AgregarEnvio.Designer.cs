
namespace Fragata.UI.WF
{
    partial class AgregarEnvio
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
            this.lblAgregarEmpleado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpcFecha = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.btnAgregarProducto = new Guna.UI2.WinForms.Guna2Button();
            this.txtDireccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblErrorMail = new System.Windows.Forms.Label();
            this.lblErrorMail2 = new System.Windows.Forms.Label();
            this.lblErrorPrecio2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblErrorPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.txtCodigoPedido = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAgregarEmpleado
            // 
            this.lblAgregarEmpleado.AutoSize = true;
            this.lblAgregarEmpleado.BackColor = System.Drawing.Color.Tomato;
            this.lblAgregarEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblAgregarEmpleado.Location = new System.Drawing.Point(182, 9);
            this.lblAgregarEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.lblAgregarEmpleado.Name = "lblAgregarEmpleado";
            this.lblAgregarEmpleado.Size = new System.Drawing.Size(118, 21);
            this.lblAgregarEmpleado.TabIndex = 77;
            this.lblAgregarEmpleado.Text = "Agregar Envío";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(17, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 89;
            this.label2.Text = "Fecha y hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(17, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 91;
            this.label3.Text = "Direccion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(17, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 109;
            this.label4.Text = "Correo:";
            // 
            // txtMail
            // 
            this.txtMail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtMail.BorderRadius = 10;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.DefaultText = "";
            this.txtMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.DisabledState.Parent = this.txtMail;
            this.txtMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.FocusedState.Parent = this.txtMail;
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.HoverState.Parent = this.txtMail;
            this.txtMail.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.Location = new System.Drawing.Point(113, 360);
            this.txtMail.Margin = new System.Windows.Forms.Padding(0);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PlaceholderText = "Correo Electronico";
            this.txtMail.SelectedText = "";
            this.txtMail.ShadowDecoration.Parent = this.txtMail;
            this.txtMail.Size = new System.Drawing.Size(252, 28);
            this.txtMail.TabIndex = 108;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtTelefono.BorderRadius = 10;
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.DefaultText = "";
            this.txtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.DisabledState.Parent = this.txtTelefono;
            this.txtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.FocusedState.Parent = this.txtTelefono;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelefono.HoverState.Parent = this.txtTelefono;
            this.txtTelefono.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Location = new System.Drawing.Point(113, 311);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(0);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PlaceholderText = "Numero de Telefono";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.ShadowDecoration.Parent = this.txtTelefono;
            this.txtTelefono.Size = new System.Drawing.Size(252, 25);
            this.txtTelefono.TabIndex = 107;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Gray;
            this.label12.Location = new System.Drawing.Point(17, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 17);
            this.label12.TabIndex = 106;
            this.label12.Text = "Telefono:";
            // 
            // dtpcFecha
            // 
            this.dtpcFecha.Animated = true;
            this.dtpcFecha.AutoRoundedCorners = true;
            this.dtpcFecha.BorderColor = System.Drawing.Color.Gray;
            this.dtpcFecha.BorderRadius = 17;
            this.dtpcFecha.CheckedState.Parent = this.dtpcFecha;
            this.dtpcFecha.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpcFecha.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtpcFecha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpcFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpcFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpcFecha.HoverState.Parent = this.dtpcFecha;
            this.dtpcFecha.Location = new System.Drawing.Point(113, 161);
            this.dtpcFecha.MaxDate = new System.DateTime(2300, 12, 31, 0, 0, 0, 0);
            this.dtpcFecha.MinDate = new System.DateTime(2009, 12, 25, 0, 0, 0, 0);
            this.dtpcFecha.Name = "dtpcFecha";
            this.dtpcFecha.Padding = new System.Windows.Forms.Padding(4);
            this.dtpcFecha.ShadowDecoration.Parent = this.dtpcFecha;
            this.dtpcFecha.Size = new System.Drawing.Size(252, 36);
            this.dtpcFecha.TabIndex = 112;
            this.dtpcFecha.Value = new System.DateTime(2021, 9, 20, 2, 1, 54, 854);
            this.dtpcFecha.ValueChanged += new System.EventHandler(this.dtpcFecha_ValueChanged);
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BackColor = System.Drawing.Color.White;
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Shapes1.FillColor = System.Drawing.Color.Tomato;
            this.guna2Shapes1.Location = new System.Drawing.Point(0, 0);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.guna2Shapes1.Size = new System.Drawing.Size(476, 38);
            this.guna2Shapes1.TabIndex = 113;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 100;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Animated = true;
            this.btnAgregarProducto.AutoRoundedCorners = true;
            this.btnAgregarProducto.BackColor = System.Drawing.Color.White;
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
            this.btnAgregarProducto.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnAgregarProducto.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnAgregarProducto.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregarProducto.HoverState.Parent = this.btnAgregarProducto;
            this.btnAgregarProducto.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAgregarProducto.Location = new System.Drawing.Point(163, 498);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.ShadowDecoration.Parent = this.btnAgregarProducto;
            this.btnAgregarProducto.Size = new System.Drawing.Size(135, 45);
            this.btnAgregarProducto.TabIndex = 115;
            this.btnAgregarProducto.Text = "Agregar Envío";
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtDireccion.BorderRadius = 10;
            this.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.DefaultText = "";
            this.txtDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDireccion.DisabledState.Parent = this.txtDireccion;
            this.txtDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDireccion.FocusedState.Parent = this.txtDireccion;
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDireccion.HoverState.FillColor = System.Drawing.Color.White;
            this.txtDireccion.HoverState.Parent = this.txtDireccion;
            this.txtDireccion.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDireccion.Location = new System.Drawing.Point(113, 215);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(0);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.PlaceholderText = "Direccion";
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.ShadowDecoration.Parent = this.txtDireccion;
            this.txtDireccion.Size = new System.Drawing.Size(252, 78);
            this.txtDireccion.TabIndex = 127;
            // 
            // lblErrorMail
            // 
            this.lblErrorMail.AutoSize = true;
            this.lblErrorMail.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMail.Location = new System.Drawing.Point(110, 388);
            this.lblErrorMail.Name = "lblErrorMail";
            this.lblErrorMail.Size = new System.Drawing.Size(164, 13);
            this.lblErrorMail.TabIndex = 128;
            this.lblErrorMail.Text = "El correo ingresado es invalido";
            this.lblErrorMail.Visible = false;
            // 
            // lblErrorMail2
            // 
            this.lblErrorMail2.AutoSize = true;
            this.lblErrorMail2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMail2.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMail2.Location = new System.Drawing.Point(110, 388);
            this.lblErrorMail2.Name = "lblErrorMail2";
            this.lblErrorMail2.Size = new System.Drawing.Size(162, 13);
            this.lblErrorMail2.TabIndex = 129;
            this.lblErrorMail2.Text = "Solo se puede ingresar un \"@\"";
            this.lblErrorMail2.Visible = false;
            // 
            // lblErrorPrecio2
            // 
            this.lblErrorPrecio2.AutoSize = true;
            this.lblErrorPrecio2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPrecio2.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrecio2.Location = new System.Drawing.Point(110, 448);
            this.lblErrorPrecio2.Name = "lblErrorPrecio2";
            this.lblErrorPrecio2.Size = new System.Drawing.Size(203, 13);
            this.lblErrorPrecio2.TabIndex = 135;
            this.lblErrorPrecio2.Text = "Solo se puede poner un punto decimal";
            this.lblErrorPrecio2.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(17, 420);
            this.label5.MaximumSize = new System.Drawing.Size(100, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 34);
            this.label5.TabIndex = 136;
            this.label5.Text = "Costo de envio:";
            // 
            // lblErrorPrecio
            // 
            this.lblErrorPrecio.AutoSize = true;
            this.lblErrorPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPrecio.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPrecio.Location = new System.Drawing.Point(110, 448);
            this.lblErrorPrecio.Name = "lblErrorPrecio";
            this.lblErrorPrecio.Size = new System.Drawing.Size(160, 13);
            this.lblErrorPrecio.TabIndex = 137;
            this.lblErrorPrecio.Text = "El precio excede de caracteres";
            this.lblErrorPrecio.Visible = false;
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
            this.txtPrecio.Location = new System.Drawing.Point(113, 420);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.PlaceholderText = "Precio";
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.ShadowDecoration.Parent = this.txtPrecio;
            this.txtPrecio.Size = new System.Drawing.Size(93, 28);
            this.txtPrecio.TabIndex = 133;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
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
            this.btnMinimize.FillColor = System.Drawing.Color.Tomato;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btnMinimize.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Image = global::Fragata.UI.WF.Properties.Resources.minimized_hover;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = global::Fragata.UI.WF.Properties.Resources.remove;
            this.btnMinimize.ImageSize = new System.Drawing.Size(15, 15);
            this.btnMinimize.Location = new System.Drawing.Point(416, 9);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PressedColor = System.Drawing.Color.Tomato;
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(24, 19);
            this.btnMinimize.TabIndex = 76;
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
            this.btnClose.FillColor = System.Drawing.Color.Tomato;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Tomato;
            this.btnClose.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.Image = global::Fragata.UI.WF.Properties.Resources.close_hover;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = global::Fragata.UI.WF.Properties.Resources.close__2_;
            this.btnClose.ImageSize = new System.Drawing.Size(10, 10);
            this.btnClose.Location = new System.Drawing.Point(443, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0, 2, 3, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.Tomato;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 75;
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtCodigoPedido
            // 
            this.txtCodigoPedido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtCodigoPedido.BorderRadius = 10;
            this.txtCodigoPedido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoPedido.DefaultText = "";
            this.txtCodigoPedido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigoPedido.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigoPedido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoPedido.DisabledState.Parent = this.txtCodigoPedido;
            this.txtCodigoPedido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoPedido.Enabled = false;
            this.txtCodigoPedido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoPedido.FocusedState.Parent = this.txtCodigoPedido;
            this.txtCodigoPedido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodigoPedido.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoPedido.HoverState.Parent = this.txtCodigoPedido;
            this.txtCodigoPedido.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoPedido.Location = new System.Drawing.Point(113, 73);
            this.txtCodigoPedido.Margin = new System.Windows.Forms.Padding(0);
            this.txtCodigoPedido.Name = "txtCodigoPedido";
            this.txtCodigoPedido.PasswordChar = '\0';
            this.txtCodigoPedido.PlaceholderText = "Codigo Pedido";
            this.txtCodigoPedido.ReadOnly = true;
            this.txtCodigoPedido.SelectedText = "";
            this.txtCodigoPedido.ShadowDecoration.Parent = this.txtCodigoPedido;
            this.txtCodigoPedido.Size = new System.Drawing.Size(200, 25);
            this.txtCodigoPedido.TabIndex = 139;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 11;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Gray;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Location = new System.Drawing.Point(319, 73);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(46, 25);
            this.guna2Button1.TabIndex = 140;
            this.guna2Button1.Text = "...";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(17, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 141;
            this.label6.Text = "Cliente:";
            // 
            // txtNombreUser
            // 
            this.txtNombreUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtNombreUser.BorderRadius = 10;
            this.txtNombreUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreUser.DefaultText = "";
            this.txtNombreUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreUser.DisabledState.Parent = this.txtNombreUser;
            this.txtNombreUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreUser.Enabled = false;
            this.txtNombreUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreUser.FocusedState.Parent = this.txtNombreUser;
            this.txtNombreUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreUser.HoverState.Parent = this.txtNombreUser;
            this.txtNombreUser.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreUser.Location = new System.Drawing.Point(113, 121);
            this.txtNombreUser.Margin = new System.Windows.Forms.Padding(0);
            this.txtNombreUser.Name = "txtNombreUser";
            this.txtNombreUser.PasswordChar = '\0';
            this.txtNombreUser.PlaceholderText = "Nombre del Cliente";
            this.txtNombreUser.ReadOnly = true;
            this.txtNombreUser.SelectedText = "";
            this.txtNombreUser.ShadowDecoration.Parent = this.txtNombreUser;
            this.txtNombreUser.Size = new System.Drawing.Size(252, 25);
            this.txtNombreUser.TabIndex = 142;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(17, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 138;
            this.label1.Text = "Pedido:";
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdPedido.ForeColor = System.Drawing.Color.Gray;
            this.lblIdPedido.Location = new System.Drawing.Point(385, 60);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(51, 17);
            this.lblIdPedido.TabIndex = 143;
            this.lblIdPedido.Text = "Pedido";
            this.lblIdPedido.Visible = false;
            // 
            // AgregarEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(476, 549);
            this.Controls.Add(this.lblIdPedido);
            this.Controls.Add(this.txtNombreUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtCodigoPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblErrorPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblErrorPrecio2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblErrorMail2);
            this.Controls.Add(this.lblErrorMail);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dtpcFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAgregarEmpleado);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2Shapes1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarEnvio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarEnvio";
            this.Activated += new System.EventHandler(this.AgregarEnvio_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregarEmpleado;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtMail;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpcFecha;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2Button btnAgregarProducto;
        private Guna.UI2.WinForms.Guna2TextBox txtDireccion;
        private System.Windows.Forms.Label lblErrorMail;
        private System.Windows.Forms.Label lblErrorMail2;
        private System.Windows.Forms.Label lblErrorPrecio2;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblErrorPrecio;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigoPedido;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdPedido;
       
    }
}