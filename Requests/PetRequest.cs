using System.ComponentModel.DataAnnotations;
using project_geopet.Models;

namespace project_geopet.Request;

public class PetRequest
{
    [Required]
    public string Name {get; set;}
    [Required]
    public int Age {get; set;}
    [Required]
    public string Carrying {get; set;}
    [Required]
    public string Race {get; set;}
    [Required]
    public Guid CaringPersonId {get; set;}
}