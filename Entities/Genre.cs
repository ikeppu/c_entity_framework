using System;
using System.ComponentModel.DataAnnotations;

namespace c_sharp_entity_framework.Entities
{
    public class Genre
    {
        //[Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}

