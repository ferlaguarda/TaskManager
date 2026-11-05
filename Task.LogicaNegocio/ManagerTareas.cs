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
            if(_dalTarea is null)
                throw new Exception("No se pudo crear la tarea. El repositorio de tareas no está disponible.");

            if (tarea.TieneFormatoValido())
            {
                var tareas = LeerTareas();
                int idTarea = tareas.Any() ? tareas.Max(t => t.Id) + 1 : 1;
                tarea.Id = idTarea;
                return _dalTarea.CrearTarea(tarea);
            }
            return 0;
        }

        public List<Tarea> CargarTareas(Guid idCuenta)
        {
            if (_dalTarea is null)
                throw new Exception("No se pudo crear la tarea. El repositorio de tareas no está disponible.");

            var tareas = LeerTareas();
            return tareas
                    .Where(t => t.IdCuenta == idCuenta)
                    .ToList();
        }
   
        public bool EliminarTarea(int idTarea)
        {
            if (_dalTarea is null)
                throw new Exception("No se pudo crear la tarea. El repositorio de tareas no está disponible.");

            var tareas = LeerTareas();
            if(!tareas.Any())
                return false;

            var tareaAELiminar = tareas
                    .Where(t => t.Id == idTarea)
                    .First();
           
            if (tareaAELiminar is null)
                return false;

            tareas.Remove(tareaAELiminar);
            _dalTarea.GuardarTareas(tareas);
            return true;
        }

        private List<Tarea> LeerTareas()
        {
            if (_dalTarea is null)
                throw new Exception("No se pudo crear la tarea. El repositorio de tareas no está disponible.");

            var tareas = _dalTarea.LeerTareas();
            if (tareas is null)
                return [];
            return tareas;
        }
    }
}
