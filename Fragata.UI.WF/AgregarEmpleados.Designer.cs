
namespace Fragata.UI.WF
{
    partial class AgregarEmpleados
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
            this.lblContadorNombres = new System.Windows.Forms.Label();
            this.lblErrorEdad = new System.Windows.Forms.Label();
            this.lblAgregarEmpleado = new System.Windows.Forms.Label();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.txtClave = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbCargo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDUI = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEdad = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblHorasTrabajo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDUI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblContadorApellidos = new System.Windows.Forms.Label();
            this.txtHorasTrabajo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblErrorHoras = new System.Windows.Forms.Label();
            this.lblDuiError = new System.Windows.Forms.Label();
            this.lblErrorDUI2 = new System.Windows.Forms.Label();
            this.lblErrorHoras2 = new System.Windows.Forms.Label();
            this.cmbGenero = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAgregarEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.chbxViewPassword = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.txtNombres = new Guna.UI2.WinForms.Guna2TextBox();
            this.pboxImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAgregarImagen = new Guna.UI2.WinForms.Guna2Button();
            this.txtApellidos = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErrorMail = new System.Windows.Forms.Label();
            this.lblErrorMail2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContadorNombres
            // 
            this.lblContadorNombres.AutoSize = true;
            this.lblContadorNombres.BackColor = System.Drawing.Color.White;
            this.lblContadorNombres.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorNombres.ForeColor = System.Drawing.Color.Gray;
            this.lblContadorNombres.Location = new System.Drawing.Point(350, 85);
            this.lblContadorNombres.Name = "lblContadorNombres";
            this.lblContadorNombres.Size = new System.Drawing.Size(29, 13);
            this.lblContadorNombres.TabIndex = 64;
            this.lblContadorNombres.Text = "0/50";
            // 
            // lblErrorEdad
            // 
            this.lblErrorEdad.AutoSize = true;
            this.lblErrorEdad.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEdad.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEdad.Location = new System.Drawing.Point(166, 194);
            this.lblErrorEdad.Name = "lblErrorEdad";
            this.lblErrorEdad.Size = new System.Drawing.Size(231, 13);
            this.lblErrorEdad.TabIndex = 63;
            this.lblErrorEdad.Text = "La edad no debe ser mayor a dos caracteres";
            this.lblErrorEdad.Visible = false;
            // 
            // lblAgregarEmpleado
            // 
            this.lblAgregarEmpleado.AutoSize = true;
            this.lblAgregarEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(252)))));
            this.lblAgregarEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarEmpleado.ForeColor = System.Drawing.Color.White;
            this.lblAgregarEmpleado.Location = new System.Drawing.Point(245, 9);
            this.lblAgregarEmpleado.Margin = new System.Windows.Forms.Padding(0);
            this.lblAgregarEmpleado.Name = "lblAgregarEmpleado";
            this.lblAgregarEmpleado.Size = new System.Drawing.Size(152, 21);
            this.lblAgregarEmpleado.TabIndex = 40;
            this.lblAgregarEmpleado.Text = "Agregar Empleado";
            this.lblAgregarEmpleado.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAgregarEmpleado_MouseDown);
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(252)))));
            this.guna2Shapes1.Location = new System.Drawing.Point(0, 0);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.guna2Shapes1.Size = new System.Drawing.Size(627, 38);
            this.guna2Shapes1.TabIndex = 62;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 100;
            this.guna2Shapes1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAgregarEmpleado_MouseDown);
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
            this.btnCancelar.Location = new System.Drawing.Point(323, 532);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(135, 45);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseTransparentBackground = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.txtClave.Location = new System.Drawing.Point(166, 481);
            this.txtClave.Margin = new System.Windows.Forms.Padding(0);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '\0';
            this.txtClave.PlaceholderText = "";
            this.txtClave.SelectedText = "";
            this.txtClave.ShadowDecoration.Parent = this.txtClave;
            this.txtClave.Size = new System.Drawing.Size(225, 28);
            this.txtClave.TabIndex = 8;
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
            this.txtTelefono.Location = new System.Drawing.Point(169, 334);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(0);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.PlaceholderText = "Numero de Telefono (Sin guión)";
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.ShadowDecoration.Parent = this.txtTelefono;
            this.txtTelefono.Size = new System.Drawing.Size(225, 28);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress_1);
            // 
            // cmbCargo
            // 
            this.cmbCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.cmbCargo.BorderRadius = 10;
            this.cmbCargo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCargo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCargo.FocusedState.Parent = this.cmbCargo;
            this.cmbCargo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbCargo.HoverState.Parent = this.cmbCargo;
            this.cmbCargo.ItemHeight = 18;
            this.cmbCargo.Items.AddRange(new object[] {
            "Cargo...",
            "Cajero",
            "Gestor de ventas",
            "Atencion al cliente",
            "Atencion web"});
            this.cmbCargo.ItemsAppearance.Parent = this.cmbCargo;
            this.cmbCargo.Location = new System.Drawing.Point(169, 294);
            this.cmbCargo.Margin = new System.Windows.Forms.Padding(0);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.ShadowDecoration.Parent = this.cmbCargo;
            this.cmbCargo.Size = new System.Drawing.Size(179, 24);
            this.cmbCargo.StartIndex = 0;
            this.cmbCargo.TabIndex = 5;
            // 
            // txtDUI
            // 
            this.txtDUI.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtDUI.BorderRadius = 10;
            this.txtDUI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDUI.DefaultText = "";
            this.txtDUI.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDUI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDUI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDUI.DisabledState.Parent = this.txtDUI;
            this.txtDUI.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDUI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDUI.FocusedState.Parent = this.txtDUI;
            this.txtDUI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDUI.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDUI.HoverState.Parent = this.txtDUI;
            this.txtDUI.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDUI.Location = new System.Drawing.Point(169, 250);
            this.txtDUI.Margin = new System.Windows.Forms.Padding(0);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.PasswordChar = '\0';
            this.txtDUI.PlaceholderText = "Ingrese su DUI (Con guión)";
            this.txtDUI.SelectedText = "";
            this.txtDUI.ShadowDecoration.Parent = this.txtDUI;
            this.txtDUI.Size = new System.Drawing.Size(225, 28);
            this.txtDUI.TabIndex = 4;
            this.txtDUI.TextChanged += new System.EventHandler(this.txtDUI_TextChanged);
            this.txtDUI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDUI_KeyPress_1);
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
            this.txtEdad.Location = new System.Drawing.Point(169, 166);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(0);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.PasswordChar = '\0';
            this.txtEdad.PlaceholderText = "Edad";
            this.txtEdad.SelectedText = "";
            this.txtEdad.ShadowDecoration.Parent = this.txtEdad;
            this.txtEdad.Size = new System.Drawing.Size(68, 28);
            this.txtEdad.TabIndex = 2;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress_1);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(21, 129);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(79, 21);
            this.lblApellidos.TabIndex = 49;
            this.lblApellidos.Text = "Apellidos";
            // 
            // lblHorasTrabajo
            // 
            this.lblHorasTrabajo.AutoSize = true;
            this.lblHorasTrabajo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorasTrabajo.Location = new System.Drawing.Point(18, 378);
            this.lblHorasTrabajo.Name = "lblHorasTrabajo";
            this.lblHorasTrabajo.Size = new System.Drawing.Size(138, 21);
            this.lblHorasTrabajo.TabIndex = 48;
            this.lblHorasTrabajo.Text = "Horas de Trabajo:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(18, 341);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(78, 21);
            this.lblTelefono.TabIndex = 47;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(12, 485);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(92, 21);
            this.lblClave.TabIndex = 46;
            this.lblClave.Text = "Contraseña";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(21, 210);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(64, 21);
            this.lblGenero.TabIndex = 45;
            this.lblGenero.Text = "Genero";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(21, 297);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(58, 21);
            this.lblCargo.TabIndex = 44;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(21, 173);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(50, 21);
            this.lblEdad.TabIndex = 43;
            this.lblEdad.Text = "Edad:";
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUI.Location = new System.Drawing.Point(21, 257);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(41, 21);
            this.lblDUI.TabIndex = 42;
            this.lblDUI.Text = "DUI:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(21, 85);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(75, 21);
            this.lblNombre.TabIndex = 41;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblContadorApellidos
            // 
            this.lblContadorApellidos.AutoSize = true;
            this.lblContadorApellidos.BackColor = System.Drawing.Color.White;
            this.lblContadorApellidos.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContadorApellidos.ForeColor = System.Drawing.Color.Gray;
            this.lblContadorApellidos.Location = new System.Drawing.Point(350, 129);
            this.lblContadorApellidos.Name = "lblContadorApellidos";
            this.lblContadorApellidos.Size = new System.Drawing.Size(29, 13);
            this.lblContadorApellidos.TabIndex = 66;
            this.lblContadorApellidos.Text = "0/50";
            // 
            // txtHorasTrabajo
            // 
            this.txtHorasTrabajo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.txtHorasTrabajo.BorderRadius = 10;
            this.txtHorasTrabajo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHorasTrabajo.DefaultText = "";
            this.txtHorasTrabajo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHorasTrabajo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHorasTrabajo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHorasTrabajo.DisabledState.Parent = this.txtHorasTrabajo;
            this.txtHorasTrabajo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHorasTrabajo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHorasTrabajo.FocusedState.Parent = this.txtHorasTrabajo;
            this.txtHorasTrabajo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHorasTrabajo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHorasTrabajo.HoverState.Parent = this.txtHorasTrabajo;
            this.txtHorasTrabajo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHorasTrabajo.Location = new System.Drawing.Point(169, 378);
            this.txtHorasTrabajo.Margin = new System.Windows.Forms.Padding(0);
            this.txtHorasTrabajo.Name = "txtHorasTrabajo";
            this.txtHorasTrabajo.PasswordChar = '\0';
            this.txtHorasTrabajo.PlaceholderText = "Horas de Trabajo (A la semana)";
            this.txtHorasTrabajo.SelectedText = "";
            this.txtHorasTrabajo.ShadowDecoration.Parent = this.txtHorasTrabajo;
            this.txtHorasTrabajo.Size = new System.Drawing.Size(190, 28);
            this.txtHorasTrabajo.TabIndex = 7;
            this.txtHorasTrabajo.TextChanged += new System.EventHandler(this.txtHorasTrabajo_TextChanged);
            this.txtHorasTrabajo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHorasTrabajo_KeyPress);
            // 
            // lblErrorHoras
            // 
            this.lblErrorHoras.AutoSize = true;
            this.lblErrorHoras.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorHoras.ForeColor = System.Drawing.Color.Red;
            this.lblErrorHoras.Location = new System.Drawing.Point(221, 406);
            this.lblErrorHoras.Name = "lblErrorHoras";
            this.lblErrorHoras.Size = new System.Drawing.Size(298, 13);
            this.lblErrorHoras.TabIndex = 68;
            this.lblErrorHoras.Text = "Las horas de trabajo solo pueden llevar un punto decimal";
            this.lblErrorHoras.Visible = false;
            // 
            // lblDuiError
            // 
            this.lblDuiError.AutoSize = true;
            this.lblDuiError.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuiError.ForeColor = System.Drawing.Color.Red;
            this.lblDuiError.Location = new System.Drawing.Point(166, 278);
            this.lblDuiError.Name = "lblDuiError";
            this.lblDuiError.Size = new System.Drawing.Size(157, 13);
            this.lblDuiError.TabIndex = 69;
            this.lblDuiError.Text = "El DUI ingresado no es valido";
            this.lblDuiError.Visible = false;
            // 
            // lblErrorDUI2
            // 
            this.lblErrorDUI2.AutoSize = true;
            this.lblErrorDUI2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDUI2.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDUI2.Location = new System.Drawing.Point(169, 278);
            this.lblErrorDUI2.Name = "lblErrorDUI2";
            this.lblErrorDUI2.Size = new System.Drawing.Size(157, 13);
            this.lblErrorDUI2.TabIndex = 70;
            this.lblErrorDUI2.Text = "El DUI ingresado no es valido";
            this.lblErrorDUI2.Visible = false;
            // 
            // lblErrorHoras2
            // 
            this.lblErrorHoras2.AutoSize = true;
            this.lblErrorHoras2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorHoras2.ForeColor = System.Drawing.Color.Red;
            this.lblErrorHoras2.Location = new System.Drawing.Point(166, 406);
            this.lblErrorHoras2.Name = "lblErrorHoras2";
            this.lblErrorHoras2.Size = new System.Drawing.Size(157, 13);
            this.lblErrorHoras2.TabIndex = 71;
            this.lblErrorHoras2.Text = "El DUI ingresado no es valido";
            this.lblErrorHoras2.Visible = false;
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
            this.cmbGenero.Location = new System.Drawing.Point(169, 210);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(0);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.ShadowDecoration.Parent = this.cmbGenero;
            this.cmbGenero.Size = new System.Drawing.Size(179, 24);
            this.cmbGenero.StartIndex = 0;
            this.cmbGenero.TabIndex = 3;
            this.cmbGenero.SelectedIndexChanged += new System.EventHandler(this.cmbGenero_SelectedIndexChanged);
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
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(169, 532);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.ShadowDecoration.Parent = this.btnAgregarEmpleado;
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(135, 45);
            this.btnAgregarEmpleado.TabIndex = 10;
            this.btnAgregarEmpleado.Text = "Agregar Empleado";
            this.btnAgregarEmpleado.UseTransparentBackground = true;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
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
            this.chbxViewPassword.Location = new System.Drawing.Point(394, 485);
            this.chbxViewPassword.Name = "chbxViewPassword";
            this.chbxViewPassword.PressedState.Parent = this.chbxViewPassword;
            this.chbxViewPassword.ShadowDecoration.Parent = this.chbxViewPassword;
            this.chbxViewPassword.Size = new System.Drawing.Size(24, 24);
            this.chbxViewPassword.TabIndex = 72;
            this.chbxViewPassword.CheckedChanged += new System.EventHandler(this.chbxViewPassword_CheckedChanged);
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
            this.txtNombres.Location = new System.Drawing.Point(169, 78);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(0);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.PasswordChar = '\0';
            this.txtNombres.PlaceholderText = "Nombres";
            this.txtNombres.SelectedText = "";
            this.txtNombres.ShadowDecoration.Parent = this.txtNombres;
            this.txtNombres.Size = new System.Drawing.Size(225, 28);
            this.txtNombres.TabIndex = 0;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress_1);
            // 
            // pboxImage
            // 
            this.pboxImage.BackColor = System.Drawing.Color.Transparent;
            this.pboxImage.BorderRadius = 20;
            this.pboxImage.Image = global::Fragata.UI.WF.Properties.Resources.mistery_man_gravatar_wordpress_avatar_persona_misteriosa_510x510;
            this.pboxImage.ImageRotate = 0F;
            this.pboxImage.Location = new System.Drawing.Point(432, 122);
            this.pboxImage.Name = "pboxImage";
            this.pboxImage.ShadowDecoration.Parent = this.pboxImage;
            this.pboxImage.Size = new System.Drawing.Size(172, 196);
            this.pboxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxImage.TabIndex = 59;
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
            this.btnAgregarImagen.Location = new System.Drawing.Point(450, 324);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.ShadowDecoration.Parent = this.btnAgregarImagen;
            this.btnAgregarImagen.Size = new System.Drawing.Size(135, 45);
            this.btnAgregarImagen.TabIndex = 9;
            this.btnAgregarImagen.Text = "Agregar foto \r\n de perfil";
            this.btnAgregarImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAgregarImagen.UseTransparentBackground = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
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
            this.txtApellidos.Location = new System.Drawing.Point(169, 122);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(0);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.PasswordChar = '\0';
            this.txtApellidos.PlaceholderText = "Apellidos";
            this.txtApellidos.SelectedText = "";
            this.txtApellidos.ShadowDecoration.Parent = this.txtApellidos;
            this.txtApellidos.Size = new System.Drawing.Size(225, 28);
            this.txtApellidos.TabIndex = 1;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress_1);
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
            this.txtMail.Location = new System.Drawing.Point(169, 434);
            this.txtMail.Margin = new System.Windows.Forms.Padding(0);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PlaceholderText = "Correo Electronico";
            this.txtMail.SelectedText = "";
            this.txtMail.ShadowDecoration.Parent = this.txtMail;
            this.txtMail.Size = new System.Drawing.Size(190, 28);
            this.txtMail.TabIndex = 73;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 74;
            this.label1.Text = "Correo:";
            // 
            // lblErrorMail
            // 
            this.lblErrorMail.AutoSize = true;
            this.lblErrorMail.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMail.Location = new System.Drawing.Point(169, 462);
            this.lblErrorMail.Name = "lblErrorMail";
            this.lblErrorMail.Size = new System.Drawing.Size(164, 13);
            this.lblErrorMail.TabIndex = 75;
            this.lblErrorMail.Text = "El correo ingresado es invalido";
            this.lblErrorMail.Visible = false;
            // 
            // lblErrorMail2
            // 
            this.lblErrorMail2.AutoSize = true;
            this.lblErrorMail2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMail2.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMail2.Location = new System.Drawing.Point(171, 462);
            this.lblErrorMail2.Name = "lblErrorMail2";
            this.lblErrorMail2.Size = new System.Drawing.Size(162, 13);
            this.lblErrorMail2.TabIndex = 76;
            this.lblErrorMail2.Text = "Solo se puede ingresar un \"@\"";
            this.lblErrorMail2.Visible = false;
            // 
            // AgregarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 589);
            this.Controls.Add(this.lblErrorMail2);
            this.Controls.Add(this.lblErrorMail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbxViewPassword);
            this.Controls.Add(this.lblErrorHoras2);
            this.Controls.Add(this.lblErrorDUI2);
            this.Controls.Add(this.lblDuiError);
            this.Controls.Add(this.lblErrorHoras);
            this.Controls.Add(this.txtHorasTrabajo);
            this.Controls.Add(this.lblContadorApellidos);
            this.Controls.Add(this.lblContadorNombres);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblErrorEdad);
            this.Controls.Add(this.lblAgregarEmpleado);
            this.Controls.Add(this.guna2Shapes1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.pboxImage);
            this.Controls.Add(this.btnAgregarImagen);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.cmbCargo);
            this.Controls.Add(this.txtDUI);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblHorasTrabajo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblDUI);
            this.Controls.Add(this.lblNombre);
            this.MinimumSize = new System.Drawing.Size(643, 560);
            this.Name = "AgregarEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarEmpleados";
            this.Shown += new System.EventHandler(this.AgregarEmpleados_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAgregarEmpleado_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtNombres;
        private System.Windows.Forms.Label lblContadorNombres;
        private System.Windows.Forms.Label lblErrorEdad;
        private System.Windows.Forms.Label lblAgregarEmpleado;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2PictureBox pboxImage;
        private Guna.UI2.WinForms.Guna2Button btnAgregarImagen;
        private Guna.UI2.WinForms.Guna2TextBox txtClave;
        private Guna.UI2.WinForms.Guna2TextBox txtTelefono;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCargo;
        private Guna.UI2.WinForms.Guna2TextBox txtDUI;
        private Guna.UI2.WinForms.Guna2TextBox txtEdad;
        private Guna.UI2.WinForms.Guna2TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblHorasTrabajo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblContadorApellidos;
        private Guna.UI2.WinForms.Guna2TextBox txtHorasTrabajo;
        private System.Windows.Forms.Label lblErrorHoras;
        private System.Windows.Forms.Label lblDuiError;
        private System.Windows.Forms.Label lblErrorDUI2;
        private System.Windows.Forms.Label lblErrorHoras2;
        private Guna.UI2.WinForms.Guna2ImageCheckBox chbxViewPassword;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGenero;
        private Guna.UI2.WinForms.Guna2Button btnAgregarEmpleado;
        private Guna.UI2.WinForms.Guna2TextBox txtMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErrorMail;
        private System.Windows.Forms.Label lblErrorMail2;
    }
}