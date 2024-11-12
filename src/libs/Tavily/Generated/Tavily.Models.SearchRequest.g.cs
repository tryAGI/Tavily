
#nullable enable

namespace Tavily
{
    /// <summary>
    /// The search request object.
    /// </summary>
    public sealed partial class SearchRequest
    {
        /// <summary>
        /// Your unique API key.<br/>
        /// Example: your api key
        /// </summary>
        /// <example>your api key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// The search query string.<br/>
        /// Example: your search query
        /// </summary>
        /// <example>your search query</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The depth of the search. It can be 'basic' or advanced. Default is 'basic'.<br/>
        /// Default Value: basic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_depth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavily.JsonConverters.SearchRequestSearchDepthJsonConverter))]
        public global::Tavily.SearchRequestSearchDepth? SearchDepth { get; set; }

        /// <summary>
        /// Include a list of query related images in the response. Default is False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_images")]
        public bool? IncludeImages { get; set; }

        /// <summary>
        /// Include answers in the search results. Default is False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_answer")]
        public bool? IncludeAnswer { get; set; }

        /// <summary>
        /// Include raw content in the search results. Default is False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_raw_content")]
        public bool? IncludeRawContent { get; set; }

        /// <summary>
        /// The number of maximum search results to return. Default is 5.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A list of domains to specifically include in the search results. Default is None.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_domains")]
        public global::System.Collections.Generic.IList<string>? IncludeDomains { get; set; }

        /// <summary>
        /// A list of domains to specifically exclude from the search results. Default is None.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_domains")]
        public global::System.Collections.Generic.IList<string>? ExcludeDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SearchRequest(
            string apiKey,
            string query,
            global::Tavily.SearchRequestSearchDepth? searchDepth,
            bool? includeImages,
            bool? includeAnswer,
            bool? includeRawContent,
            int? maxResults,
            global::System.Collections.Generic.IList<string>? includeDomains,
            global::System.Collections.Generic.IList<string>? excludeDomains)
        {
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.SearchDepth = searchDepth;
            this.IncludeImages = includeImages;
            this.IncludeAnswer = includeAnswer;
            this.IncludeRawContent = includeRawContent;
            this.MaxResults = maxResults;
            this.IncludeDomains = includeDomains;
            this.ExcludeDomains = excludeDomains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        public SearchRequest()
        {
        }
    }
}