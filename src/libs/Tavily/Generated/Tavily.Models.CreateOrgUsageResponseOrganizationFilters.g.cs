
#nullable enable

namespace Tavily
{
    /// <summary>
    /// Echo of the filters applied to this response
    /// </summary>
    public sealed partial class CreateOrgUsageResponseOrganizationFilters
    {
        /// <summary>
        /// Example: 2026-05-01
        /// </summary>
        /// <example>2026-05-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public string? StartDate { get; set; }

        /// <summary>
        /// Example: 2026-05-27
        /// </summary>
        /// <example>2026-05-27</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public string? EndDate { get; set; }

        /// <summary>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("depth")]
        public string? Depth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrgUsageResponseOrganizationFilters" /> class.
        /// </summary>
        /// <param name="startDate">
        /// Example: 2026-05-01
        /// </param>
        /// <param name="endDate">
        /// Example: 2026-05-27
        /// </param>
        /// <param name="projectId">
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="depth">
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrgUsageResponseOrganizationFilters(
            string? startDate,
            string? endDate,
            string? projectId,
            string? depth)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ProjectId = projectId;
            this.Depth = depth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrgUsageResponseOrganizationFilters" /> class.
        /// </summary>
        public CreateOrgUsageResponseOrganizationFilters()
        {
        }

    }
}