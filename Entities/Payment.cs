using System;
namespace c_sharp_entity_framework.Entities
{
    public abstract class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public PaymentType PaymentType { get; set; }
    }
}

