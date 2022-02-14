using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Infrastructure.Internal;
using Microsoft.Extensions.Configuration;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Context.Base
{
    public class DbContextBase : DbContext, IDisposable
    {
        private readonly DbContextOptions _options;
        private readonly IConfiguration _config;
        private string _connectionString;

        public DbContextBase(IConfiguration config) : base()
        {
            _config = config;
            DefineConnectionString();
        }

        public DbContextBase(DbContextOptions options) => _options = options;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var extension = _options.FindExtension<SqlServerOptionsExtension>();

            if (extension != null)
            {
                optionsBuilder.UseSqlServer(extension.ConnectionString);
            }
            else
            {
                DefineConnectionString();
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-1OK5BLI;Initial Catalog=TransitAgencyPopayan;Integrated Security=True");
            }
        }

        public void DefineConnectionString() => _connectionString = _config.GetConnectionString("DbConnectionString");

        public int Commit() => base.SaveChanges();

        public void RollBack() =>
            base.ChangeTracker
            .Entries()
            .Where(e => e.Entity != null)
            .ToList()
            .ForEach(e => e.State = EntityState.Detached);

        public new DbSet<T> Set<T>() where T : class => base.Set<T>();

        public void SetDeatached<T>(T item) where T : class => Entry(item).State = EntityState.Detached;

        public void SetModified<T>(T item) where T : class => Entry(item).State = EntityState.Modified;

        public void Attach<T>(T item) where T : class
        {
            if (Entry(item).State == EntityState.Detached)
                base.Set<T>().Attach(item);
        }
    }
}
