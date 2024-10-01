
#nullable enable

namespace Tavily
{
    /// <summary>
    /// The depth of the search. It can be 'basic' or advanced. Default is 'basic'.<br/>
    /// Default Value: basic
    /// </summary>
    public enum SearchRequestSearchDepth
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
    public static class SearchRequestSearchDepthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestSearchDepth value)
        {
            return value switch
            {
                SearchRequestSearchDepth.Basic => "basic",
                SearchRequestSearchDepth.Advanced => "advanced",
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
                "basic" => SearchRequestSearchDepth.Basic,
                "advanced" => SearchRequestSearchDepth.Advanced,
                _ => null,
            };
        }
    }
}