//using Microsoft.EntityFrameworkCore;
//using ProductAPI.Data;

//var builder = WebApplication.CreateBuilder(args);
//builder.WebHost.UseUrls("http://0.0.0.0:80");

//// Add services to the container.
//builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();

//builder.Services.AddSwaggerGen(options =>
//{
//    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
//    {
//        Title = "Product API",
//        Version = "v1"
//    });
//});

//// Database connection
//var connString = builder.Configuration.GetConnectionString("ProductConnn");

//builder.Services.AddDbContext<ProductDbContext>(options =>
//    options.UseSqlServer(connString));

//var app = builder.Build();


//// Enable Swagger in dev
////if (app.Environment.IsDevelopment())
////{
////    app.UseSwagger(); // Generates /swagger/v1/swagger.json
////    app.UseSwaggerUI(options =>
////    {
////        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Product API V1");
////    });
////}

//app.UseSwagger();
//app.UseSwaggerUI();
////var builder = WebApplication.CreateBuilder(args);

//// Add services to the container
////builder.Services.AddControllers();
//builder.Services.AddEndpointsApiExplorer();
////builder.Services.AddSwaggerGen();

////var app = builder.Build();

//app.UseSwagger();
//app.UseSwaggerUI();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();

//app.UseAuthorization();
//app.MapControllers();
//app.Run();

using Microsoft.EntityFrameworkCore;
using ProductAPI.Data;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://0.0.0.0:80");

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
var connString = builder.Configuration.GetConnectionString("ProductConnn");

var dbName = builder.Configuration.GetConnectionString("MyTestDB") ?? "DefaultTestDb";
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase(dbName));

var app = builder.Build();

// Enable Swagger UI unconditionally (or restrict to development if you want)
// if (app.Environment.IsDevelopment())
// {
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "Product API V1");
});
// }

app.UseAuthorization();

app.MapControllers();

app.Run();


