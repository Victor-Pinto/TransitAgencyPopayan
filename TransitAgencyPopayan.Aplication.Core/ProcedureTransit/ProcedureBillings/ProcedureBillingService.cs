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
        //Todo: Victor, revisar las condicionales
        public async Task<ProcedureBillingDto> Create(ProcedureBillingDto request) =>
            _mapper.Map<ProcedureBillingDto>(await _repository.Insert(_mapper.Map<ProcedureBilling>(request)).ConfigureAwait(false)) ??
            throw new ArgumentException("Faltan datos en el objeto");

        public async Task<IEnumerable<ProcedureBillingDto>> GetAll()
        {
            var objectList = _mapper.Map<IEnumerable<ProcedureBillingDto>>(await _repository.GetAll().ConfigureAwait(false));
            if (objectList == null)
            {
                throw new ArgumentException("Aún no hay contenido en la base de datos");
            }
            return objectList;
        }


        public async Task<ProcedureBillingDto> GetById(int id)
        {
            if (id == 0)
                throw new ArgumentException("El id no puede ser 0");

            var object2get = _mapper.Map<ProcedureBillingDto>(await _repository.GetById(id).ConfigureAwait(false)) ?? new ProcedureBillingDto();

            if (object2get == null)
                throw new ArgumentException("El objeto consultado no existe");

            return object2get;
        }

        public async Task<bool> Update(ProcedureBillingDto request) =>
            await _repository.Update(_mapper.Map<ProcedureBilling>(request)).ConfigureAwait(false);

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