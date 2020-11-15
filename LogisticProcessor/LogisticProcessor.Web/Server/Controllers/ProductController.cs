using LogisticProcessor.Web.Shared.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticProcessor.Web.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //private readonly IStartupConfigureServicesFilter _startupConfigureServicesFilter;
        public ProductController() // TODO: This is just example - change when there will be proper one available
        {
            //_startupConfigureServicesFilter = startupConfigureServicesFilter;
        }

        [HttpGet]
        //[Route("api/products")]
        public ActionResult<IEnumerable<Product>> Get(int? id = null)
        {
            return GetTestProduct();
        }

        #region helper
        private ActionResult<IEnumerable<Product>> GetTestProduct(){
            {
                return new[]
                {
                    new Product
                    {
                        Id = 1,
                        Name = "Test",
                        ArrivalTime = DateTime.Now.AddHours(-1),
                        Priority = 1,
                        Description = "Test Product",
                        Picture = "\\\\server\\dir1\\",
                        Weight = 2.0,
                        Width = 3.5,
                        Depth = 1.2
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Test2",
                        ArrivalTime = DateTime.Now.AddHours(-2),
                        Priority = 2,
                        Description = "Test Product 2",
                        Picture = "\\\\server\\dir1\\",
                        Weight = 5.0,
                        Width = 1.5,
                        Depth = 2.2
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Test3",
                        ArrivalTime = DateTime.Now.AddHours(-3),
                        Priority = 3,
                        Description = "Test Product 3",
                        Picture = "\\\\server\\dir2\\",
                        Weight = 1.0,
                        Width = 5.5,
                        Depth = 3.2
                    }
                };
            }
        }
        #endregion


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