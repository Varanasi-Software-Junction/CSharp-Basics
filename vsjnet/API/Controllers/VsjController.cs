using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VsjController : Controller
    {
        [HttpGet]
        public string SayHello()
        {
            return "Hello ";
        }

        [HttpGet("{name}"), HttpPost("{name}")]
        public string SayHello(string name)
        {
            return "Hello " + name;
        }

    }
}