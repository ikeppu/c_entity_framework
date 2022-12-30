using System;
using c_sharp_entity_framework.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace c_sharp_entity_framework.Controllers
{
    [ApiController]
    [Route("api/people")]
    public class PeopleController : ControllerBase
    {
        private readonly ApllicationDbContext context;

        public PeopleController(ApllicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Person>> Get(int id)
        {
            var person = await context.People
                .Include(p => p.ReceivedMessages)
                .Include(p => p.SentMessages)
                .FirstOrDefaultAsync(p => p.Id == id);
            if (person is null)
                return NotFound();

            return Ok(person);
        }
    }
}

