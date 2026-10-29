using Task.Entities;
using Tesk.Persistencia.Interfaces;
using Tesk.Persistencia.DalArchivos;

namespace Task.LogicaNegocio
{
    public class ManagerTareas
    {
        ITarea _dalTarea;

        public ManagerTareas()
        {
            _dalTarea = new TareaArchivo();
        }

        public int CrearTarea(Tarea tarea)
        {
            if (tarea.TieneFormatoValido())
            {
                var tareas = _dalTarea.LeerTareas();
                int idTarea = tareas.Any() ? tareas.Max(t => t.Id) + 1 : 1;
                tarea.Id = idTarea;
                return _dalTarea.CrearTarea(tarea);
            }
            return 0;
        }
    }
}
