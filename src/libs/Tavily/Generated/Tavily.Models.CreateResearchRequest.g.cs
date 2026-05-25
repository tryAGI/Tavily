
#nullable enable

namespace Tavily
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateResearchRequest
    {
        /// <summary>
        /// The research task or question to investigate.<br/>
        /// Example: What are the latest developments in AI?
        /// </summary>
        /// <example>What are the latest developments in AI?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Input { get; set; }

        /// <summary>
        /// The model used by the research agent. "mini" is optimized for targeted, efficient research and works best for narrow or well-scoped questions. "pro" provides comprehensive, multi-angle research and is suited for complex topics that span multiple subtopics or domains<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavily.JsonConverters.CreateResearchRequestModelJsonConverter))]
        public global::Tavily.CreateResearchRequestModel? Model { get; set; }

        /// <summary>
        /// Whether to stream the research results as they are generated. When 'true', returns a Server-Sent Events (SSE) stream. See [Streaming documentation](/documentation/api-reference/endpoint/research-streaming) for details.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// A JSON Schema object that defines the structure of the research output. When provided, the research response will be structured to match this schema, ensuring a predictable and validated output shape. Must include a 'properties' field, and may optionally include 'required' field.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: {"properties":{"company":{"type":"string","description":"The name of the company"},"key_metrics":{"type":"array","description":"List of key performance metrics","items":{"type":"string"}},"financial_details":{"type":"object","description":"Detailed financial breakdown","properties":{"operating_income":{"type":"number","description":"Operating income for the period"}}}},"required":["company"]}
        /// </summary>
        /// <example>{"properties":{"company":{"type":"string","description":"The name of the company"},"key_metrics":{"type":"array","description":"List of key performance metrics","items":{"type":"string"}},"financial_details":{"type":"object","description":"Detailed financial breakdown","properties":{"operating_income":{"type":"number","description":"Operating income for the period"}}}},"required":["company"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_schema")]
        public global::Tavily.CreateResearchRequestOutputSchema? OutputSchema { get; set; }

        /// <summary>
        /// The format for citations in the research report.<br/>
        /// Default Value: numbered
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citation_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavily.JsonConverters.CreateResearchRequestCitationFormatJsonConverter))]
        public global::Tavily.CreateResearchRequestCitationFormat? CitationFormat { get; set; }

        /// <summary>
        /// Soft preference for sources. The research agent prioritizes these domains, but URLs from other domains can still appear in the final report. Matching is host-based and includes subdomains (e.g., `sec.gov` matches `sec.gov` and `data.sec.gov`). Maximum 20 entries.<br/>
        /// Default Value: []<br/>
        /// Example: [sec.gov, ec.europa.eu]
        /// </summary>
        /// <example>[sec.gov, ec.europa.eu]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_domains")]
        public global::System.Collections.Generic.IList<string>? IncludeDomains { get; set; }

        /// <summary>
        /// Hard blocklist. No URL from a listed domain or any of its subdomains appears in the response. Subdomain matching is downward only — blocking `medium.com` also blocks `blog.medium.com`, but blocking `blog.medium.com` leaves `medium.com` itself allowed. Maximum 20 entries.<br/>
        /// Default Value: []<br/>
        /// Example: [reddit.com, quora.com]
        /// </summary>
        /// <example>[reddit.com, quora.com]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude_domains")]
        public global::System.Collections.Generic.IList<string>? ExcludeDomains { get; set; }

        /// <summary>
        /// Typed control over response size. Ranges are targets, not hard caps — individual responses can fall outside when the question requires it.<br/>
        /// Default Value: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_length")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavily.JsonConverters.CreateResearchRequestOutputLengthJsonConverter))]
        public global::Tavily.CreateResearchRequestOutputLength? OutputLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResearchRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// The research task or question to investigate.<br/>
        /// Example: What are the latest developments in AI?
        /// </param>
        /// <param name="model">
        /// The model used by the research agent. "mini" is optimized for targeted, efficient research and works best for narrow or well-scoped questions. "pro" provides comprehensive, multi-angle research and is suited for complex topics that span multiple subtopics or domains<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="stream">
        /// Whether to stream the research results as they are generated. When 'true', returns a Server-Sent Events (SSE) stream. See [Streaming documentation](/documentation/api-reference/endpoint/research-streaming) for details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="outputSchema">
        /// A JSON Schema object that defines the structure of the research output. When provided, the research response will be structured to match this schema, ensuring a predictable and validated output shape. Must include a 'properties' field, and may optionally include 'required' field.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: {"properties":{"company":{"type":"string","description":"The name of the company"},"key_metrics":{"type":"array","description":"List of key performance metrics","items":{"type":"string"}},"financial_details":{"type":"object","description":"Detailed financial breakdown","properties":{"operating_income":{"type":"number","description":"Operating income for the period"}}}},"required":["company"]}
        /// </param>
        /// <param name="citationFormat">
        /// The format for citations in the research report.<br/>
        /// Default Value: numbered
        /// </param>
        /// <param name="includeDomains">
        /// Soft preference for sources. The research agent prioritizes these domains, but URLs from other domains can still appear in the final report. Matching is host-based and includes subdomains (e.g., `sec.gov` matches `sec.gov` and `data.sec.gov`). Maximum 20 entries.<br/>
        /// Default Value: []<br/>
        /// Example: [sec.gov, ec.europa.eu]
        /// </param>
        /// <param name="excludeDomains">
        /// Hard blocklist. No URL from a listed domain or any of its subdomains appears in the response. Subdomain matching is downward only — blocking `medium.com` also blocks `blog.medium.com`, but blocking `blog.medium.com` leaves `medium.com` itself allowed. Maximum 20 entries.<br/>
        /// Default Value: []<br/>
        /// Example: [reddit.com, quora.com]
        /// </param>
        /// <param name="outputLength">
        /// Typed control over response size. Ranges are targets, not hard caps — individual responses can fall outside when the question requires it.<br/>
        /// Default Value: standard
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateResearchRequest(
            string input,
            global::Tavily.CreateResearchRequestModel? model,
            bool? stream,
            global::Tavily.CreateResearchRequestOutputSchema? outputSchema,
            global::Tavily.CreateResearchRequestCitationFormat? citationFormat,
            global::System.Collections.Generic.IList<string>? includeDomains,
            global::System.Collections.Generic.IList<string>? excludeDomains,
            global::Tavily.CreateResearchRequestOutputLength? outputLength)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Model = model;
            this.Stream = stream;
            this.OutputSchema = outputSchema;
            this.CitationFormat = citationFormat;
            this.IncludeDomains = includeDomains;
            this.ExcludeDomains = excludeDomains;
            this.OutputLength = outputLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResearchRequest" /> class.
        /// </summary>
        public CreateResearchRequest()
        {
        }

    }
}