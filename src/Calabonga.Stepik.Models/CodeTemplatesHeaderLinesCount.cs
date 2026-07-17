using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents header lines count for code templates per language.
    /// </summary>
    public sealed class CodeTemplatesHeaderLinesCount
    {
        /// <summary>
        /// Lines count for language C#.
        /// </summary>
        [JsonPropertyName("c#")]
        public int? Csharp { get; set; }
    }
}
