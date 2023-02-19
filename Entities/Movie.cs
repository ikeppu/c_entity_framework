using System;
namespace c_sharp_entity_framework.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool InCinemas { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PosterURL { get; set; }
        public ICollection<Genre> Genres { get; set; }
        // MANY-TO-MANY
        public ICollection<MovieActor> MovieActors { get; set; }

    }
}

