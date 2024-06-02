using ElegantCoffeeImplementation.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElegantCoffeeImplementation.Data
{
    public class ElegantContext : IdentityDbContext
    {
        public ElegantContext (DbContextOptions<ElegantContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Picture> Pictures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Bid>().ToTable("Bid");
            modelBuilder.Entity<Picture>().ToTable("Picture");
        }

    }
}
