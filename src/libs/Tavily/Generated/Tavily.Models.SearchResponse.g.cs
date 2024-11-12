
#nullable enable

namespace Tavily
{
    /// <summary>
    /// The response data from the search query.
    /// </summary>
    public sealed partial class SearchResponse
    {
        /// <summary>
        /// The answer to your search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("answer")]
        public string? Answer { get; set; }

        /// <summary>
        /// Your search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Your search result response time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ResponseTime { get; set; }

        /// <summary>
        /// A list of query related image urls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        public global::System.Collections.Generic.IList<string>? Images { get; set; }

        /// <summary>
        /// A list of suggested research follow up questions related to original query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("follow_up_questions")]
        public global::System.Collections.Generic.IList<string>? FollowUpQuestions { get; set; }

        /// <summary>
        /// A list of search results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Tavily.SearchResult> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        /// <param name="answer">
        /// The answer to your search query.
        /// </param>
        /// <param name="query">
        /// Your search query.
        /// </param>
        /// <param name="responseTime">
        /// Your search result response time.
        /// </param>
        /// <param name="images">
        /// A list of query related image urls.
        /// </param>
        /// <param name="followUpQuestions">
        /// A list of suggested research follow up questions related to original query.
        /// </param>
        /// <param name="results">
        /// A list of search results.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SearchResponse(
            string query,
            double responseTime,
            global::System.Collections.Generic.IList<global::Tavily.SearchResult> results,
            string? answer,
            global::System.Collections.Generic.IList<string>? images,
            global::System.Collections.Generic.IList<string>? followUpQuestions)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.ResponseTime = responseTime;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.Answer = answer;
            this.Images = images;
            this.FollowUpQuestions = followUpQuestions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        public SearchResponse()
        {
        }
    }
}