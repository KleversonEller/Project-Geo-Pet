using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using project_geopet.Data;
using project_geopet.Request;
using project_geopet.Services;

namespace project_geopet.Controllers;

[ApiController]
[Route(template: "[controller]")]

public class LoginController : ControllerBase
{
    [HttpPost]
    [AllowAnonymous]
    public Task<IActionResult> Post(
        [FromServices] GeoPetContext context,
        [FromBody] LoginRequest request)
    {
        var login = context.CaringPersons.First(person =>
            person.Email == request.Email && person.Password == request.Password);

        if(login == null) return Task.FromResult<IActionResult>(NotFound());

        var token = TokenService.GenerateToken((Models.CaringPerson)login);

        return Task.FromResult<IActionResult>(Ok(token));
    }
}