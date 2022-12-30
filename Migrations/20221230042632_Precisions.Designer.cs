﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using c_sharp_entity_framework;

#nullable disable

namespace c_sharp_entity_framework.Migrations
{
    [DbContext(typeof(ApllicationDbContext))]
    [Migration("20221230042632_Precisions")]
    partial class Precisions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("c_sharp_entity_framework.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Biography")
                        .HasColumnType("text");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("Date");

                    b.Property<string>("Name")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Biography = "Thomas Stanley Holland (born 1 June 1996) is an English actor. He is recipient of several accolades, including the 2017 BAFTA Rising Star Award. Holland began his acting career as a child actor on the West End stage in Billy Elliot the Musical at the Victoria Palace Theatre in 2008, playing a supporting part",
                            DateOfBirth = new DateTime(1996, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Tom Holland"
                        },
                        new
                        {
                            Id = 2,
                            Biography = "Samuel Leroy Jackson (born December 21, 1948) is an American actor and producer. One of the most widely recognized actors of his generation, the films in which he has appeared have collectively grossed over $27 billion worldwide, making him the highest-grossing actor of all time (excluding cameo appearances and voice roles).",
                            DateOfBirth = new DateTime(1948, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Samuel L. Jackson"
                        },
                        new
                        {
                            Id = 3,
                            Biography = "Robert John Downey Jr. (born April 4, 1965) is an American actor and producer. His career has been characterized by critical and popular success in his youth, followed by a period of substance abuse and legal troubles, before a resurgence of commercial success later in his career.",
                            DateOfBirth = new DateTime(1965, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Robert Downey Jr."
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1981, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Chris Evans"
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(1972, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Dwayne Johnson"
                        },
                        new
                        {
                            Id = 6,
                            DateOfBirth = new DateTime(2000, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Auli'i Cravalho"
                        },
                        new
                        {
                            Id = 7,
                            DateOfBirth = new DateTime(1984, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Scarlett Johansson"
                        },
                        new
                        {
                            Id = 8,
                            DateOfBirth = new DateTime(1964, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Keanu Reeves"
                        });
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.CinameHall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CinemaHallType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(1);

                    b.Property<int>("CinemaId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Cost")
                        .HasColumnType("numeric");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.ToTable("CinameHalls");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            CinemaHallType = 1,
                            CinemaId = 3,
                            Cost = 250m,
                            Currency = ""
                        },
                        new
                        {
                            Id = 6,
                            CinemaHallType = 2,
                            CinemaId = 3,
                            Cost = 330m,
                            Currency = ""
                        },
                        new
                        {
                            Id = 7,
                            CinemaHallType = 3,
                            CinemaId = 3,
                            Cost = 450m,
                            Currency = ""
                        },
                        new
                        {
                            Id = 8,
                            CinemaHallType = 1,
                            CinemaId = 4,
                            Cost = 250m,
                            Currency = ""
                        },
                        new
                        {
                            Id = 1,
                            CinemaHallType = 1,
                            CinemaId = 1,
                            Cost = 220m,
                            Currency = ""
                        },
                        new
                        {
                            Id = 2,
                            CinemaHallType = 2,
                            CinemaId = 1,
                            Cost = 320m,
                            Currency = ""
                        },
                        new
                        {
                            Id = 3,
                            CinemaHallType = 1,
                            CinemaId = 2,
                            Cost = 200m,
                            Currency = ""
                        },
                        new
                        {
                            Id = 4,
                            CinemaHallType = 2,
                            CinemaId = 2,
                            Cost = 290m,
                            Currency = ""
                        });
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("Id");

                    b.ToTable("Cinemas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Agora Mall"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sambil"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Megacentro"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Acropolis"
                        });
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.CinemaOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Begin")
                        .HasColumnType("date");

                    b.Property<int>("CinemaId")
                        .HasColumnType("integer");

                    b.Property<decimal>("DiscountPercentage")
                        .HasPrecision(5, 2)
                        .HasColumnType("numeric(5,2)");

                    b.Property<DateTime>("End")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId")
                        .IsUnique();

                    b.ToTable("CinemaOffers");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Begin = new DateTime(2022, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CinemaId = 4,
                            DiscountPercentage = 15m,
                            End = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 1,
                            Begin = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CinemaId = 1,
                            DiscountPercentage = 10m,
                            End = new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Animation"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Science Fiction"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Drama"
                        });
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.Log", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("integer");

                    b.Property<int>("SenderId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverId");

                    b.HasIndex("SenderId");

                    b.ToTable("Messages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Hello, Andrew",
                            ReceiverId = 1,
                            SenderId = 2
                        },
                        new
                        {
                            Id = 2,
                            Content = "I am fine, and how are you",
                            ReceiverId = 2,
                            SenderId = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "Buagagagaga",
                            ReceiverId = 1,
                            SenderId = 2
                        });
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("InCinemas")
                        .HasColumnType("boolean");

