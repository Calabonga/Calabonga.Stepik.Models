using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents permission to view reports.
    /// </summary>
    public sealed class ViewReports
    {
        /// <summary>
        /// Gets or sets a value indicating whether viewing reports is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
