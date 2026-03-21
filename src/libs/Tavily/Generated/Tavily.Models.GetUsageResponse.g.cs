
#nullable enable

namespace Tavily
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUsageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public global::Tavily.GetUsageResponseKey? Key { get; set; }

        /// <summary>
        /// Account plan and usage information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        public global::Tavily.GetUsageResponseAccount? Account { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponse" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="account">
        /// Account plan and usage information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsageResponse(
            global::Tavily.GetUsageResponseKey? key,
            global::Tavily.GetUsageResponseAccount? account)
        {
            this.Key = key;
            this.Account = account;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponse" /> class.
        /// </summary>
        public GetUsageResponse()
        {
        }
    }
}