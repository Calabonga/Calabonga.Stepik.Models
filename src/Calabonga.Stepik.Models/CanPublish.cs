using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    public sealed class CanPublish
    {
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Required subscription plan
        /// </summary>
        [JsonPropertyName("needs_plan")]
        public object? NeedsPlan { get; set; }
    }
}
