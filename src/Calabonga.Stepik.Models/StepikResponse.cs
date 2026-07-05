using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    public class StepikResponse
    {
        [JsonPropertyName("meta")]
        public Meta? Meta { get; set; }

        [JsonPropertyName("courses")]
        public Course[]? Courses { get; set; }
    }
}
