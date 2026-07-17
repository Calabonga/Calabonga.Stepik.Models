using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents footer lines count for code templates per language.
    /// </summary>
    public sealed class CodeTemplatesFooterLinesCount
    {
        /// <summary>
        /// Lines count for language C#.
        /// </summary>
        [JsonPropertyName("c#")]
        public int? CSharp { get; set; }
    }
}
