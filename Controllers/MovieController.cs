using System;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using c_sharp_entity_framework.DTOs;
using c_sharp_entity_framework.Entities;
using c_sharp_entity_framework.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace c_sharp_entity_framework.Controllers
{
    [ApiController]
    [Route("api/movie")]
    public class MovieController : ControllerBase
    {
        private readonly ApllicationDbContext context;
        private readonly IMapper mapper;

        public MovieController(ApllicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<Movie>> Get()
        {
            return await context.Movies
                .OrderBy(m => m.Title)
                .ToListAsync();
        }

        //[HttpGet("{id:int}")]
        //public async Task<ActionResult<MovieDTO>> GetById(int id)
        //{
        //    //EAGER LOADER
        //    var movie = await context.Movies
        //        .Include(m => m.Genres
        //            .OrderByDescending(g => g.Name)
        //            .Where(g => g.Name.Contains("m")))
        //        .Include(m => m.CinameHalls)
        //            .ThenInclude(ch => ch.Cinema)
        //        .Include(m => m.MovieActors)
        //            .ThenInclude(ma => ma.Actor)
        //        .FirstOrDefaultAsync(m => m.Id == id);

        //    if (movie is null)
        //        return NotFound("No movie with that id");

        //    var movieDTO = mapper.Map<MovieDTO>(movie);

        //    return movieDTO;

        //}

        [HttpGet("automapper/{id:int}")]
        public async Task<ActionResult<MovieDTO>> GetWithAutoMapper(int id)
        {
            //EAGER LOADER
            var movie = await context.Movies
                .ProjectTo<MovieDTO>(mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (movie is null)
                return NotFound("No movie with that id");

            var movieDTO = mapper.Map<MovieDTO>(movie);

            return movieDTO;

        }

        //[HttpGet("select-loading/{id:int}")]
        //public async Task<ActionResult> GetSelectLoading(int id)
        //{
        //    //Annonymyos type
        //    var movieDTO = await context.Movies.Select(m => new
        //    {
        //        Id = m.Id,
        //        Title = m.Title,
        //        Genres = m.Genres.Select(g => g.Name)
        //    }).FirstOrDefaultAsync(m => m.Id == id);

        //    if (movieDTO is null)
        //        return NotFound("Not Found");

        //    return Ok(movieDTO);
        //}

        //[HttpGet("explicit-loading/{id:int}")]
        //public async Task<ActionResult<MovieDTO>> GetExplicit(int id)
        //{
        //    var movie = await context.Movies.FirstOrDefaultAsync(m => m.Id == id);

        //    if (movie is null)
        //        return NotFound("Movie not found");

        //    await context.Entry(movie).Collection(p => p.Genres).LoadAsync();
        //    var genresCount = await context.Entry(movie)
        //        .Collection(p => p.Genres)
        //        .Query()
        //        .CountAsync();

        //    Console.WriteLine(genresCount);

        //    var movieDTO = mapper.Map<MovieDTO>(movie);

        //    return movieDTO;
        //}

        //[HttpGet("grouped-by-cinema")]
        //public async Task<ActionResult> GetGroupedByCinema()
        //{
        //    var groupedMovies = await context.Movies
        //        .GroupBy(m => m.InCinemas)
        //        .Select(g => new
        //        {
        //            InCinemas = g.Key,
        //            Count = g.Count(),
        //            Movies = g.ToList()
        //        }).ToListAsync();

        //    return Ok(groupedMovies);
        //}

        //[HttpGet("grouped-by-genres-count")]
        //public async Task<ActionResult> GetGroupedByGenresCount()
        //{
        //    var groupedMovies = await context.Movies
        //        .GroupBy(m => m.Genres.Count())
        //        .Select(g => new
        //        {
        //            Count = g.Key,
        //            Titles = g.Select(x => x.Title),
        //            Genres = g.Select(m => m.Genres)
        //        }).ToListAsync();


        //    return Ok(groupedMovies);
        //}

        [HttpPost]
        public async Task<ActionResult> Post(MovieCreationDTO movieCreationDTO)
        {
            var movie = mapper.Map<Movie>(movieCreationDTO);

            movie.Genres.ForEach(g => context.Entry(g).State = EntityState.Unchanged);
            movie.CinameHalls.ForEach(ch => context.Entry(ch).State = EntityState.Unchanged);

            if (movie.MovieActors is not null)
            {
                for (int i = 0; i < movie.MovieActors.Count(); i++)
                {
                    movie.MovieActors[i].Order = i + 1;
                }
            }

            context.Add(movie);
            await context.SaveChangesAsync();

            return Ok();
        }
    }
}

