using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents pagination metadata.
    /// </summary>
    public class Meta
    {
        /// <summary>
        /// Gets or sets the current page number.
        /// </summary>
        [JsonPropertyName("meta")]
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether there is a next page.
        /// </summary>
        [JsonPropertyName("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether there is a previous page.
        /// </summary>
        [JsonPropertyName("has_previous")]
        public bool HasPrevious { get; set; }
    }
}
