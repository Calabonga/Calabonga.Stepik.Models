using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    /// <summary>
    /// Represents available actions and permissions for a course.
    /// </summary>
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


        /// <summary>
        /// Gets or sets advanced settings edit permission.
        /// </summary>
        [JsonPropertyName("edit_advanced_settings")]
        public EditAdvancedSettings? EditAdvancedSettings { get; set; }

        /// <summary>
        /// Gets or sets manage permissions setting.
        /// </summary>
        [JsonPropertyName("manage_permissions")]
        public ManagePermissions? ManagePermissions { get; set; }

        /// <summary>
        /// Gets or sets assist course action identifier.
        /// </summary>
        [JsonPropertyName("assist_course")]
        public string? AssistCourse { get; set; }

        /// <summary>
        /// Gets or sets view instructor dashboard action identifier.
        /// </summary>
        [JsonPropertyName("view_instructor_dashboard")]
        public string? ViewInstructorDashboard { get; set; }

        /// <summary>
        /// Gets or sets edit course action identifier.
        /// </summary>
        [JsonPropertyName("edit_course")]
        public string? EditCourse { get; set; }

        /// <summary>
        /// Edit course Syllabus
        /// </summary>
        [JsonPropertyName("edit_syllabus")]
        public string? EditSyllabus { get; set; }

        /// <summary>
        /// Gets or sets view statistics action identifier.
        /// </summary>
        [JsonPropertyName("view_statistics")]
        public string? ViewStatistics { get; set; }

        /// <summary>
        /// Gets or sets attachments action identifier.
        /// </summary>
        [JsonPropertyName("attachments")]
        public string? Attachments { get; set; }

        /// <summary>
        /// Gets or sets create announcements action identifier.
        /// </summary>
        [JsonPropertyName("create_announcements")]
        public string? CreateAnnouncements { get; set; }

        /// <summary>
        /// Gets or sets clone course action identifier.
        /// </summary>
        [JsonPropertyName("clone_course")]
        public string? CloneCourse { get; set; }

        /// <summary>
        /// Gets or sets clone module action identifier.
        /// </summary>
        [JsonPropertyName("clone_module")]
        public string? CloneModule { get; set; }

        /// <summary>
        /// Gets or sets edit certificates action identifier.
        /// </summary>
        [JsonPropertyName("edit_certificates")]
        public string? EditCertificates { get; set; }

        /// <summary>
        /// Gets or sets publishing capability information.
        /// </summary>
        [JsonPropertyName("can_publish")]
        public CanPublish? CanPublish { get; set; }

        /// <summary>
        /// Gets or sets privacy capability information.
        /// </summary>
        [JsonPropertyName("can_be_private")]
        public CanBePrivate? CanBePrivate { get; set; }

        /// <summary>
        /// Gets or sets admin course action identifier.
        /// </summary>
        [JsonPropertyName("admin_course")]
        public string? AdminCourse { get; set; }

        /// <summary>
        /// Gets or sets edit permissions action identifier.
        /// </summary>
        [JsonPropertyName("edit_permissions")]
        public string? EditPermissions { get; set; }

        /// <summary>
        /// Gets or sets edit publish settings action identifier.
        /// </summary>
        [JsonPropertyName("edit_publish_settings")]
        public string? EditPublishSettings { get; set; }

        /// <summary>
        /// Gets or sets set price action identifier.
        /// </summary>
        [JsonPropertyName("set_price")]
        public string? SetPrice { get; set; }

        /// <summary>
        /// Gets or sets transfer ownership action identifier.
        /// </summary>
        [JsonPropertyName("transfer_ownership")]
        public string? TransferOwnership { get; set; }

        /// <summary>
        /// Gets or sets view revenue permission information.
        /// </summary>
        [JsonPropertyName("view_revenue")]
        public ViewRevenue? ViewRevenue { get; set; }

        /// <summary>
        /// Gets or sets buy capability information.
        /// </summary>
        [JsonPropertyName("can_be_bought")]
        public CanBeBought? CanBeBought { get; set; }

        /// <summary>
        /// Gets or sets price change capability information.
        /// </summary>
        [JsonPropertyName("can_be_price_changed")]
        public CanBePriceChanged? CanBePriceChanged { get; set; }

        /// <summary>
        /// Gets or sets delete capability information.
        /// </summary>
        [JsonPropertyName("can_be_deleted")]
        public CanBeDeleted? CanBeDeleted { get; set; }

        /// <summary>
        /// Gets or sets edit tags permission information.
        /// </summary>
        [JsonPropertyName("edit_tags")]
        public EditTags? EditTags { get; set; }
    }
}
