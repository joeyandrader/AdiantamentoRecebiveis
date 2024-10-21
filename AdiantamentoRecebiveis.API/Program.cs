using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using AdiantamentoRecebiveis.API.Ioc;
using AdiantamentoRecebiveis.Application.Utils;
using AdiantamentoRecebiveis.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;


var builder = WebApplication.CreateBuilder(args);

//Add Services to the container.
builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    var xmlFileName = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFileName);
    opt.IncludeXmlComments(xmlPath);
});

//Dependecy Load
Ioc.LoadDependencyInjection(builder.Services);

//AppSettings Load
AppSettings.LoadSettings(builder.Configuration);

var teste = AppSettings.ConnectionString;

//For automatic generate add apply migrations
builder.Services.AddDbContext<DataContext>(
    conn => conn.UseSqlServer("Server=JOEL\\SQLEXPRESS;Database=testedb;Trusted_Connection=True;TrustServerCertificate=True;"));


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseSwagger(c => { c.RouteTemplate = "Api/swagger/{documentName}/swagger.json"; });
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("api/swagger/v1/swagger.json", "AdiantamentoRecebiveis API v1");
        c.RoutePrefix = "api/swagger";
    });
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();


app.Run();

