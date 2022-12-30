using System;
using System.ComponentModel.DataAnnotations;

namespace c_sharp_entity_framework.DTOs
{
    public class GenresCreationDTO
    {
        [Required]
        public string Name { get; set; }
    }
}

