
#nullable enable

namespace Tavily
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateResearchRequestFile
    {
        /// <summary>
        /// The filename, including its extension (`.txt`, `.md`, or `.json`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The base64-encoded file contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// The encoding of the `data` field.<br/>
        /// Default Value: base64
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavily.JsonConverters.CreateResearchRequestFileTypeJsonConverter))]
        public global::Tavily.CreateResearchRequestFileType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResearchRequestFile" /> class.
        /// </summary>
        /// <param name="name">
        /// The filename, including its extension (`.txt`, `.md`, or `.json`).
        /// </param>
        /// <param name="data">
        /// The base64-encoded file contents.
        /// </param>
        /// <param name="type">
        /// The encoding of the `data` field.<br/>
        /// Default Value: base64
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResearchRequestFile(
            string name,
            string data,
            global::Tavily.CreateResearchRequestFileType? type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResearchRequestFile" /> class.
        /// </summary>
        public CreateResearchRequestFile()
        {
        }

    }
}