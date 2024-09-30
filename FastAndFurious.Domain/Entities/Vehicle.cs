namespace FastAndFurious.Domain.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string? Marca { get; set; }
        public string? Color { get; set; }
        public DateTime FechaEnsamblaje { get; set; }
        public int NumeroEnsamblaje { get; set; }

        public Chasis? Chasis { get; set; }
        public Motor? Motor { get; set; }
        public Cojinera? Cojinera { get; set; }
    }
}
