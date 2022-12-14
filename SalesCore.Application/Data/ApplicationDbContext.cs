using CarSales.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCore.Application.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarSalesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plate>()
    .HasIndex((c=>c.FrontPlate))
        .IsUnique();
            modelBuilder.Entity<Plate>()
    .HasIndex((c => c.RearPlate))
        .IsUnique();
            modelBuilder.Entity<InsuranceContract>().HasKey(I => I.InsuranceNumber);
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<InsuranceContract> insuranceContracts  { get; set; }
        public DbSet<Plate> plates { get; set; }

    }
}
