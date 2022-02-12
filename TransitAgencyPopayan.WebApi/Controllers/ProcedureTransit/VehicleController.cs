using Microsoft.AspNetCore.Mvc;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Vehicles;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.WebApi.Controllers.ProcedureTransit
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService) => _vehicleService = vehicleService;

        [HttpPost(nameof(Create))]
        public async Task<VehicleDto> Create(VehicleDto request) =>
            await _vehicleService.Create(request).ConfigureAwait(false);

        [HttpGet(nameof(GetAll))]
        public async Task<IEnumerable<VehicleDto>> GetAll() =>
            await _vehicleService.GetAll().ConfigureAwait(true);

        [HttpGet("GetById/{id}")]
        public async Task<VehicleDto> GetById(int id) =>
            await _vehicleService.GetById(id).ConfigureAwait(false);

        [HttpPut(nameof(Update))]
        public async Task<bool> Update(VehicleDto request) =>
            await _vehicleService.Update(request).ConfigureAwait(false);

        [HttpPut("Delete/{id}")]
        public async Task<bool> Delete(int id) =>
            await _vehicleService.Delete(id).ConfigureAwait(false);
    }
}
