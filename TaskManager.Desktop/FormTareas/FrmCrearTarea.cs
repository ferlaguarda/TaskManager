using Task.Entities;
using Task.LogicaNegocio;

namespace TaskManager.Desktop.FormTareas
{
    public partial class FrmCrearTarea : Form
    {
        public Tarea NuevaTarea { get; private set; }
        private Guid _idCuenta;

        public FrmCrearTarea(Guid idCuenta)
        {
            InitializeComponent();
            _idCuenta = idCuenta;
            cboPrioridades.DataSource = Enum.GetValues(typeof(Task.Entities.Enumerators.Prioridad));
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            NuevaTarea = new Tarea()
            {
                IdCuenta = _idCuenta,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                FechaExpiracion = dtpExpiracion.Value,
                Duracion = (int)nudDuracion.Value,
                Prioridad = cboPrioridades.SelectedItem != null
                    ?(Task.Entities.Enumerators.Prioridad)cboPrioridades.SelectedItem
                    : Task.Entities.Enumerators.Prioridad.Indefinida,
                FechaCreacion = DateTime.Now,
                State = Task.Entities.Enumerators.EstadoTarea.Pendiente
            };
            ManagerTareas manager = new ManagerTareas();
            try
            {
                manager.CrearTarea(NuevaTarea);
                MessageBox.Show($"Se ha creado la tarea correctamente.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la tarea: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
        }
    }
}
