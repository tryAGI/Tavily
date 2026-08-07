#nullable enable

namespace Tavily
{
    public partial interface ITavilyClient
    {
        /// <summary>
        /// Get usage logs for your API keys<br/>
        /// Retrieve per-request usage logs for the API keys under your account or organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavily.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavily.CreateLogsResponse> CreateLogsAsync(

            global::Tavily.CreateLogsRequest request,
            global::Tavily.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get usage logs for your API keys<br/>
        /// Retrieve per-request usage logs for the API keys under your account or organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavily.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavily.AutoSDKHttpResponse<global::Tavily.CreateLogsResponse>> CreateLogsAsResponseAsync(

            global::Tavily.CreateLogsRequest request,
            global::Tavily.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get usage logs for your API keys<br/>
        /// Retrieve per-request usage logs for the API keys under your account or organization.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tavily.CreateLogsResponse> CreateLogsAsync(
            int? limit = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::System.Collections.Generic.IList<global::Tavily.CreateLogsRequestEndpoint>? endpoints = default,
            string? projectId = default,
            bool? filterByApiKey = default,
            global::Tavily.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}