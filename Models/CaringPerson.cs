namespace project_geopet.Models;

public class CaringPerson
{
    public Guid Id {get; set;}
    public string Name {get; set;}=string.Empty;
    public string Email {get; set;}=string.Empty;
    public string Cep {get; set;}=string.Empty;
    public string Password {get; set;}=string.Empty;
    public DateTime? CreatedAt {get; set;}
    public DateTime? UpdatedAt {get; set;}
    public virtual List<Pet> Pets {get; set;}
}