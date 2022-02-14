using AutoMapper;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Brands;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Brands
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _repository;
        private readonly IMapper _mapper;

        public BrandService(IBrandRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<BrandDto> Create(BrandDto request) =>
            _mapper.Map<BrandDto>(await _repository.Insert(_mapper.Map<Brand>(request))
                .ConfigureAwait(false));

        public async Task<IEnumerable<BrandDto>> GetAll() =>
            _mapper.Map<IEnumerable<BrandDto>>(await _repository.GetAll()
                .ConfigureAwait(false));

        public async Task<BrandDto> GetById(int id) =>
            _mapper.Map<BrandDto>(await _repository.GetById(id).ConfigureAwait(false));

        public async Task<bool> Update(BrandDto request) =>
            await _repository.Update(_mapper.Map<Brand>(request)).ConfigureAwait(false);

        public async Task<bool> Delete(int id) =>
            await _repository.Delete(id).ConfigureAwait(false) ? true : throw new ArgumentException("No existe el Id");
    }
}