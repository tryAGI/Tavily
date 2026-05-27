
#nullable enable

namespace Tavily
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrgUsageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::Tavily.CreateOrgUsageResponseOrganization? Organization { get; set; }

        /// <summary>
        /// Aggregated usage across all keys in the organization for the selected window/filters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totals")]
        public global::Tavily.CreateOrgUsageResponseTotals? Totals { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keys")]
        public global::System.Collections.Generic.IList<global::Tavily.CreateOrgUsageResponseKey>? Keys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrgUsageResponse" /> class.
        /// </summary>
        /// <param name="organization"></param>
        /// <param name="totals">
        /// Aggregated usage across all keys in the organization for the selected window/filters
        /// </param>
        /// <param name="keys"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrgUsageResponse(
            global::Tavily.CreateOrgUsageResponseOrganization? organization,
            global::Tavily.CreateOrgUsageResponseTotals? totals,
            global::System.Collections.Generic.IList<global::Tavily.CreateOrgUsageResponseKey>? keys)
        {
            this.Organization = organization;
            this.Totals = totals;
            this.Keys = keys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrgUsageResponse" /> class.
        /// </summary>
        public CreateOrgUsageResponse()
        {
        }

    }
}