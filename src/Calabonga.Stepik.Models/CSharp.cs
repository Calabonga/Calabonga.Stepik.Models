using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    public sealed class Csharp
    {
        /// <summary>
        /// Limit milliseconds for execution
        /// </summary>
        [JsonPropertyName("time")]
        public int? Time { get; set; }

        /// <summary>Limit megabytes for execution</summary>
        [JsonPropertyName("memory")]
        public int? Memory { get; set; }
    }
}
