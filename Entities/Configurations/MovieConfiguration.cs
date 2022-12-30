using System;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace c_sharp_entity_framework.Entities.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder
                .Property(p => p.Title)
                .HasMaxLength(250)
                .IsRequired();
            builder
                .Property(p => p.ReleaseDate)
                .HasColumnType("date");

            builder
                .Property(p => p.PosterUrl)
                .HasMaxLength(500)
                .IsUnicode(false);
        }
    }
}

