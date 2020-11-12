using LogisticProcessor.Web.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace LogisticProcessor.Web.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InboundProductController : Controller
    {
        [HttpPost]
        public IActionResult InputNewProduct(Product product)
        {

            return Ok("TBD");
        }
    }
}
