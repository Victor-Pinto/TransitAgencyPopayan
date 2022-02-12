using TransitAgencyPopayan.Aplication.Core.ProcedureTransit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.ConfigureProcedureTransitServices();
var dbSettings = "Data Source=DESKTOP-1OK5BLI;Initial Catalog=TransitAgencyPopayan;Integrated Security=True";
builder.services.ConfigurePeopleManagementService(new DbSettings { ConnectionString = dbSettings });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
