#region Using
using Task.Entities;
using TaskManager.Desktop.Helpers; 
#endregion

namespace TaskManager.Desktop
{
    public partial class FrmLogin : Form
    {
        private List<Cuenta> _cuentasCreadas;
        public FrmLogin()
        {
            InitializeComponent();
            _cuentasCreadas = [];
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (!IsValidForm())
                return;

            bool credencialesValidas = false;
            Cuenta? miCuenta = null;
            foreach (var cuenta in _cuentasCreadas)
            {
                if (cuenta.Owner.Email == txtEmail.Text)
                {
                    if (cuenta.Owner.Password == txtPassword.Text)
                    {
                        credencialesValidas = true;
                        miCuenta = cuenta;
                        break;
                    }
                }
            }
            if (credencialesValidas)
            {
                if (miCuenta != null)
                {
                    FrmMain frmMain = new FrmMain(miCuenta);
                    this.Hide();
                    DialogResult result = frmMain.ShowDialog();
                    if(result == DialogResult.Cancel)
                    {
                        this.Show();
                    }
                    else if(result == DialogResult.Abort)
                    {
                        Application.Exit();
                    }
                }
            }
            else
                MessageBox.Show($"Los datos proporcionados no son validos.",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void LinkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro frmRegistro = new();
            var result = frmRegistro.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtEmail.Text = frmRegistro.NuevaCuenta.Owner.Email;
                _cuentasCreadas.Add(frmRegistro.NuevaCuenta);
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
