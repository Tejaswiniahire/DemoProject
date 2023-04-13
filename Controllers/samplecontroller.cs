using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Tejaswini Ahire");
        }
        
        [HttpPost]
        public IActionResult Post(int id)
        {
            return Ok($"You posted: {id}");
        }
    }
}
