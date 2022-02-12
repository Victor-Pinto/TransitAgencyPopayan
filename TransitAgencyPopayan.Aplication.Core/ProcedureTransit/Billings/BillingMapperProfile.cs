using AutoMapper;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Billings;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Billings
{
    public class BillingMapperProfile : Profile
    {
        public BillingMapperProfile() => CreateMap<BillingDto, Billing>().ReverseMap();
    }
}