using System;
namespace c_sharp_entity_framework.Entities
{
    public class CinemaHall
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }
        public CinemaHallType CinemaHallType { get; set; }
        public int CinemaId { get; set; }
        public Cinema Cinema { get; set; }
    }
}

