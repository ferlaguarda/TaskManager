namespace TaskManager.Desktop.FormTareas
{
    partial class FrmCrearTarea
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
            components = new System.ComponentModel.Container();
            lblNombre = new Label();
            lblDuracion = new Label();
            lblDescripcion = new Label();
            lblExpiracion = new Label();
            lblPrioridad = new Label();
            lblResponsable = new Label();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            nudDuracion = new NumericUpDown();
            dtpExpiracion = new DateTimePicker();
            cboPrioridades = new ComboBox();
            cboResponsables = new ComboBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            equipoBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)nudDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)equipoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(46, 31);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(142, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre de la tarea:";
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Location = new Point(46, 301);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(111, 20);
            lblDuracion.TabIndex = 1;
            lblDuracion.Text = "Duración (Hrs.):";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(46, 97);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(185, 20);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción /Instrucciones:";
            // 
            // lblExpiracion
            // 
            lblExpiracion.AutoSize = true;
            lblExpiracion.Location = new Point(327, 301);
            lblExpiracion.Name = "lblExpiracion";
            lblExpiracion.Size = new Size(123, 20);
            lblExpiracion.TabIndex = 3;
            lblExpiracion.Text = "Fecha expiración:";
            // 
            // lblPrioridad
            // 
            lblPrioridad.AutoSize = true;
            lblPrioridad.Location = new Point(46, 392);
            lblPrioridad.Name = "lblPrioridad";
            lblPrioridad.Size = new Size(73, 20);
            lblPrioridad.TabIndex = 4;
            lblPrioridad.Text = "Prioridad:";
            // 
            // lblResponsable
            // 
            lblResponsable.AutoSize = true;
            lblResponsable.Location = new Point(327, 392);
            lblResponsable.Name = "lblResponsable";
            lblResponsable.Size = new Size(96, 20);
            lblResponsable.TabIndex = 8;
            lblResponsable.Text = "Responsable:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 54);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(509, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(100, 134);
            txtDescripcion.MaxLength = 500;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(509, 152);
            txtDescripcion.TabIndex = 1;
            // 
            // nudDuracion
            // 
            nudDuracion.Location = new Point(100, 336);
            nudDuracion.Maximum = new decimal(new int[] { 160, 0, 0, 0 });
            nudDuracion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDuracion.Name = "nudDuracion";
            nudDuracion.Size = new Size(102, 27);
            nudDuracion.TabIndex = 2;
            nudDuracion.TextAlign = HorizontalAlignment.Right;
            nudDuracion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtpExpiracion
            // 
            dtpExpiracion.Location = new Point(359, 333);
            dtpExpiracion.MinDate = new DateTime(2026, 10, 7, 16, 45, 34, 625);
            dtpExpiracion.Name = "dtpExpiracion";
            dtpExpiracion.Size = new Size(250, 27);
            dtpExpiracion.TabIndex = 3;
            dtpExpiracion.Value = new DateTime(2026, 10, 7, 16, 45, 34, 625);
            // 
            // cboPrioridades
            // 
            cboPrioridades.FormattingEnabled = true;
            cboPrioridades.Location = new Point(100, 429);
            cboPrioridades.Name = "cboPrioridades";
            cboPrioridades.Size = new Size(202, 28);
            cboPrioridades.TabIndex = 4;
            // 
            // cboResponsables
            // 
            cboResponsables.FormattingEnabled = true;
            cboResponsables.Location = new Point(359, 429);
            cboResponsables.Name = "cboResponsables";
            cboResponsables.Size = new Size(250, 28);
            cboResponsables.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(175, 482);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(127, 29);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(359, 482);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(127, 29);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "&Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += BtnGuardar_Click;
            // 
            // equipoBindingSource
            // 
            equipoBindingSource.DataSource = typeof(Task.Entities.Equipo);
            // 
            // FrmCrearTarea
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 558);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(cboResponsables);
            Controls.Add(cboPrioridades);
            Controls.Add(dtpExpiracion);
            Controls.Add(nudDuracion);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblResponsable);
            Controls.Add(lblPrioridad);
            Controls.Add(lblExpiracion);
            Controls.Add(lblDescripcion);
            Controls.Add(lblDuracion);
            Controls.Add(lblNombre);
            Name = "FrmCrearTarea";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar tarea";
            ((System.ComponentModel.ISupportInitialize)nudDuracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)equipoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblDuracion;
        private Label lblDescripcion;
        private Label lblExpiracion;
        private Label lblPrioridad;
        private Label lblResponsable;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private NumericUpDown nudDuracion;
        private DateTimePicker dtpExpiracion;
        private ComboBox cboPrioridades;
        private ComboBox cboResponsables;
        private Button btnCancelar;
        private Button btnGuardar;
        private BindingSource equipoBindingSource;
    }
}