using System;
namespace c_sharp_entity_framework.Entities
{
    public class Actor
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public DateTime? DateOfBirth { get; set; }
        // MANY-TO-MANY
        public ICollection<MovieActor> MovieActors { get; set; }
    }
}

