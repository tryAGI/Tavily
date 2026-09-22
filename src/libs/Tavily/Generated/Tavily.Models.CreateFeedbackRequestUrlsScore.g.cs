
#nullable enable

namespace Tavily
{
    /// <summary>
    /// Feedback on a single result. Each item must include `id` or `url`.
    /// </summary>
    public sealed partial class CreateFeedbackRequestUrlsScore
    {
        /// <summary>
        /// The `id` of the result, as returned in the search response.<br/>
        /// Example: a3f9c2-04
        /// </summary>
        /// <example>a3f9c2-04</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The URL of the result. Use instead of `id` when you don't have the result ID.<br/>
        /// Example: https://www.britannica.com/facts/Lionel-Messi
        /// </summary>
        /// <example>https://www.britannica.com/facts/Lionel-Messi</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Score for this specific result.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_score")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavily.JsonConverters.OneOfJsonConverter<double?, string>))]
        public global::Tavily.OneOf<double?, string>? AgentScore { get; set; }

        /// <summary>
        /// Additional labeled scores for this result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scores")]
        public global::System.Collections.Generic.IList<global::Tavily.CreateFeedbackRequestUrlsScoreScore>? Scores { get; set; }

        /// <summary>
        /// Free-text explanation of the feedback on this result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFeedbackRequestUrlsScore" /> class.
        /// </summary>
        /// <param name="id">
        /// The `id` of the result, as returned in the search response.<br/>
        /// Example: a3f9c2-04
        /// </param>
        /// <param name="url">
        /// The URL of the result. Use instead of `id` when you don't have the result ID.<br/>
        /// Example: https://www.britannica.com/facts/Lionel-Messi
        /// </param>
        /// <param name="agentScore">
        /// Score for this specific result.<br/>
        /// Example: 1
        /// </param>
        /// <param name="scores">
        /// Additional labeled scores for this result.
        /// </param>
        /// <param name="comment">
        /// Free-text explanation of the feedback on this result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFeedbackRequestUrlsScore(
            string? id,
            string? url,
            global::Tavily.OneOf<double?, string>? agentScore,
            global::System.Collections.Generic.IList<global::Tavily.CreateFeedbackRequestUrlsScoreScore>? scores,
            string? comment)
        {
            this.Id = id;
            this.Url = url;
            this.AgentScore = agentScore;
            this.Scores = scores;
            this.Comment = comment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFeedbackRequestUrlsScore" /> class.
        /// </summary>
        public CreateFeedbackRequestUrlsScore()
        {
        }

    }
}