#region Using
using Task.Entities;
using TaskManager.Desktop.FormTareas; 
#endregion

namespace TaskManager.Desktop
{
    public partial class FrmMain : Form
    {
        private Cuenta _miCuenta;
        public FrmMain(Cuenta cuenta)
        {
            InitializeComponent();
            _miCuenta = cuenta;
            if (_miCuenta.TipoCuenta == Task.Entities.Enumerators.TipoCuenta.Personal)
                tsmiEquipos.Visible = false;

        }

        private void TsmiSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void TsmiLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiCrearTarea_Click(object sender, EventArgs e)
        {
            FrmCrearTarea frmCrearTarea = new FrmCrearTarea(_miCuenta.Id);
            DialogResult result = frmCrearTarea.ShowDialog();
        }

        private void tsmiConsultarTarea_Click(object sender, EventArgs e)
        {
            FrmListaTareas frmCrearTarea = new FrmListaTareas(_miCuenta.Tareas);
            frmCrearTarea.MdiParent = this;
            frmCrearTarea.Show();
        }
    }
}
