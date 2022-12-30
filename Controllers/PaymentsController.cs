using System;
using c_sharp_entity_framework.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace c_sharp_entity_framework.Controllers
{
    [ApiController]
    [Route("api/payments")]
    public class PaymentsController : ControllerBase
    {
        private readonly ApllicationDbContext context;

        public PaymentsController(ApllicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Payment>>> Get()
        {

            return await context.Payments.ToListAsync();
        }

        [HttpGet("cards")]
        public async Task<ActionResult<IEnumerable<CardPayment>>> GetCards()
        {

            return await context.Payments.OfType<CardPayment>().ToListAsync();
        }

        [HttpGet("paypal")]
        public async Task<ActionResult<IEnumerable<PaypalPayment>>> GetPaypal()
        {

            return await context.Payments.OfType<PaypalPayment>().ToListAsync();
        }
    }
}

