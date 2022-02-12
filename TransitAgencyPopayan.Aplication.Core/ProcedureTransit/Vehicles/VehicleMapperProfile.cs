using AutoMapper;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Vehicles;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.Vehicles
{
    public class VehicleMapperProfile : Profile
    {
        public VehicleMapperProfile() => CreateMap<VehicleDto, Vehicle>().ReverseMap();
    }
}