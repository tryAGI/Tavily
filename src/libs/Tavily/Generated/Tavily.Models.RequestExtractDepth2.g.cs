
#nullable enable

namespace Tavily
{
    /// <summary>
    /// Advanced extraction retrieves more data, including tables and embedded content, with higher success but may increase latency. `basic` extraction costs 1 credit per 5 successful extractions, while `advanced` extraction costs 2 credits per 5 successful extractions.<br/>
    /// Default Value: basic
    /// </summary>
    public enum RequestExtractDepth2
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
    public static class RequestExtractDepth2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestExtractDepth2 value)
        {
            return value switch
            {
                RequestExtractDepth2.Basic => "basic",
                RequestExtractDepth2.Advanced => "advanced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestExtractDepth2? ToEnum(string value)
        {
            return value switch
            {
                "basic" => RequestExtractDepth2.Basic,
                "advanced" => RequestExtractDepth2.Advanced,
                _ => null,
            };
        }
    }
}