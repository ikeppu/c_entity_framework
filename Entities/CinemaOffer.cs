using System;
namespace c_sharp_entity_framework.Entities
{
    public class CinemaOffer
    {
        public int Id { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public decimal DiscountPercentage { get; set; }

        public int CinemaId { get; set; }
    }
}


