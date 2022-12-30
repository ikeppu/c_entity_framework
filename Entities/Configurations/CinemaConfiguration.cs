using System;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace c_sharp_entity_framework.Entities.Configurations
{
    public class CinemaConfiguration : IEntityTypeConfiguration<Cinema>
    {
        public void Configure(EntityTypeBuilder<Cinema> builder)
        {
            builder
                .Property(p => p.Name)
                .HasMaxLength(150)
                .IsRequired();

            //builder.HasOne(c => c.CinemaOffer).WithOne();
        }
    }
}

