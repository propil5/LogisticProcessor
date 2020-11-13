using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogisticProcessor.Web.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProuctController : ControllerBase
    {
        private readonly IStartupConfigureServicesFilter _startupConfigureServicesFilter;
        ProuctController(IStartupConfigureServicesFilter startupConfigureServicesFilter) // TODO: This is just example - change when there will be proper one available
        {
            _startupConfigureServicesFilter = startupConfigureServicesFilter;
        }

        //[HttpGet]
        //public IEnumerable<Product> GetProducts(int? id = null)
        //{
        //    //_startupConfigureServicesFilter
        //}
    }
}
