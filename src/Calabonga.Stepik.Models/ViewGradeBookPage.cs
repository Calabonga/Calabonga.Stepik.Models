using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    public sealed class ViewGradeBookPage
    {
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
