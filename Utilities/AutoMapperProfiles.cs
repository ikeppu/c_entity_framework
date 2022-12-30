using System;
using AutoMapper;
using c_sharp_entity_framework.DTOs;
using c_sharp_entity_framework.Entities;

namespace c_sharp_entity_framework.Utilities
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Actor, ActorDTO>();

            CreateMap<Genre, GenreDTO>();
            CreateMap<GenresCreationDTO, Genre>();

            CreateMap<Movie, MovieDTO>()
                .ForMember(dto => dto.Actors, ent => ent.MapFrom(p => p.MovieActors
                    .Select(ma => ma.Actor)));
            //.ForMember(dto => dto.C)


            CreateMap<MovieCreationDTO, Movie>()
                .ForMember(ent => ent.Genres, dto => dto.MapFrom(prop =>
                    prop.GenresIds.Select(id => new Genre() { Id = id })))
                .ForMember(ent => ent.CinameHalls, dto => dto.MapFrom(prop =>
                    prop.CinemaHallsIds.Select(id =>
                        new CinameHall() { Id = id })));

            CreateMap<MovieActorsCreationDTO, MovieActor>();



        }
    }
}

