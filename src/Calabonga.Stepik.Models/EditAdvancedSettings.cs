using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents edit advanced settings permission.
    /// </summary>
    public sealed class EditAdvancedSettings
    {
        /// <summary>
        /// Gets or sets a value indicating whether advanced settings editing is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
