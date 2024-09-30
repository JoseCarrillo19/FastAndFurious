namespace FastAndFurious.Application.DTOs
{
    public class AssembleVehicleRequest
    {
        public string? Marca { get; set; }
        public string? Color { get; set; }
        public int ChasisId { get; set; }
        public int MotorId { get; set; }
        public int CojineraId { get; set; }
    }
}
