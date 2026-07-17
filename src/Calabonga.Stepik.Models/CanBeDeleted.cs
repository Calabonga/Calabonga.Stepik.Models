using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents a flag that indicates whether the entity can be deleted.
    /// </summary>
    public sealed class CanBeDeleted
    {
        /// <summary>
        /// Gets or sets a value indicating whether deletion is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