                    b.Property<string>("PosterUrl")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("character varying(500)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            InCinemas = false,
                            PosterUrl = "https://upload.wikimedia.org/wikipedia/en/8/8a/The_Avengers_%282012_film%29_poster.jpg",
                            ReleaseDate = new DateTime(2012, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Avengers"
                        },
                        new
                        {
                            Id = 2,
                            InCinemas = false,
                            PosterUrl = "https://upload.wikimedia.org/wikipedia/en/9/98/Coco_%282017_film%29_poster.jpg",
                            ReleaseDate = new DateTime(2017, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Coco"
                        },
                        new
                        {
                            Id = 3,
                            InCinemas = false,
                            PosterUrl = "https://upload.wikimedia.org/wikipedia/en/0/00/Spider-Man_No_Way_Home_poster.jpg",
                            ReleaseDate = new DateTime(2022, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Spider-Man: No way home"
                        },
                        new
                        {
                            Id = 4,
                            InCinemas = false,
                            PosterUrl = "https://upload.wikimedia.org/wikipedia/en/0/00/Spider-Man_No_Way_Home_poster.jpg",
                            ReleaseDate = new DateTime(2019, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Spider-Man: Far From Home"
                        },
                        new
                        {
                            Id = 5,
                            InCinemas = true,
                            PosterUrl = "https://upload.wikimedia.org/wikipedia/en/5/50/The_Matrix_Resurrections.jpg",
                            ReleaseDate = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Matrix Resurrections"
                        });
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.MovieActor", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("integer");

                    b.Property<int>("ActorId")
                        .HasColumnType("integer");

                    b.Property<string>("Character")
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<int>("Order")
                        .HasColumnType("integer");

                    b.HasKey("MovieId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("MovieActors");

                    b.HasData(
                        new
                        {
                            MovieId = 4,
                            ActorId = 2,
                            Character = "Samuel L. Jackson",
                            Order = 2
                        },
                        new
                        {
                            MovieId = 4,
                            ActorId = 1,
                            Character = "Peter Parker",
                            Order = 1
                        },
                        new
                        {
                            MovieId = 3,
                            ActorId = 1,
                            Character = "Peter Parker",
                            Order = 1
                        },
                        new
                        {
                            MovieId = 1,
                            ActorId = 3,
                            Character = "Iron Man",
                            Order = 2
                        },
                        new
                        {
                            MovieId = 1,
                            ActorId = 7,
                            Character = "Black Widow",
                            Order = 3
                        },
                        new
                        {
                            MovieId = 1,
                            ActorId = 4,
                            Character = "Capitán América",
                            Order = 1
                        },
                        new
                        {
                            MovieId = 5,
                            ActorId = 8,
                            Character = "Neo",
                            Order = 1
                        });
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasPrecision(18, 2)
                        .HasColumnType("numeric(18,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("date");

                    b.Property<int>("PaymentType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Payments");

                    b.HasDiscriminator<int>("PaymentType");
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Andrew"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sofija"
                        });
                });

            modelBuilder.Entity("CinameHallMovie", b =>
                {
                    b.Property<int>("CinameHallsId")
                        .HasColumnType("integer");

                    b.Property<int>("MoviesId")
                        .HasColumnType("integer");

                    b.HasKey("CinameHallsId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("CinameHallMovie");

                    b.HasData(
                        new
                        {
                            CinameHallsId = 3,
                            MoviesId = 5
                        },
                        new
                        {
                            CinameHallsId = 4,
                            MoviesId = 5
                        },
                        new
                        {
                            CinameHallsId = 1,
                            MoviesId = 5
                        },
                        new
                        {
                            CinameHallsId = 2,
                            MoviesId = 5
                        },
                        new
                        {
                            CinameHallsId = 5,
                            MoviesId = 5
                        },
                        new
                        {
                            CinameHallsId = 6,
                            MoviesId = 5
                        },
                        new
                        {
                            CinameHallsId = 7,
                            MoviesId = 5
                        });
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.Property<int>("GenresId")
                        .HasColumnType("integer");

                    b.Property<int>("MoviesId")
                        .HasColumnType("integer");

                    b.HasKey("GenresId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("GenreMovie");

                    b.HasData(
                        new
                        {
                            GenresId = 1,
                            MoviesId = 1
                        },
                        new
                        {
                            GenresId = 4,
                            MoviesId = 1
                        },
                        new
                        {
                            GenresId = 2,
                            MoviesId = 2
                        },
                        new
                        {
                            GenresId = 4,
                            MoviesId = 3
                        },
                        new
                        {
                            GenresId = 1,
                            MoviesId = 3
                        },
                        new
                        {
                            GenresId = 3,
                            MoviesId = 3
                        },
                        new
                        {
                            GenresId = 4,
                            MoviesId = 4
                        },
                        new
                        {
                            GenresId = 1,
                            MoviesId = 4
                        },
                        new
                        {
                            GenresId = 3,
                            MoviesId = 4
                        },
                        new
                        {
                            GenresId = 4,
                            MoviesId = 5
                        },
                        new
                        {
                            GenresId = 1,
                            MoviesId = 5
                        },
                        new
                        {
                            GenresId = 5,
                            MoviesId = 5
                        });
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.CardPayment", b =>
                {
                    b.HasBaseType("c_sharp_entity_framework.Entities.Payment");

                    b.Property<string>("Last4Digits")
                        .IsRequired()
                        .HasColumnType("char(4)");

                    b.HasDiscriminator().HasValue(2);

                    b.HasData(
                        new
                        {
                            Id = 5,
                            Amount = 456.76m,
                            PaymentDate = new DateTime(2022, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentType = 2,
                            Last4Digits = "1234"
                        },
                        new
                        {
                            Id = 6,
                            Amount = 1233.56m,
                            PaymentDate = new DateTime(2022, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentType = 2,
                            Last4Digits = "4567"
                        });
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.PaypalPayment", b =>
                {
                    b.HasBaseType("c_sharp_entity_framework.Entities.Payment");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue(1);

                    b.HasData(
                        new
                        {
                            Id = 7,
                            Amount = 456m,
                            PaymentDate = new DateTime(2022, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentType = 1,
                            EmailAddress = "sofija@sof.com"
                        },
                        new
                        {
                            Id = 8,
                            Amount = 123m,
                            PaymentDate = new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PaymentType = 1,
                            EmailAddress = "andrew@sof.com"
                        });
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.CinameHall", b =>
                {
                    b.HasOne("c_sharp_entity_framework.Entities.Cinema", "Cinema")
                        .WithMany("CinameHalls")
                        .HasForeignKey("CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.CinemaOffer", b =>
                {
                    b.HasOne("c_sharp_entity_framework.Entities.Cinema", null)
                        .WithOne("CinemaOffer")
                        .HasForeignKey("c_sharp_entity_framework.Entities.CinemaOffer", "CinemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.Message", b =>
                {
                    b.HasOne("c_sharp_entity_framework.Entities.Person", "Receiver")
                        .WithMany("ReceivedMessages")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("c_sharp_entity_framework.Entities.Person", "Sender")
                        .WithMany("SentMessages")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.MovieActor", b =>
                {
                    b.HasOne("c_sharp_entity_framework.Entities.Actor", "Actor")
                        .WithMany("MovieActors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("c_sharp_entity_framework.Entities.Movie", "Movie")
                        .WithMany("MovieActors")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("CinameHallMovie", b =>
                {
                    b.HasOne("c_sharp_entity_framework.Entities.CinameHall", null)
                        .WithMany()
                        .HasForeignKey("CinameHallsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("c_sharp_entity_framework.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.HasOne("c_sharp_entity_framework.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("c_sharp_entity_framework.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.Actor", b =>
                {
                    b.Navigation("MovieActors");
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.Cinema", b =>
                {
                    b.Navigation("CinameHalls");

                    b.Navigation("CinemaOffer");
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.Movie", b =>
                {
                    b.Navigation("MovieActors");
                });

            modelBuilder.Entity("c_sharp_entity_framework.Entities.Person", b =>
                {
                    b.Navigation("ReceivedMessages");

                    b.Navigation("SentMessages");
                });
#pragma warning restore 612, 618
        }
    }
}
