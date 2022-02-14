using AutoMapper;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Owners;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Owners
{
    public class OwnerService : IOwnerService
    {
        private readonly IOwnerRepository _repository;
        private readonly IMapper _mapper;

        public OwnerService(IOwnerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OwnerDto> Create(OwnerDto request) =>
            _mapper.Map<OwnerDto>(await _repository.Insert(_mapper.Map<Owner>(request))
                .ConfigureAwait(false));

        public async Task<IEnumerable<OwnerDto>> GetAll() =>
            _mapper.Map<IEnumerable<OwnerDto>>(await _repository.GetAll()
                .ConfigureAwait(false));

        public async Task<OwnerDto> GetById(int id) =>
            _mapper.Map<OwnerDto>(await _repository.GetById(id).ConfigureAwait(false));

        public async Task<bool> Update(OwnerDto request) =>
            await _repository.Update(_mapper.Map<Owner>(request)).ConfigureAwait(false);

        public async Task<bool> Delete(int id) =>
            await _repository.Delete(id).ConfigureAwait(false) ? true : throw new ArgumentException("No existe el Id");
    }
}