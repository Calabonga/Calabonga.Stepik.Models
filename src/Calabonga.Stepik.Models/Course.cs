using Calabonga.Stepik.Models;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Course
{
    /// <summary>
    /// Represents a course entity (global namespace).
    /// </summary>

    /// <summary>
    /// Course identifier.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// Brief description.
    /// </summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>
    /// Workload for completing the course (for example: "3-5 hours per week").
    /// </summary>
    [JsonPropertyName("workload")]
    public string? Workload { get; set; }

    /// <summary>
    /// Link to the course cover image.
    /// </summary>
    [JsonPropertyName("cover")]
    public string? Cover { get; set; }

    /// <summary>
    /// Intro text or video reference.
    /// </summary>
    [JsonPropertyName("intro")]
    public string? Intro { get; set; }

    /// <summary>
    /// Course format description.
    /// </summary>
    [JsonPropertyName("course_format")]
    public string? CourseFormat { get; set; }

    /// <summary>
    /// Target audience description.
    /// </summary>
    [JsonPropertyName("target_audience")]
    public string? TargetAudience { get; set; }

    /// <summary>
    /// Link to certificate footer image.
    /// </summary>
    [JsonPropertyName("certificate_footer")]
    public string? CertificateFooter { get; set; }

    /// <summary>
    /// Link to certificate organization cover.
    /// </summary>
    [JsonPropertyName("certificate_cover_org")]
    public string? CertificateCoverOrg { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a certificate is issued.
    /// </summary>
    [JsonPropertyName("is_certificate_issued")]
    public bool IsCertificateIssued { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether a certificate is auto-issued.
    /// </summary>
    [JsonPropertyName("is_certificate_auto_issued")]
    public bool IsCertificateAutoIssued { get; set; }

    /// <summary>
    /// Threshold points for a regular certificate.
    /// </summary>
    [JsonPropertyName("certificate_regular_threshold")]
    public int? CertificateRegularThreshold { get; set; }

    /// <summary>
    /// Threshold points for a distinction certificate.
    /// </summary>
    [JsonPropertyName("certificate_distinction_threshold")]
    public int? CertificateDistinctionThreshold { get; set; }

    /// <summary>
    /// Gets or sets instructors identifiers.
    /// </summary>
    [JsonPropertyName("instructors")]
    public List<int>? Instructors { get; set; }

    /// <summary>
    /// Gets or sets certificate information.
    /// </summary>
    [JsonPropertyName("certificate")]
    public string? Certificate { get; set; }

    /// <summary>
    /// Gets or sets course requirements.
    /// </summary>
    [JsonPropertyName("requirements")]
    public string? Requirements { get; set; }

    /// <summary>
    /// Gets or sets course description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets section identifiers.
    /// </summary>
    [JsonPropertyName("sections")]
    public List<int>? Sections { get; set; }

    /// <summary>
    /// Gets or sets total units count.
    /// </summary>
    [JsonPropertyName("total_units")]
    public int? TotalUnits { get; set; }

    /// <summary>
    /// Gets or sets enrollment count.
    /// </summary>
    [JsonPropertyName("enrollment")]
    public int? Enrollment { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the course is marked as favorite.
    /// </summary>
    [JsonPropertyName("is_favorite")]
    public bool IsFavorite { get; set; }

    /// <summary>
    /// Gets or sets available actions for the course.
    /// </summary>
    [JsonPropertyName("actions")]
    public Actions? Actions { get; set; }

    /// <summary>
    /// Gets or sets progress information.
    /// </summary>
    [JsonPropertyName("progress")]
    public object? Progress { get; set; }

    /// <summary>
    /// Gets or sets the first lesson identifier.
    /// </summary>
    [JsonPropertyName("first_lesson")]
    public int? FirstLesson { get; set; }

    /// <summary>
    /// Gets or sets the first unit identifier.
    /// </summary>
    [JsonPropertyName("first_unit")]
    public int? FirstUnit { get; set; }

    /// <summary>
    /// Gets or sets the certificate link.
    /// </summary>
    [JsonPropertyName("certificate_link")]
    public string? CertificateLink { get; set; }

    /// <summary>
    /// Gets or sets the regular certificate link.
    /// </summary>
    [JsonPropertyName("certificate_regular_link")]
    public string? CertificateRegularLink { get; set; }

    /// <summary>
    /// Gets or sets the distinction certificate link.
    /// </summary>
    [JsonPropertyName("certificate_distinction_link")]
    public string? CertificateDistinctionLink { get; set; }

    /// <summary>
    /// Gets or sets user certificate identifier.
    /// </summary>
    [JsonPropertyName("user_certificate")]
    public int? UserCertificate { get; set; }

    /// <summary>
    /// Gets or sets referral link.
    /// </summary>
    [JsonPropertyName("referral_link")]
    public string? ReferralLink { get; set; }

    /// <summary>
    /// Gets or sets schedule link.
    /// </summary>
    [JsonPropertyName("schedule_link")]
    public string? ScheduleLink { get; set; }

    /// <summary>
    /// Gets or sets long schedule link.
    /// </summary>
    [JsonPropertyName("schedule_long_link")]
    public string? ScheduleLongLink { get; set; }

    /// <summary>
    /// Gets or sets the first deadline.
    /// </summary>
    [JsonPropertyName("first_deadline")]
    public object? FirstDeadline { get; set; }

    /// <summary>
    /// Gets or sets the last deadline.
    /// </summary>
    [JsonPropertyName("last_deadline")]
    public object? LastDeadline { get; set; }

    /// <summary>
    /// Gets or sets subscriptions.
    /// </summary>
    [JsonPropertyName("subscriptions")]
    public List<string>? Subscriptions { get; set; }

    /// <summary>
    /// Gets or sets announcement identifiers.
    /// </summary>
    [JsonPropertyName("announcements")]
    public List<int>? Announcements { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the course is a contest.
    /// </summary>
    [JsonPropertyName("is_contest")]
    public bool IsContest { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the course is self paced.
    /// </summary>
    [JsonPropertyName("is_self_paced")]
    public bool IsSelfPaced { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the course is adaptive.
    /// </summary>
    [JsonPropertyName("is_adaptive")]
    public bool IsAdaptive { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the course is idea compatible.
    /// </summary>
    [JsonPropertyName("is_idea_compatible")]
    public bool IsIdeaCompatible { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the course is in wishlist.
    /// </summary>
    [JsonPropertyName("is_in_wishlist")]
    public bool IsInWishlist { get; set; }

    /// <summary>
    /// Gets or sets last step reference.
    /// </summary>
    [JsonPropertyName("last_step")]
    public string? LastStep { get; set; }

    /// <summary>
    /// Gets or sets introductory video information.
    /// </summary>
    [JsonPropertyName("intro_video")]
    public IntroVideo? IntroVideo { get; set; }

    /// <summary>
    /// Gets or sets social providers.
    /// </summary>
    [JsonPropertyName("social_providers")]
    public List<object>? SocialProviders { get; set; }

    /// <summary>
    /// Gets or sets authors identifiers.
    /// </summary>
    [JsonPropertyName("authors")]
    public List<int>? Authors { get; set; }

    /// <summary>
    /// Gets or sets tag identifiers.
    /// </summary>
    [JsonPropertyName("tags")]
    public List<int>? Tags { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the course has tutors.
    /// </summary>
    [JsonPropertyName("has_tutors")]
    public bool HasTutors { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the course is enabled.
    /// </summary>
    [JsonPropertyName("is_enabled")]
    public bool IsEnabled { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the course is proctored.
    /// </summary>
    [JsonPropertyName("is_proctored")]
    public bool IsProctored { get; set; }

    /// <summary>
    /// Gets or sets the proctor URL.
    /// </summary>
    [JsonPropertyName("proctor_url")]
    public string? ProctorUrl { get; set; }

    /// <summary>
    /// Gets or sets review summary.
    /// </summary>
    [JsonPropertyName("review_summary")]
    public int? ReviewSummary { get; set; }

    /// <summary>
    /// Gets or sets schedule type.
    /// </summary>
    [JsonPropertyName("schedule_type")]
    public string? ScheduleType { get; set; }

    /// <summary>
    /// Gets or sets certificates count.
    /// </summary>
    [JsonPropertyName("certificates_count")]
    public int? CertificatesCount { get; set; }

    /// <summary>
    /// Gets or sets learners count.
    /// </summary>
    [JsonPropertyName("learners_count")]
    public int LearnersCount { get; set; }

    /// <summary>
    /// Gets or sets lessons count.
    /// </summary>
    [JsonPropertyName("lessons_count")]
    public int LessonsCount { get; set; }

    /// <summary>
    /// Gets or sets quizzes count.
    /// </summary>
    [JsonPropertyName("quizzes_count")]
    public int QuizzesCount { get; set; }

    /// <summary>
    /// Gets or sets challenges count.
    /// </summary>
    [JsonPropertyName("challenges_count")]
    public int ChallengesCount { get; set; }

    /// <summary>
    /// Gets or sets peer reviews count.
    /// </summary>
    [JsonPropertyName("peer_reviews_count")]
    public int PeerReviewsCount { get; set; }

    /// <summary>
    /// Gets or sets instructor reviews count.
    /// </summary>
    [JsonPropertyName("instructor_reviews_count")]
    public int InstructorReviewsCount { get; set; }

    /// <summary>
    /// Gets or sets videos total duration in seconds.
    /// </summary>
    [JsonPropertyName("videos_duration")]
    public int VideosDuration { get; set; }
    /// <summary>
    /// Gets or sets estimated time to complete (in minutes or seconds depending on API context).
    /// </summary>
    [JsonPropertyName("time_to_complete")]
    public int? TimeToComplete { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the course is popular.
    /// </summary>
    [JsonPropertyName("is_popular")]
    public bool IsPopular { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the course is processed with Paddle.
    /// </summary>
    [JsonPropertyName("is_processed_with_paddle")]
    public bool IsProcessedWithPaddle { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the course is unsuitable.
    /// </summary>
    [JsonPropertyName("is_unsuitable")]
    public bool IsUnsuitable { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the course is paid.
    /// </summary>
    [JsonPropertyName("is_paid")]
    public bool IsPaid { get; set; }

    /// <summary>
    /// Gets or sets the price.
    /// </summary>
    [JsonPropertyName("price")]
    public string? Price { get; set; }

    /// <summary>
    /// Gets or sets the currency code.
    /// </summary>
    [JsonPropertyName("currency_code")]
    public string? CurrencyCode { get; set; }

    /// <summary>
    /// Gets or sets the display price.
    /// </summary>
    [JsonPropertyName("display_price")]
    public string? DisplayPrice { get; set; }

    /// <summary>
    /// Gets or sets default promo code name.
    /// </summary>
    [JsonPropertyName("default_promo_code_name")]
    public object? DefaultPromoCodeName { get; set; }

    /// <summary>
    /// Gets or sets default promo code price.
    /// </summary>
    [JsonPropertyName("default_promo_code_price")]
    public object? DefaultPromoCodePrice { get; set; }

    /// <summary>
    /// Gets or sets default promo code discount.
    /// </summary>
    [JsonPropertyName("default_promo_code_discount")]
    public object? DefaultPromoCodeDiscount { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the default promo code uses percent discount.
    /// </summary>
    [JsonPropertyName("default_promo_code_is_percent_discount")]
    public object? DefaultPromoCodeIsPercentDiscount { get; set; }

    /// <summary>
    /// Gets or sets default promo code expire date.
    /// </summary>
    [JsonPropertyName("default_promo_code_expire_date")]
    public object? DefaultPromoCodeExpireDate { get; set; }

    /// <summary>
    /// Gets or sets continue URL.
    /// </summary>
    [JsonPropertyName("continue_url")]
    public string? ContinueUrl { get; set; }

    /// <summary>
    /// Gets or sets readiness metric.
    /// </summary>
    [JsonPropertyName("readiness")]
    public double Readiness { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the course is archived.
    /// </summary>
    [JsonPropertyName("is_archived")]
    public bool IsArchived { get; set; }

    /// <summary>
    /// Gets or sets options and limits for the course.
    /// </summary>
    [JsonPropertyName("options")]
    public Options? Options { get; set; }

    /// <summary>
    /// Gets or sets price tier information.
    /// </summary>
    [JsonPropertyName("price_tier")]
    public object? PriceTier { get; set; }

    /// <summary>
    /// Gets or sets position value.
    /// </summary>
    [JsonPropertyName("position")]
    public int Position { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the course is censored.
    /// </summary>
    [JsonPropertyName("is_censored")]
    public bool IsCensored { get; set; }

    /// <summary>
    /// Gets or sets difficulty level.
    /// </summary>
    [JsonPropertyName("difficulty")]
    public string? Difficulty { get; set; }

    /// <summary>
    /// Gets or sets acquired skills.
    /// </summary>
    [JsonPropertyName("acquired_skills")]
    public List<string>? AcquiredSkills { get; set; }

    /// <summary>
    /// Gets or sets acquired assets.
    /// </summary>
    [JsonPropertyName("acquired_assets")]
    public List<string>? AcquiredAssets { get; set; }

    /// <summary>
    /// Gets or sets learning format.
    /// </summary>
    [JsonPropertyName("learning_format")]
    public string? LearningFormat { get; set; }

    /// <summary>
    /// Gets or sets content details.
    /// </summary>
    [JsonPropertyName("content_details")]
    public List<object>? ContentDetails { get; set; }

    /// <summary>
    /// Gets or sets issue information.
    /// </summary>
    [JsonPropertyName("issue")]
    public object? Issue { get; set; }

    /// <summary>
    /// Gets or sets course type.
    /// </summary>
    [JsonPropertyName("course_type")]
    public string? CourseType { get; set; }

    /// <summary>
    /// Gets or sets possible type information.
    /// </summary>
    [JsonPropertyName("possible_type")]
    public object? PossibleType { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether certificate requires score.
    /// </summary>
    [JsonPropertyName("is_certificate_with_score")]
    public bool IsCertificateWithScore { get; set; }

    /// <summary>
    /// Gets or sets preview lesson identifier.
    /// </summary>
    [JsonPropertyName("preview_lesson")]
    public int? PreviewLesson { get; set; }

    /// <summary>
    /// Gets or sets preview unit identifier.
    /// </summary>
    [JsonPropertyName("preview_unit")]
    public int? PreviewUnit { get; set; }

    /// <summary>
    /// Gets or sets possible currencies.
    /// </summary>
    [JsonPropertyName("possible_currencies")]
    public List<object>? PossibleCurrencies { get; set; }

    /// <summary>
    /// Gets or sets basic commission information.
    /// </summary>
    [JsonPropertyName("commission_basic")]
    public object? CommissionBasic { get; set; }

    /// <summary>
    /// Gets or sets promo commission information.
    /// </summary>
    [JsonPropertyName("commission_promo")]
    public object? CommissionPromo { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether course has a certificate.
    /// </summary>
    [JsonPropertyName("with_certificate")]
    public bool WithCertificate { get; set; }

    /// <summary>
    /// Gets or sets child courses identifiers.
    /// </summary>
    [JsonPropertyName("child_courses")]
    public List<int>? ChildCourses { get; set; }

    /// <summary>
    /// Gets or sets child courses count.
    /// </summary>
    [JsonPropertyName("child_courses_count")]
    public int ChildCoursesCount { get; set; }

    /// <summary>
    /// Gets or sets parent courses identifiers.
    /// </summary>
    [JsonPropertyName("parent_courses")]
    public List<int>? ParentCourses { get; set; }

    /// <summary>
    /// Gets or sets the date when the course became published.
    /// </summary>
    [JsonPropertyName("became_published_at")]
    public DateTime? BecamePublishedAt { get; set; }

    /// <summary>
    /// Gets or sets the date when the course became paid.
    /// </summary>
    [JsonPropertyName("became_paid_at")]
    public string? BecamePaidAt { get; set; }

    /// <summary>
    /// Gets or sets English title.
    /// </summary>
    [JsonPropertyName("title_en")]
    public string? TitleEn { get; set; }

    /// <summary>
    /// Gets or sets last update price date.
    /// </summary>
    [JsonPropertyName("last_update_price_date")]
    public string? LastUpdatePriceDate { get; set; }

    /// <summary>
    /// Gets or sets owner identifier.
    /// </summary>
    [JsonPropertyName("owner")]
    public int Owner { get; set; }

    /// <summary>
    /// Gets or sets language code.
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the course is featured.
    /// </summary>
    [JsonPropertyName("is_featured")]
    public bool IsFeatured { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the course is public.
    /// </summary>
    [JsonPropertyName("is_public")]
    public bool IsPublic { get; set; }

    /// <summary>
    /// Gets or sets canonical URL.
    /// </summary>
    [JsonPropertyName("canonical_url")]
    public string? CanonicalUrl { get; set; }

    /// <summary>
    /// Gets or sets title.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// Gets or sets slug.
    /// </summary>
    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    /// <summary>
    /// Gets or sets begin date.
    /// </summary>
    [JsonPropertyName("begin_date")]
    public string? BeginDate { get; set; }

    /// <summary>
    /// Gets or sets end date.
    /// </summary>
    [JsonPropertyName("end_date")]
    public object? EndDate { get; set; }

    /// <summary>
    /// Gets or sets soft deadline.
    /// </summary>
    [JsonPropertyName("soft_deadline")]
    public object? SoftDeadline { get; set; }

    /// <summary>
    /// Gets or sets hard deadline.
    /// </summary>
    [JsonPropertyName("hard_deadline")]
    public object? HardDeadline { get; set; }

    /// <summary>
    /// Gets or sets grading policy.
    /// </summary>
    [JsonPropertyName("grading_policy")]
    public string? GradingPolicy { get; set; }

    /// <summary>
    /// Gets or sets begin date source.
    /// </summary>
    [JsonPropertyName("begin_date_source")]
    public string? BeginDateSource { get; set; }

    /// <summary>
    /// Gets or sets end date source.
    /// </summary>
    [JsonPropertyName("end_date_source")]
    public object? EndDateSource { get; set; }

    /// <summary>
    /// Gets or sets soft deadline source.
    /// </summary>
    [JsonPropertyName("soft_deadline_source")]
    public object? SoftDeadlineSource { get; set; }

    /// <summary>
    /// Gets or sets hard deadline source.
    /// </summary>
    [JsonPropertyName("hard_deadline_source")]
    public object? HardDeadlineSource { get; set; }

    /// <summary>
    /// Gets or sets grading policy source.
    /// </summary>
    [JsonPropertyName("grading_policy_source")]
    public string? GradingPolicySource { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the course is active.
    /// </summary>
    [JsonPropertyName("is_active")]
    public bool IsActive { get; set; }

    /// <summary>
    /// Gets or sets create date.
    /// </summary>
    [JsonPropertyName("create_date")]
    public string? CreateDate { get; set; }

    /// <summary>
    /// Gets or sets update date.
    /// </summary>
    [JsonPropertyName("update_date")]
    public string? UpdateDate { get; set; }

    /// <summary>
    /// Gets or sets learners group identifier.
    /// </summary>
    [JsonPropertyName("learners_group")]
    public int? LearnersGroup { get; set; }

    /// <summary>
    /// Gets or sets testers group identifier.
    /// </summary>
    [JsonPropertyName("testers_group")]
    public int? TestersGroup { get; set; }

    /// <summary>
    /// Gets or sets moderators group identifier.
    /// </summary>
    [JsonPropertyName("moderators_group")]
    public int? ModeratorsGroup { get; set; }

    /// <summary>
    /// Gets or sets assistants group identifier.
    /// </summary>
    [JsonPropertyName("assistants_group")]
    public int? AssistantsGroup { get; set; }

    /// <summary>
    /// Gets or sets teachers group identifier.
    /// </summary>
    [JsonPropertyName("teachers_group")]
    public int? TeachersGroup { get; set; }

    /// <summary>
    /// Gets or sets admins group identifier.
    /// </summary>
    [JsonPropertyName("admins_group")]
    public int? AdminsGroup { get; set; }

    /// <summary>
    /// Gets or sets discussions count.
    /// </summary>
    [JsonPropertyName("discussions_count")]
    public int DiscussionsCount { get; set; }

    /// <summary>
    /// Gets or sets discussion proxy.
    /// </summary>
    [JsonPropertyName("discussion_proxy")]
    public string? DiscussionProxy { get; set; }

    /// <summary>
    /// Gets or sets discussion threads.
    /// </summary>
    [JsonPropertyName("discussion_threads")]
    public List<string>? DiscussionThreads { get; set; }

    /// <summary>
    /// Gets or sets LTI consumer key.
    /// </summary>
    [JsonPropertyName("lti_consumer_key")]
    public string? LtiConsumerKey { get; set; }

    /// <summary>
    /// Gets or sets LTI secret key.
    /// </summary>
    [JsonPropertyName("lti_secret_key")]
    public string? LtiSecretKey { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether LTI private profile is enabled.
    /// </summary>
    [JsonPropertyName("lti_private_profile")]
    public bool LtiPrivateProfile { get; set; }
}
