using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using project_geopet.Models;
using project_geopet.Request;
using project_geopet.Data;

namespace project_geopet.Controllers;

[ApiController]
[Authorize]
[Route(template: "[controller]")]

public class PetController : ControllerBase
{
    [HttpGet]
    public IActionResult Get(
        [FromServices] GeoPetContext context)
    {
        var pets = context.Pets.ToList();
        return Ok(pets);
    }


    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> Get(
        [FromServices] GeoPetContext context,
        [FromRoute] Guid id)
    {
        var pet = await context.Pets.FindAsync(id);
        return pet == null ? NotFound() : Ok(pet);
    }


    [HttpPost]
    public async Task<IActionResult> Post(
        [FromServices] GeoPetContext context,
        [FromBody] PetRequest request)
    {
        if(!ModelState.IsValid) return BadRequest();

        var caringperson = await context.CaringPersons.FindAsync(request.CaringPersonId);
        if(caringperson == null) return NotFound();

        var pet = new Pet
        {
            Id = Guid.NewGuid(),
            Name = request.Name,
            Age = request.Age,
            Race = request.Race,
            Carrying = request.Carrying,
            CaringPerson = caringperson,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
        try
        {
            await context.Pets.AddAsync(pet);
            await context.SaveChangesAsync();
            return Created("Pet created successfully", pet);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }


    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> Put(
        [FromServices] GeoPetContext context,
        [FromBody] PetRequest request,
        [FromRoute] Guid id)
    {
        if(!ModelState.IsValid) return BadRequest();

        var pet = await context.Pets.FindAsync(id);
        if(pet == null) return NotFound();

        try
        {
            pet.Name = request.Name;
            pet.Age = request.Age;
            pet.Carrying = request.Carrying;
            pet.Race = request.Race;
            pet.UpdatedAt = DateTime.Now;

            context.Pets.Update(pet);
            await context.SaveChangesAsync();
            return Ok(pet);
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }


    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> Delete(
        [FromServices] GeoPetContext context,
        [FromRoute] Guid id)
    {
        if(!ModelState.IsValid) return BadRequest();

        var pet = await context.Pets.FindAsync(id);
        if(pet == null) return NotFound();

        try
        {
            context.Pets.Remove(pet);
            await context.SaveChangesAsync();
            return Ok("Pet deleted successful !");
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }
}