using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    public class Meta
    {
        [JsonPropertyName("meta")]
        public int Page { get; set; }
        
        [JsonPropertyName("has_next")]
        public bool HasNext { get; set; }
        
        [JsonPropertyName("has_previous")]
        public bool HasPrevious { get; set; }
    }
}
