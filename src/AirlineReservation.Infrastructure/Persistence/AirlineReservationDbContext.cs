using Microsoft.EntityFrameworkCore;
using AirlineReservation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineReservation.Infrastructure.Persistence
{
    public class AirlineReservationDbContext : DbContext
    {
        public AirlineReservationDbContext(DbContextOptions<AirlineReservationDbContext> options) : base(options)
        {
        }

        public DbSet<Airport> Airports { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AirportConfiguration());
        }
    }
}
