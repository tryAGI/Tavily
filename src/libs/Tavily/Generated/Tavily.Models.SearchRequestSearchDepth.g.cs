
#nullable enable

namespace Tavily
{
    /// <summary>
    /// Controls the latency vs. relevance tradeoff and how `results[].content` is generated:<br/>
    /// - `advanced`: Highest relevance with increased latency. Best for detailed, high-precision queries. Returns multiple semantically relevant snippets per URL (configurable via `chunks_per_source`).<br/>
    /// - `basic`: A balanced option for relevance and latency. Ideal for general-purpose searches. Returns multiple semantically relevant snippets per URL (configurable via `chunks_per_source`).<br/>
    /// - `fast`: Prioritizes lower latency while maintaining good relevance. Returns multiple semantically relevant snippets per URL (configurable via `chunks_per_source`).<br/>
    /// - `ultra-fast`: Minimizes latency above all else. Best for time-critical use cases. Returns one NLP summary per URL.<br/>
    /// **Cost**:<br/>
    /// - `basic`, `fast`, `ultra-fast`: 1 API Credit<br/>
    /// - `advanced`: 2 API Credits<br/>
    /// See [Search Best Practices](/documentation/best-practices/best-practices-search#search-depth) for guidance on choosing the right search depth.<br/>
    /// Default Value: basic
    /// </summary>
    public enum SearchRequestSearchDepth
    {
        /// <summary>
        /// Highest relevance with increased latency. Best for detailed, high-precision queries. Returns multiple semantically relevant snippets per URL (configurable via `chunks_per_source`).
        /// </summary>
        Advanced,
        /// <summary>
        /// A balanced option for relevance and latency. Ideal for general-purpose searches. Returns multiple semantically relevant snippets per URL (configurable via `chunks_per_source`).
        /// </summary>
        Basic,
        /// <summary>
        /// Prioritizes lower latency while maintaining good relevance. Returns multiple semantically relevant snippets per URL (configurable via `chunks_per_source`).
        /// </summary>
        Fast,
        /// <summary>
        /// Minimizes latency above all else. Best for time-critical use cases. Returns one NLP summary per URL.
        /// </summary>
        UltraFast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRequestSearchDepthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestSearchDepth value)
        {
            return value switch
            {
                SearchRequestSearchDepth.Advanced => "advanced",
                SearchRequestSearchDepth.Basic => "basic",
                SearchRequestSearchDepth.Fast => "fast",
                SearchRequestSearchDepth.UltraFast => "ultra-fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestSearchDepth? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => SearchRequestSearchDepth.Advanced,
                "basic" => SearchRequestSearchDepth.Basic,
                "fast" => SearchRequestSearchDepth.Fast,
                "ultra-fast" => SearchRequestSearchDepth.UltraFast,
                _ => null,
            };
        }
    }
}