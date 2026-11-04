using System.Text.Json;
using Task.Entities;
using Tesk.Persistencia.Interfaces;

namespace Tesk.Persistencia.DalArchivos
{
    public class TareaArchivo : ITarea
    {
        private readonly string filePath = Path
            .Combine(Constantes.RUTA_ARCHIVOS, $"{Constantes.ARCHIVO_TAREAS}.json");

        private IFileProvider _fileProvider = new FileProviders.JsonFileProvider();

        public List<Tarea> BuscarTareas(Guid idCuenta)
        {
            throw new NotImplementedException();
        }

        public int CrearTarea(Tarea tarea)
        {
            List<Tarea> tareas = LeerTareas();
            tareas.Add(tarea);
            _fileProvider.GuardarRegistros(filePath, tareas);
            return tarea.Id;
        }

        public List<Tarea> LeerTareas()
        {
            return _fileProvider.LeerRegistros<Tarea>(filePath);
        }

    }
}
