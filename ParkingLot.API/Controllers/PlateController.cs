using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingLot.API.Services;

namespace ParkingLot.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlateController : ControllerBase
    {
        private readonly PlateService _plateService;

        public PlateController(PlateService plateService)
        {
            _plateService = plateService;
        }

        [HttpPost("detect")]
        public async Task<IActionResult> DetectPlate(IFormFile image)
        {
            if (image == null || image.Length == 0)
                return BadRequest("Image Empty");

            var plate = await _plateService.DetectPlate(image);

            return Ok(plate);
        }
    }

}
