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
        /// <remarks>
        /// from tavily import TavilyClient<br/>
        /// tavily_client = TavilyClient(api_key="tvly-YOUR_API_KEY")<br/>
        /// response = tavily_client.get_research("123e4567-e89b-12d3-a456-426614174111")<br/>
        /// print(response)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Tavily.GetResearchResponse> GetResearchByRequestIdAsync(
            string requestId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}