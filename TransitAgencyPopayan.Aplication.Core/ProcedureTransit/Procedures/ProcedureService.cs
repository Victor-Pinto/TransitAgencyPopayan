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
        //Todo: Victor, revisar las condicionales
        public async Task<ProcedureDto> Create(ProcedureDto request) =>
            _mapper.Map<ProcedureDto>(await _repository.Insert(_mapper.Map<Procedure>(request)).ConfigureAwait(false)) ??
            throw new ArgumentException("Faltan datos en el objeto");

        public async Task<IEnumerable<ProcedureDto>> GetAll()
        {
            var objectList = _mapper.Map<IEnumerable<ProcedureDto>>(await _repository.GetAll().ConfigureAwait(false));
            if (objectList == null)
            {
                throw new ArgumentException("Aún no hay contenido en la base de datos");
            }
            return objectList;
        }


        public async Task<ProcedureDto> GetById(int id)
        {
            if (id == 0)
                throw new ArgumentException("El id no puede ser 0");

            var object2get = _mapper.Map<ProcedureDto>(await _repository.GetById(id).ConfigureAwait(false)) ?? new ProcedureDto();

            if (object2get == null)
                throw new ArgumentException("El objeto consultado no existe");

            return object2get;
        }

        public async Task<bool> Update(ProcedureDto request) =>
            await _repository.Update(_mapper.Map<Procedure>(request)).ConfigureAwait(false);

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