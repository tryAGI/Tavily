
#nullable enable

namespace Tavily
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateFeedbackRequestExtraScore
    {
        /// <summary>
        /// Name of the dimension being scored.<br/>
        /// Example: freshness
        /// </summary>
        /// <example>freshness</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// A numeric score, or a short string label (max 64 characters).<br/>
        /// Example: 0.8F
        /// </summary>
        /// <example>0.8F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavily.JsonConverters.OneOfJsonConverter<double?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Tavily.OneOf<double?, string> Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFeedbackRequestExtraScore" /> class.
        /// </summary>
        /// <param name="label">
        /// Name of the dimension being scored.<br/>
        /// Example: freshness
        /// </param>
        /// <param name="value">
        /// A numeric score, or a short string label (max 64 characters).<br/>
        /// Example: 0.8F
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFeedbackRequestExtraScore(
            string label,
            global::Tavily.OneOf<double?, string> value)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFeedbackRequestExtraScore" /> class.
        /// </summary>
        public CreateFeedbackRequestExtraScore()
        {
        }

    }
}