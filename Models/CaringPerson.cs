namespace project_geopet.Models;

public class CaringPerson
{
    public Guid CaringPersonId {get; set;}
    public string Name {get; set;}
    public string Email {get; set;}
    public int Cep {get; set;}
    public string Password {get; set;}
    public DateTime? CreatedAt {get; set;}
    public DateTime? UpdatedAt {get; set;}

    public ICollection<Pet>? Pets {get; set;}
}