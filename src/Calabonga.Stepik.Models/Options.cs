using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents various options and limits for code execution and templates.
    /// </summary>
    public sealed class Options
    {
        /// <summary>
        /// Managing learners enabled
        /// </summary>
        [JsonPropertyName("manage_learners")]
        public bool? ManageLearners { get; set; }

        /// <summary>
        /// Code execution limit (ms)
        /// </summary>
        [JsonPropertyName("execution_time_limit")]
        public int? ExecutionTimeLimit { get; set; }

        /// <summary>
        /// Memory execution limit (ms)
        /// </summary>
        [JsonPropertyName("execution_memory_limit")]
        public int? ExecutionMemoryLimit { get; set; }

        /// <summary>
        /// Programming language limits
        /// </summary>
        [JsonPropertyName("limits")]
        public Limits? Limits { get; set; }

        /// <summary>
        /// Programming language templates 
        /// </summary>
        [JsonPropertyName("code_templates")]
        public CodeTemplates? CodeTemplates { get; set; }

        /// <summary>
        /// Code template header lines count
        /// </summary>
        [JsonPropertyName("code_templates_header_lines_count")]
        public CodeTemplatesHeaderLinesCount? CodeTemplatesHeaderLinesCount { get; set; }

        /// <summary>
        /// Code templated footer lines count
        /// </summary>
        [JsonPropertyName("code_templates_footer_lines_count")]
        public CodeTemplatesFooterLinesCount? CodeTemplatesFooterLinesCount { get; set; }

        /// <summary>
        /// Additional template parameters
        /// </summary>
        [JsonPropertyName("code_templates_options")]
        public CodeTemplatesOptions? CodeTemplatesOptions { get; set; }

        /// <summary>
        /// Samples input and output data 
        /// </summary>
        [JsonPropertyName("samples")]
        public List<List<string>>? Samples { get; set; }

        /// <summary>
        /// Allows user run own code
        /// </summary>
        [JsonPropertyName("is_run_user_code_allowed")]
        public bool? IsRunUserCodeAllowed { get; set; }
    }
}
