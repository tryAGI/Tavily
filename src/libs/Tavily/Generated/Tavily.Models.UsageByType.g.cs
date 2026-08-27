
#nullable enable

namespace Tavily
{
    /// <summary>
    /// Breakdown per request type
    /// </summary>
    public sealed partial class UsageByType
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        public global::Tavily.UsageMetrics? Search { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crawl")]
        public global::Tavily.UsageMetrics? Crawl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract")]
        public global::Tavily.UsageMetrics? Extract { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("map")]
        public global::Tavily.UsageMetrics? Map { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("research")]
        public global::Tavily.UsageMetrics? Research { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageByType" /> class.
        /// </summary>
        /// <param name="search"></param>
        /// <param name="crawl"></param>
        /// <param name="extract"></param>
        /// <param name="map"></param>
        /// <param name="research"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageByType(
            global::Tavily.UsageMetrics? search,
            global::Tavily.UsageMetrics? crawl,
            global::Tavily.UsageMetrics? extract,
            global::Tavily.UsageMetrics? map,
            global::Tavily.UsageMetrics? research)
        {
            this.Search = search;
            this.Crawl = crawl;
            this.Extract = extract;
            this.Map = map;
            this.Research = research;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageByType" /> class.
        /// </summary>
        public UsageByType()
        {
        }

    }
}