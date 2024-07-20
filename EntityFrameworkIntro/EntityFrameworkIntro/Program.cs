using BLL.Extensions;
using DataLayer;
using DataLayer.Data.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDataAccessLayer(configuration);
builder.Services.AddBusinessLogicLayer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    try
    {
        var context = serviceProvider.GetRequiredService<WebShopDbContext>();
        DbInitializer.InitializeDatabase(context);
    }
    catch (Exception)
    {
        throw;
    }
}

/* UNCOMMENT TO SEED DATA
using (var scope = app.Services.CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    try
    {
        var seeder = serviceProvider.GetRequiredService<DataSeeder>();
        await seeder.Seed();
    }
    catch (Exception)
    {
        throw;
    }
}
*/

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
