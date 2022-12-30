using System;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace c_sharp_entity_framework.Entities.Configurations
{
    public class ActorConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder
             .Property(p => p.Name)
             .HasMaxLength(150);
            builder
             .Property(p => p.DateOfBirth)
             .HasColumnType("Date");
            //builder
            //    .Ignore(p => p.Age);
        }
    }
}

