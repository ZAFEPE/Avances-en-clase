using Microsoft.EntityFrameworkCore;
using Sales.API.DataBase;
using Scalar.AspNetCore; 

var builder = WebApplication.CreateBuilder(args);
//Add database service      // ESTUDIAAAAAAAAR
builder.Services.AddDbContext<SalesDbContext> (options => 
    options.UseSqlite(builder.Configuration
    .GetConnectionString("DefaultConnection")) // no se pone la url de mi maquina por que solo ufnciona en local    
);// te vas a appsettings.Development, y agregas el json que se agregó

// Add services to the container.
builder.Services.AddOpenApi();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())// solo se genera cuando esta en entorno de desarrollo
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();