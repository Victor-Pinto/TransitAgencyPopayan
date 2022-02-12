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
        //Todo: Victor, revisar las condicionales
        public async Task<TypeServiceDto> Create(TypeServiceDto request) =>
            _mapper.Map<TypeServiceDto>(await _repository.Insert(_mapper.Map<TypeService>(request)).ConfigureAwait(false)) ??
            throw new ArgumentException("Faltan datos en el objeto");

        public async Task<IEnumerable<TypeServiceDto>> GetAll()
        {
            var objectList = _mapper.Map<IEnumerable<TypeServiceDto>>(await _repository.GetAll().ConfigureAwait(false));
            if (objectList == null)
            {
                throw new ArgumentException("Aún no hay contenido en la base de datos");
            }
            return objectList;
        }


        public async Task<TypeServiceDto> GetById(int id)
        {
            if (id == 0)
                throw new ArgumentException("El id no puede ser 0");

            var object2get = _mapper.Map<TypeServiceDto>(await _repository.GetById(id).ConfigureAwait(false)) ?? new TypeServiceDto();

            if (object2get == null)
                throw new ArgumentException("El objeto consultado no existe");

            return object2get;
        }

        public async Task<bool> Update(TypeServiceDto request) =>
            await _repository.Update(_mapper.Map<TypeService>(request)).ConfigureAwait(false);

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