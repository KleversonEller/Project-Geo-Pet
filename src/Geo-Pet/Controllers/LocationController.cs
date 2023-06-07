using Microsoft.AspNetCore.Mvc;
using project_geopet.Services;

namespace project_geopet.Controllers;

[ApiController]
[Route(template: "[controller]")]

public class LocationController : ControllerBase
{
    [HttpGet]
    [Route("{lat}/{lon}")]
    public async Task<IActionResult> Get(
        [FromRoute] float lat,
        [FromRoute] float lon)
    {
            var location = await GetLocation.AddressByLocation(lat, lon);

            if(location == null) return BadRequest();
            return Ok(location);
    }
}