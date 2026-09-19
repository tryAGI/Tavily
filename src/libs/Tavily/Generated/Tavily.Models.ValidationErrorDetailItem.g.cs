
#nullable enable

namespace Tavily
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ValidationErrorDetailItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loc")]
        public global::System.Collections.Generic.IList<global::Tavily.OneOf<string, int?>>? Loc { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string? Msg { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ctx")]
        public object? Ctx { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationErrorDetailItem" /> class.
        /// </summary>
        /// <param name="loc"></param>
        /// <param name="msg"></param>
        /// <param name="type"></param>
        /// <param name="input"></param>
        /// <param name="ctx"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidationErrorDetailItem(
            global::System.Collections.Generic.IList<global::Tavily.OneOf<string, int?>>? loc,
            string? msg,
            string? type,
            object? input,
            object? ctx)
        {
            this.Loc = loc;
            this.Msg = msg;
            this.Type = type;
            this.Input = input;
            this.Ctx = ctx;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationErrorDetailItem" /> class.
        /// </summary>
        public ValidationErrorDetailItem()
        {
        }

    }
}