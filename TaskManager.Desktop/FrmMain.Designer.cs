namespace TaskManager.Desktop
{
    partial class FrmMain
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
            menuStrip1 = new MenuStrip();
            tsmiTareas = new ToolStripMenuItem();
            tsmiCrearTarea = new ToolStripMenuItem();
            tsmiConsultarTarea = new ToolStripMenuItem();
            tsmiUsuarios = new ToolStripMenuItem();
            tsmiEquipos = new ToolStripMenuItem();
            tsmiMiCuenta = new ToolStripMenuItem();
            tsmiMisDatos = new ToolStripMenuItem();
            tsmiLogout = new ToolStripMenuItem();
            tsmiSalir = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiTareas, tsmiUsuarios, tsmiEquipos, tsmiMiCuenta });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1121, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiTareas
            // 
            tsmiTareas.DropDownItems.AddRange(new ToolStripItem[] { tsmiCrearTarea, tsmiConsultarTarea });
            tsmiTareas.Name = "tsmiTareas";
            tsmiTareas.Size = new Size(64, 24);
            tsmiTareas.Text = "Tareas";
            // 
            // tsmiCrearTarea
            // 
            tsmiCrearTarea.Name = "tsmiCrearTarea";
            tsmiCrearTarea.Size = new Size(224, 26);
            tsmiCrearTarea.Text = "Crear";
            tsmiCrearTarea.Click += tsmiCrearTarea_Click;
            // 
            // tsmiConsultarTarea
            // 
            tsmiConsultarTarea.Name = "tsmiConsultarTarea";
            tsmiConsultarTarea.Size = new Size(224, 26);
            tsmiConsultarTarea.Text = "Consultar";
            tsmiConsultarTarea.Click += tsmiConsultarTarea_Click;
            // 
            // tsmiUsuarios
            // 
            tsmiUsuarios.Name = "tsmiUsuarios";
            tsmiUsuarios.Size = new Size(79, 24);
            tsmiUsuarios.Text = "Usuarios";
            // 
            // tsmiEquipos
            // 
            tsmiEquipos.Name = "tsmiEquipos";
            tsmiEquipos.Size = new Size(76, 24);
            tsmiEquipos.Text = "Equipos";
            // 
            // tsmiMiCuenta
            // 
            tsmiMiCuenta.DropDownItems.AddRange(new ToolStripItem[] { tsmiMisDatos, tsmiLogout, tsmiSalir });
            tsmiMiCuenta.Name = "tsmiMiCuenta";
            tsmiMiCuenta.Size = new Size(88, 24);
            tsmiMiCuenta.Text = "Mi cuenta";
            // 
            // tsmiMisDatos
            // 
            tsmiMisDatos.Name = "tsmiMisDatos";
            tsmiMisDatos.Size = new Size(156, 26);
            tsmiMisDatos.Text = "Mis datos";
            // 
            // tsmiLogout
            // 
            tsmiLogout.Name = "tsmiLogout";
            tsmiLogout.Size = new Size(156, 26);
            tsmiLogout.Text = "Logout";
            tsmiLogout.Click += TsmiLogout_Click;
            // 
            // tsmiSalir
            // 
            tsmiSalir.Name = "tsmiSalir";
            tsmiSalir.Size = new Size(156, 26);
            tsmiSalir.Text = "Salir";
            tsmiSalir.Click += TsmiSalir_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 657);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Manager";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiTareas;
        private ToolStripMenuItem tsmiCrearTarea;
        private ToolStripMenuItem tsmiConsultarTarea;
        private ToolStripMenuItem tsmiUsuarios;
        private ToolStripMenuItem tsmiEquipos;
        private ToolStripMenuItem tsmiMiCuenta;
        private ToolStripMenuItem tsmiMisDatos;
        private ToolStripMenuItem tsmiLogout;
        private ToolStripMenuItem tsmiSalir;
    }
}