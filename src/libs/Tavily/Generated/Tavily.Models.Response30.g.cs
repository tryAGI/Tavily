
#nullable enable

namespace Tavily
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Response30
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        public global::Tavily.ResponseDetail26? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Response30" /> class.
        /// </summary>
        /// <param name="detail"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Response30(
            global::Tavily.ResponseDetail26? detail)
        {
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Response30" /> class.
        /// </summary>
        public Response30()
        {
        }
    }
}