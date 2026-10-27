using Microsoft.EntityFrameworkCore;
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
    }
}
