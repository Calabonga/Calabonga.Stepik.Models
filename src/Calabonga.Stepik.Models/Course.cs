using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Calabonga.Stepik.Models
{
    public sealed class Course
    {
        /// <summary>
        /// Course identifier
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Brief description
        /// </summary>
        [JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Workload for course ex. "3-5 hours per week" or "1 hour per day"
        /// </summary>
        [JsonPropertyName("workload")]
        public string? Workload { get; set; }

        /// <summary>
        /// Code link
        /// </summary>
        [JsonPropertyName("cover")]
        public string? Cover { get; set; }

        /// <summary>
        /// Intro video
        /// </summary>
        [JsonPropertyName("intro")]
        public string? Intro { get; set; }

        /// <summary>
        /// Course format description
        /// </summary>
        [JsonPropertyName("course_format")]
        public string? CourseFormat { get; set; }

        /// <summary>
        /// For who this course
        /// </summary>
        [JsonPropertyName("target_audience")]
        public string? TargetAudience { get; set; }

        /// <summary>
        /// Link to certificate footer
        /// </summary>
        [JsonPropertyName("certificate_footer")]
        public string? CertificateFooter { get; set; }

        /// <summary>
        /// School logo link
        /// </summary>
        [JsonPropertyName("certificate_cover_org")]
        public string? CertificateCoverOrg { get; set; }

        [JsonPropertyName("is_certificate_issued")]
        public bool IsCertificateIssued { get; set; }

        [JsonPropertyName("is_certificate_auto_issued")]
        public bool IsCertificateAutoIssued { get; set; }

        /// <summary>
        /// Threshold for regular certificate
        /// </summary>
        [JsonPropertyName("certificate_regular_threshold")]
        public int? CertificateRegularThreshold { get; set; }

        /// <summary>
        /// Threshold for distinction certificate
        /// </summary>
        [JsonPropertyName("certificate_distinction_threshold")]
        public int? CertificateDistinctionThreshold { get; set; }

        [JsonPropertyName("instructors")]
        public List<int>? Instructors { get; set; }

        [JsonPropertyName("certificate")]
        public string? Certificate { get; set; }

        [JsonPropertyName("requirements")]
        public string? Requirements { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("sections")]
        public List<int>? Sections { get; set; }

        [JsonPropertyName("total_units")]
        public int? TotalUnits { get; set; }

        [JsonPropertyName("enrollment")]
        public int? Enrollment { get; set; }

        [JsonPropertyName("is_favorite")]
        public bool IsFavorite { get; set; }

        [JsonPropertyName("actions")]
        public Actions? Actions { get; set; }

        [JsonPropertyName("progress")]
        public object? Progress { get; set; }

        [JsonPropertyName("first_lesson")]
        public int? FirstLesson { get; set; }

        [JsonPropertyName("first_unit")]
        public int? FirstUnit { get; set; }

        [JsonPropertyName("certificate_link")]
        public string? CertificateLink { get; set; }

        [JsonPropertyName("certificate_regular_link")]
        public string? CertificateRegularLink { get; set; }

        [JsonPropertyName("certificate_distinction_link")]
        public string? CertificateDistinctionLink { get; set; }

        [JsonPropertyName("user_certificate")]
        public int? UserCertificate { get; set; }

        [JsonPropertyName("referral_link")]
        public string? ReferralLink { get; set; }

        [JsonPropertyName("schedule_link")]
        public string? ScheduleLink { get; set; }

        [JsonPropertyName("schedule_long_link")]
        public string? ScheduleLongLink { get; set; }

        [JsonPropertyName("first_deadline")]
        public object? FirstDeadline { get; set; }

        [JsonPropertyName("last_deadline")]
        public object? LastDeadline { get; set; }

        [JsonPropertyName("subscriptions")]
        public List<string>? Subscriptions { get; set; }

        [JsonPropertyName("announcements")]
        public List<int>? Announcements { get; set; }

        [JsonPropertyName("is_contest")]
        public bool IsContest { get; set; }

        [JsonPropertyName("is_self_paced")]
        public bool IsSelfPaced { get; set; }

        [JsonPropertyName("is_adaptive")]
        public bool IsAdaptive { get; set; }

        [JsonPropertyName("is_idea_compatible")]
        public bool IsIdeaCompatible { get; set; }

        [JsonPropertyName("is_in_wishlist")]
        public bool IsInWishlist { get; set; }

        [JsonPropertyName("last_step")]
        public string? LastStep { get; set; }

        [JsonPropertyName("intro_video")]
        public IntroVideo? IntroVideo { get; set; }

        [JsonPropertyName("social_providers")]
        public List<object>? SocialProviders { get; set; }

        [JsonPropertyName("authors")]
        public List<int>? Authors { get; set; }

        [JsonPropertyName("tags")]
        public List<int>? Tags { get; set; }

        [JsonPropertyName("has_tutors")]
        public bool HasTutors { get; set; }

        [JsonPropertyName("is_enabled")]
        public bool IsEnabled { get; set; }

        [JsonPropertyName("is_proctored")]
        public bool IsProctored { get; set; }

        [JsonPropertyName("proctor_url")]
        public string? ProctorUrl { get; set; }

        [JsonPropertyName("review_summary")]
        public int? ReviewSummary { get; set; }

        [JsonPropertyName("schedule_type")]
        public string? ScheduleType { get; set; }

        [JsonPropertyName("certificates_count")]
        public int? CertificatesCount { get; set; }

        [JsonPropertyName("learners_count")]
        public int LearnersCount { get; set; }

        [JsonPropertyName("lessons_count")]
        public int LessonsCount { get; set; }

        [JsonPropertyName("quizzes_count")]
        public int QuizzesCount { get; set; }

        [JsonPropertyName("challenges_count")]
        public int ChallengesCount { get; set; }

        [JsonPropertyName("peer_reviews_count")]
        public int PeerReviewsCount { get; set; }

        [JsonPropertyName("instructor_reviews_count")]
        public int InstructorReviewsCount { get; set; }

        [JsonPropertyName("videos_duration")]
        public int VideosDuration { get; set; }

        [JsonPropertyName("time_to_complete")]
        public int? TimeToComplete { get; set; }

        [JsonPropertyName("is_popular")]
        public bool IsPopular { get; set; }

        [JsonPropertyName("is_processed_with_paddle")]
        public bool IsProcessedWithPaddle { get; set; }

        [JsonPropertyName("is_unsuitable")]
        public bool IsUnsuitable { get; set; }

        [JsonPropertyName("is_paid")]
        public bool IsPaid { get; set; }

        [JsonPropertyName("price")]
        public string? Price { get; set; }

        [JsonPropertyName("currency_code")]
        public string? CurrencyCode { get; set; }

        [JsonPropertyName("display_price")]
        public string? DisplayPrice { get; set; }

        [JsonPropertyName("default_promo_code_name")]
        public object? DefaultPromoCodeName { get; set; }

        [JsonPropertyName("default_promo_code_price")]
        public object? DefaultPromoCodePrice { get; set; }

        [JsonPropertyName("default_promo_code_discount")]
        public object? DefaultPromoCodeDiscount { get; set; }

        [JsonPropertyName("default_promo_code_is_percent_discount")]
        public object? DefaultPromoCodeIsPercentDiscount { get; set; }

        [JsonPropertyName("default_promo_code_expire_date")]
        public object? DefaultPromoCodeExpireDate { get; set; }

        [JsonPropertyName("continue_url")]
        public string? ContinueUrl { get; set; }

        [JsonPropertyName("readiness")]
        public double Readiness { get; set; }

        [JsonPropertyName("is_archived")]
        public bool IsArchived { get; set; }

        [JsonPropertyName("options")]
        public Options? Options { get; set; }

        [JsonPropertyName("price_tier")]
        public object? PriceTier { get; set; }

        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonPropertyName("is_censored")]
        public bool IsCensored { get; set; }

        [JsonPropertyName("difficulty")]
        public string? Difficulty { get; set; }

        [JsonPropertyName("acquired_skills")]
        public List<string>? AcquiredSkills { get; set; }

        [JsonPropertyName("acquired_assets")]
        public List<string>? AcquiredAssets { get; set; }

        [JsonPropertyName("learning_format")]
        public string? LearningFormat { get; set; }

        [JsonPropertyName("content_details")]
        public List<object>? ContentDetails { get; set; }

        [JsonPropertyName("issue")]
        public object? Issue { get; set; }

        [JsonPropertyName("course_type")]
        public string? CourseType { get; set; }

        [JsonPropertyName("possible_type")]
        public object? PossibleType { get; set; }

        [JsonPropertyName("is_certificate_with_score")]
        public bool IsCertificateWithScore { get; set; }

        [JsonPropertyName("preview_lesson")]
        public int? PreviewLesson { get; set; }

        [JsonPropertyName("preview_unit")]
        public int? PreviewUnit { get; set; }

        [JsonPropertyName("possible_currencies")]
        public List<object>? PossibleCurrencies { get; set; }

        [JsonPropertyName("commission_basic")]
        public object? CommissionBasic { get; set; }

        [JsonPropertyName("commission_promo")]
        public object? CommissionPromo { get; set; }

        [JsonPropertyName("with_certificate")]
        public bool WithCertificate { get; set; }

        [JsonPropertyName("child_courses")]
        public List<int>? ChildCourses { get; set; }

        [JsonPropertyName("child_courses_count")]
        public int ChildCoursesCount { get; set; }

        [JsonPropertyName("parent_courses")]
        public List<int>? ParentCourses { get; set; }

        [JsonPropertyName("became_published_at")]
        public DateTime? BecamePublishedAt { get; set; }

        [JsonPropertyName("became_paid_at")]
        public string? BecamePaidAt { get; set; }

        [JsonPropertyName("title_en")]
        public string? TitleEn { get; set; }

        [JsonPropertyName("last_update_price_date")]
        public string? LastUpdatePriceDate { get; set; }

        [JsonPropertyName("owner")]
        public int Owner { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        [JsonPropertyName("is_featured")]
        public bool IsFeatured { get; set; }

        [JsonPropertyName("is_public")]
        public bool IsPublic { get; set; }

        [JsonPropertyName("canonical_url")]
        public string? CanonicalUrl { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }

        [JsonPropertyName("slug")]
        public string? Slug { get; set; }

        [JsonPropertyName("begin_date")]
        public string? BeginDate { get; set; }

        [JsonPropertyName("end_date")]
        public object? EndDate { get; set; }

        [JsonPropertyName("soft_deadline")]
        public object? SoftDeadline { get; set; }

        [JsonPropertyName("hard_deadline")]
        public object? HardDeadline { get; set; }

        [JsonPropertyName("grading_policy")]
        public string? GradingPolicy { get; set; }

        [JsonPropertyName("begin_date_source")]
        public string? BeginDateSource { get; set; }

        [JsonPropertyName("end_date_source")]
        public object? EndDateSource { get; set; }

        [JsonPropertyName("soft_deadline_source")]
        public object? SoftDeadlineSource { get; set; }

        [JsonPropertyName("hard_deadline_source")]
        public object? HardDeadlineSource { get; set; }

        [JsonPropertyName("grading_policy_source")]
        public string? GradingPolicySource { get; set; }

        [JsonPropertyName("is_active")]
        public bool IsActive { get; set; }

        [JsonPropertyName("create_date")]
        public string? CreateDate { get; set; }

        [JsonPropertyName("update_date")]
        public string? UpdateDate { get; set; }

        [JsonPropertyName("learners_group")]
        public int? LearnersGroup { get; set; }

        [JsonPropertyName("testers_group")]
        public int? TestersGroup { get; set; }

        [JsonPropertyName("moderators_group")]
        public int? ModeratorsGroup { get; set; }

        [JsonPropertyName("assistants_group")]
        public int? AssistantsGroup { get; set; }

        [JsonPropertyName("teachers_group")]
        public int? TeachersGroup { get; set; }

        [JsonPropertyName("admins_group")]
        public int? AdminsGroup { get; set; }

        [JsonPropertyName("discussions_count")]
        public int DiscussionsCount { get; set; }

        [JsonPropertyName("discussion_proxy")]
        public string? DiscussionProxy { get; set; }

        [JsonPropertyName("discussion_threads")]
        public List<string>? DiscussionThreads { get; set; }

        [JsonPropertyName("lti_consumer_key")]
        public string? LtiConsumerKey { get; set; }

        [JsonPropertyName("lti_secret_key")]
        public string? LtiSecretKey { get; set; }

        [JsonPropertyName("lti_private_profile")]
        public bool LtiPrivateProfile { get; set; }
    }
}
