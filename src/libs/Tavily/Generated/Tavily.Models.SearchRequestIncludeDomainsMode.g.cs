
#nullable enable

namespace Tavily
{
    /// <summary>
    /// Controls how `include_domains` is applied. `restrict` limits results to only the listed domains. `prefer` also searches the rest of the web, so results outside `include_domains` can still surface, rather than excluding them. Requires `include_domains` to be set; returns a 400 error otherwise.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public enum SearchRequestIncludeDomainsMode
    {
        /// <summary>
        ///
        /// </summary>
        Prefer,
        /// <summary>
        ///
        /// </summary>
        Restrict,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRequestIncludeDomainsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestIncludeDomainsMode value)
        {
            return value switch
            {
                SearchRequestIncludeDomainsMode.Prefer => "prefer",
                SearchRequestIncludeDomainsMode.Restrict => "restrict",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestIncludeDomainsMode? ToEnum(string value)
        {
            return value switch
            {
                "prefer" => SearchRequestIncludeDomainsMode.Prefer,
                "restrict" => SearchRequestIncludeDomainsMode.Restrict,
                _ => null,
            };
        }
    }
}