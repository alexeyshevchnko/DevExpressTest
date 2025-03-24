using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using WindowsFormsApp.Entitys;

namespace WindowsFormsApp.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItems> SaleItems { get; set; }   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            Console.WriteLine(connectionString);
            optionsBuilder.UseNpgsql(connectionString);
        }
 
    }
}
