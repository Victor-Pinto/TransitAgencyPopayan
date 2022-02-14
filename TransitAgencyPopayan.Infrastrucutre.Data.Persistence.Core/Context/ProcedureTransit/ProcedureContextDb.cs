using Microsoft.EntityFrameworkCore;
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
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Context.Base;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Context.ProcedureTransit
{
    public partial class ProcedureContextDb : DbContextBase, IProcedureContextDb
    {
        public ProcedureContextDb(DbContextOptions<ProcedureContextDb> options) : base(options) { }

        #region Tables Db 
        public DbSet<Vehicle> Vehicle { get; set; }

        public DbSet<Brand> Brand { get; set; }

        public DbSet<Line> Line { get; set; }

        public DbSet<VehicleClass> VehicleClass { get; set; }

        public DbSet<TypeService> TypeService { get; set; }

        public DbSet<Billing> Billing { get; set; }

        public DbSet<ProcedureBilling> ProcedureBilling { get; set; }

        public DbSet<Owner> Owner { get; set; }

        public DbSet<VehicleOwner> VehicleOwner { get; set; }

        public DbSet<Procedure> Procedure { get; set; }

        #endregion Tables Db


    }
}