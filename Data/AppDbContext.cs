using Microsoft.EntityFrameworkCore;
using ProductAPI.Models;
using System;
namespace ProductAPI.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
       
    }
}
