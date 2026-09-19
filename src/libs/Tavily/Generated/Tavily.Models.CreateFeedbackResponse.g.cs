
#nullable enable

namespace Tavily
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateFeedbackResponse
    {
        /// <summary>
        /// Whether the feedback was accepted.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// Unique identifier of this feedback submission.<br/>
        /// Example: f1c0f0a5-0f9b-4a62-9e0e-1b6b2f0a6d31
        /// </summary>
        /// <example>f1c0f0a5-0f9b-4a62-9e0e-1b6b2f0a6d31</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_id")]
        public string? FeedbackId { get; set; }

        /// <summary>
        /// Response time of this feedback request in seconds.<br/>
        /// Example: 0.05F
        /// </summary>
        /// <example>0.05F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_time")]
        public double? ResponseTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFeedbackResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the feedback was accepted.<br/>
        /// Example: true
        /// </param>
        /// <param name="feedbackId">
        /// Unique identifier of this feedback submission.<br/>
        /// Example: f1c0f0a5-0f9b-4a62-9e0e-1b6b2f0a6d31
        /// </param>
        /// <param name="responseTime">
        /// Response time of this feedback request in seconds.<br/>
        /// Example: 0.05F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFeedbackResponse(
            bool? success,
            string? feedbackId,
            double? responseTime)
        {
            this.Success = success;
            this.FeedbackId = feedbackId;
            this.ResponseTime = responseTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFeedbackResponse" /> class.
        /// </summary>
        public CreateFeedbackResponse()
        {
        }

    }
}