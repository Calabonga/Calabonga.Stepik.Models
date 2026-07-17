using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents a video URL with quality information.
    /// </summary>
    public sealed class Url
    {
        /// <summary>
        /// Quality for video (example: 360, 720, 1080).
        /// </summary>
        [JsonPropertyName("quality")]
        public string? Quality { get; set; }

        /// <summary>
        /// Gets or sets the video link.
        /// </summary>
        [JsonPropertyName("url")]
        public string? Link { get; set; }
    }
}
