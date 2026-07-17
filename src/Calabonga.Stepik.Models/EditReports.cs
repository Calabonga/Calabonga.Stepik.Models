using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents permission to edit reports.
    /// </summary>
    public sealed class EditReports
    {
        /// <summary>
        /// Gets or sets a value indicating whether editing reports is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
