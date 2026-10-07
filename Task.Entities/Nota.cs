namespace Task.Entities
{
    public class Nota
    {
        public int Id { get; set; }
        public required string Descripcion { get; set; }
        public DateTime Fecha { get; set; } = DateTime.UtcNow;

        public override string ToString()
        {
            return $"Nota: {Descripcion}, Fecha: {Fecha.ToString("dd-MM-yyyy HH:mm:ss")}";
        }
    }
}
