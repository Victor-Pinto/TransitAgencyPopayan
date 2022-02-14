using AutoMapper;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.VehicleClasses;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.VehicleClasses
{
    public class VehicleClassMapperProfile : Profile
    {
        public VehicleClassMapperProfile() => CreateMap<VehicleClassDto, VehicleClass>().ReverseMap();
    }
}