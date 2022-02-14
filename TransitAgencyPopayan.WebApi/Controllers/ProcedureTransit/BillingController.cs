using Microsoft.AspNetCore.Mvc;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Billings;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit.Billings;

namespace TransitAgencyPopayan.WebApi.Controllers.ProcedureTransit
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillingController : ControllerBase
    {
        private readonly IBillingService _service;

        public BillingController(IBillingService Service) => _service = Service;

        [HttpPost(nameof(Create))]
        public async Task<BillingDto> Create(BillingDto request) =>
            await _service.Create(request).ConfigureAwait(false);

        [HttpGet(nameof(GetAll))]
        public async Task<IEnumerable<BillingDto>> GetAll() =>
            await _service.GetAll().ConfigureAwait(true);

        [HttpGet("GetById/{id}")]
        public async Task<BillingDto> GetById(int id) =>
            await _service.GetById(id).ConfigureAwait(false);

        [HttpPost(nameof(SearchMatching))]
        public async Task<List<BillingDto>> SearchMatching(BillingSearchPropsDto request) =>
            await _service.SearchMatching(request).ConfigureAwait(false);

        [HttpPut(nameof(Update))]
        public async Task<bool> Update(BillingDto request) =>
            await _service.Update(request).ConfigureAwait(false);

        [HttpDelete("Delete/{id}")]
        public async Task<bool> Delete(int id) =>
            await _service.Delete(id).ConfigureAwait(false);
    }
}
