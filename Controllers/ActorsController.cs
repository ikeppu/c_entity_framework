using System;
using Microsoft.AspNetCore.Mvc;
using c_sharp_entity_framework.Entities;
using c_sharp_entity_framework.Utilities;
using Microsoft.EntityFrameworkCore;
using c_sharp_entity_framework.DTOs;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace c_sharp_entity_framework.Controllers
{
    [ApiController]
    [Route("api/actors")]
    public class ActorsController : ControllerBase
    {
        private readonly ApllicationDbContext _context;
        private readonly IMapper _mapper;

        public ActorsController(ApllicationDbContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ActorDTO>> Get()
        {
            return await _context.Actors
                .AsNoTracking()
                .OrderBy(a => a.Name)
                .ProjectTo<ActorDTO>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        //[HttpGet]
        //public async Task<IEnumerable<ActorDTO>> Get([FromQuery] int page = 1,
        //    [FromQuery] int recordsToTake = 2)
        //{
        //    return await _context.Actors
        //        .AsNoTracking()
        //        .OrderBy(a => a.Name)
        //        .ProjectTo<ActorDTO>(_mapper.ConfigurationProvider)
        //        .Paginate(page, recordsToTake)
        //        .ToListAsync();
        //}

        [HttpPut]
        public async Task<ActionResult> Put(ActorCreationDTO actorCreationDTO, int id)
        {
            var actorDB = await _context.Actors.FirstOrDefaultAsync(p => p.Id == id);

            if (actorDB is null)
                return NotFound();

            actorDB = _mapper.Map(actorCreationDTO, actorDB);

            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}

