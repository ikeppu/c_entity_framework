using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace c_sharp_entity_framework.Entities
{
    public class Log
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        public string Message { get; set; }
    }
}

