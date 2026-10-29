using Task.Entities.Enumerators;

namespace Task.Entities
{
    public class Tarea
    {
        public int Id { get; set; }
        public Guid IdCuenta { get; set; }
        public required string Nombre { get; set; }
        public required string Descripcion { get; set; }
        public EstadoTarea State { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public int Duracion { get; set; }
        public Prioridad Prioridad { get; set; }
        IEnumerable<Nota>? Notas { get; set; }
        IEnumerable<Comentario>? Comentarios { get; set; }

        public bool TieneFormatoValido()
        {
            //Validar datos de entrada
            if (string.IsNullOrEmpty(Nombre))
                throw new ArgumentException("El nombre de la tarea no puede estar vacío.");
            if (string.IsNullOrEmpty(Descripcion))
                throw new ArgumentException("La descripción de la tarea no puede estar vacía.");
            if (FechaExpiracion < DateTime.Now)
                throw new ArgumentException("La fecha de expiración no puede ser menor a la fecha actual.");
            if (Duracion <= 0)
                throw new ArgumentException("La duración de la tarea debe ser mayor a cero.");
            
            return true;
        }
    }
}
