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
        //Todo: Victor, revisar las condicionales
        public async Task<OwnerDto> Create(OwnerDto request) =>
            _mapper.Map<OwnerDto>(await _repository.Insert(_mapper.Map<Owner>(request)).ConfigureAwait(false)) ??
            throw new ArgumentException("Faltan datos en el objeto");

        public async Task<IEnumerable<OwnerDto>> GetAll()
        {
            var objectList = _mapper.Map<IEnumerable<OwnerDto>>(await _repository.GetAll().ConfigureAwait(false));
            if (objectList == null)
            {
                throw new ArgumentException("Aún no hay contenido en la base de datos");
            }
            return objectList;
        }


        public async Task<OwnerDto> GetById(int id)
        {
            if (id == 0)
                throw new ArgumentException("El id no puede ser 0");

            var object2get = _mapper.Map<OwnerDto>(await _repository.GetById(id).ConfigureAwait(false)) ?? new OwnerDto();

            if (object2get == null)
                throw new ArgumentException("El objeto consultado no existe");

            return object2get;
        }

        public async Task<bool> Update(OwnerDto request) =>
            await _repository.Update(_mapper.Map<Owner>(request)).ConfigureAwait(false);

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