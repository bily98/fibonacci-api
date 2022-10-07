using Fibonacci.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace Fibonacci.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(int n)
        {
            if (n < 1)
                return BadRequest("n value must be grater than 0");

            return Ok(n.GetFibonacciValue());
        }
    }
}
