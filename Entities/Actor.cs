using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace c_sharp_entity_framework.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        //[Column(TypeName = "Date")]
        public DateTime? DateOfBirth { get; set; }
        //[NotMapped]
        //public int? Age
        //{
        //    get
        //    {
        //        if (!DateOfBirth.HasValue)
        //        {
        //            return null;
        //        }

        //        var dob = DateOfBirth.Value;

        //        var age = DateTime.Today.Year - dob.Year;

        //        if (new DateTime(DateTime.Today.Year, dob.Month, dob.Day) >
        //            DateTime.Today)
        //        {
        //            age--;
        //        }

        //        return age;
        //    }
        //}
        public HashSet<MovieActor> MovieActors { get; set; }
    }
}

