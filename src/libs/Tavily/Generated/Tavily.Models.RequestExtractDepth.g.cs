
#nullable enable

namespace Tavily
{
    /// <summary>
    /// The depth of the extraction process. `advanced` extraction retrieves more data, including tables and embedded content, with higher success but may increase latency.`basic` extraction costs 1 credit per 5 successful URL extractions, while `advanced` extraction costs 2 credits per 5 successful URL extractions.<br/>
    /// Default Value: basic
    /// </summary>
    public enum RequestExtractDepth
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
    public static class RequestExtractDepthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestExtractDepth value)
        {
            return value switch
            {
                RequestExtractDepth.Basic => "basic",
                RequestExtractDepth.Advanced => "advanced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestExtractDepth? ToEnum(string value)
        {
            return value switch
            {
                "basic" => RequestExtractDepth.Basic,
                "advanced" => RequestExtractDepth.Advanced,
                _ => null,
            };
        }
    }
}