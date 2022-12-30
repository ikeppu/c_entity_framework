using System;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace c_sharp_entity_framework.Entities.Configurations
{
    public class MovieActorConfiguration : IEntityTypeConfiguration<MovieActor>
    {
        public void Configure(EntityTypeBuilder<MovieActor> builder)
        {
            //Many-to-many
            builder
                .HasKey(p => new { p.MovieId, p.ActorId });
            builder
                .Property(p => p.Character)
                .HasMaxLength(150);
        }
    }
}

