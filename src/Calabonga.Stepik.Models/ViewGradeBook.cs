using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents permission to view the grade book.
    /// </summary>
    public sealed class ViewGradeBook
    {
        /// <summary>
        /// Gets or sets a value indicating whether viewing the grade book is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
