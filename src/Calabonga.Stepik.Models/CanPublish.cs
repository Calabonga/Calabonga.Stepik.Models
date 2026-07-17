using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents settings related to publishing capability.
    /// </summary>
    public sealed class CanPublish
    {
        /// <summary>
        /// Gets or sets a value indicating whether publishing is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Required subscription plan.
        /// </summary>
        [JsonPropertyName("needs_plan")]
        public object? NeedsPlan { get; set; }
    }
}
