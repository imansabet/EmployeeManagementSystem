using System.Text.Json.Serialization;

namespace BaseLibrary.Entities;
public class City : BaseEntity
{
    public Country? Country { get; set; }
    public int CountryId { get; set; } = 0;
    [JsonIgnore]

    public List<Town>? Towns { get; set; }
}
