#nullable enable

namespace Tavily
{
    public partial interface ITavilyClient
    {
        /// <summary>
        /// Get organization usage across all API keys<br/>
        /// Retrieve usage (credits), pay-as-you-go USD cost, and request counts for **every API key under an organization you own**, mirroring the platform's Usage analytics page.<br/>
        /// Identify the organization by **name** in the request body. Authenticate with the organization owner's **personal API key** — the key from the owner's own personal account, **not** an organization or enterprise API key. Supports date-range, project, and depth filtering.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavily.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavily.CreateOrgUsageResponse> CreateOrgUsageAsync(

            global::Tavily.CreateOrgUsageRequest request,
            global::Tavily.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get organization usage across all API keys<br/>
        /// Retrieve usage (credits), pay-as-you-go USD cost, and request counts for **every API key under an organization you own**, mirroring the platform's Usage analytics page.<br/>
        /// Identify the organization by **name** in the request body. Authenticate with the organization owner's **personal API key** — the key from the owner's own personal account, **not** an organization or enterprise API key. Supports date-range, project, and depth filtering.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavily.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavily.AutoSDKHttpResponse<global::Tavily.CreateOrgUsageResponse>> CreateOrgUsageAsResponseAsync(

            global::Tavily.CreateOrgUsageRequest request,
            global::Tavily.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get organization usage across all API keys<br/>
        /// Retrieve usage (credits), pay-as-you-go USD cost, and request counts for **every API key under an organization you own**, mirroring the platform's Usage analytics page.<br/>
        /// Identify the organization by **name** in the request body. Authenticate with the organization owner's **personal API key** — the key from the owner's own personal account, **not** an organization or enterprise API key. Supports date-range, project, and depth filtering.
        /// </summary>
        /// <param name="organizationName">
        /// Exact organization name (case-sensitive). You must be the owner of this organization.<br/>
        /// Example: Acme Inc
        /// </param>
        /// <param name="startDate">
        /// Inclusive start of the usage window (YYYY-MM-DD). Defaults to the start of the current billing cycle.<br/>
        /// Example: 2026-05-01
        /// </param>
        /// <param name="endDate">
        /// Inclusive end of the usage window (YYYY-MM-DD). Defaults to today.<br/>
        /// Example: 2026-05-27
        /// </param>
        /// <param name="projectId">
        /// Scope usage to a single project.
        /// </param>
        /// <param name="depth">
        /// Scope usage to a single request depth.<br/>
        /// Example: advanced
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tavily.CreateOrgUsageResponse> CreateOrgUsageAsync(
            string organizationName,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            string? projectId = default,
            global::Tavily.CreateOrgUsageRequestDepth? depth = default,
            global::Tavily.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}