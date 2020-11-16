using LogisticProcessor.Web.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticProcessor.Web.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //// GET: api/Products/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Product> GetProducts(int id)
        //{
        //    var products = await _context.Products.FindAsync(id);

        //    if (products == null)
        //    {
        //        return NotFound();
        //    }

        //    return products;
        //}

        //// PUT: api/Products/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutProducts(int id, Products products)
        //{
        //    if (id != products.ProductId)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(products).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ProductsExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Products
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for
        //// more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPost]
        //public async Task<ActionResult<Products>> PostProducts(Products products)
        //{
        //    _context.Products.Add(products);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetProducts", new { id = products.ProductId }, products);
        //}

        //// DELETE: api/Products/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Products>> DeleteProducts(int id)
        //{
        //    var products = await _context.Products.FindAsync(id);
        //    if (products == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Products.Remove(products);
        //    await _context.SaveChangesAsync();

        //    return products;
        //}

        //private bool ProductsExists(int id)
        //{
        //    return _context.Products.Any(e => e.ProductId == id);
        //}
    }
}
