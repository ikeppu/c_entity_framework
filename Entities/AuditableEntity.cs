using System;
namespace c_sharp_entity_framework.Entities
{
    public class AuditableEntity
    {
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}

