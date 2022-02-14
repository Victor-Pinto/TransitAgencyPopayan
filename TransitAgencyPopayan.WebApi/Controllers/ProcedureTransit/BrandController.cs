using Microsoft.AspNetCore.Mvc;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Brands;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.WebApi.Controllers.ProcedureTransit
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _service;

        public BrandController(IBrandService Service) => _service = Service;

        [HttpPost(nameof(Create))]
        public async Task<BrandDto> Create(BrandDto request) =>
            await _service.Create(request).ConfigureAwait(false);

        [HttpGet(nameof(GetAll))]
        public async Task<IEnumerable<BrandDto>> GetAll() =>
            await _service.GetAll().ConfigureAwait(true);

        [HttpGet("GetById/{id}")]
        public async Task<BrandDto> GetById(int id) =>
            await _service.GetById(id).ConfigureAwait(false);

        [HttpPut(nameof(Update))]
        public async Task<bool> Update(BrandDto request) =>
            await _service.Update(request).ConfigureAwait(false);

        [HttpDelete("Delete/{id}")]
        public async Task<bool> Delete(int id) =>
            await _service.Delete(id).ConfigureAwait(false);
    }
}
