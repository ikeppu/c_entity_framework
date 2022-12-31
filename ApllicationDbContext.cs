using System;
using System.Reflection;
using c_sharp_entity_framework.Entities;
using c_sharp_entity_framework.Entities.Seeding;
using c_sharp_entity_framework.Utilities;
using Microsoft.EntityFrameworkCore;

namespace c_sharp_entity_framework
{
    public class ApllicationDbContext : DbContext
    {
        private readonly IUserService userService;

        public ApllicationDbContext()
        {

        }

        public ApllicationDbContext(DbContextOptions options,
            IUserService userService, IChangeTrackerEventHandler changeTrackerEventHandler) : base(options)
        {
            this.userService = userService;
            if (changeTrackerEventHandler is not null)
            {
                ChangeTracker.Tracked += changeTrackerEventHandler.TrackHandler;
                ChangeTracker.StateChanged += changeTrackerEventHandler.StateChangeHandler;
                SavingChanges += changeTrackerEventHandler.SavingChangedHandler;
                SavedChanges += changeTrackerEventHandler.SavedChangesHandler;
                SaveChangesFailed += changeTrackerEventHandler.SavedChangesFailHandler;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
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

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {

            ProcessSaveChanges();

            return base.SaveChangesAsync(cancellationToken);


        }

        private void ProcessSaveChanges()
        {
            foreach (var item in ChangeTracker.Entries().Where(e =>
                e.State == EntityState.Added && e.Entity is AuditableEntity))
            {
                var entity = item.Entity as AuditableEntity;
                entity.CreatedBy = userService.GetUserId();
                entity.ModifiedBy = userService.GetUserId();

            }

            foreach (var item in ChangeTracker.Entries().Where(e =>
                e.State == EntityState.Modified && e.Entity is AuditableEntity))
            {
                var entity = item.Entity as AuditableEntity;
                entity.ModifiedBy = userService.GetUserId();
                item.Property(nameof(entity.CreatedBy)).IsModified = false;
            }
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


