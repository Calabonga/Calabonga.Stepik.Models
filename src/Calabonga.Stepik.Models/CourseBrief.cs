using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    public sealed class CourseBrief
    {
        /// <summary>
        /// Course identifier
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("position")]
        public int Position { get; set; }

        /// <summary>
        /// Brief description
        /// </summary>
        [JsonPropertyName("summary")]
        public string? Summary { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("title_en")]
        public string? TitleEn { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("cover")]
        public string? Cover { get; set; }
    }
}
