using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingLot.Core;

namespace ParkingLot.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("hello")]
        public IActionResult Hello()
        {
            return Ok("sümitoyu çok sevdim");
        }
    }
}
