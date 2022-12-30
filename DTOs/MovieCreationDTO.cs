using System;
namespace c_sharp_entity_framework.DTOs
{
    public class MovieCreationDTO
    {
        public string Title { get; set; }
        public bool InCinemas { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<int> GenresIds { get; set; }
        public List<int> CinemaHallsIds { get; set; }
        public List<MovieActorsCreationDTO> MovieActors { get; set; }
    }
}

