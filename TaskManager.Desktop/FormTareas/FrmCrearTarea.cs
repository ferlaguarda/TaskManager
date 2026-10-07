using Task.Entities;

namespace TaskManager.Desktop.FormTareas
{
    public partial class FrmCrearTarea : Form
    {
        public Tarea NuevaTarea { get; private set; }

        public FrmCrearTarea()
        {
            InitializeComponent();
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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
