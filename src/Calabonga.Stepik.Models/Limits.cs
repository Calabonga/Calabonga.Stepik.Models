using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    public sealed class Limits
    {
        /// <summary>
        /// CSharp limits
        /// </summary>
        [JsonPropertyName("c#")]
        public CSharp? C { get; set; }
    }
}
