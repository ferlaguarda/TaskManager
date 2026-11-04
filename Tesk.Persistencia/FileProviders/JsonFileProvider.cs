using System.Text.Json;
using Tesk.Persistencia.Interfaces;

namespace Tesk.Persistencia.FileProviders
{
    internal class JsonFileProvider : IFileProvider
    {
        public void GuardarRegistros<T>(string filePath, List<T> registros)
        {
            var json = JsonSerializer.Serialize(registros);
            File.WriteAllText(filePath, json);
        }

        public List<T> LeerRegistros<T>(string filePath)
        {
            if (!File.Exists(filePath))
                return [];

            var fileContent = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<T>>(fileContent) ?? [];
        }
    }
}
