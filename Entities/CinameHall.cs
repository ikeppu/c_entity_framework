using System;
using System.ComponentModel.DataAnnotations.Schema;
using c_sharp_entity_framework.Entities.Enums;

namespace c_sharp_entity_framework.Entities
{
    public class CinameHall
    {
        public int Id { get; set; }
        public CinemaHallType CinemaHallType { get; set; }
        public decimal Cost { get; set; }
        public Currency Currency { get; set; }
        public int CinemaId { get; set; }
        // Below is change the foreign key in relation
        //public int TheCinemaId { get; set; }
        //[ForeignKey(nameof(TheCinemaId))]
        public Cinema Cinema { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}

