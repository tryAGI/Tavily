#nullable enable

namespace Tavily
{
    public partial interface ITavilyClient
    {
        /// <summary>
        /// Get API key and account usage details<br/>
        /// Get API key and account usage details
        /// </summary>
        /// <param name="xProjectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavily.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavily.Response43> GetUsageAsync(
            string? xProjectId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}