using System.Text.Json.Serialization;

namespace project_geopet.Models;

public class Pet
{
    public Guid Id {get; set;}
    public string Name {get; set;}=string.Empty;
    public int Age {get; set;}
    public string Carrying {get; set;}=string.Empty;
    public string Race {get; set;}=string.Empty;
    public DateTime? CreatedAt {get; set;}
    public DateTime? UpdatedAt {get; set;}
    [JsonIgnore]
    public virtual CaringPerson CaringPerson {get; set;}
    public Guid CaringPersonId {get; set;}
}