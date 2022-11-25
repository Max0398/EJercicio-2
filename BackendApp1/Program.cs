//Todo: 1. Para trabajar con EntityFramework
using Microsoft.EntityFrameworkCore;
using UniversityBackend.DataAccess;

var builder = WebApplication.CreateBuilder(args);

//Todo: 2 Conexion con sqlserver
const string CONNECTIONNAME = "UniversityDB";
var connectionString=builder.Configuration.GetConnectionString(CONNECTIONNAME);


//3. Añadir contextos
builder.Services.AddDbContext<UniversityDBContex>(options => options.UseSqlServer
(connectionString));



// Add services to the container.

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
