using Microsoft.Extensions.DependencyInjection;

namespace TransitAgencyPopayan.Infrastructure.Transversal.Http.Client.Configurator
{
    public static class HttpClientConfigurator
    {
        public static void ConfigureHttpClientService(this IServiceCollection services, HttpClientSettings settings) =>
            services.Configure<HttpClientSettings>(o => o.CopyFrom(settings));
    }
}
