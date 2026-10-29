#region Using
using Task.Entities;
using Task.LogicaNegocio;
using TaskManager.Desktop.Helpers; 
#endregion

namespace TaskManager.Desktop
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (!IsValidForm())
                return;

            ManagerAutenticacion managerAutenticacion = new ManagerAutenticacion();
            try
            {
                Cuenta miCuenta = managerAutenticacion.Login(txtPassword.Text, txtEmail.Text);
                FrmMain frmMain = new FrmMain(miCuenta);
                this.Hide();
                DialogResult result = frmMain.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    this.Show();
                }
                else if (result == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void LinkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro frmRegistro = new();
            var result = frmRegistro.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEmail.Text = frmRegistro.NuevaCuenta.Owner.Email;
            }
        }
        private bool IsValidForm()
        {
            int errorCount = 0;
            if (!ValidatorHelper.IsValidRequieredTextBox(txtPassword, "Contraseña"))
                errorCount++;

            if (!ValidatorHelper.IsValidRequieredTextBox(txtEmail, "E-mail"))
                errorCount++;

            return errorCount == 0;
        }

    }
}
