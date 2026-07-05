using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    public sealed class CodeTemplatesFooterLinesCount
    {
        /// <summary>
        /// Lines count for language C#.
        /// </summary>
        [JsonPropertyName("c#")]
        public int? CSharp { get; set; }
    }
}
