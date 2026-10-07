namespace Task.Entities
{
    public class Empresa
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public string? Direccion { get; set; }
        public required string RUT { get; set; }
        public string? RazonSocial { get; set; }
    }
}
