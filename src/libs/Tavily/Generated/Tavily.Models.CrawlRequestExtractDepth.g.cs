
#nullable enable

namespace Tavily
{
    /// <summary>
    /// Advanced extraction retrieves more data, including tables and embedded content, with higher success but may increase latency. `basic` extraction costs 1 credit per 5 successful extractions, while `advanced` extraction costs 2 credits per 5 successful extractions.<br/>
    /// Default Value: basic
    /// </summary>
    public enum CrawlRequestExtractDepth
    {
        /// <summary>
        ///
        /// </summary>
        Advanced,
        /// <summary>
        ///
        /// </summary>
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CrawlRequestExtractDepthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CrawlRequestExtractDepth value)
        {
            return value switch
            {
                CrawlRequestExtractDepth.Advanced => "advanced",
                CrawlRequestExtractDepth.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CrawlRequestExtractDepth? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => CrawlRequestExtractDepth.Advanced,
                "basic" => CrawlRequestExtractDepth.Basic,
                _ => null,
            };
        }
    }
}