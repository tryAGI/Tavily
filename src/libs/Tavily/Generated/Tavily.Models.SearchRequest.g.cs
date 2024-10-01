
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
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKey { get; set; }

        /// <summary>
        /// The search query string.<br/>
        /// Example: your search query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The depth of the search. It can be 'basic' or advanced. Default is 'basic'.<br/>
        /// Default Value: basic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_depth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavily.JsonConverters.SearchRequestSearchDepthJsonConverter))]
        public global::Tavily.SearchRequestSearchDepth? SearchDepth { get; set; } = global::Tavily.SearchRequestSearchDepth.Basic;

        /// <summary>
        /// Include a list of query related images in the response. Default is False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_images")]
        public bool? IncludeImages { get; set; } = false;

        /// <summary>
        /// Include answers in the search results. Default is False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_answer")]
        public bool? IncludeAnswer { get; set; } = false;

        /// <summary>
        /// Include raw content in the search results. Default is False.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_raw_content")]
        public bool? IncludeRawContent { get; set; } = false;

        /// <summary>
        /// The number of maximum search results to return. Default is 5.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public int? MaxResults { get; set; } = 5;

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
    }
}