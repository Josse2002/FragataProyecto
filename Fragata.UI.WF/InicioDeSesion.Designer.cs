
namespace Fragata.UI.WF
{
    partial class InicioDeSesion
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
            this.lblTittle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.errorIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCorreo = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.lblTittle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTittle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.White;
            this.lblTittle.Location = new System.Drawing.Point(12, 160);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(138, 28);
            this.lblTittle.TabIndex = 25;
            this.lblTittle.Text = "Iniciar Sesión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(13, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Por favor inicie sesion para continuar.";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(85, 392);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 71;
            this.guna2Button1.Text = "Ingresar";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(109, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 72;
            this.label2.Text = "¿Contraseña Olvidada?";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.lblError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.White;
            this.lblError.Location = new System.Drawing.Point(36, 337);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(101, 19);
            this.lblError.TabIndex = 74;
            this.lblError.Text = "ErrorMessage";
            this.lblError.Visible = false;
            // 
            // errorIcon
            // 
            this.errorIcon.Image = global::Fragata.UI.WF.Properties.Resources.cancel;
            this.errorIcon.ImageRotate = 0F;
            this.errorIcon.Location = new System.Drawing.Point(17, 337);
            this.errorIcon.Name = "errorIcon";
            this.errorIcon.ShadowDecoration.Parent = this.errorIcon;
            this.errorIcon.Size = new System.Drawing.Size(13, 19);
            this.errorIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.errorIcon.TabIndex = 75;
            this.errorIcon.TabStop = false;
            this.errorIcon.Visible = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2PictureBox1.Image = global::Fragata.UI.WF.Properties.Resources.close__2_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(333, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(15, 15);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 73;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.txtPassword.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.txtPassword.FocusedState.ForeColor = System.Drawing.Color.White;
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.txtPassword.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.txtPassword.HoverState.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.IconLeft = global::Fragata.UI.WF.Properties.Resources.padlock;
            this.txtPassword.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtPassword.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Location = new System.Drawing.Point(17, 284);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "Contraseña";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(316, 37);
            this.txtPassword.TabIndex = 70;
            this.txtPassword.TextOffset = new System.Drawing.Point(5, 0);
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.txtCorreo.BorderRadius = 10;
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.DefaultText = "";
            this.txtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreo.DisabledState.Parent = this.txtCorreo;
            this.txtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCorreo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.txtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.txtCorreo.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.txtCorreo.FocusedState.ForeColor = System.Drawing.Color.White;
            this.txtCorreo.FocusedState.Parent = this.txtCorreo;
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.txtCorreo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(48)))), ((int)(((byte)(77)))));
            this.txtCorreo.HoverState.ForeColor = System.Drawing.Color.White;
            this.txtCorreo.HoverState.Parent = this.txtCorreo;
            this.txtCorreo.IconLeft = global::Fragata.UI.WF.Properties.Resources.email;
            this.txtCorreo.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtCorreo.IconLeftSize = new System.Drawing.Size(15, 15);
            this.txtCorreo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.Location = new System.Drawing.Point(17, 234);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(0);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Padding = new System.Windows.Forms.Padding(5);
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.PlaceholderText = "Correo Electronico";
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.ShadowDecoration.Parent = this.txtCorreo;
            this.txtCorreo.Size = new System.Drawing.Size(316, 37);
            this.txtCorreo.TabIndex = 69;
            this.txtCorreo.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fragata.UI.WF.Properties.Resources._1630449230492;
            this.pictureBox1.Location = new System.Drawing.Point(76, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // InicioDeSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(360, 503);
            this.Controls.Add(this.errorIcon);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InicioDeSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioDeSesion";
          
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtCorreo;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblError;
        private Guna.UI2.WinForms.Guna2PictureBox errorIcon;
    }
}