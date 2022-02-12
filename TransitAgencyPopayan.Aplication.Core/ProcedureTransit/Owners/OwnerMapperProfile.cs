using AutoMapper;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Owners;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Owners
{
    public class OwnerMapperProfile : Profile
    {
        public OwnerMapperProfile() => CreateMap<OwnerDto, Owner>().ReverseMap();
    }
}