using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents LTI edit permissions.
    /// </summary>
    public sealed class EditLti
    {
        /// <summary>
        /// Gets or sets a value indicating whether LTI editing is enabled.
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Required plan.
        /// </summary>
        [JsonPropertyName("needs_plan")]
        public string? NeedsPlan { get; set; }
    }
}
