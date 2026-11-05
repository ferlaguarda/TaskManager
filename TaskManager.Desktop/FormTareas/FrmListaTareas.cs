using System.Data.Common;
using Task.Entities;
using Task.LogicaNegocio;
using Tesk.Persistencia.Interfaces;

namespace TaskManager.Desktop.FormTareas
{
    public partial class FrmListaTareas : Form
    {
        ManagerTareas _manager = new ManagerTareas();
        Guid _idCuenta;
        public FrmListaTareas(Guid idCuenta)
        {
            InitializeComponent();
            _idCuenta = idCuenta;
            Configure_DataGridview();
            dgvTareas.DataSource = _manager.CargarTareas(_idCuenta);            
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
            switch (columna)
            {
                case "btnDetalle":
                    MessageBox.Show("Viendo detalle");
                    break;
                case "btnModificar":
                    MessageBox.Show("Modificando ....");
                    break;
                case "btnBorrar":
                    var confirmacion = MessageBox.Show("Esta seguro de eliminar la tarea?", "Confirmar",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmacion == DialogResult.Yes)
                        if (_manager.EliminarTarea(tarea.Id))
                        {
                            MessageBox.Show("Tarea eliminada correctamente");
                            dgvTareas.DataSource = _manager.CargarTareas(_idCuenta);
                        }
                        else
                            MessageBox.Show("No se pudo eliminar la tarea");
                    break;
            }
        }

    }
}
