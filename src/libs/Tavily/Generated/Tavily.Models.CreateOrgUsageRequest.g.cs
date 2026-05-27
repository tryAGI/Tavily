
#nullable enable

namespace Tavily
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrgUsageRequest
    {
        /// <summary>
        /// Exact organization name (case-sensitive). You must be the owner of this organization.<br/>
        /// Example: Acme Inc
        /// </summary>
        /// <example>Acme Inc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationName { get; set; }

        /// <summary>
        /// Inclusive start of the usage window (YYYY-MM-DD). Defaults to the start of the current billing cycle.<br/>
        /// Example: 2026-05-01
        /// </summary>
        /// <example>2026-05-01</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_date")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Inclusive end of the usage window (YYYY-MM-DD). Defaults to today.<br/>
        /// Example: 2026-05-27
        /// </summary>
        /// <example>2026-05-27</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public global::System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Scope usage to a single project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Scope usage to a single request depth.<br/>
        /// Example: advanced
        /// </summary>
        /// <example>advanced</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("depth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Tavily.JsonConverters.CreateOrgUsageRequestDepthJsonConverter))]
        public global::Tavily.CreateOrgUsageRequestDepth? Depth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrgUsageRequest" /> class.
        /// </summary>
        /// <param name="organizationName">
        /// Exact organization name (case-sensitive). You must be the owner of this organization.<br/>
        /// Example: Acme Inc
        /// </param>
        /// <param name="startDate">
        /// Inclusive start of the usage window (YYYY-MM-DD). Defaults to the start of the current billing cycle.<br/>
        /// Example: 2026-05-01
        /// </param>
        /// <param name="endDate">
        /// Inclusive end of the usage window (YYYY-MM-DD). Defaults to today.<br/>
        /// Example: 2026-05-27
        /// </param>
        /// <param name="projectId">
        /// Scope usage to a single project.
        /// </param>
        /// <param name="depth">
        /// Scope usage to a single request depth.<br/>
        /// Example: advanced
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrgUsageRequest(
            string organizationName,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            string? projectId,
            global::Tavily.CreateOrgUsageRequestDepth? depth)
        {
            this.OrganizationName = organizationName ?? throw new global::System.ArgumentNullException(nameof(organizationName));
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ProjectId = projectId;
            this.Depth = depth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrgUsageRequest" /> class.
        /// </summary>
        public CreateOrgUsageRequest()
        {
        }

    }
}