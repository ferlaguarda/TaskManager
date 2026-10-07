namespace TaskManager.Desktop
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalir = new Button();
            lblEmail = new Label();
            lblPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnEntrar = new Button();
            linkRegistro = new LinkLabel();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(98, 175);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(106, 29);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += BtnSalir_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(26, 37);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(75, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-Mail (*):";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(26, 100);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(106, 20);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Contraseña (*):";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(54, 60);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(376, 27);
            txtEmail.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(54, 123);
            txtPassword.MaxLength = 16;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(376, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(249, 175);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(106, 29);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "&Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += BtnEntrar_Click;
            // 
            // linkRegistro
            // 
            linkRegistro.AutoSize = true;
            linkRegistro.Location = new Point(354, 218);
            linkRegistro.Name = "linkRegistro";
            linkRegistro.Size = new Size(113, 20);
            linkRegistro.TabIndex = 4;
            linkRegistro.TabStop = true;
            linkRegistro.Text = "Crear mi cuenta";
            linkRegistro.LinkClicked += LinkRegistro_LinkClicked;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 277);
            Controls.Add(linkRegistro);
            Controls.Add(btnEntrar);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnEntrar;
        private LinkLabel linkRegistro;
    }
}
