
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
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::Tavily.SearchRequest? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Tavily.SearchRequest),
                jsonSerializerContext) as global::Tavily.SearchRequest;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Tavily.SearchRequest? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Tavily.SearchRequest>(
                json,
                jsonSerializerOptions);
        }

    }
}