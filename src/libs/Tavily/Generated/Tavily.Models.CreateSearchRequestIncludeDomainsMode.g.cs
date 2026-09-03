
#nullable enable

namespace Tavily
{
    /// <summary>
    /// Controls how `include_domains` is applied. `filter` restricts results to only the listed domains. `boost` also searches the rest of the web, so results outside `include_domains` can still surface, rather than excluding them. Requires `include_domains` to be set; returns a 400 error otherwise.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public enum CreateSearchRequestIncludeDomainsMode
    {
        /// <summary>
        ///
        /// </summary>
        Boost,
        /// <summary>
        ///
        /// </summary>
        Filter,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSearchRequestIncludeDomainsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSearchRequestIncludeDomainsMode value)
        {
            return value switch
            {
                CreateSearchRequestIncludeDomainsMode.Boost => "boost",
                CreateSearchRequestIncludeDomainsMode.Filter => "filter",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSearchRequestIncludeDomainsMode? ToEnum(string value)
        {
            return value switch
            {
                "boost" => CreateSearchRequestIncludeDomainsMode.Boost,
                "filter" => CreateSearchRequestIncludeDomainsMode.Filter,
                _ => null,
            };
        }
    }
}