using Microsoft.AspNetCore.Mvc;
using project_geopet.Models;
using project_geopet.Data;
using project_geopet.Request;

namespace project_geopet.Controllers;

[ApiController]
[Route(template:"[Controller]")]

public class GeoPetController : ControllerBase
{
    [HttpGet]
    [Route("AllCaringPersons")]
    public IActionResult Get(
        [FromServices] GeoPetContext context)
    {
        var caringpersons = context.CaringPersons.ToList();
        return Ok(caringpersons);
    }

    [HttpPost]
    [Route("CaringPerson")]
    public async Task<IActionResult> Post(
        [FromServices] GeoPetContext context,
        [FromBody] CaringPersonRequest request)
    {
        if(!ModelState.IsValid) return BadRequest();

        var caringperson = new CaringPerson
        {
            CaringPersonId = Guid.NewGuid(),
            Cep = request.Cep,
            Email = request.Email,
            Name = request.Name,
            Password = request.Password,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
        try
        {
            await context.CaringPersons.AddAsync(caringperson);
            await context.SaveChangesAsync();
            return StatusCode(201, "Caregiver created successfully");
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }
}