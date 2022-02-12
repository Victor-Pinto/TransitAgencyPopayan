using AutoMapper;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.TypeServices;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.TypeServices
{
    public class TypeServiceMapperProfile : Profile
    {
        public TypeServiceMapperProfile() => CreateMap<TypeServiceDto, TypeService>().ReverseMap();
    }
}