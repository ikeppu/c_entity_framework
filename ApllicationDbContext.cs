using System;
using System.Reflection;
using c_sharp_entity_framework.Entities;
using c_sharp_entity_framework.Entities.Seeding;
using Microsoft.EntityFrameworkCore;

namespace c_sharp_entity_framework
{
    public class ApllicationDbContext : DbContext
    {
        public ApllicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder modelConfigurationBuilder)
        {
            //base.ConfigureConventions(modelConfigurationBuilder);
            modelConfigurationBuilder
                .Properties<DateTime>()
                .HaveColumnType("date");

            //modelConfigurationBuilder
            //    .Properties<string>()
            //    .HaveMaxLength(150);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly());

            Module3Seeding.Seed(modelBuilder);
            Module6Seeding.Seed(modelBuilder);

            modelBuilder.Entity<Merchandising>().ToTable("Merchandising");
            modelBuilder.Entity<RentableMovie>().ToTable("RentableMovies");

            var movie = new RentableMovie()
            {
                Id = 1,
                Name = "Spider-Man",
                MovieId = 1,
                Price = 5.99m
            };

            var merchandising = new Merchandising()
            {
                Id = 2,
                Available = true,
                IsClothing = true,
                Name = "One piece T-Shirt",
                Weight = 1,
                Volume = 1,
                Price = 11
            };

            modelBuilder.Entity<Merchandising>().HasData(merchandising);
            modelBuilder.Entity<RentableMovie>().HasData(movie);


        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<CinemaOffer> CinemaOffers { get; set; }
        public DbSet<CinameHall> CinameHalls { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}


