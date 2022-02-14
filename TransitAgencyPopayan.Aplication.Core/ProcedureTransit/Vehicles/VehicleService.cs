using AutoMapper;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Vehicles;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Vehicles
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _repository;
        private readonly IMapper _mapper;

        public VehicleService(IVehicleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<VehicleDto> Create(VehicleDto request) =>
            _mapper.Map<VehicleDto>(await _repository.Insert(_mapper.Map<Vehicle>(request))
                .ConfigureAwait(false));

        public async Task<IEnumerable<VehicleDto>> GetAll() =>
            _mapper.Map<IEnumerable<VehicleDto>>(await _repository.GetAll()
                .ConfigureAwait(false));

        public async Task<VehicleDto> GetById(int id) =>
            _mapper.Map<VehicleDto>(await _repository.GetById(id).ConfigureAwait(false));

        public async Task<bool> Update(VehicleDto request) =>
            await _repository.Update(_mapper.Map<Vehicle>(request)).ConfigureAwait(false);

        public async Task<bool> Delete(int id) =>
            await _repository.Delete(id).ConfigureAwait(false) ? true : throw new ArgumentException("No existe el Id");
    }
}