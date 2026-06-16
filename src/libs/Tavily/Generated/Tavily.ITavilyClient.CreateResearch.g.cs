#nullable enable

namespace Tavily
{
    public partial interface ITavilyClient
    {
        /// <summary>
        /// Initiate a research task<br/>
        /// Tavily Research performs comprehensive research on a given topic by conducting multiple searches, analyzing sources, and generating a detailed research report.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavily.ApiException"></exception>
        /// <remarks>
        /// from tavily import TavilyClient<br/>
        /// tavily_client = TavilyClient(api_key="tvly-YOUR_API_KEY")<br/>
        /// response = tavily_client.research("What are the latest developments in AI?")<br/>
        /// print(response)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Tavily.CreateResearchResponse> CreateResearchAsync(

            global::Tavily.CreateResearchRequest request,
            global::Tavily.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Initiate a research task<br/>
        /// Tavily Research performs comprehensive research on a given topic by conducting multiple searches, analyzing sources, and generating a detailed research report.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavily.ApiException"></exception>
        /// <remarks>
        /// from tavily import TavilyClient<br/>
        /// tavily_client = TavilyClient(api_key="tvly-YOUR_API_KEY")<br/>
        /// response = tavily_client.research("What are the latest developments in AI?")<br/>
        /// print(response)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Tavily.AutoSDKHttpResponse<global::Tavily.CreateResearchResponse>> CreateResearchAsResponseAsync(

            global::Tavily.CreateResearchRequest request,
            global::Tavily.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Initiate a research task<br/>
        /// Tavily Research performs comprehensive research on a given topic by conducting multiple searches, analyzing sources, and generating a detailed research report.
        /// </summary>
        /// <param name="input">
        /// The research task or question to investigate.<br/>
        /// Example: What are the latest developments in AI?
        /// </param>
        /// <param name="model">
        /// The model used by the research agent. "mini" is optimized for targeted, efficient research and works best for narrow or well-scoped questions. "pro" provides comprehensive, multi-angle research and is suited for complex topics that span multiple subtopics or domains<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="stream">
        /// Whether to stream the research results as they are generated. When 'true', returns a Server-Sent Events (SSE) stream. See [Streaming documentation](/documentation/api-reference/endpoint/research-streaming) for details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="outputSchema">
        /// A JSON Schema object that defines the structure of the research output. When provided, the research response will be structured to match this schema, ensuring a predictable and validated output shape. Must include a 'properties' field, and may optionally include 'required' field.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: {"properties":{"company":{"type":"string","description":"The name of the company"},"key_metrics":{"type":"array","description":"List of key performance metrics","items":{"type":"string"}},"financial_details":{"type":"object","description":"Detailed financial breakdown","properties":{"operating_income":{"type":"number","description":"Operating income for the period"}}}},"required":["company"]}
        /// </param>
        /// <param name="citationFormat">
        /// The format for citations in the research report.<br/>
        /// Default Value: numbered
        /// </param>
        /// <param name="includeDomains">
        /// Soft preference for sources. The research agent prioritizes these domains, but URLs from other domains can still appear in the final report. Matching is host-based and includes subdomains (e.g., `sec.gov` matches `sec.gov` and `data.sec.gov`). Maximum 20 entries.<br/>
        /// Default Value: []<br/>
        /// Example: [sec.gov, ec.europa.eu]
        /// </param>
        /// <param name="excludeDomains">
        /// Hard blocklist. No URL from a listed domain or any of its subdomains appears in the response. Subdomain matching is downward only — blocking `medium.com` also blocks `blog.medium.com`, but blocking `blog.medium.com` leaves `medium.com` itself allowed. Maximum 20 entries.<br/>
        /// Default Value: []<br/>
        /// Example: [reddit.com, quora.com]
        /// </param>
        /// <param name="outputLength">
        /// Typed control over response size. Ranges are targets, not hard caps — individual responses can fall outside when the question requires it.<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="files">
        /// Attach files to the research request and the agent uses their contents as a source alongside the web. Each entry carries a filename and its base64-encoded contents. The agent reads the relevant parts of each file, grounds its answer in them, and cites any file it draws from.<br/>
        /// Supported file types: `.txt`, `.md`, `.json`.<br/>
        /// Limits: up to 5 files per request; max 80,000 words per text file; max 80,000 words combined across all files.<br/>
        /// Example: [{"name":"q1-report.md","data":"\u003Cbase64-encoded file contents\u003E","type":"base64"}]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tavily.CreateResearchResponse> CreateResearchAsync(
            string input,
            global::Tavily.CreateResearchRequestModel? model = default,
            bool? stream = default,
            global::Tavily.CreateResearchRequestOutputSchema? outputSchema = default,
            global::Tavily.CreateResearchRequestCitationFormat? citationFormat = default,
            global::System.Collections.Generic.IList<string>? includeDomains = default,
            global::System.Collections.Generic.IList<string>? excludeDomains = default,
            global::Tavily.CreateResearchRequestOutputLength? outputLength = default,
            global::System.Collections.Generic.IList<global::Tavily.CreateResearchRequestFile>? files = default,
            global::Tavily.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}