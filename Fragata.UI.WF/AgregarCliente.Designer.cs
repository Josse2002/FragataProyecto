
namespace Fragata.UI.WF
{
    partial class AgregarCliente
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
            this.lblErrorMail2 = new System.Windows.Forms.Label();
            this.lblErrorMail = new System.Windows.Forms.Label();
            this.txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContadorApellidos = new System.Windows.Forms.Label();
            this.lblContadorNombres = new System.Windows.Forms.Label();
            this.lblErrorEdad = new System.Windows.Forms.Label();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnAgregarEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.txtClave = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbGenero = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtEdad = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblHorasTrabajo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.chbxViewPassword = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.txtNombres = new Guna.UI2.WinForms.Guna2TextBox();
            this.pboxImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAgregarImagen = new Guna.UI2.WinForms.Guna2Button();
            this.txtApellidos = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAgregarEmpleado = new System.Windows.Forms.Label();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErrorMail2
            // 
            this.lblErrorMail2.AutoSize = true;
            this.lblErrorMail2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMail2.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMail2.Location = new System.Drawing.Point(176, 349);
            this.lblErrorMail2.Name = "lblErrorMail2";
            this.lblErrorMail2.Size = new System.Drawing.Size(162, 13);
            this.lblErrorMail2.TabIndex = 110;
            this.lblErrorMail2.Text = "Solo se puede ingresar un \"@\"";
            this.lblErrorMail2.Visible = false;
            // 
            // lblErrorMail
            // 
            this.lblErrorMail.AutoSize = true;
            this.lblErrorMail.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMail.Location = new System.Drawing.Point(176, 407);
            this.lblErrorMail.Name = "lblErrorMail";
            this.lblErrorMail.Size = new System.Drawing.Size(164, 13);
            this.lblErrorMail.TabIndex = 109;
            this.lblErrorMail.Text = "El correo ingresado es invalido";
            this.lblErrorMail.Visible = false;
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
            this.txtMail.Location = new System.Drawing.Point(174, 321);
            this.txtMail.Margin = new System.Windows.Forms.Padding(0);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PlaceholderText = "Correo Electronico";
            this.txtMail.SelectedText = "";
            this.txtMail.ShadowDecoration.Parent = this.txtMail;
            this.txtMail.Size = new System.Drawing.Size(190, 28);
            this.txtMail.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 108;
            this.label1.Text = "Correo:";
            // 
            // lblContadorApellidos
            // 
            this.lblContadorApellidos.AutoSize = true;
            this.lblContadorApellidos.BackColor = System.Drawing.Color.White;
            this.lblContadorApellidos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorApellidos.ForeColor = System.Drawing.Color.Gray;
            this.lblContadorApellidos.Location = new System.Drawing.Point(355, 109);
            this.lblContadorApellidos.Name = "lblContadorApellidos";
            this.lblContadorApellidos.Size = new System.Drawing.Size(29, 13);
            this.lblContadorApellidos.TabIndex = 101;
            this.lblContadorApellidos.Text = "0/50";
            // 
            // lblContadorNombres
            // 
            this.lblContadorNombres.AutoSize = true;
            this.lblContadorNombres.BackColor = System.Drawing.Color.White;
            this.lblContadorNombres.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorNombres.ForeColor = System.Drawing.Color.Gray;
            this.lblContadorNombres.Location = new System.Drawing.Point(355, 65);
            this.lblContadorNombres.Name = "lblContadorNombres";
            this.lblContadorNombres.Size = new System.Drawing.Size(29, 13);
            this.lblContadorNombres.TabIndex = 100;
            this.lblContadorNombres.Text = "0/50";
            // 
            // lblErrorEdad
            // 
            this.lblErrorEdad.AutoSize = true;
            this.lblErrorEdad.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEdad.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEdad.Location = new System.Drawing.Point(171, 174);
            this.lblErrorEdad.Name = "lblErrorEdad";
            this.lblErrorEdad.Size = new System.Drawing.Size(231, 13);
            this.lblErrorEdad.TabIndex = 99;
            this.lblErrorEdad.Text = "La edad no debe ser mayor a dos caracteres";
            this.lblErrorEdad.Visible = false;
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
            this.btnCancelar.Location = new System.Drawing.Point(331, 467);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(135, 45);
            this.btnCancelar.TabIndex = 98;
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
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(174, 467);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.ShadowDecoration.Parent = this.btnAgregarEmpleado;
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(135, 45);
            this.btnAgregarEmpleado.TabIndex = 87;
            this.btnAgregarEmpleado.Text = "Agregar Cliente";
            this.btnAgregarEmpleado.UseTransparentBackground = true;
            // 
            // txtClave
            // 
            this.txtClave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtClave.BorderRadius = 10;
            this.txtClave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClave.DefaultText = "";
            this.txtClave.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClave.DisabledState.Parent = this.txtClave;
            this.txtClave.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClave.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClave.FocusedState.Parent = this.txtClave;
            this.txtClave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtClave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClave.HoverState.Parent = this.txtClave;
            this.txtClave.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClave.Location = new System.Drawing.Point(174, 379);
            this.txtClave.Margin = new System.Windows.Forms.Padding(0);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '\0';
            this.txtClave.PlaceholderText = "";
            this.txtClave.SelectedText = "";
            this.txtClave.ShadowDecoration.Parent = this.txtClave;
            this.txtClave.Size = new System.Drawing.Size(225, 28);
            this.txtClave.TabIndex = 85;
            this.txtClave.UseSystemPasswordChar = true;
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
            this.txtTelefono.Location = new System.Drawing.Point(174, 229);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(0);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PlaceholderText = "Numero de Telefono (Sin guión)";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.ShadowDecoration.Parent = this.txtTelefono;
            this.txtTelefono.Size = new System.Drawing.Size(225, 28);
            this.txtTelefono.TabIndex = 83;
            // 
            // cmbGenero
            // 
            this.cmbGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.cmbGenero.BorderRadius = 10;
            this.cmbGenero.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGenero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGenero.FocusedState.Parent = this.cmbGenero;
            this.cmbGenero.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbGenero.HoverState.Parent = this.cmbGenero;
            this.cmbGenero.ItemHeight = 18;
            this.cmbGenero.Items.AddRange(new object[] {
            "Genero...",
            "Masculino",
            "Femenino"});
            this.cmbGenero.ItemsAppearance.Parent = this.cmbGenero;
            this.cmbGenero.Location = new System.Drawing.Point(174, 190);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(0);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.ShadowDecoration.Parent = this.cmbGenero;
            this.cmbGenero.Size = new System.Drawing.Size(179, 24);
            this.cmbGenero.StartIndex = 0;
            this.cmbGenero.TabIndex = 80;
            // 
            // txtEdad
            // 
            this.txtEdad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtEdad.BorderRadius = 10;
            this.txtEdad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdad.DefaultText = "";
            this.txtEdad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEdad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEdad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEdad.DisabledState.Parent = this.txtEdad;
            this.txtEdad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEdad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEdad.FocusedState.Parent = this.txtEdad;
            this.txtEdad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEdad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEdad.HoverState.Parent = this.txtEdad;
            this.txtEdad.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdad.Location = new System.Drawing.Point(174, 146);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(0);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.PasswordChar = '\0';
            this.txtEdad.PlaceholderText = "Edad";
            this.txtEdad.SelectedText = "";
            this.txtEdad.ShadowDecoration.Parent = this.txtEdad;
            this.txtEdad.Size = new System.Drawing.Size(68, 28);
            this.txtEdad.TabIndex = 79;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(26, 109);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(79, 21);
            this.lblApellidos.TabIndex = 96;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblHorasTrabajo
            // 
            this.lblHorasTrabajo.AutoSize = true;
            this.lblHorasTrabajo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTrabajo.Location = new System.Drawing.Point(26, 274);
            this.lblHorasTrabajo.Name = "lblHorasTrabajo";
            this.lblHorasTrabajo.Size = new System.Drawing.Size(120, 21);
            this.lblHorasTrabajo.TabIndex = 95;
            this.lblHorasTrabajo.Text = "Departamento:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(26, 229);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(78, 21);
            this.lblTelefono.TabIndex = 94;
            this.lblTelefono.Text = "Telefono:";
            this.lblTelefono.Click += new System.EventHandler(this.lblTelefono_Click);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(26, 379);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(92, 21);
            this.lblClave.TabIndex = 93;
            this.lblClave.Text = "Contraseña";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(26, 190);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 21);
            this.lblGenero.TabIndex = 92;
            this.lblGenero.Text = "Genero";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(26, 153);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(50, 21);
            this.lblEdad.TabIndex = 90;
            this.lblEdad.Text = "Edad:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(26, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 21);
            this.lblNombre.TabIndex = 88;
            this.lblNombre.Text = "Nombre:";
            // 
            // chbxViewPassword
            // 
            this.chbxViewPassword.CheckedState.Image = global::Fragata.UI.WF.Properties.Resources.viewer__1_;
            this.chbxViewPassword.CheckedState.Parent = this.chbxViewPassword;
            this.chbxViewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbxViewPassword.HoverState.Parent = this.chbxViewPassword;
            this.chbxViewPassword.Image = global::Fragata.UI.WF.Properties.Resources.viewer;
            this.chbxViewPassword.ImageOffset = new System.Drawing.Point(0, 0);
            this.chbxViewPassword.ImageRotate = 0F;
            this.chbxViewPassword.Location = new System.Drawing.Point(402, 379);
            this.chbxViewPassword.Name = "chbxViewPassword";
            this.chbxViewPassword.PressedState.Parent = this.chbxViewPassword;
            this.chbxViewPassword.ShadowDecoration.Parent = this.chbxViewPassword;
            this.chbxViewPassword.Size = new System.Drawing.Size(24, 22);
            this.chbxViewPassword.TabIndex = 106;
            // 
            // txtNombres
            // 
            this.txtNombres.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtNombres.BorderRadius = 10;
            this.txtNombres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombres.DefaultText = "";
            this.txtNombres.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombres.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombres.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombres.DisabledState.Parent = this.txtNombres;
            this.txtNombres.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombres.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombres.FocusedState.Parent = this.txtNombres;
            this.txtNombres.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombres.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombres.HoverState.Parent = this.txtNombres;
            this.txtNombres.IconRight = global::Fragata.UI.WF.Properties.Resources.icon;
            this.txtNombres.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombres.IconRightSize = new System.Drawing.Size(40, 20);
            this.txtNombres.Location = new System.Drawing.Point(174, 58);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(0);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.PlaceholderText = "Nombres";
            this.txtNombres.SelectedText = "";
            this.txtNombres.ShadowDecoration.Parent = this.txtNombres;
            this.txtNombres.Size = new System.Drawing.Size(225, 28);
            this.txtNombres.TabIndex = 77;
            // 
            // pboxImage
            // 
            this.pboxImage.BackColor = System.Drawing.Color.Transparent;
            this.pboxImage.BorderRadius = 20;
            this.pboxImage.Image = global::Fragata.UI.WF.Properties.Resources.mistery_man_gravatar_wordpress_avatar_persona_misteriosa_510x510;
            this.pboxImage.ImageRotate = 0F;
            this.pboxImage.Location = new System.Drawing.Point(437, 102);
            this.pboxImage.Name = "pboxImage";
            this.pboxImage.ShadowDecoration.Parent = this.pboxImage;
            this.pboxImage.Size = new System.Drawing.Size(172, 196);
            this.pboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxImage.TabIndex = 97;
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
            this.btnAgregarImagen.Location = new System.Drawing.Point(455, 304);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.ShadowDecoration.Parent = this.btnAgregarImagen;
            this.btnAgregarImagen.Size = new System.Drawing.Size(135, 45);
            this.btnAgregarImagen.TabIndex = 86;
            this.btnAgregarImagen.Text = "Agregar foto \r\n de perfil";
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
            this.txtApellidos.Location = new System.Drawing.Point(174, 102);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(0);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.PlaceholderText = "Apellidos";
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.ShadowDecoration.Parent = this.txtApellidos;
            this.txtApellidos.Size = new System.Drawing.Size(225, 28);
            this.txtApellidos.TabIndex = 78;
            // 
            // lblAgregarEmpleado
            // 
            this.lblAgregarEmpleado.AutoSize = true;
            this.lblAgregarEmpleado.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblAgregarEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblAgregarEmpleado.Location = new System.Drawing.Point(262, 9);
            this.lblAgregarEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.lblAgregarEmpleado.Name = "lblAgregarEmpleado";
            this.lblAgregarEmpleado.Size = new System.Drawing.Size(129, 21);
            this.lblAgregarEmpleado.TabIndex = 111;
            this.lblAgregarEmpleado.Text = "Agregar Cliente";
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Shapes1.FillColor = System.Drawing.Color.NavajoWhite;
            this.guna2Shapes1.Location = new System.Drawing.Point(0, 0);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.guna2Shapes1.Size = new System.Drawing.Size(627, 38);
            this.guna2Shapes1.TabIndex = 112;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 100;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.BorderRadius = 10;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 18;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Departamentos...",
            "Ahuachapán",
            "Cabañas",
            "Chalatenango",
            "Cuscatlán",
            "La Libertad",
            "Morazán",
            "La Paz",
            "Santa Ana",
            "San Miguel",
            "San Salvador",
            "San Vicente ",
            "Sonsonate",
            "La Unión",
            "Usulután"});
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Location = new System.Drawing.Point(174, 274);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(179, 24);
            this.guna2ComboBox1.StartIndex = 0;
            this.guna2ComboBox1.TabIndex = 113;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
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
            this.btnMinimize.FillColor = System.Drawing.Color.NavajoWhite;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.btnMinimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(255)))), ((int)(((byte)(117)))));
            this.btnMinimize.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Image = global::Fragata.UI.WF.Properties.Resources.minimized_hover;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = global::Fragata.UI.WF.Properties.Resources.remove;
            this.btnMinimize.ImageSize = new System.Drawing.Size(15, 15);
            this.btnMinimize.Location = new System.Drawing.Point(557, 9);
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
            this.btnClose.FillColor = System.Drawing.Color.NavajoWhite;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(69)))), ((int)(((byte)(70)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(255)))), ((int)(((byte)(117)))));
            this.btnClose.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.HoverState.Image = global::Fragata.UI.WF.Properties.Resources.close_hover;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = global::Fragata.UI.WF.Properties.Resources.close__2_;
            this.btnClose.ImageSize = new System.Drawing.Size(10, 10);
            this.btnClose.Location = new System.Drawing.Point(579, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0, 5, 3, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(252)))));
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 114;
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 542);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.lblAgregarEmpleado);
            this.Controls.Add(this.guna2Shapes1);
            this.Controls.Add(this.lblErrorMail2);
            this.Controls.Add(this.lblErrorMail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbxViewPassword);
            this.Controls.Add(this.lblContadorApellidos);
            this.Controls.Add(this.lblContadorNombres);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblErrorEdad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.pboxImage);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblHorasTrabajo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNombre);
            this.Name = "AgregarCliente";
            this.Text = "AgregarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorMail2;
        private System.Windows.Forms.Label lblErrorMail;
        private Guna.UI2.WinForms.Guna2TextBox txtMail;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox chbxViewPassword;
        private System.Windows.Forms.Label lblContadorApellidos;
        private System.Windows.Forms.Label lblContadorNombres;
        private Guna.UI2.WinForms.Guna2TextBox txtNombres;
        private System.Windows.Forms.Label lblErrorEdad;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnAgregarEmpleado;
        private Guna.UI2.WinForms.Guna2PictureBox pboxImage;
        private Guna.UI2.WinForms.Guna2Button btnAgregarImagen;
        private Guna.UI2.WinForms.Guna2TextBox txtClave;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGenero;
        private Guna.UI2.WinForms.Guna2TextBox txtEdad;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblHorasTrabajo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAgregarEmpleado;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}