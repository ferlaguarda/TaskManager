namespace Task.Entities
{
    public class CuentaEmpresa : Cuenta
    {
        public List<Equipo>? Equipos { get; set; }
        public required Empresa Empresa { get; set; }
    }
}
