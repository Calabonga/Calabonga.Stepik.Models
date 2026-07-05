using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    public sealed class ManagePermissions
    {
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Required plan
        /// </summary>
        [JsonPropertyName("needs_plan")]
        public string? NeedsPlan { get; set; }
    }
}
