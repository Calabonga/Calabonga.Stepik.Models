using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents a flag that indicates whether the entity can be bought.
    /// </summary>
    public sealed class CanBeBought
    {
        /// <summary>
        /// Gets or sets a value indicating whether buying is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
