using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ParkingLot.API.Services;
using ParkingLot.Core;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace ParkingLot.API.Controllers
{
    [ApiController]
    [Route("api/plate")]
    public class PlateController : ControllerBase
    {
        private readonly PlateService _plateService;

        public PlateController(PlateService plateService)
        {
            _plateService = plateService;
        }
        [HttpPost("detect")]
        public async Task<IActionResult> Detect(IFormFile file)
        {
            var plate = await _plateService.DetectPlate(file);
            return Ok(new { plate = plate });
        }
    }

}
