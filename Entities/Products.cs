using System;
using Microsoft.EntityFrameworkCore;
namespace c_sharp_entity_framework.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Precision(18, 2)]
        public decimal Price { get; set; }
    }
}


