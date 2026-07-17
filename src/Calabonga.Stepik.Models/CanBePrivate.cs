using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents settings related to privacy capability.
    /// </summary>
    public sealed class CanBePrivate
    {
        /// <summary>
        /// Gets or sets a value indicating whether privacy is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Required subscription plan.
        /// </summary>
        [JsonPropertyName("needs_plan")]
        public string? NeedsPlan { get; set; }
    }
}
