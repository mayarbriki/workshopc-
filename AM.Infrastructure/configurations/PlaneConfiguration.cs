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
    internal class PlaneConfiguration : IEntityTypeConfiguration<Plane>
    {
      

        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder.HasKey(p => p.PlaneId);
            builder.ToTable("MyPlanes");
            builder.Property(p => p.Capacity);

        }
    }
}
