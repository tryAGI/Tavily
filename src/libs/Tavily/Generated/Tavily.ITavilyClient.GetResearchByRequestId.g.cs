#nullable enable

namespace Tavily
{
    public partial interface ITavilyClient
    {
        /// <summary>
        /// Get research task status and results<br/>
        /// Retrieve the status and results of a research task using its request ID.
        /// </summary>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavily.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavily.Response38> GetResearchByRequestIdAsync(
            string requestId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}