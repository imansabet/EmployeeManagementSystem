using System.Text.Json.Serialization;

namespace BaseLibrary.Entities;

public class Town : BaseEntity
{
    public City? City { get; set; }
    public int CityId { get; set; }
    [JsonIgnore]

    public List<Employee>? Employees { get; set; }
}
