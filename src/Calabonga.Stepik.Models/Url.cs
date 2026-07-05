using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    public sealed class Url
    {
        /// <summary>
        /// Quality for Video (example, 360, 720, 1080).
        /// </summary>
        [JsonPropertyName("quality")]
        public string? Quality { get; set; }

        /// <summary>
        /// URL video
        /// </summary>
        [JsonPropertyName("url")]
        public string? Link { get; set; }
    }
}
