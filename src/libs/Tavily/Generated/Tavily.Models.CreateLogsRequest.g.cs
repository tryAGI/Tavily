
#nullable enable

namespace Tavily
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateLogsRequest
    {
        /// <summary>
        /// Maximum number of logs to return, most recent first.<br/>
        /// Default Value: 10<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Inclusive start of the log window (YYYY-MM-DD).<br/>
        /// Example: 2026-08-01
        /// </summary>
        /// <example>2026-08-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Inclusive end of the log window (YYYY-MM-DD).<br/>
        /// Example: 2026-08-07
        /// </summary>
        /// <example>2026-08-07</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public global::System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Only return logs for these endpoints. By default, logs for all endpoints are returned.<br/>
        /// Example: [search, research]
        /// </summary>
        /// <example>[search, research]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        public global::System.Collections.Generic.IList<global::Tavily.CreateLogsRequestEndpoint>? Endpoints { get; set; }

        /// <summary>
        /// Only return logs for a single project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// When `true`, return only logs for the API key provided in the Authorization header. When `false` (default), logs for all API keys under your account or organization are returned.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_by_api_key")]
        public bool? FilterByApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLogsRequest" /> class.
        /// </summary>
        /// <param name="limit">
        /// Maximum number of logs to return, most recent first.<br/>
        /// Default Value: 10<br/>
        /// Example: 100
        /// </param>
        /// <param name="startDate">
        /// Inclusive start of the log window (YYYY-MM-DD).<br/>
        /// Example: 2026-08-01
        /// </param>
        /// <param name="endDate">
        /// Inclusive end of the log window (YYYY-MM-DD).<br/>
        /// Example: 2026-08-07
        /// </param>
        /// <param name="endpoints">
        /// Only return logs for these endpoints. By default, logs for all endpoints are returned.<br/>
        /// Example: [search, research]
        /// </param>
        /// <param name="projectId">
        /// Only return logs for a single project.
        /// </param>
        /// <param name="filterByApiKey">
        /// When `true`, return only logs for the API key provided in the Authorization header. When `false` (default), logs for all API keys under your account or organization are returned.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLogsRequest(
            int? limit,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            global::System.Collections.Generic.IList<global::Tavily.CreateLogsRequestEndpoint>? endpoints,
            string? projectId,
            bool? filterByApiKey)
        {
            this.Limit = limit;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Endpoints = endpoints;
            this.ProjectId = projectId;
            this.FilterByApiKey = filterByApiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLogsRequest" /> class.
        /// </summary>
        public CreateLogsRequest()
        {
        }

    }
}