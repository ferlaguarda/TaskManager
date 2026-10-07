using Task.Entities;

Console.WriteLine("Hello, World!");
var note = new Nota()
{
    Descripcion = "Esto es la prueba de integración con librerias",
};
Console.WriteLine(note.ToString());