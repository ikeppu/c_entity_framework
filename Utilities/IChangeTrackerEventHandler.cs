using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace c_sharp_entity_framework.Utilities
{
    public interface IChangeTrackerEventHandler
    {
        void TrackHandler(object sender, EntityTrackedEventArgs args);
        void StateChangeHandler(object sender, EntityStateChangedEventArgs args);
        void SavingChangedHandler(object sender, SavingChangesEventArgs args);
        void SavedChangesHandler(object sender, SavedChangesEventArgs args);
        void SavedChangesFailHandler(object sender, SaveChangesFailedEventArgs args);
    }
}

