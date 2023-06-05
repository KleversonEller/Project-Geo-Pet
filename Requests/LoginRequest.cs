using System.ComponentModel.DataAnnotations;

namespace project_geopet.Request;

public class LoginRequest
{
    [Required]
    public string Email {get; set;}
    [Required]
    public string Password {get; set;}
}