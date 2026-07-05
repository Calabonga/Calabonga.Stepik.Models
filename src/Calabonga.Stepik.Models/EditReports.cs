using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    public sealed class EditReports
    {
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
