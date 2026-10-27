using AirlineReservation.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirlineReservation.Infrastructure;

public class AirportConfiguration : IEntityTypeConfiguration<Airport>
{
    public void Configure(EntityTypeBuilder<Airport> builder)
    {
         builder.ToTable("Airports");

        builder.HasKey(airport => airport.Id);

        builder.Property(airport => airport.IataCode)
            .HasMaxLength(3)
            .IsRequired();

        builder.HasIndex(airport => airport.IataCode)
            .IsUnique();

        builder.Property(airport => airport.Name)
            .HasMaxLength(150)
            .IsRequired();

        builder.Property(airport => airport.City)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(airport => airport.Country)
            .HasMaxLength(100)
            .IsRequired();
    }
}