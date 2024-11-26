using Microsoft.EntityFrameworkCore;
using Web.ApplicationLayer;
using Web.Database.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string connectionString = "Server=.;Database=ExampleDb;Ýntegrated Security: False;TrustServerCertificate:false;";
builder.Services.AddDbContext<Context>(Options => Options.UseSqlServer("connectionString"));
builder.Services.AddTransient<ICityService, CityService>();  // dependeny 
builder.Services.AddTransient<IDistrictService, IDistrictService>();

var app = builder.Build();



using(var scope= app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<Context>();

	try
	{
		dbContext.Database.CanConnect();
		Console.Write("DB context Succes");
	}
	catch (Exception exp)
	{
        dbContext.Database.CanConnect();
        Console.Write("DB context failure");
    }


}






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
