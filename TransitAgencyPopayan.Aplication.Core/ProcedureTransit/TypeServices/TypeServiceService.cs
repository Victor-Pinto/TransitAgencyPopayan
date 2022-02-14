using AutoMapper;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.TypeServices;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.TypeServices
{
    public class TypeServiceService : ITypeServiceService
    {
        private readonly ITypeServiceRepository _repository;
        private readonly IMapper _mapper;

        public TypeServiceService(ITypeServiceRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<TypeServiceDto> Create(TypeServiceDto request) =>
            _mapper.Map<TypeServiceDto>(await _repository.Insert(_mapper.Map<TypeService>(request))
                .ConfigureAwait(false));

        public async Task<IEnumerable<TypeServiceDto>> GetAll() =>
            _mapper.Map<IEnumerable<TypeServiceDto>>(await _repository.GetAll()
                .ConfigureAwait(false));

        public async Task<TypeServiceDto> GetById(int id) =>
            _mapper.Map<TypeServiceDto>(await _repository.GetById(id).ConfigureAwait(false));

        public async Task<bool> Update(TypeServiceDto request) =>
            await _repository.Update(_mapper.Map<TypeService>(request)).ConfigureAwait(false);

        public async Task<bool> Delete(int id) =>
            await _repository.Delete(id).ConfigureAwait(false) ? true : throw new ArgumentException("No existe el Id");
    }
}