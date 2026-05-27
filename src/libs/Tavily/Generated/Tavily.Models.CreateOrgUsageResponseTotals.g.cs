
#nullable enable

namespace Tavily
{
    /// <summary>
    /// Aggregated usage across all keys in the organization for the selected window/filters
    /// </summary>
    public sealed partial class CreateOrgUsageResponseTotals
    {
        /// <summary>
        /// Example: 1820
        /// </summary>
        /// <example>1820</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public int? Usage { get; set; }

        /// <summary>
        /// Example: 12.71F
        /// </summary>
        /// <example>12.71F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("paygo_cost_usd")]
        public double? PaygoCostUsd { get; set; }

        /// <summary>
        /// Example: 1760
        /// </summary>
        /// <example>1760</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_count")]
        public int? RequestCount { get; set; }

        /// <summary>
        /// Breakdown per request type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("by_type")]
        public global::Tavily.UsageByType? ByType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrgUsageResponseTotals" /> class.
        /// </summary>
        /// <param name="usage">
        /// Example: 1820
        /// </param>
        /// <param name="paygoCostUsd">
        /// Example: 12.71F
        /// </param>
        /// <param name="requestCount">
        /// Example: 1760
        /// </param>
        /// <param name="byType">
        /// Breakdown per request type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrgUsageResponseTotals(
            int? usage,
            double? paygoCostUsd,
            int? requestCount,
            global::Tavily.UsageByType? byType)
        {
            this.Usage = usage;
            this.PaygoCostUsd = paygoCostUsd;
            this.RequestCount = requestCount;
            this.ByType = byType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrgUsageResponseTotals" /> class.
        /// </summary>
        public CreateOrgUsageResponseTotals()
        {
        }

    }
}