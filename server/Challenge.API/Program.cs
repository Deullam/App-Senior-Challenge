using livraria.Models;
using livraria.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration.GetConnectionString("DBConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(connectionString));

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.PropertyNamingPolicy = null;
});


var app = builder.Build();
// AutoMapper Settings
//builder.Services.AddAutoMapperConfiguration();

//DI
//builder.Services.AddDependencyInjectionConfiguration();

//Confid CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder => builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
    );
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
DatabaseManagementService.MigrationInitialisation(app);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
