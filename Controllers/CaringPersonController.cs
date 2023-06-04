using Microsoft.AspNetCore.Mvc;
using project_geopet.Models;
using project_geopet.Data;
using project_geopet.Request;
// using System.Drawing;
// using project_geopet.Utils;

namespace project_geopet.Controllers;

[ApiController]
[Route(template:"[Controller]")]

public class CaringPersonController : ControllerBase
{
    [HttpGet]
    public IActionResult Get(
        [FromServices] GeoPetContext context)
    {
        var caringpersons = context.CaringPersons.ToList();
        return Ok(caringpersons);
    }


    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> Get(
        [FromServices] GeoPetContext context,
        [FromRoute] Guid id)
    {
        var caringperson = await context.CaringPersons.FindAsync(id);
        return caringperson == null ? NotFound() : Ok(caringperson);
    }


    [HttpGet]
    [Route("{id}/Pets")]
    public async Task<IActionResult> GetPets(
        [FromServices] GeoPetContext context,
        [FromRoute] Guid id)
    {
        var pets = context.Pets.Where(pet => pet.CaringPersonId == id).ToList();
        return pets == null ? NotFound() : Ok(pets);
    }


    [HttpPost]
    public async Task<IActionResult> Post(
        [FromServices] GeoPetContext context,
        [FromBody] CaringPersonRequest request)
    {
        if(!ModelState.IsValid) return BadRequest();

        var caringperson = new CaringPerson
        {
            Id = Guid.NewGuid(),
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
            return Created("Caregiver created successfully", caringperson);
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
        [FromRoute] Guid id,
        [FromBody] CaringPersonRequest request)
    {
        if(!ModelState.IsValid) return BadRequest();

        var caringperson = await context.CaringPersons.FindAsync(id);
        if(caringperson == null) return NotFound();

        try
        {
            caringperson.Cep = request.Cep;
            caringperson.Email = request.Email;
            caringperson.Name = request.Name;
            caringperson.Password = request.Password;
            caringperson.UpdatedAt = DateTime.Now;

            context.CaringPersons.Update(caringperson);
            await context.SaveChangesAsync();
            return Ok(caringperson);
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

        var caringperson = await context.CaringPersons.FindAsync(id);
        if(caringperson == null) return NotFound();

        try
        {
            context.CaringPersons.Remove(caringperson);
            await context.SaveChangesAsync();
            return Ok("User deleted successful !");
        }
        catch (Exception e)
        {
            return BadRequest(e);
        }
    }


    // [HttpGet]
    // [Route("CaringPersonInfos/{id}")]
    // public async Task<Bitmap> GetQRCode(
    //     [FromServices] GeoPetContext context,
    //     [FromRoute] Guid id)
    // {
    //     var infos = await context.CaringPersons.FindAsync(id);
    //     return QRCodeInfos.GenerateQRCode(infos.Name, infos.Email, infos.Cep);
    // }
}