using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    public sealed class CanBeDeleted
    {
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
