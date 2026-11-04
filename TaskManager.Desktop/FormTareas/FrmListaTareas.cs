using System.Data.Common;
using Task.Entities;
using Task.LogicaNegocio;

namespace TaskManager.Desktop.FormTareas
{
    public partial class FrmListaTareas : Form
    {
        public FrmListaTareas(Guid idCuenta)
        {
            InitializeComponent();
            ManagerTareas manager = new ManagerTareas();
            Configure_DataGridview();
            dgvTareas.DataSource = manager.CargarTareas(idCuenta);            
        }

        private void Configure_DataGridview()
        {
            dgvTareas.AutoGenerateColumns = false;
            AgregarColumnaEnGrilla("Id", "Nr.");
            AgregarColumnaEnGrilla("Nombre", "Tarea");
            AgregarColumnaEnGrilla("FechaExpiracion", "Vencimiento");
            AgregarColumnaEnGrilla("State", "Estado");
            AgregarColumnaEnGrilla("Prioridad", "Prioridad");
            AgregarBtnEnGrilla("Detalle");
            AgregarBtnEnGrilla("Modificar");
            AgregarBtnEnGrilla("Borrar");

            dgvTareas.CellContentClick += DgvCellContentGrid;
        }
        private void AgregarColumnaEnGrilla(string propiedad, string textoAMostrar)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn()
            {
                DataPropertyName = propiedad,
                HeaderText = textoAMostrar,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };
            dgvTareas.Columns.Add(column);
        }

        private void AgregarBtnEnGrilla(string texto)
        {
            DataGridViewButtonColumn colBtn = new DataGridViewButtonColumn()
            {
                Name = $"btn{texto}",
                Text = texto,
                HeaderText = string.Empty,
                UseColumnTextForButtonValue = true
            };
            dgvTareas.Columns.Add(colBtn);
        }

        private void DgvCellContentGrid(object? sender, DataGridViewCellEventArgs args)
        {
            if (args.RowIndex < 0)
                return;

            string columna = dgvTareas.Columns[args.ColumnIndex].Name;
            var tarea = dgvTareas.Rows[args.RowIndex].DataBoundItem as Tarea;

        }

    }
}
