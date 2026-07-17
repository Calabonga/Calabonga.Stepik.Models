using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents an introductory video attached to a course.
    /// </summary>
    public sealed class IntroVideo
    {
        /// <summary>
        /// Gets or sets the video identifier.
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the thumbnail URL.
        /// </summary>
        [JsonPropertyName("thumbnail")]
        public string? Thumbnail { get; set; }

        /// <summary>
        /// Gets or sets available video URLs.
        /// </summary>
        [JsonPropertyName("urls")]
        public List<Url>? Urls { get; set; }

        /// <summary>
        /// Gets or sets the video duration in seconds.
        /// </summary>
        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// Gets or sets the current processing status.
        /// </summary>
        [JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Gets or sets the upload date.
        /// </summary>
        [JsonPropertyName("upload_date")]
        public DateTime UploadDate { get; set; }

        /// <summary>
        /// Gets or sets the filename.
        /// </summary>
        [JsonPropertyName("filename")]
        public string? Filename { get; set; }
    }
}
