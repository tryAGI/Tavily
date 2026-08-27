
#nullable enable

namespace Tavily
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateLogsResponse
    {
        /// <summary>
        /// Matching log entries, most recent first. Log entries never include the input or output of the original request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        public global::System.Collections.Generic.IList<global::Tavily.CreateLogsResponseLog>? Logs { get; set; }

        /// <summary>
        /// Number of log entries returned<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Response time of this logs request in seconds<br/>
        /// Example: 1.33F
        /// </summary>
        /// <example>1.33F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_time")]
        public double? ResponseTime { get; set; }

        /// <summary>
        /// Unique identifier of this logs request<br/>
        /// Example: d98eaaf1-cf41-4234-bf23-6f1780fbcf73
        /// </summary>
        /// <example>d98eaaf1-cf41-4234-bf23-6f1780fbcf73</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLogsResponse" /> class.
        /// </summary>
        /// <param name="logs">
        /// Matching log entries, most recent first. Log entries never include the input or output of the original request.
        /// </param>
        /// <param name="count">
        /// Number of log entries returned<br/>
        /// Example: 100
        /// </param>
        /// <param name="responseTime">
        /// Response time of this logs request in seconds<br/>
        /// Example: 1.33F
        /// </param>
        /// <param name="requestId">
        /// Unique identifier of this logs request<br/>
        /// Example: d98eaaf1-cf41-4234-bf23-6f1780fbcf73
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLogsResponse(
            global::System.Collections.Generic.IList<global::Tavily.CreateLogsResponseLog>? logs,
            int? count,
            double? responseTime,
            string? requestId)
        {
            this.Logs = logs;
            this.Count = count;
            this.ResponseTime = responseTime;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLogsResponse" /> class.
        /// </summary>
        public CreateLogsResponse()
        {
        }

    }
}