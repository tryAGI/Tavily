#nullable enable

namespace Tavily
{
    public partial interface ITavilyClient
    {
        /// <summary>
        /// Submit feedback on a search request or session<br/>
        /// Submit feedback on how relevant and useful Tavily's results were for your task.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavily.ApiException"></exception>
        /// <remarks>
        /// from tavily import TavilyClient<br/>
        /// tavily_client = TavilyClient(api_key="tvly-YOUR_API_KEY")<br/>
        /// response = tavily_client.feedback(<br/>
        ///     request_id="8442d8d0-8b74-4fca-a89e-5b1b6dd33295",<br/>
        ///     agent_score=1,<br/>
        ///     comment="The top results answered the question directly.",<br/>
        ///     used_ids=["a3f9c2-04"],<br/>
        /// )<br/>
        /// print(response)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Tavily.CreateFeedbackResponse> CreateFeedbackAsync(

            global::Tavily.CreateFeedbackRequest request,
            global::Tavily.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit feedback on a search request or session<br/>
        /// Submit feedback on how relevant and useful Tavily's results were for your task.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavily.ApiException"></exception>
        /// <remarks>
        /// from tavily import TavilyClient<br/>
        /// tavily_client = TavilyClient(api_key="tvly-YOUR_API_KEY")<br/>
        /// response = tavily_client.feedback(<br/>
        ///     request_id="8442d8d0-8b74-4fca-a89e-5b1b6dd33295",<br/>
        ///     agent_score=1,<br/>
        ///     comment="The top results answered the question directly.",<br/>
        ///     used_ids=["a3f9c2-04"],<br/>
        /// )<br/>
        /// print(response)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Tavily.AutoSDKHttpResponse<global::Tavily.CreateFeedbackResponse>> CreateFeedbackAsResponseAsync(

            global::Tavily.CreateFeedbackRequest request,
            global::Tavily.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit feedback on a search request or session<br/>
        /// Submit feedback on how relevant and useful Tavily's results were for your task.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Tavily.CreateFeedbackResponse> CreateFeedbackAsync(
            string? requestId = default,
            string? sessionId = default,
            global::Tavily.OneOf<double?, string>? agentScore = default,
            global::Tavily.OneOf<double?, string>? humanScore = default,
            global::System.Collections.Generic.IList<global::Tavily.CreateFeedbackRequestExtraScore>? extraScores = default,
            string? comment = default,
            string? responseDelivered = default,
            global::System.Collections.Generic.IList<string>? usedIds = default,
            global::System.Collections.Generic.IList<string>? usedUrls = default,
            global::System.Collections.Generic.IList<string>? usedCitations = default,
            global::System.Collections.Generic.IList<global::Tavily.CreateFeedbackRequestUrlsScore>? urlsScores = default,
            global::Tavily.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}