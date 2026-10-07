using Task.Entities;

namespace TaskManager.Desktop.FormTareas
{
    public partial class FrmListaTareas : Form
    {
        public FrmListaTareas(List<Tarea>? tareas)
        {
            InitializeComponent();
            dgvTareas.DataSource = tareas;
        }
    }
}
