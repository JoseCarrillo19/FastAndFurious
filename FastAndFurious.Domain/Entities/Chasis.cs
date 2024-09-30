namespace FastAndFurious.Domain.Entities
{
    public class Chasis
    {
        public int Id { get; set; }
        public int NumeroEjes { get; set; }
        public string? TipoTransmision { get; set; } // Automática o Mecánica
    }
}
