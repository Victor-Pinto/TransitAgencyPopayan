using Microsoft.AspNetCore.Mvc;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Lines;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.WebApi.Controllers.ProcedureTransit
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineController : ControllerBase
    {
        private readonly ILineService _service;

        public LineController(ILineService Service) => _service = Service;

        [HttpPost(nameof(Create))]
        public async Task<LineDto> Create(LineDto request) =>
            await _service.Create(request).ConfigureAwait(false);

        [HttpGet(nameof(GetAll))]
        public async Task<IEnumerable<LineDto>> GetAll() =>
            await _service.GetAll().ConfigureAwait(true);

        [HttpGet("GetById/{id}")]
        public async Task<LineDto> GetById(int id) =>
            await _service.GetById(id).ConfigureAwait(false);

        [HttpPut(nameof(Update))]
        public async Task<bool> Update(LineDto request) =>
            await _service.Update(request).ConfigureAwait(false);

        [HttpDelete("Delete/{id}")]
        public async Task<bool> Delete(int id) =>
            await _service.Delete(id).ConfigureAwait(false);
    }
}
