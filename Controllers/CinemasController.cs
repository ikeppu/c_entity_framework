using System;
using c_sharp_entity_framework.DTOs;
using c_sharp_entity_framework.Entities;
using c_sharp_entity_framework.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace c_sharp_entity_framework.Controllers
{
    [ApiController]
    [Route("api/cinema")]
    public class CinemasController : ControllerBase
    {
        private readonly ApllicationDbContext context;

        public CinemasController(ApllicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Cinema>> Get([FromQuery] int page = 1,
            [FromQuery] int recordsToTake = 2)
        {


            return await context.Cinemas
                .AsNoTracking()
                .OrderBy(a => a.Name)
                .Paginate(page, recordsToTake)
                .ToListAsync();
        }


    }
}

