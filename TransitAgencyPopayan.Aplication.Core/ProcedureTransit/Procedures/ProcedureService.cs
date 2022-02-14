using AutoMapper;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Procedures;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Procedures
{
    public class ProcedureService : IProcedureService
    {
        private readonly IProcedureRepository _repository;
        private readonly IMapper _mapper;

        public ProcedureService(IProcedureRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<ProcedureDto> Create(ProcedureDto request) =>
            _mapper.Map<ProcedureDto>(await _repository.Insert(_mapper.Map<Procedure>(request))
                .ConfigureAwait(false));

        public async Task<IEnumerable<ProcedureDto>> GetAll() =>
            _mapper.Map<IEnumerable<ProcedureDto>>(await _repository.GetAll()
                .ConfigureAwait(false));

        public async Task<ProcedureDto> GetById(int id) =>
            _mapper.Map<ProcedureDto>(await _repository.GetById(id).ConfigureAwait(false));

        public async Task<bool> Update(ProcedureDto request) =>
            await _repository.Update(_mapper.Map<Procedure>(request)).ConfigureAwait(false);

        public async Task<bool> Delete(int id) =>
            await _repository.Delete(id).ConfigureAwait(false) ? true : throw new ArgumentException("No existe el Id");
    }
}