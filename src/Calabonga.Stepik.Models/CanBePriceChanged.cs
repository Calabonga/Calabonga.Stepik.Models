using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    public sealed class CanBePriceChanged
    {
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
