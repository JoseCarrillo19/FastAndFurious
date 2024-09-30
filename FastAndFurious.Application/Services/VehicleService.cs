using FastAndFurious.Application.IServices;
using FastAndFurious.Domain.Entities;
using FastAndFurious.Domain.IRepositories;

namespace FastAndFurious.Application.Services
{
    public class VehicleService: IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IChasisRepository _chasisRepository;
        private readonly IMotorRepository _motorRepository;
        private readonly ICojineraRepository _cojineraRepository;

        public VehicleService(IVehicleRepository vehicleRepository, IChasisRepository chasisRepository,
                              IMotorRepository motorRepository, ICojineraRepository cojineraRepository)
        {
            _vehicleRepository = vehicleRepository;
            _chasisRepository = chasisRepository;
            _motorRepository = motorRepository;
            _cojineraRepository = cojineraRepository;
        }

        public async Task<Vehicle> AssembleVehicleAsync(string marca, string color, int chasisId, int motorId, int cojineraId)
        {
            var chasis = await _chasisRepository.GetByIdAsync(chasisId);
            var motor = await _motorRepository.GetByIdAsync(motorId);
            var cojinera = await _cojineraRepository.GetByIdAsync(cojineraId);

            return await _vehicleRepository.AssembleVehicleAsync(marca, color, chasis, motor, cojinera);
        }
    }
}
