using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    public sealed class IntroVideo
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("thumbnail")]
        public string? Thumbnail { get; set; }

        [JsonPropertyName("urls")]
        public List<Url>? Urls { get; set; }

        [JsonPropertyName("duration")]
        public int Duration { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("upload_date")]
        public DateTime UploadDate { get; set; }

        [JsonPropertyName("filename")]
        public string? Filename { get; set; }
    }
}