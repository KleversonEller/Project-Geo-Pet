using System.ComponentModel.DataAnnotations;

namespace project_geopet.Request;

public class PetRequest
{
    public string Name {get; set;}
    public int Age {get; set;}
    public string Carrying {get; set;}
    public string Race {get; set;}
    [Required]
    public Guid CaringPersonId {get; set;}
}