using AutoMapper;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.VehicleClasses;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.VehicleClasses
{
    public class VehicleClassService : IVehicleClassService
    {
        private readonly IVehicleClassRepository _repository;
        private readonly IMapper _mapper;

        public VehicleClassService(IVehicleClassRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<VehicleClassDto> Create(VehicleClassDto request) =>
            _mapper.Map<VehicleClassDto>(await _repository.Insert(_mapper.Map<VehicleClass>(request))
                .ConfigureAwait(false));

        public async Task<IEnumerable<VehicleClassDto>> GetAll() =>
            _mapper.Map<IEnumerable<VehicleClassDto>>(await _repository.GetAll()
                .ConfigureAwait(false));

        public async Task<VehicleClassDto> GetById(int id) =>
            _mapper.Map<VehicleClassDto>(await _repository.GetById(id).ConfigureAwait(false));

        public async Task<bool> Update(VehicleClassDto request) =>
            await _repository.Update(_mapper.Map<VehicleClass>(request)).ConfigureAwait(false);

        public async Task<bool> Delete(int id) =>
            await _repository.Delete(id).ConfigureAwait(false) ? true : throw new ArgumentException("No existe el Id");
    }
}