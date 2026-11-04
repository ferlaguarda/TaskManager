namespace Tesk.Persistencia.Interfaces
{
    public interface IFileProvider
    {
        List<T> LeerRegistros<T>(string filePath);

        void GuardarRegistros<T>(string filePath, List<T> registros);
    }
}
