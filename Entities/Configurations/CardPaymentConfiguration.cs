using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace c_sharp_entity_framework.Entities.Configurations
{
    public class CardPaymentConfiguration : IEntityTypeConfiguration<CardPayment>
    {
        public void Configure(EntityTypeBuilder<CardPayment> builder)
        {
            builder
                .Property(p => p.Last4Digits)
                .HasColumnType("char(4)")
                .IsRequired();

            var payment = new CardPayment()
            {
                Id = 5,
                PaymentDate = new DateTime(2022, 12, 23),
                PaymentType = PaymentType.Card,
                Amount = 456.76m,
                Last4Digits = "1234"
            };

            var payment1 = new CardPayment()
            {
                Id = 6,
                PaymentDate = new DateTime(2022, 11, 12),
                PaymentType = PaymentType.Card,
                Amount = 1233.56m,
                Last4Digits = "4567"
            };

            builder.HasData(payment, payment1);
        }

    }
}

