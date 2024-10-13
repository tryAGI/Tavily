
#nullable enable

namespace Tavily
{
    public partial class TavilyClient
    {
        partial void PrepareSearchArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Tavily.SearchRequest request);
        partial void PrepareSearchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Tavily.SearchRequest request);
        partial void ProcessSearchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSearchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search for data based on a query.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Tavily.SearchResponse> SearchAsync(
            global::Tavily.SearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareSearchArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/search",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSearchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSearchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSearchResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Tavily.SearchResponse.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

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
        public async global::System.Threading.Tasks.Task<global::Tavily.SearchResponse> SearchAsync(
            string apiKey,
            string query,
            global::Tavily.SearchRequestSearchDepth? searchDepth = global::Tavily.SearchRequestSearchDepth.Basic,
            bool? includeImages = false,
            bool? includeAnswer = false,
            bool? includeRawContent = false,
            int? maxResults = 5,
            global::System.Collections.Generic.IList<string>? includeDomains = default,
            global::System.Collections.Generic.IList<string>? excludeDomains = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Tavily.SearchRequest
            {
                ApiKey = apiKey,
                Query = query,
                SearchDepth = searchDepth,
                IncludeImages = includeImages,
                IncludeAnswer = includeAnswer,
                IncludeRawContent = includeRawContent,
                MaxResults = maxResults,
                IncludeDomains = includeDomains,
                ExcludeDomains = excludeDomains,
            };

            return await SearchAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}