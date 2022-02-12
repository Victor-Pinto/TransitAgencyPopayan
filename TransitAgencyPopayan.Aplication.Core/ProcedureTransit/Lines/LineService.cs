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
        //Todo: Victor, revisar las condicionales
        public async Task<LineDto> Create(LineDto request) =>
            _mapper.Map<LineDto>(await _repository.Insert(_mapper.Map<Line>(request)).ConfigureAwait(false)) ??
            throw new ArgumentException("Faltan datos en el objeto");

        public async Task<IEnumerable<LineDto>> GetAll()
        {
            var objectList = _mapper.Map<IEnumerable<LineDto>>(await _repository.GetAll().ConfigureAwait(false));
            if (objectList == null)
            {
                throw new ArgumentException("Aún no hay contenido en la base de datos");
            }
            return objectList;
        }


        public async Task<LineDto> GetById(int id)
        {
            if (id == 0)
                throw new ArgumentException("El id no puede ser 0");

            var object2get = _mapper.Map<LineDto>(await _repository.GetById(id).ConfigureAwait(false)) ?? new LineDto();

            if (object2get == null)
                throw new ArgumentException("El objeto consultado no existe");

            return object2get;
        }

        public async Task<bool> Update(LineDto request) =>
            await _repository.Update(_mapper.Map<Line>(request)).ConfigureAwait(false);

        public async Task<bool> Delete(int id)
        {
            if (id == 0)
                throw new ArgumentException("El id no puede ser 0");

            var validateExistId = await _repository.GetById(id).ConfigureAwait(false);

            if (validateExistId == null)
                throw new ArgumentException("No existe el Id");

            return await _repository.Delete(id).ConfigureAwait(false);
        }
    }
}