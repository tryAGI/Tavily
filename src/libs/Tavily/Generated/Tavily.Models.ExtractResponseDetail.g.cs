
#nullable enable

namespace Tavily
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExtractResponseDetail
    {
        /// <summary>
        /// A list of URLs that could not be processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_results")]
        public global::System.Collections.Generic.IList<global::Tavily.ExtractResponseDetailFailedResult>? FailedResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractResponseDetail" /> class.
        /// </summary>
        /// <param name="failedResults">
        /// A list of URLs that could not be processed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExtractResponseDetail(
            global::System.Collections.Generic.IList<global::Tavily.ExtractResponseDetailFailedResult>? failedResults)
        {
            this.FailedResults = failedResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtractResponseDetail" /> class.
        /// </summary>
        public ExtractResponseDetail()
        {
        }

    }
}