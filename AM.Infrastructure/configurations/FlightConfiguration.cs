using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Infrastructure.configurations
{
    internal class FlightConfiguration : IEntityTypeConfiguration<Flight>

    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasMany(f => f.Passengers).WithMany(p => p.Flights).UsingEntity("Reservations");
            builder.HasOne(f => f.Plane).WithMany(p => p.Flights).HasForeignKey(f => f.PlaneId);
        }
    }
}
