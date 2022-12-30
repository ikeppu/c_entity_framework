using System;
namespace c_sharp_entity_framework.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool InCinemas { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PosterUrl { get; set; }
        public List<Genre> Genres { get; set; }
        public List<CinameHall> CinameHalls { get; set; }
        public List<MovieActor> MovieActors { get; set; }
    }
}

