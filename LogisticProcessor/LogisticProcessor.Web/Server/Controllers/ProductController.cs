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
        private readonly IStartupConfigureServicesFilter _startupConfigureServicesFilter;
        public ProductController(IStartupConfigureServicesFilter startupConfigureServicesFilter) // TODO: This is just example - change when there will be proper one available
        {
            _startupConfigureServicesFilter = startupConfigureServicesFilter;
        }

        [HttpGet]
        [Route("api/products")]
        public string Get(int? id = null)
        {
            return JsonConvert.SerializeObject(GetTestProduct());
        }

        #region helper
        private IEnumerable<Product> GetTestProduct(){
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
    }
}