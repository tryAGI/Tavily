
#nullable enable

namespace Tavily
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateLogsResponseLog
    {
        /// <summary>
        /// When the request was made<br/>
        /// Example: 2026-08-06T13:14:34.739037+00:00
        /// </summary>
        /// <example>2026-08-06T13:14:34.739037+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// Which Tavily API was called<br/>
        /// Example: search
        /// </summary>
        /// <example>search</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavily.JsonConverters.CreateLogsResponseLogEndpointJsonConverter))]
        public global::Tavily.CreateLogsResponseLogEndpoint? Endpoint { get; set; }

        /// <summary>
        /// The request depth (e.g. `basic`, `advanced`). For `research` requests, the model tier.<br/>
        /// Example: advanced
        /// </summary>
        /// <example>advanced</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("depth")]
        public string? Depth { get; set; }

        /// <summary>
        /// Server-side response time in seconds<br/>
        /// Example: 1.52F
        /// </summary>
        /// <example>1.52F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_time")]
        public double? ResponseTime { get; set; }

        /// <summary>
        /// API credits the request consumed<br/>
        /// Example: 2F
        /// </summary>
        /// <example>2F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits")]
        public double? Credits { get; set; }

        /// <summary>
        /// The API key that made the request, masked to its last 4 characters<br/>
        /// Example: ****abcd
        /// </summary>
        /// <example>****abcd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Unique identifier of the original request<br/>
        /// Example: 8442d8d0-8b74-4fca-a89e-5b1b6dd33295
        /// </summary>
        /// <example>8442d8d0-8b74-4fca-a89e-5b1b6dd33295</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLogsResponseLog" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// When the request was made<br/>
        /// Example: 2026-08-06T13:14:34.739037+00:00
        /// </param>
        /// <param name="endpoint">
        /// Which Tavily API was called<br/>
        /// Example: search
        /// </param>
        /// <param name="depth">
        /// The request depth (e.g. `basic`, `advanced`). For `research` requests, the model tier.<br/>
        /// Example: advanced
        /// </param>
        /// <param name="responseTime">
        /// Server-side response time in seconds<br/>
        /// Example: 1.52F
        /// </param>
        /// <param name="credits">
        /// API credits the request consumed<br/>
        /// Example: 2F
        /// </param>
        /// <param name="apiKey">
        /// The API key that made the request, masked to its last 4 characters<br/>
        /// Example: ****abcd
        /// </param>
        /// <param name="requestId">
        /// Unique identifier of the original request<br/>
        /// Example: 8442d8d0-8b74-4fca-a89e-5b1b6dd33295
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLogsResponseLog(
            global::System.DateTime? timestamp,
            global::Tavily.CreateLogsResponseLogEndpoint? endpoint,
            string? depth,
            double? responseTime,
            double? credits,
            string? apiKey,
            string? requestId)
        {
            this.Timestamp = timestamp;
            this.Endpoint = endpoint;
            this.Depth = depth;
            this.ResponseTime = responseTime;
            this.Credits = credits;
            this.ApiKey = apiKey;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLogsResponseLog" /> class.
        /// </summary>
        public CreateLogsResponseLog()
        {
        }

    }
}