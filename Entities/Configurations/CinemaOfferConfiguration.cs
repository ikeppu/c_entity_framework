using System;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace c_sharp_entity_framework.Entities.Configurations
{
    public class CinemaOfferConfiguration : IEntityTypeConfiguration<CinemaOffer>
    {
        public void Configure(EntityTypeBuilder<CinemaOffer> builder)
        {

            builder
                .Property(p => p.DiscountPercentage)
                .HasPrecision(5, 2);
            builder
                .Property(p => p.Begin)
                .HasColumnType("date");
            builder
                .Property(p => p.End)
                .HasColumnType("date");
        }
    }
}

