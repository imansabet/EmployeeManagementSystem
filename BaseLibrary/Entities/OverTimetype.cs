
using System.Text.Json.Serialization;

namespace BaseLibrary.Entities;

public class OverTimetype : BaseEntity
{
    [JsonIgnore]
    public List<OverTime>? OverTime { get; set; }
}
