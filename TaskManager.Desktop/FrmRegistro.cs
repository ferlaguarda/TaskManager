#region Using
using System.ComponentModel;
using Task.Entities;
using Task.Entities.Enumerators;
using Task.LogicaNegocio;
using TaskManager.Desktop.Helpers; 
#endregion

namespace TaskManager.Desktop
{
    public partial class FrmRegistro : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Cuenta NuevaCuenta { get; set; }

        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            if (!IsValidForm())
                return;
            ManagerAutenticacion managerAutenticacion = new ManagerAutenticacion();
            try
            {
                NuevaCuenta = managerAutenticacion
                        .CrearCuenta(txtNombre.Text, txtEmail.Text, txtPassword.Text);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private bool IsValidForm()
        {
            int errorCount = 0;
            if (!ValidatorHelper.IsValidRequieredTextBox(txtPassword, "Contraseña"))
                errorCount++;

            if (!ValidatorHelper.IsValidRequieredTextBox(txtEmail, "E-mail"))
                errorCount++;

            if (!ValidatorHelper.IsValidRequieredTextBox(txtNombre, "Nombre"))
                errorCount++;

            return errorCount == 0;
        }
    }
}
