using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents a flag that indicates whether the price can be changed.
    /// </summary>
    public sealed class CanBePriceChanged
    {
        /// <summary>
        /// Gets or sets a value indicating whether price change is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
