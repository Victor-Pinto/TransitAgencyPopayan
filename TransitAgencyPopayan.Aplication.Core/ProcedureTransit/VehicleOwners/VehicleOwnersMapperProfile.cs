using AutoMapper;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.VehicleOwners;
using TransitAgencyPopayan.Aplication.Dto.ProcedureTransit;

namespace TransitAgencyPopayan.Aplication.Core.ProcedureTransit.VehicleOwners
{
    public class VehicleOwnerMapperProfile : Profile
    {
        public VehicleOwnerMapperProfile() => CreateMap<VehicleOwnerDto, VehicleOwner>().ReverseMap();
    }
}