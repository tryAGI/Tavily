
#nullable enable

namespace Tavily
{
    /// <summary>
    /// Controls how `include_domains` is applied. `restrict` limits results to only the listed domains. `prefer` also searches the rest of the web, so results outside `include_domains` can still surface, rather than excluding them. Defaults to `restrict`, so `include_domains` acts as a hard filter unless set to `prefer`. Setting it without `include_domains` returns a 400 error.<br/>
    /// Default Value: restrict
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