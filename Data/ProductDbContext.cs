using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ProductAPI.Models;
using System;
namespace ProductAPI.Data
{

    public class ProductDbContext : DbContext
    {

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Product { get; set; }
    }

      
        public class ProductDbContextFactory : IDesignTimeDbContextFactory<ProductDbContext>
        {
            public ProductDbContext CreateDbContext(string[] args)
            {
                // Load configuration from appsettings.json
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = configuration.GetConnectionString("ProductConnn");

                var optionsBuilder = new DbContextOptionsBuilder<ProductDbContext>();
                optionsBuilder.UseSqlServer(connectionString); 

                return new ProductDbContext(optionsBuilder.Options);
            }
        }
    }

