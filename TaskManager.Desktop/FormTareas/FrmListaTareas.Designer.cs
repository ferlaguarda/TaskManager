namespace TaskManager.Desktop.FormTareas
{
    partial class FrmListaTareas
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
            dgvTareas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTareas).BeginInit();
            SuspendLayout();
            // 
            // dgvTareas
            // 
            dgvTareas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTareas.Location = new Point(37, 31);
            dgvTareas.Name = "dgvTareas";
            dgvTareas.RowHeadersWidth = 51;
            dgvTareas.Size = new Size(793, 284);
            dgvTareas.TabIndex = 0;
            // 
            // FrmListaTareas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 387);
            Controls.Add(dgvTareas);
            Name = "FrmListaTareas";
            Text = "LIsta de tareas";
            ((System.ComponentModel.ISupportInitialize)dgvTareas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTareas;
    }
}