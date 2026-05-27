
#nullable enable

namespace Tavily
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOrgUsageResponseOrganization
    {
        /// <summary>
        /// Example: Acme Inc
        /// </summary>
        /// <example>Acme Inc</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Echo of the filters applied to this response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::Tavily.CreateOrgUsageResponseOrganizationFilters? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrgUsageResponseOrganization" /> class.
        /// </summary>
        /// <param name="name">
        /// Example: Acme Inc
        /// </param>
        /// <param name="filters">
        /// Echo of the filters applied to this response
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrgUsageResponseOrganization(
            string? name,
            global::Tavily.CreateOrgUsageResponseOrganizationFilters? filters)
        {
            this.Name = name;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrgUsageResponseOrganization" /> class.
        /// </summary>
        public CreateOrgUsageResponseOrganization()
        {
        }

    }
}