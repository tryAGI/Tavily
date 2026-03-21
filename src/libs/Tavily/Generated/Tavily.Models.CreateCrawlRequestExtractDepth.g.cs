
#nullable enable

namespace Tavily
{
    /// <summary>
    /// Advanced extraction retrieves more data, including tables and embedded content, with higher success but may increase latency. `basic` extraction costs 1 credit per 5 successful extractions, while `advanced` extraction costs 2 credits per 5 successful extractions.<br/>
    /// Default Value: basic
    /// </summary>
    public enum CreateCrawlRequestExtractDepth
    {
        /// <summary>
        /// 
        /// </summary>
        Basic,
        /// <summary>
        /// 
        /// </summary>
        Advanced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCrawlRequestExtractDepthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCrawlRequestExtractDepth value)
        {
            return value switch
            {
                CreateCrawlRequestExtractDepth.Basic => "basic",
                CreateCrawlRequestExtractDepth.Advanced => "advanced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCrawlRequestExtractDepth? ToEnum(string value)
        {
            return value switch
            {
                "basic" => CreateCrawlRequestExtractDepth.Basic,
                "advanced" => CreateCrawlRequestExtractDepth.Advanced,
                _ => null,
            };
        }
    }
}