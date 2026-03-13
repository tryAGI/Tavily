
#nullable enable

namespace Tavily
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestIncludeAnswer
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
    public static class RequestIncludeAnswerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestIncludeAnswer value)
        {
            return value switch
            {
                RequestIncludeAnswer.Basic => "basic",
                RequestIncludeAnswer.Advanced => "advanced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestIncludeAnswer? ToEnum(string value)
        {
            return value switch
            {
                "basic" => RequestIncludeAnswer.Basic,
                "advanced" => RequestIncludeAnswer.Advanced,
                _ => null,
            };
        }
    }
}