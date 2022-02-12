using AutoMapper;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Lines;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Lines
{
    public class LineMapperProfile : Profile
    {
        public LineMapperProfile() => CreateMap<LineDto, Line>().ReverseMap();
    }
}