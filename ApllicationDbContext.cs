using System;
using c_sharp_entity_framework.Entities;
using Microsoft.EntityFrameworkCore;

namespace c_sharp_entity_framework
{
    public class ApllicationDbContext : DbContext
    {
        public ApllicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("date");
            configurationBuilder.Properties<string>().HaveMaxLength(150);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Genre>()
            //    .ToTable(name: "GenresTbl", schema: "movies")
            // Add Primary Key Strategy
            //modelBuilder.Entity<Genre>()
            //.Property(p => p.Name)
            //.HasColumnName("GenreName")
            //.HasMaxLength(150);
            //.HasKey(p => p.Id);
            // ------------
            // Actors

        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<CinemaOffer> CinemaOffers { get; set; }
        public DbSet<CinemaHall> CinemaHalls { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }


    }
}

