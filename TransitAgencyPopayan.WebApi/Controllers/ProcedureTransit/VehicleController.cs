using Microsoft.AspNetCore.Mvc;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Vehicles;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.WebApi.Controllers.ProcedureTransit
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _service;

        public VehicleController(IVehicleService vehicleService) => _service = vehicleService;

        [HttpPost(nameof(Create))]
        public async Task<VehicleDto> Create(VehicleDto request) =>
            await _service.Create(request).ConfigureAwait(false);

        [HttpGet(nameof(GetAll))]
        public async Task<IEnumerable<VehicleDto>> GetAll() =>
            await _service.GetAll().ConfigureAwait(true);

        [HttpGet("GetById/{id}")]
        public async Task<VehicleDto> GetById(int id) =>
            await _service.GetById(id).ConfigureAwait(false);

        [HttpPut(nameof(Update))]
        public async Task<bool> Update(VehicleDto request) =>
            await _service.Update(request).ConfigureAwait(false);

        [HttpDelete("Delete/{id}")]
        public async Task<bool> Delete(int id) =>
            await _service.Delete(id).ConfigureAwait(false);
    }
}
