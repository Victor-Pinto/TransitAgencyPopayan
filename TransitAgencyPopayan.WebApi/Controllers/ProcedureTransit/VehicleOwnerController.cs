using Microsoft.AspNetCore.Mvc;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.VehicleOwners;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.WebApi.Controllers.ProcedureTransit
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleOwnerController : ControllerBase
    {
        private readonly IVehicleOwnerService _service;

        public VehicleOwnerController(IVehicleOwnerService VehicleOwnerService) => _service = VehicleOwnerService;

        [HttpPost(nameof(Create))]
        public async Task<VehicleOwnerDto> Create(VehicleOwnerDto request) =>
            await _service.Create(request).ConfigureAwait(false);

        [HttpGet(nameof(GetAll))]
        public async Task<IEnumerable<VehicleOwnerDto>> GetAll() =>
            await _service.GetAll().ConfigureAwait(true);

        [HttpGet("GetById/{id}")]
        public async Task<VehicleOwnerDto> GetById(int id) =>
            await _service.GetById(id).ConfigureAwait(false);

        [HttpPut(nameof(Update))]
        public async Task<bool> Update(VehicleOwnerDto request) =>
            await _service.Update(request).ConfigureAwait(false);

        [HttpDelete("Delete/{id}")]
        public async Task<bool> Delete(int id) =>
            await _service.Delete(id).ConfigureAwait(false);
    }
}
