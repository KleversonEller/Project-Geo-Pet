using System.ComponentModel.DataAnnotations;

namespace project_geopet.Request;

public class CaringPersonRequest
{
    [Required]
    public string Name {get; set;}
    [Required]
    public string Email {get; set;}
    [Required]
    public string Cep {get; set;}
    [Required]
    public string Password {get; set;}
}