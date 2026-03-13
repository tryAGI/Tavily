
#nullable enable

namespace Tavily
{
    /// <summary>
    /// Example: {"request_id":"123e4567-e89b-12d3-a456-426614174111","status":"failed"}
    /// </summary>
    public sealed partial class ResearchTaskFailed
    {
        /// <summary>
        /// The unique identifier of the research task.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174111
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174111</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestId { get; set; }

        /// <summary>
        /// The current status of the research task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavily.JsonConverters.ResearchTaskFailedStatusJsonConverter))]
        public global::Tavily.ResearchTaskFailedStatus Status { get; set; }

        /// <summary>
        /// Time in seconds it took to complete the request.<br/>
        /// Example: 1.23
        /// </summary>
        /// <example>1.23</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ResponseTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchTaskFailed" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The unique identifier of the research task.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174111
        /// </param>
        /// <param name="status">
        /// The current status of the research task.
        /// </param>
        /// <param name="responseTime">
        /// Time in seconds it took to complete the request.<br/>
        /// Example: 1.23
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResearchTaskFailed(
            string requestId,
            int responseTime,
            global::Tavily.ResearchTaskFailedStatus status)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.ResponseTime = responseTime;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResearchTaskFailed" /> class.
        /// </summary>
        public ResearchTaskFailed()
        {
        }
    }
}