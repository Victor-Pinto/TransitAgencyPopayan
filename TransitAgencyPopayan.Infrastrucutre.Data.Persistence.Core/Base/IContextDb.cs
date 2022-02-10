using Microsoft.EntityFrameworkCore;
using TransitAgencyPopayan.Aplication.Domine.Core.Base;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Billings;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Brands;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Lines;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Owners;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.ProcedureBillings;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Procedures;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.TypeServices;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.VehicleClasses;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.VehicleOwners;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Vehicles;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base
{
    public interface IContextDb : IUnitOfWork
    {
        DbSet<Vehicle> Vehicle { get; }
        DbSet<Brand> Brand { get; }
        DbSet<Line> Line { get; }
        DbSet<VehicleClass> VehicleClass { get; }
        DbSet<TypeService> TypeService { get; }
        DbSet<Billing> Billing { get; }
        DbSet<ProcedureBilling> ProcedureBilling { get; }
        DbSet<Owner> Owner { get; }
        DbSet<VehicleOwner> VehicleOwner { get; }
        DbSet<Procedure> Procedure { get; }
    }
}
