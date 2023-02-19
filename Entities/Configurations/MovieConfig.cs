using System;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace c_sharp_entity_framework.Entities.Configurations
{
    public class MovieConfig : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {

            builder
                .Property(p => p.Title)
                .IsRequired();

            builder
                .Property(p => p.PosterURL)
                .HasMaxLength(500)
                .IsUnicode(false);
        }
    }
}

