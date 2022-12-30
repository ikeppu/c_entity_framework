using System;
namespace c_sharp_entity_framework.Entities
{
    public class Cinema
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // one-to-one
        public CinemaOffer CinemaOffer { get; set; }
        public ICollection<CinameHall> CinameHalls { get; set; }
    }
}


