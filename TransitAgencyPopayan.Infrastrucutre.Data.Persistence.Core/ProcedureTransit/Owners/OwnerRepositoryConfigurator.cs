using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TransitAgencyPopayan.Aplication.Domine.Core.ProcedureTransit.Owners;

namespace TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.ProcedureTransit.Owners
{
    public static class OwnerRepositoryConfigurator
    {
        public static void ConfigureOwnerRepository(this IServiceCollection services) =>
            services.TryAddScoped<IOwnerRepository, OwnerRepository>();
    }
}