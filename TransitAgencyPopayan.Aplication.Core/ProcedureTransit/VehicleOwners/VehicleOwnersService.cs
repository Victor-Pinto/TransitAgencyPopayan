using AutoMapper;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Owners;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.VehicleOwners;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.VehicleOwners
{
    public class VehicleOwnerService : IVehicleOwnerService
    {
        private readonly IVehicleOwnerRepository _repository;
        private readonly IOwnerService _ownerService;
        private readonly IMapper _mapper;

        public VehicleOwnerService(
            IVehicleOwnerRepository repository,
            IOwnerService ownerService,
            IMapper mapper)
        {
            _repository = repository;
            _ownerService = ownerService;
            _mapper = mapper;
        }

        public async Task<VehicleOwnerDto> Create(VehicleOwnerDto request) =>
            _mapper.Map<VehicleOwnerDto>(await _repository.Insert(_mapper.Map<VehicleOwner>(request))
                .ConfigureAwait(false));

        public async Task<IEnumerable<VehicleOwnerDto>> GetAll()
        {
            var vehiclesOwners = _mapper.Map<IEnumerable<VehicleOwnerDto>>(await _repository.GetAll()
                .ConfigureAwait(false));

            foreach (var item in vehiclesOwners)
                await GetObjectsOfForingKeys(item).ConfigureAwait(false);

            return vehiclesOwners;
        }

        public async Task<VehicleOwnerDto> GetById(int id) =>
            _mapper.Map<VehicleOwnerDto>(await _repository.GetById(id).ConfigureAwait(false));

        public async Task<bool> Update(VehicleOwnerDto request) =>
            await _repository.Update(_mapper.Map<VehicleOwner>(request)).ConfigureAwait(false);

        public async Task<bool> Delete(int id) =>
            await _repository.Delete(id).ConfigureAwait(false) ? true : throw new ArgumentException("No existe el Id");

        private async Task GetObjectsOfForingKeys(VehicleOwnerDto request)
        {
            if (request.OwnerId != 0)
            {
                request.Owner = await _ownerService.GetById(request.OwnerId).ConfigureAwait(false);
            }
        }
    }
}