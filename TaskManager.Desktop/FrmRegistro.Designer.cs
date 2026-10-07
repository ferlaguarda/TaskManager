namespace TaskManager.Desktop
{
    partial class FrmRegistro
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
            btnConfirmar = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblPassword = new Label();
            lblEmail = new Label();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(272, 237);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(106, 29);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "&Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += BtnConfirmar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(77, 185);
            txtPassword.MaxLength = 16;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(376, 27);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "admin1234";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(77, 122);
            txtEmail.MaxLength = 100;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(376, 27);
            txtEmail.TabIndex = 4;
            txtEmail.Text = "pruebita@gmail.com";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(49, 162);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(106, 20);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Contraseña (*):";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(49, 99);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(75, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "E-Mail (*):";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(121, 237);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(106, 29);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "C&ancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(77, 60);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(376, 27);
            txtNombre.TabIndex = 10;
            txtNombre.Text = "Pedro Mendoza";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(49, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(154, 20);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Ingrese su nombre (*):";
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 295);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnConfirmar);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(btnCancelar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmar;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lblPassword;
        private Label lblEmail;
        private Button btnCancelar;
        private TextBox txtNombre;
        private Label lblNombre;
    }
}