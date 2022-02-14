using AutoMapper;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.ProcedureBillings;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.ProcedureBillings
{
    public class ProcedureBillingService : IProcedureBillingService
    {
        private readonly IProcedureBillingRepository _repository;
        private readonly IMapper _mapper;

        public ProcedureBillingService(IProcedureBillingRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ProcedureBillingDto> Create(ProcedureBillingDto request) =>
            _mapper.Map<ProcedureBillingDto>(await _repository.Insert(_mapper.Map<ProcedureBilling>(request))
                .ConfigureAwait(false));

        public async Task<IEnumerable<ProcedureBillingDto>> GetAll() =>
            _mapper.Map<IEnumerable<ProcedureBillingDto>>(await _repository.GetAll()
                .ConfigureAwait(false));

        public async Task<ProcedureBillingDto> GetById(int id) =>
            _mapper.Map<ProcedureBillingDto>(await _repository.GetById(id).ConfigureAwait(false));

        public async Task<bool> Update(ProcedureBillingDto request) =>
            await _repository.Update(_mapper.Map<ProcedureBilling>(request)).ConfigureAwait(false);

        public async Task<bool> Delete(int id) =>
            await _repository.Delete(id).ConfigureAwait(false) ? true : throw new ArgumentException("No existe el Id");
    }
}