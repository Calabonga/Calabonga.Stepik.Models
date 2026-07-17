using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents permission to view the grade book page.
    /// </summary>
    public sealed class ViewGradeBookPage
    {
        /// <summary>
        /// Gets or sets a value indicating whether viewing the grade book page is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
