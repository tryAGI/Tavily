
#nullable enable

namespace Tavily
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchRequestIncludeAnswer
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
    public static class SearchRequestIncludeAnswerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestIncludeAnswer value)
        {
            return value switch
            {
                SearchRequestIncludeAnswer.Advanced => "advanced",
                SearchRequestIncludeAnswer.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestIncludeAnswer? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => SearchRequestIncludeAnswer.Advanced,
                "basic" => SearchRequestIncludeAnswer.Basic,
                _ => null,
            };
        }
    }
}