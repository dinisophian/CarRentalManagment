using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRentalManagment.Domain;
using CarRentalManagment.Configuration.Entities;

namespace CarRentalManagment.Data
{
    public class CarRentalManagmentContext : DbContext
    {
        public CarRentalManagmentContext (DbContextOptions<CarRentalManagmentContext> options)
            : base(options)
        {
        }

        public DbSet<CarRentalManagment.Domain.Make> Make { get; set; } = default!;
        public DbSet<CarRentalManagment.Domain.Model> Model { get; set; } = default!;
        public DbSet<CarRentalManagment.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CarRentalManagment.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<CarRentalManagment.Domain.Booking> Booking { get; set; } = default!;

        public DbSet<CarRentalManagment.Domain.Customer> Customer { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());

            builder.ApplyConfiguration(new MakeSeed());

            builder.ApplyConfiguration(new ModelSeed());
        }
        

    }
}
