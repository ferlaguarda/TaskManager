using Task.Entities.Enumerators;

namespace Task.Entities
{
    public class Tarea
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Descripcion { get; set; }
        public EstadoTarea State { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public int Duracion { get; set; }
        public Prioridad Prioridad { get; set; }
        IEnumerable<Nota>? Notas { get; set; }
        IEnumerable<Comentario>? Comentarios { get; set; }
    }
}
