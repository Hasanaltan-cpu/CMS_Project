using DataLayer.SeedData;
using EntityLayer.Entities.Concrete;
using MapLayer.Mapping.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Context
{
    public class ApplicationDbContext:IdentityDbContext<AppUser>
    {

       // Here we pointed out DbSet with Entity Framework Core helps.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryMap());
            builder.ApplyConfiguration(new AppUserMap());
            builder.ApplyConfiguration(new PageMap());
            builder.ApplyConfiguration(new ProductMap());
            builder.ApplyConfiguration(new SeedPages());
            base.OnModelCreating(builder);
        }
    }
}
