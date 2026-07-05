using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    public sealed class Actions
    {
        /// <summary>
        /// Reports for course
        /// </summary>
        [JsonPropertyName("view_reports")]
        public ViewReports? ViewReports { get; set; }

        /// <summary>
        /// Edit report allows
        /// </summary>
        [JsonPropertyName("edit_reports")]
        public EditReports? EditReports { get; set; }

        /// <summary>
        /// Grade book access
        /// </summary>
        [JsonPropertyName("view_grade_book_page")]
        public ViewGradeBookPage? ViewGradeBookPage { get; set; }

        /// <summary>
        /// Grade book access
        /// </summary>
        [JsonPropertyName("view_grade_book")]
        public ViewGradeBook? ViewGradeBook { get; set; }

        /// <summary>
        /// Access to LTI.
        /// </summary>
        [JsonPropertyName("edit_lti")]
        public EditLti? EditLti { get; set; }


        [JsonPropertyName("edit_advanced_settings")]
        public EditAdvancedSettings? EditAdvancedSettings { get; set; }

        [JsonPropertyName("manage_permissions")]
        public ManagePermissions? ManagePermissions { get; set; }

        [JsonPropertyName("assist_course")]
        public string? AssistCourse { get; set; }

        [JsonPropertyName("view_instructor_dashboard")]
        public string? ViewInstructorDashboard { get; set; }

        [JsonPropertyName("edit_course")]
        public string? EditCourse { get; set; }

        /// <summary>
        /// Edit course Syllabus
        /// </summary>
        [JsonPropertyName("edit_syllabus")]
        public string? EditSyllabus { get; set; }

        [JsonPropertyName("view_statistics")]
        public string? ViewStatistics { get; set; }

        [JsonPropertyName("attachments")]
        public string? Attachments { get; set; }

        [JsonPropertyName("create_announcements")]
        public string? CreateAnnouncements { get; set; }

        [JsonPropertyName("clone_course")]
        public string? CloneCourse { get; set; }

        [JsonPropertyName("clone_module")]
        public string? CloneModule { get; set; }

        [JsonPropertyName("edit_certificates")]
        public string? EditCertificates { get; set; }

        [JsonPropertyName("can_publish")]
        public CanPublish? CanPublish { get; set; }

        [JsonPropertyName("can_be_private")]
        public CanBePrivate? CanBePrivate { get; set; }

        [JsonPropertyName("admin_course")]
        public string? AdminCourse { get; set; }

        [JsonPropertyName("edit_permissions")]
        public string? EditPermissions { get; set; }

        [JsonPropertyName("edit_publish_settings")]
        public string? EditPublishSettings { get; set; }

        [JsonPropertyName("set_price")]
        public string? SetPrice { get; set; }

        [JsonPropertyName("transfer_ownership")]
        public string? TransferOwnership { get; set; }

        [JsonPropertyName("view_revenue")]
        public ViewRevenue? ViewRevenue { get; set; }

        [JsonPropertyName("can_be_bought")]
        public CanBeBought? CanBeBought { get; set; }

        [JsonPropertyName("can_be_price_changed")]
        public CanBePriceChanged? CanBePriceChanged { get; set; }

        [JsonPropertyName("can_be_deleted")]
        public CanBeDeleted? CanBeDeleted { get; set; }

        [JsonPropertyName("edit_tags")]
        public EditTags? EditTags { get; set; }
    }
}
