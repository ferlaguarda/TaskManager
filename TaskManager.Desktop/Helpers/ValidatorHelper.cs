namespace TaskManager.Desktop.Helpers
{
    internal static class ValidatorHelper
    {
        internal static bool IsValidRequieredTextBox(TextBox textBox,
            string campoValidado)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show($"El campo {campoValidado} es obligatorio.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
