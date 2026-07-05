using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    public sealed class CodeTemplatesHeaderLinesCount
    {
        /// <summary>
        /// Lines count for language C#.
        /// </summary>
        [JsonPropertyName("c#")]
        public int? Csharp { get; set; }
    }
}
