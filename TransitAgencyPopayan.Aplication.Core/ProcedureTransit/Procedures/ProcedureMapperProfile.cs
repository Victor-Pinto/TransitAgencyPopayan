using AutoMapper;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Procedures;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Procedures
{
    public class ProcedureMapperProfile : Profile
    {
        public ProcedureMapperProfile() => CreateMap<ProcedureDto, Procedure>().ReverseMap();
    }
}