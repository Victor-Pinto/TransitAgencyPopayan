using AutoMapper;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.VehicleOwners;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Billings;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit.Billings;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Billings
{
    public class BillingService : IBillingService
    {
        private readonly IBillingRepository _billingRepository;
        private readonly IVehicleOwnerService _vehicleOwnerService;
        private readonly IMapper _mapper;

        public BillingService(
            IBillingRepository repository,
            IVehicleOwnerService vehicleOwnerService,
            IMapper mapper)
        {
            _billingRepository = repository;
            _vehicleOwnerService = vehicleOwnerService;
            _mapper = mapper;
        }

        public async Task<BillingDto> Create(BillingDto request) =>
            _mapper.Map<BillingDto>(await _billingRepository.Insert(_mapper.Map<Billing>(request))
                .ConfigureAwait(false));

        public async Task<IEnumerable<BillingDto>> GetAll() =>
            _mapper.Map<IEnumerable<BillingDto>>(await _billingRepository.GetAll()
                .ConfigureAwait(false));

        public async Task<BillingDto> GetById(int id) =>
            _mapper.Map<BillingDto>(await _billingRepository.GetById(id).ConfigureAwait(false));

        public async Task<List<BillingDto>> SearchMatching(BillingSearchPropsDto request)
        {
            var idOwner = string.Empty;
            var billings = new List<BillingDto>();
            var vehicleOwner = await _vehicleOwnerService.GetAll().ConfigureAwait(false);

            if (request.InitialDate != null && request.FinalDate != null && string.IsNullOrEmpty(request.LicensePlate) &&
                string.IsNullOrEmpty(request.OwnerIdentification))
            {
                billings = await ValidationDateRange(request);

                return (from bill in billings
                        where request.InitialDate <= bill.Date && bill.Date <= request.FinalDate
                        select bill).ToList();
            }

            if (request.InitialDate != null && request.FinalDate != null && !string.IsNullOrEmpty(request.LicensePlate) &&
                string.IsNullOrEmpty(request.OwnerIdentification))

            {
                billings = await ValidationDateRange(request);
                return (from bill in billings
                        where request.InitialDate <= bill.Date && bill.Date <= request.FinalDate &&
                           request.LicensePlate == bill.Vehicle.LicensePlate
                        select bill).ToList();
            }

            if (request.InitialDate != null && request.FinalDate != null && string.IsNullOrEmpty(request.LicensePlate) &&
                !string.IsNullOrEmpty(request.OwnerIdentification))
            {

                if (vehicleOwner == null)
                    throw new ArgumentException("La lista de propietarios de vehículos está vacía");

                idOwner = vehicleOwner.FirstOrDefault(x =>
                    x.Owner.Identification == request.OwnerIdentification).Owner.Identification ?? string.Empty;

                billings = await ValidationDateRange(request);
                return (from bill in billings
                        where request.InitialDate <= bill.Date && bill.Date <= request.FinalDate &&
                             request.OwnerIdentification == idOwner
                        select bill).ToList();
            }

            if (request.InitialDate == null && request.FinalDate == null && !string.IsNullOrEmpty(request.LicensePlate) &&
                string.IsNullOrEmpty(request.OwnerIdentification))
            {

                billings = (await GetAll().ConfigureAwait(false)).ToList();
                return (from bill in billings
                        where request.LicensePlate == bill.Vehicle.LicensePlate
                        select bill).ToList();

            }

            if (request.InitialDate == null && request.FinalDate == null && string.IsNullOrEmpty(request.LicensePlate) &&
                !string.IsNullOrEmpty(request.OwnerIdentification))
            {
                if (vehicleOwner == null)
                    throw new ArgumentException("La lista de propietarios de vehículos está vacía");

                idOwner = vehicleOwner.FirstOrDefault(x =>
                    x.Owner.Identification == request.OwnerIdentification).Owner.Identification ?? string.Empty;

                billings = await ValidationDateRange(request);
                return (from bill in billings
                        where request.OwnerIdentification == idOwner
                        select bill).ToList();
            }


            if (vehicleOwner == null)
                throw new ArgumentException("La lista de propietarios de vehículos está vacía");

            idOwner = vehicleOwner.FirstOrDefault(x =>
                x.Owner.Identification == request.OwnerIdentification).Owner.Identification ?? string.Empty;

            var billingsList = await ValidationDateRange(request);
            return (from bill in billingsList
                    where request.InitialDate <= bill.Date && bill.Date <= request.FinalDate &&
                         request.OwnerIdentification == idOwner
                    select bill).ToList();
        }

        private async Task<List<BillingDto>> ValidationDateRange(BillingSearchPropsDto request)
        {
            if (request.InitialDate > DateTimeOffset.Now)
                throw new Exception("La fecha no puede ser mayor a la actual");

            if (request.FinalDate < request.InitialDate)
                throw new Exception("La fecha final no puede ser menor que la inicial");

            if (request.FinalDate > DateTimeOffset.Now)
                throw new Exception("La fecha final no puede ser mayor que la actual");

            return (await GetAll().ConfigureAwait(false)).ToList();
        }

        public async Task<bool> Update(BillingDto request) =>
            await _billingRepository.Update(_mapper.Map<Billing>(request)).ConfigureAwait(false);

        public async Task<bool> Delete(int id) =>
            await _billingRepository.Delete(id).ConfigureAwait(false) ? true : throw new ArgumentException("No existe el Id");
    }


}