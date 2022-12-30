using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace c_sharp_entity_framework.Entities.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder
                .Property(p => p.Amount)
                .HasPrecision(18, 2);

            builder
                .HasDiscriminator(p => p.PaymentType)
                .HasValue<PaypalPayment>(PaymentType.Paypal)
                .HasValue<CardPayment>(PaymentType.Card);


        }
    }
}

