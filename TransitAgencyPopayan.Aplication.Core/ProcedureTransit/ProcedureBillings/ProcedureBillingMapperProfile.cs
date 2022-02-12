using AutoMapper;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.ProcedureBillings;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.ProcedureBillings
{
    public class ProcedureBillingMapperProfile : Profile
    {
        public ProcedureBillingMapperProfile() => CreateMap<ProcedureBillingDto, ProcedureBilling>().ReverseMap();
    }
}