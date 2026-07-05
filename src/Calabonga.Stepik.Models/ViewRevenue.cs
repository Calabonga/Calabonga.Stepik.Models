using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    public sealed class ViewRevenue
    {
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
