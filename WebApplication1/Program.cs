using Microsoft.EntityFrameworkCore;
using Web.ApplicationLayer;
using Web.ApplicationLayer.Personnels;
using Web.Database;
using Web.Database.Repository;
using Web.Database.Repository.Personnels;
using Web.Database.UnitofWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


string connectionString = "Server=DESKTOP-0QE53DC;Database=ExampleDb;Integrated Security=True;TrustServerCertificate=True;";
builder.Services.AddDbContext<Context>(Options => Options.UseSqlServer(connectionString));
builder.Services.AddTransient<ICityService, CityService>();  // dependeny 
builder.Services.AddTransient<ICityRepository, CityRepository>();
builder.Services.AddTransient<IDistrictService, DistrictService>();
builder.Services.AddTransient<IPersonnelRepository, PersonnelRepository>();
builder.Services.AddTransient<IPersonnelService, PersonnelService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

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
