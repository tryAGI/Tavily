#nullable enable

namespace Tavily
{
    public partial interface ITavilyClient
    {
        /// <summary>
        /// Search for data based on a query.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavily.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Tavily.SearchResponse> SearchAsync(
            global::Tavily.SearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Search for data based on a query.
        /// </summary>
        /// <param name="apiKey">
        /// Your unique API key.<br/>
        /// Example: your api key
        /// </param>
        /// <param name="query">
        /// The search query string.<br/>
        /// Example: your search query
        /// </param>
        /// <param name="searchDepth">
        /// The depth of the search. It can be 'basic' or advanced. Default is 'basic'.<br/>
        /// Default Value: basic
        /// </param>
        /// <param name="includeImages">
        /// Include a list of query related images in the response. Default is False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeAnswer">
        /// Include answers in the search results. Default is False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeRawContent">
        /// Include raw content in the search results. Default is False.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maxResults">
        /// The number of maximum search results to return. Default is 5.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="includeDomains">
        /// A list of domains to specifically include in the search results. Default is None.
        /// </param>
        /// <param name="excludeDomains">
        /// A list of domains to specifically exclude from the search results. Default is None.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tavily.SearchResponse> SearchAsync(
            string apiKey,
            string query,
            global::Tavily.SearchRequestSearchDepth? searchDepth = default,
            bool? includeImages = default,
            bool? includeAnswer = default,
            bool? includeRawContent = default,
            int? maxResults = default,
            global::System.Collections.Generic.IList<string>? includeDomains = default,
            global::System.Collections.Generic.IList<string>? excludeDomains = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}