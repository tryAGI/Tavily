
#nullable enable

namespace Tavily
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response39
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
        /// Current status of the research task.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavily.JsonConverters.ResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Tavily.ResponseStatus Status { get; set; }

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
        /// Initializes a new instance of the <see cref="Response39" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The unique identifier of the research task.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174111
        /// </param>
        /// <param name="status">
        /// Current status of the research task.
        /// </param>
        /// <param name="responseTime">
        /// Time in seconds it took to complete the request.<br/>
        /// Example: 1.23
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response39(
            string requestId,
            global::Tavily.ResponseStatus status,
            int responseTime)
        {
            this.RequestId = requestId ?? throw new global::System.ArgumentNullException(nameof(requestId));
            this.Status = status;
            this.ResponseTime = responseTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response39" /> class.
        /// </summary>
        public Response39()
        {
        }
    }
}