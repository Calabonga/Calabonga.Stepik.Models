using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents code templates for different languages.
    /// </summary>
    public sealed class CodeTemplates
    {
        /// <summary>
        /// Template of the code for C#.
        /// </summary>
        [JsonPropertyName("c#")]
        public string? CSharp { get; set; }
    }
}
