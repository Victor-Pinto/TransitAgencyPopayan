using AutoMapper;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Lines;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Lines
{
    public class LineService : ILineService
    {
        private readonly ILineRepository _repository;
        private readonly IMapper _mapper;

        public LineService(ILineRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<LineDto> Create(LineDto request) =>
            _mapper.Map<LineDto>(await _repository.Insert(_mapper.Map<Line>(request))
                .ConfigureAwait(false));

        public async Task<IEnumerable<LineDto>> GetAll() =>
            _mapper.Map<IEnumerable<LineDto>>(await _repository.GetAll()
                .ConfigureAwait(false));

        public async Task<LineDto> GetById(int id) =>
            _mapper.Map<LineDto>(await _repository.GetById(id).ConfigureAwait(false));

        public async Task<bool> Update(LineDto request) =>
            await _repository.Update(_mapper.Map<Line>(request)).ConfigureAwait(false);

        public async Task<bool> Delete(int id) =>
            await _repository.Delete(id).ConfigureAwait(false) ? true : throw new ArgumentException("No existe el Id");
    }
}