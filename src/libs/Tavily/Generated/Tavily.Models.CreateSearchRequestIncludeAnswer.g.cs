
#nullable enable

namespace Tavily
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateSearchRequestIncludeAnswer
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
    public static class CreateSearchRequestIncludeAnswerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSearchRequestIncludeAnswer value)
        {
            return value switch
            {
                CreateSearchRequestIncludeAnswer.Basic => "basic",
                CreateSearchRequestIncludeAnswer.Advanced => "advanced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSearchRequestIncludeAnswer? ToEnum(string value)
        {
            return value switch
            {
                "basic" => CreateSearchRequestIncludeAnswer.Basic,
                "advanced" => CreateSearchRequestIncludeAnswer.Advanced,
                _ => null,
            };
        }
    }
}