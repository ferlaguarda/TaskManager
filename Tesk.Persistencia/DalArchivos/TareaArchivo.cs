using System.Text.Json;
using Task.Entities;
using Tesk.Persistencia.Interfaces;

namespace Tesk.Persistencia.DalArchivos
{
    public class TareaArchivo : ITarea
    {
        private readonly string filePath = Path
            .Combine(Constantes.RUTA_ARCHIVOS, $"{Constantes.ARCHIVO_TAREAS}.json");


        public List<Tarea> BuscarTareas(Guid idCuenta)
        {
            throw new NotImplementedException();
        }

        public int CrearTarea(Tarea tarea)
        {
            List<Tarea> tareas = LeerTareas();
            tareas.Add(tarea);
            var fileContent = JsonSerializer.Serialize(tareas);
            File.WriteAllText(filePath, fileContent);
            return tarea.Id;
        }

        public List<Tarea> LeerTareas()
        {
            if (!File.Exists(filePath))
                return new List<Tarea>();

            var fileContent = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Tarea>>(fileContent) ??
                new List<Tarea>();
        }
    }
}
