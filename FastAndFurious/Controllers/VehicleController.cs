using FastAndFurious.Application.DTOs;
using FastAndFurious.Application.IServices;
using Microsoft.AspNetCore.Mvc;

namespace FastAndFurious.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpPost("assemble")]
        public async Task<IActionResult> AssembleVehicle([FromBody] AssembleVehicleRequest request)
        {
            var vehicle = await _vehicleService.AssembleVehicleAsync(request.Marca, request.Color, request.ChasisId, request.MotorId, request.CojineraId);
            return Ok(vehicle);
        }
    }
}
