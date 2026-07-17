using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents execution limits for supported languages.
    /// </summary>
    public sealed class Limits
    {
        /// <summary>
        /// C# limits.
        /// </summary>
        [JsonPropertyName("c#")]
        public Csharp? C { get; set; }
    }
}
