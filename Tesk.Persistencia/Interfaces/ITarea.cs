using Task.Entities;

namespace Tesk.Persistencia.Interfaces
{
    public interface ITarea
    {
        int CrearTarea(Tarea tarea);

        List<Tarea> BuscarTareas(Guid idCuenta);

        List<Tarea> LeerTareas();

        bool GuardarTareas(List<Tarea> tareas);
    }
}
