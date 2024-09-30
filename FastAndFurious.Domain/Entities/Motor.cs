namespace FastAndFurious.Domain.Entities
{
    public class Motor
    {
        public int Id { get; set; }
        public int PotenciaMaxima { get; set; }
        public string? Tecnologia { get; set; } // Eléctrico, Térmico, Híbrido
    }
}
