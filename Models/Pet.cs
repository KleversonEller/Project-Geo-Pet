namespace project_geopet.Models;

public class Pet
{
    public Guid PetId {get; set;}
    public string Name {get; set;}
    public int Age {get; set;}
    public string Carrying {get; set;}
    public string Race {get; set;}
    public DateTime? CreatedAt {get; set;}
    public DateTime? UpdatedAt {get; set;}
    public CaringPerson? CaringPerson {get; set;}
}