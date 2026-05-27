
#nullable enable

namespace Tavily
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrgUsageResponseKey
    {
        /// <summary>
        /// API key, masked to the last 5 characters<br/>
        /// Example: ...AB3xQ
        /// </summary>
        /// <example>...AB3xQ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Key name<br/>
        /// Example: production-key
        /// </summary>
        /// <example>production-key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: 543
        /// </summary>
        /// <example>543</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public int? Usage { get; set; }

        /// <summary>
        /// Example: 4.34F
        /// </summary>
        /// <example>4.34F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("paygo_cost_usd")]
        public double? PaygoCostUsd { get; set; }

        /// <summary>
        /// Example: 528
        /// </summary>
        /// <example>528</example>
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
        /// Initializes a new instance of the <see cref="CreateOrgUsageResponseKey" /> class.
        /// </summary>
        /// <param name="key">
        /// API key, masked to the last 5 characters<br/>
        /// Example: ...AB3xQ
        /// </param>
        /// <param name="name">
        /// Key name<br/>
        /// Example: production-key
        /// </param>
        /// <param name="usage">
        /// Example: 543
        /// </param>
        /// <param name="paygoCostUsd">
        /// Example: 4.34F
        /// </param>
        /// <param name="requestCount">
        /// Example: 528
        /// </param>
        /// <param name="byType">
        /// Breakdown per request type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrgUsageResponseKey(
            string? key,
            string? name,
            int? usage,
            double? paygoCostUsd,
            int? requestCount,
            global::Tavily.UsageByType? byType)
        {
            this.Key = key;
            this.Name = name;
            this.Usage = usage;
            this.PaygoCostUsd = paygoCostUsd;
            this.RequestCount = requestCount;
            this.ByType = byType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrgUsageResponseKey" /> class.
        /// </summary>
        public CreateOrgUsageResponseKey()
        {
        }

    }
}