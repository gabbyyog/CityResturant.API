using System;
using CityResturant.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityResturant.Infrastructure.DataBContext;

internal class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    internal DbSet<Resturant> Resturants {get; set;}
    internal DbSet<Dish> Dishes {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Resturant>()
        .OwnsOne(r => r.Address);

        modelBuilder.Entity<Resturant>()
        .HasMany(r => r.Dishes)
        .WithOne()
        .HasForeignKey(d => d.ResturantId);
    }
}
