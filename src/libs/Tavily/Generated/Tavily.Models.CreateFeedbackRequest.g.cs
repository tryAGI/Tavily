
#nullable enable

namespace Tavily
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateFeedbackRequest
    {
        /// <summary>
        /// The search request to give feedback on, as returned in the `request_id` field of the search response. When provided, the feedback applies to this request.<br/>
        /// Example: 8442d8d0-8b74-4fca-a89e-5b1b6dd33295
        /// </summary>
        /// <example>8442d8d0-8b74-4fca-a89e-5b1b6dd33295</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// The session to give feedback on — the value you sent in the `X-Session-Id` header. When `request_id` is omitted, the feedback applies to the whole session. Optional if `request_id` is provided.<br/>
        /// Example: 5874812a-2e9b-43ea-8978-6cc9225b587b
        /// </summary>
        /// <example>5874812a-2e9b-43ea-8978-6cc9225b587b</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Overall score for how relevant and useful the results were for your task.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_score")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavily.JsonConverters.OneOfJsonConverter<double?, string>))]
        public global::Tavily.OneOf<double?, string>? AgentScore { get; set; }

        /// <summary>
        /// Feedback from your end user, if you collect it.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("human_score")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavily.JsonConverters.OneOfJsonConverter<double?, string>))]
        public global::Tavily.OneOf<double?, string>? HumanScore { get; set; }

        /// <summary>
        /// Additional labeled scores for the dimensions you care about.<br/>
        /// Example: [{"label":"freshness","value":0.4}, {"label":"authority","value":0.9}]
        /// </summary>
        /// <example>[{"label":"freshness","value":0.4}, {"label":"authority","value":0.9}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_scores")]
        public global::System.Collections.Generic.IList<global::Tavily.CreateFeedbackRequestExtraScore>? ExtraScores { get; set; }

        /// <summary>
        /// Free-text explanation of the feedback.<br/>
        /// Example: Results were authoritative but several were more than a year old.
        /// </summary>
        /// <example>Results were authoritative but several were more than a year old.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// The final answer you produced using the results.<br/>
        /// Example: Lionel Messi is an Argentine footballer born in 1987...
        /// </summary>
        /// <example>Lionel Messi is an Argentine footballer born in 1987...</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_delivered")]
        public string? ResponseDelivered { get; set; }

        /// <summary>
        /// IDs of the results you actually used in your answer. Alternative to `used_urls`.<br/>
        /// Example: [a3f9c2-04, a3f9c2-07]
        /// </summary>
        /// <example>[a3f9c2-04, a3f9c2-07]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_ids")]
        public global::System.Collections.Generic.IList<string>? UsedIds { get; set; }

        /// <summary>
        /// URLs of the results you actually used in your answer. Alternative to `used_ids`.<br/>
        /// Example: [https://www.britannica.com/facts/Lionel-Messi]
        /// </summary>
        /// <example>[https://www.britannica.com/facts/Lionel-Messi]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_urls")]
        public global::System.Collections.Generic.IList<string>? UsedUrls { get; set; }

        /// <summary>
        /// The specific content snippets you quoted from the results.<br/>
        /// Example: [Messi is known for his exceptional dribbling skills, vision, and goal-scoring ability.]
        /// </summary>
        /// <example>[Messi is known for his exceptional dribbling skills, vision, and goal-scoring ability.]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("used_citations")]
        public global::System.Collections.Generic.IList<string>? UsedCitations { get; set; }

        /// <summary>
        /// Per-result feedback. Identify each result by `id` or `url`.<br/>
        /// Example: [{"id":"a3f9c2-04","agent_score":1,"comment":"Directly answered the question."}, {"url":"https://example.com/stale-page","agent_score":-1,"scores":[{"label":"freshness","value":0.1}]}]
        /// </summary>
        /// <example>[{"id":"a3f9c2-04","agent_score":1,"comment":"Directly answered the question."}, {"url":"https://example.com/stale-page","agent_score":-1,"scores":[{"label":"freshness","value":0.1}]}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls_scores")]
        public global::System.Collections.Generic.IList<global::Tavily.CreateFeedbackRequestUrlsScore>? UrlsScores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFeedbackRequest" /> class.
        /// </summary>
        /// <param name="requestId">
        /// The search request to give feedback on, as returned in the `request_id` field of the search response. When provided, the feedback applies to this request.<br/>
        /// Example: 8442d8d0-8b74-4fca-a89e-5b1b6dd33295
        /// </param>
        /// <param name="sessionId">
        /// The session to give feedback on — the value you sent in the `X-Session-Id` header. When `request_id` is omitted, the feedback applies to the whole session. Optional if `request_id` is provided.<br/>
        /// Example: 5874812a-2e9b-43ea-8978-6cc9225b587b
        /// </param>
        /// <param name="agentScore">
        /// Overall score for how relevant and useful the results were for your task.<br/>
        /// Example: 1
        /// </param>
        /// <param name="humanScore">
        /// Feedback from your end user, if you collect it.<br/>
        /// Example: 1
        /// </param>
        /// <param name="extraScores">
        /// Additional labeled scores for the dimensions you care about.<br/>
        /// Example: [{"label":"freshness","value":0.4}, {"label":"authority","value":0.9}]
        /// </param>
        /// <param name="comment">
        /// Free-text explanation of the feedback.<br/>
        /// Example: Results were authoritative but several were more than a year old.
        /// </param>
        /// <param name="responseDelivered">
        /// The final answer you produced using the results.<br/>
        /// Example: Lionel Messi is an Argentine footballer born in 1987...
        /// </param>
        /// <param name="usedIds">
        /// IDs of the results you actually used in your answer. Alternative to `used_urls`.<br/>
        /// Example: [a3f9c2-04, a3f9c2-07]
        /// </param>
        /// <param name="usedUrls">
        /// URLs of the results you actually used in your answer. Alternative to `used_ids`.<br/>
        /// Example: [https://www.britannica.com/facts/Lionel-Messi]
        /// </param>
        /// <param name="usedCitations">
        /// The specific content snippets you quoted from the results.<br/>
        /// Example: [Messi is known for his exceptional dribbling skills, vision, and goal-scoring ability.]
        /// </param>
        /// <param name="urlsScores">
        /// Per-result feedback. Identify each result by `id` or `url`.<br/>
        /// Example: [{"id":"a3f9c2-04","agent_score":1,"comment":"Directly answered the question."}, {"url":"https://example.com/stale-page","agent_score":-1,"scores":[{"label":"freshness","value":0.1}]}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFeedbackRequest(
            string? requestId,
            string? sessionId,
            global::Tavily.OneOf<double?, string>? agentScore,
            global::Tavily.OneOf<double?, string>? humanScore,
            global::System.Collections.Generic.IList<global::Tavily.CreateFeedbackRequestExtraScore>? extraScores,
            string? comment,
            string? responseDelivered,
            global::System.Collections.Generic.IList<string>? usedIds,
            global::System.Collections.Generic.IList<string>? usedUrls,
            global::System.Collections.Generic.IList<string>? usedCitations,
            global::System.Collections.Generic.IList<global::Tavily.CreateFeedbackRequestUrlsScore>? urlsScores)
        {
            this.RequestId = requestId;
            this.SessionId = sessionId;
            this.AgentScore = agentScore;
            this.HumanScore = humanScore;
            this.ExtraScores = extraScores;
            this.Comment = comment;
            this.ResponseDelivered = responseDelivered;
            this.UsedIds = usedIds;
            this.UsedUrls = usedUrls;
            this.UsedCitations = usedCitations;
            this.UrlsScores = urlsScores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFeedbackRequest" /> class.
        /// </summary>
        public CreateFeedbackRequest()
        {
        }

    }
}