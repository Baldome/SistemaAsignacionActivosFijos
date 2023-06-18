namespace Sistema_de_Asignacion_de_Activos_Fijos
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogo = new System.Windows.Forms.Panel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.lnklblRecuperaContrasenia = new System.Windows.Forms.LinkLabel();
            this.btnAcceder = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.txtPassword = new CustomBox.RJControls.RJTextBox();
            this.txtUsuario = new CustomBox.RJControls.RJTextBox();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.panelLogo.Controls.Add(this.iconPictureBox3);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 330);
            this.panelLogo.TabIndex = 1;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.PhoenixSquadron;
            this.iconPictureBox3.IconColor = System.Drawing.Color.White;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 160;
            this.iconPictureBox3.Location = new System.Drawing.Point(45, 80);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(160, 160);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox3.TabIndex = 0;
            this.iconPictureBox3.TabStop = false;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelLogin.Controls.Add(this.txtPassword);
            this.panelLogin.Controls.Add(this.txtUsuario);
            this.panelLogin.Controls.Add(this.btnMinimizar);
            this.panelLogin.Controls.Add(this.btnCerrar);
            this.panelLogin.Controls.Add(this.lnklblRecuperaContrasenia);
            this.panelLogin.Controls.Add(this.btnAcceder);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.iconPictureBox2);
            this.panelLogin.Controls.Add(this.iconPictureBox1);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(250, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(530, 330);
            this.panelLogin.TabIndex = 2;
            this.panelLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogin_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.White;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMinimizar.IconSize = 28;
            this.btnMinimizar.Location = new System.Drawing.Point(471, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 16;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCerrar.IconSize = 28;
            this.btnCerrar.Location = new System.Drawing.Point(500, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 15;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lnklblRecuperaContrasenia
            // 
            this.lnklblRecuperaContrasenia.AutoSize = true;
            this.lnklblRecuperaContrasenia.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblRecuperaContrasenia.LinkColor = System.Drawing.Color.White;
            this.lnklblRecuperaContrasenia.Location = new System.Drawing.Point(179, 288);
            this.lnklblRecuperaContrasenia.Name = "lnklblRecuperaContrasenia";
            this.lnklblRecuperaContrasenia.Size = new System.Drawing.Size(155, 16);
            this.lnklblRecuperaContrasenia.TabIndex = 14;
            this.lnklblRecuperaContrasenia.TabStop = true;
            this.lnklblRecuperaContrasenia.Text = "¿Olvidaste la contraseña?";
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(58)))), ((int)(((byte)(87)))));
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(58)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.Color.White;
            this.btnAcceder.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAcceder.IconColor = System.Drawing.Color.Black;
            this.btnAcceder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAcceder.Location = new System.Drawing.Point(30, 223);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(451, 46);
            this.btnAcceder.TabIndex = 13;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(202, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "LOGIN";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox2.IconColor = System.Drawing.Color.White;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 50;
            this.iconPictureBox2.Location = new System.Drawing.Point(30, 140);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(50, 50);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox2.TabIndex = 11;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 50;
            this.iconPictureBox1.Location = new System.Drawing.Point(30, 52);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(50, 50);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 10;
            this.iconPictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtPassword.BorderColor = System.Drawing.Color.White;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.BorderRadius = 0;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(87, 148);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.White;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.Size = new System.Drawing.Size(394, 36);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.txtUsuario.BorderColor = System.Drawing.Color.White;
            this.txtUsuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUsuario.BorderRadius = 0;
            this.txtUsuario.BorderSize = 2;
            this.txtUsuario.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(87, 60);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.PlaceholderColor = System.Drawing.Color.White;
            this.txtUsuario.PlaceholderText = "";
            this.txtUsuario.Size = new System.Drawing.Size(394, 36);
            this.txtUsuario.TabIndex = 17;
            this.txtUsuario.Texts = "";
            this.txtUsuario.UnderlinedStyle = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Panel panelLogin;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.LinkLabel lnklblRecuperaContrasenia;
        private FontAwesome.Sharp.IconButton btnAcceder;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private CustomBox.RJControls.RJTextBox txtPassword;
        private CustomBox.RJControls.RJTextBox txtUsuario;
    }
}

