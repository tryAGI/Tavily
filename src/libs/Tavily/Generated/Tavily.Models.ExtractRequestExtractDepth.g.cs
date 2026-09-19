
#nullable enable

namespace Tavily
{
    /// <summary>
    /// The depth of the extraction process. `advanced` extraction retrieves more data, including tables and embedded content, with higher success but may increase latency.`basic` extraction costs 1 credit per 5 successful URL extractions, while `advanced` extraction costs 2 credits per 5 successful URL extractions.<br/>
    /// Default Value: basic
    /// </summary>
    public enum ExtractRequestExtractDepth
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
    public static class ExtractRequestExtractDepthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExtractRequestExtractDepth value)
        {
            return value switch
            {
                ExtractRequestExtractDepth.Advanced => "advanced",
                ExtractRequestExtractDepth.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExtractRequestExtractDepth? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => ExtractRequestExtractDepth.Advanced,
                "basic" => ExtractRequestExtractDepth.Basic,
                _ => null,
            };
        }
    }
}