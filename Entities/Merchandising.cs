using System;
namespace c_sharp_entity_framework.Entities
{
    public class Merchandising : Products
    {
        public bool Available { get; set; }
        public double Weight { get; set; }
        public double Volume { get; set; }
        public bool IsClothing { get; set; }
        public bool IsCollectionable { get; set; }
    }
}

