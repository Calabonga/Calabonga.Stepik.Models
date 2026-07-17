using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents permission to view revenue information.
    /// </summary>
    public sealed class ViewRevenue
    {
        /// <summary>
        /// Gets or sets a value indicating whether viewing revenue is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
