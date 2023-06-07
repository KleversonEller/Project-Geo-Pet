using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace project_geopet.Models;

public class Pet
{
    public Guid Id {get; set;}
    [Required]
    public string Name {get; set;}=string.Empty;
    [Required]
    public int Age {get; set;}
    [Required]
    public string Carrying {get; set;}=string.Empty;
    [Required]
    public string Race {get; set;}=string.Empty;
    public DateTime? CreatedAt {get; set;}
    public DateTime? UpdatedAt {get; set;}
    [JsonIgnore]
    public virtual CaringPerson CaringPerson {get; set;}
    public Guid CaringPersonId {get; set;}
}