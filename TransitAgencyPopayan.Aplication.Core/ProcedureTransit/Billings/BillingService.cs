using AutoMapper;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Billings;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Billings
{
    public class BillingService : IBillingService
    {
        private readonly IBillingRepository _repository;
        private readonly IMapper _mapper;

        public BillingService(IBillingRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        //Todo: Victor, revisar las condicionales
        public async Task<BillingDto> Create(BillingDto request) =>
            _mapper.Map<BillingDto>(await _repository.Insert(_mapper.Map<Billing>(request)).ConfigureAwait(false)) ??
            throw new ArgumentException("Faltan datos en el objeto");

        public async Task<IEnumerable<BillingDto>> GetAll()
        {
            var objectList = _mapper.Map<IEnumerable<BillingDto>>(await _repository.GetAll().ConfigureAwait(false));
            if (objectList == null)
            {
                throw new ArgumentException("Aún no hay contenido en la base de datos");
            }
            return objectList;
        }


        public async Task<BillingDto> GetById(int id)
        {
            if (id == 0)
                throw new ArgumentException("El id no puede ser 0");

            var object2get = _mapper.Map<BillingDto>(await _repository.GetById(id).ConfigureAwait(false)) ?? new BillingDto();

            if (object2get == null)
                throw new ArgumentException("El objeto consultado no existe");

            return object2get;
        }

        public async Task<bool> Update(BillingDto request) =>
            await _repository.Update(_mapper.Map<Billing>(request)).ConfigureAwait(false);

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