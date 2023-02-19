using System;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace c_sharp_entity_framework.Entities.Configurations
{
    public class CinemaHallConfig : IEntityTypeConfiguration<CinemaHall>
    {
        public void Configure(EntityTypeBuilder<CinemaHall> builder)
        {
            builder
                .Property(p => p.Cost)
                .HasPrecision(precision: 9, scale: 5);

            builder
                .Property(p => p.CinemaHallType)
                .HasDefaultValue(CinemaHallType.TwoDimensions)
                .HasPrecision(precision: 9, scale: 5);
        }
    }
}

