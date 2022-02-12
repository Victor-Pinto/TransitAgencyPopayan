using AutoMapper;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Brands;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Brands
{
    public class BrandMapperProfile : Profile
    {
        public BrandMapperProfile() => CreateMap<BrandDto, Brand>().ReverseMap();
    }
}