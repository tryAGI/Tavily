
#nullable enable

namespace Tavily
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UsageMetrics
    {
        /// <summary>
        /// Credits consumed<br/>
        /// Example: 543
        /// </summary>
        /// <example>543</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public int? Usage { get; set; }

        /// <summary>
        /// Pay-as-you-go cost in USD (overage credits billed at the account's per-credit rate)<br/>
        /// Example: 4.34F
        /// </summary>
        /// <example>4.34F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("paygo_cost_usd")]
        public double? PaygoCostUsd { get; set; }

        /// <summary>
        /// Number of requests<br/>
        /// Example: 528
        /// </summary>
        /// <example>528</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_count")]
        public int? RequestCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageMetrics" /> class.
        /// </summary>
        /// <param name="usage">
        /// Credits consumed<br/>
        /// Example: 543
        /// </param>
        /// <param name="paygoCostUsd">
        /// Pay-as-you-go cost in USD (overage credits billed at the account's per-credit rate)<br/>
        /// Example: 4.34F
        /// </param>
        /// <param name="requestCount">
        /// Number of requests<br/>
        /// Example: 528
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageMetrics(
            int? usage,
            double? paygoCostUsd,
            int? requestCount)
        {
            this.Usage = usage;
            this.PaygoCostUsd = paygoCostUsd;
            this.RequestCount = requestCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageMetrics" /> class.
        /// </summary>
        public UsageMetrics()
        {
        }

    }
}