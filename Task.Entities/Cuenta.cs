using Task.Entities.Enumerators;

namespace Task.Entities
{
    public class Cuenta
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required Administrador Owner { get; set; }
        public List<Tarea>? Tareas { get; set; }
        public List<Usuario>? Usuarios { get; set; }
        public TipoCuenta TipoCuenta { get; set; } = TipoCuenta.Personal;
    }
}
