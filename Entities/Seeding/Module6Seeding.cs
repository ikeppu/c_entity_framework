using System;
using Microsoft.EntityFrameworkCore;

namespace c_sharp_entity_framework.Entities.Seeding
{
    public static class Module6Seeding
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var andrew = new Person()
            {
                Id = 1,
                Name = "Andrew"
            };

            var sofija = new Person()
            {
                Id = 2,
                Name = "Sofija"
            };

            var message1 = new Message
            {
                Id = 1,
                Content = "Hello, Andrew",
                SenderId = sofija.Id,
                ReceiverId = andrew.Id
            };
            var message2 = new Message
            {
                Id = 2,
                Content = "I am fine, and how are you",
                SenderId = andrew.Id,
                ReceiverId = sofija.Id
            };

            var message3 = new Message
            {
                Id = 3,
                Content = "Buagagagaga",
                SenderId = sofija.Id,
                ReceiverId = andrew.Id
            };

            modelBuilder.Entity<Person>()
                .HasData(andrew, sofija);
            modelBuilder.Entity<Message>()
                .HasData(message1, message2, message3);
        }
    }
}


