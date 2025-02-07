
#nullable enable

namespace Tavily
{
    /// <summary>
    /// The search result object.
    /// </summary>
    public sealed partial class SearchResult
    {
        /// <summary>
        /// The title of the search result url.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The url of the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The most query related content from the scraped url.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The parsed and cleaned HTML of the site. For now includes parsed text only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_content")]
        public string? RawContent { get; set; }

        /// <summary>
        /// The relevance score of the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResult" /> class.
        /// </summary>
        /// <param name="title">
        /// The title of the search result url.
        /// </param>
        /// <param name="url">
        /// The url of the search result.
        /// </param>
        /// <param name="content">
        /// The most query related content from the scraped url.
        /// </param>
        /// <param name="rawContent">
        /// The parsed and cleaned HTML of the site. For now includes parsed text only.
        /// </param>
        /// <param name="score">
        /// The relevance score of the search result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResult(
            string title,
            string url,
            string content,
            double score,
            string? rawContent)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Score = score;
            this.RawContent = rawContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResult" /> class.
        /// </summary>
        public SearchResult()
        {
        }
    }
}