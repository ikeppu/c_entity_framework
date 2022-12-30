using System;
using System.Reflection.Emit;
using c_sharp_entity_framework.Entities.Conversions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace c_sharp_entity_framework.Entities.Configurations
{
    public class CinameHallConfiguration : IEntityTypeConfiguration<CinameHall>
    {
        public void Configure(EntityTypeBuilder<CinameHall> builder)
        {
            builder
                .Property(p => p.CinemaHallType)
                .HasDefaultValue(CinemaHallType.TwoDimensions);
            builder
                .Property(p => p.Currency)
                .HasConversion<CurrencyToSymbolConverter>();
        }
    }
}

