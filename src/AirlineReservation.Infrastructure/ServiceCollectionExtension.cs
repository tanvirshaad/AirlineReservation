using AirlineReservation.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirlineReservation.Infrastructure
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddAirlineReservationSqlServerPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("AirlineReservationDb") 
                ?? throw new ArgumentNullException("Database connection string AirlineReservationDb was not found");

            services.AddDbContext<AirlineReservationDbContext>(options =>
                options.UseSqlServer(connectionString));

            return services;
        }
    }
}
