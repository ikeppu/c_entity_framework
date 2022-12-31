using System;
using c_sharp_entity_framework.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using c_sharp_entity_framework.Utilities;
using c_sharp_entity_framework.DTOs;
using AutoMapper;

namespace c_sharp_entity_framework.Controllers
{
    [ApiController]
    [Route("api/genres")]
    public class GenresController : ControllerBase
    {
        private readonly ApllicationDbContext _context;
        private readonly IMapper mapper;

        public GenresController(ApllicationDbContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<Genre>> Get()
        {

            _context.Logs.Add(new Log { Message = "Executing Get from GenresController" });
            await _context.SaveChangesAsync();

            return await _context.Genres
                .AsNoTracking()
                .OrderBy(g => g.Name)
                .ToListAsync();
        }

        [HttpGet("first")]
        public async Task<ActionResult<Genre>> GetFirst()
        {
            var genre = await _context.Genres.FirstAsync(g => g.Name.Contains("m"));


            if (genre is null)
            {
                return genre;
            }

            return NotFound();
        }

        [HttpGet("filter")]
        public async Task<IEnumerable<Genre>> Filter([FromQuery] string name)
        {
            return await _context.Genres
                .Where(g => g.Name.Contains(name))
                .ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(GenresCreationDTO genresCreationDTO)
        {
            var genreExists = await _context.Genres
                .IgnoreQueryFilters()
                .AnyAsync(p =>
                    p.Name == genresCreationDTO.Name);

            if (genreExists)
                return BadRequest($"Genre with name {genresCreationDTO.Name} already exists");

            var genre = mapper.Map<Genre>(genresCreationDTO); // Make map using automapper

            _context.Add(genre); // marking genre as added.

            //_context.Entry(genre).State = EntityState.Added;

            await _context.SaveChangesAsync(); // make save
            //var status = _context.Entry(genre).State;

            return Ok();
        }

        [HttpPost("several")]
        public async Task<ActionResult> Post(GenresCreationDTO[] genresDTO)
        {
            var genres = mapper.Map<Genre[]>(genresDTO);
            _context.AddRange(genres);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put(Genre genre)
        {
            _context.Update(genre);
            await _context.SaveChangesAsync();

            return Ok();
        }


        [HttpGet("raw-query")]
        public async Task<ActionResult> GetRawQuery(int id)
        {

            //Doesn't work
            var genre = await _context.Genres.FromSqlRaw("SELECT * FROM Genres")
                .IgnoreQueryFilters()
                .FirstOrDefaultAsync();

            return Ok(genre);
        }

    }
}

