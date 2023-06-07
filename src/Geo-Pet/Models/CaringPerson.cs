using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project_geopet.Models;

public class CaringPerson
{
    public Guid Id {get; set;}
    [Required]
    public string Name {get; set;}=string.Empty;
    [Required]
    [Index("email", IsUnique = true)]
    public string Email {get; set;}=string.Empty;
    [Required]
    public string Cep {get; set;}=string.Empty;
    [Required]
    public string Password {get; set;}=string.Empty;
    public DateTime? CreatedAt {get; set;}
    public DateTime? UpdatedAt {get; set;}
    public virtual List<Pet> Pets {get; set;}
}