using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents a response wrapper from Stepik API containing metadata and items.
    /// </summary>
    public class StepikResponse
    {
        /// <summary>
        /// Gets or sets pagination metadata.
        /// </summary>
        [JsonPropertyName("meta")]
        public Meta? Meta { get; set; }

        /// <summary>
        /// Gets or sets the collection of courses returned by the API.
        /// </summary>
        [JsonPropertyName("courses")]
        public Course[]? Courses { get; set; }
    }
}
