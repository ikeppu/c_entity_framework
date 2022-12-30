using System;
using c_sharp_entity_framework.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace c_sharp_entity_framework.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly ApllicationDbContext context;

        public ProductsController(ApllicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Products>>> Get()
        {

            return await context.Products.ToListAsync();
        }

        [HttpGet("merch")]
        public async Task<ActionResult<IEnumerable<Merchandising>>> GetMerch()
        {

            return await context.Set<Merchandising>().ToListAsync();
        }

        [HttpGet("rentables")]
        public async Task<ActionResult<IEnumerable<RentableMovie>>> GetRent()
        {

            return await context.Set<RentableMovie>().ToListAsync();
        }
    }
}

