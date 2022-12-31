using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace c_sharp_entity_framework.Utilities
{
    public class ChangeTrackerEventHandler : IChangeTrackerEventHandler
    {
        private readonly ILogger<ChangeTrackerEventHandler> logger;

        public ChangeTrackerEventHandler(ILogger<ChangeTrackerEventHandler> logger)
        {
            this.logger = logger;
        }

        public void TrackHandler(object sender, EntityTrackedEventArgs args)
        {
            var message = $"Entity: {args.Entry.Entity}, state: {args.Entry.State}";
            logger.LogInformation(message);
        }

        public void StateChangeHandler(object sender, EntityStateChangedEventArgs args)
        {
            var message = $"Entity: {args.Entry.Entity}, previous state: {args.OldState} - new state{args.NewState}";
            logger.LogInformation(message);
        }

        public void SavingChangedHandler(object sender, SavingChangesEventArgs args)
        {
            var entities = ((ApllicationDbContext)sender).ChangeTracker.Entries();

            foreach (var entity in entities)
            {
                var message = $"Entity: {entity.Entity} it's going to be {entity.State}";

                logger.LogInformation(message);
            }
        }

        public void SavedChangesHandler(object sender, SavedChangesEventArgs args)
        {
            var message = $"We processed {args.EntitiesSavedCount} entities";
            logger.LogInformation(message);
        }

        public void SavedChangesFailHandler(object sender, SaveChangesFailedEventArgs args)
        {
            logger.LogError(args.Exception, "Error in SaveChangess");
        }
    }
}

