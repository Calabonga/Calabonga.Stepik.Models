using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents permission to edit tags.
    /// </summary>
    public sealed class EditTags
    {
        /// <summary>
        /// Gets or sets a value indicating whether editing tags is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
