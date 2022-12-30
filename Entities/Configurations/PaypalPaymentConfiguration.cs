using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace c_sharp_entity_framework.Entities.Configurations
{
    public class PaypalPaymentConfiguration : IEntityTypeConfiguration<PaypalPayment>
    {
        public void Configure(EntityTypeBuilder<PaypalPayment> builder)
        {
            builder
                .Property(p => p.EmailAddress)
                .IsRequired();

            var payment = new PaypalPayment()
            {
                Id = 7,
                PaymentDate = new DateTime(2022, 12, 28),
                PaymentType = PaymentType.Paypal,
                Amount = 456,
                EmailAddress = "sofija@sof.com"
            };

            var payment1 = new PaypalPayment()
            {
                Id = 8,
                PaymentDate = new DateTime(2022, 12, 3),
                PaymentType = PaymentType.Paypal,
                Amount = 123,
                EmailAddress = "andrew@sof.com"
            };

            builder.HasData(payment, payment1);
        }
    }
}

