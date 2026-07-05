using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    public sealed class CodeTemplates
    {
        /// <summary>
        /// Template of the code for Csharp
        /// </summary>
        [JsonPropertyName("c#")]
        public string CSharp { get; set; }
    }
}
