using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents manage permissions settings.
    /// </summary>
    public sealed class ManagePermissions
    {
        /// <summary>
        /// Gets or sets a value indicating whether permission management is enabled.
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
