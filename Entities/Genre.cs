using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace c_sharp_entity_framework.Entities
{
    //[Table(name: "Genrestbl", Schema = "movies")]
    //[Index(nameof(Name), IsUnique = true)]
    public class Genre : AuditableEntity
    {
        // [Key]
        public int Id { get; set; }
        // [StringLength(maximumLength: 150)]
        // [Required]
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set; }

    }
}

