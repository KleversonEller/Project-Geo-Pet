using project_geopet.Models;

namespace project_geopet;

public class PetRequest
{
    public string? Name {get; set;}
    public int Age {get; set;}
    public string? Carrying {get; set;}
    public string? Race {get; set;}
    public CaringPerson? CaringPerson {get; set;}
}