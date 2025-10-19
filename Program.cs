using Microsoft.EntityFrameworkCore;
using ProductAPI.Data;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Product API",
        Version = "v1"
    });
});

// Database connection
var connString = builder.Configuration.GetConnectionString("ProdDBConnection");

builder.Services.AddDbContext<ProductDbContext>(options =>
    options.UseSqlServer(connString));

var app = builder.Build();


//Enable Swagger in dev
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Generates /swagger/v1/swagger.json
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Product API V1");
});
}

app.UseSwagger();
app.UseSwaggerUI();


app.UseAuthorization();
app.MapControllers();
app.Run();

