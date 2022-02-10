using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
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
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base.Configuration;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Base
{
    internal class ContextDb : DbContext, IContextDb
    {
        private readonly DbSettings _settings;

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

        public ContextDb(IOptions<DbSettings> settings) =>
            _settings = settings.Value;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
           optionsBuilder.UseSqlServer(_settings.ConnectionString);

        public int Commit() => base.SaveChanges();

        public void RollBack() =>
            base.ChangeTracker
            .Entries()
            .Where(e => e.Entity != null)
            .ToList()
            .ForEach(e => e.State = EntityState.Detached);

        public new DbSet<T> Set<T>() where T : EntityBase => base.Set<T>();

        public void SetDeatached<T>(T item) where T : EntityBase => Entry(item).State = EntityState.Detached;

        public void SetModified<T>(T item) where T : EntityBase => Entry(item).State = EntityState.Modified;

        public void Attach<T>(T item) where T : EntityBase
        {
            if (Entry(item).State == EntityState.Detached)
                base.Set<T>().Attach(item);
        }
    }
}