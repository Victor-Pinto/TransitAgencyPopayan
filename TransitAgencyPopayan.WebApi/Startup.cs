using Microsoft.OpenApi.Models;
using TransitAgencyPopayan.Aplication.Core.ProcedureTransit;
using TransitAgencyPopayan.Infrastrucutre.Data.Persistence.Core.Context.Base;

namespace TransitAgencyPopayan.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public IHostEnvironment Environment { get; }

        private const string ConnectionStringName = "DbConnectionString";

        public Startup(IConfiguration configuration, IHostEnvironment env)
        {
            Environment = env;

            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", false, true)
                .AddJsonFile($"appsettings{env.EnvironmentName}.json", true, true)
                .AddEnvironmentVariables();

            Configuration = configuration;
            Configuration = configurationBuilder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProcedureTransit.WebApi", Version = "v1" }));

            services.ConfigureProcedureTransitServices();

            var sqlConnection = Configuration.GetSection(ConnectionStringName).Get<string>();

            services.ConfigureDbContext(sqlConnection);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProcedureTransit.WebApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}