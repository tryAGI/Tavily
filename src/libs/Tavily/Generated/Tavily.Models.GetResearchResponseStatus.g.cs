
#nullable enable

namespace Tavily
{
    /// <summary>
    /// Current status of the research task.
    /// </summary>
    public enum GetResearchResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetResearchResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetResearchResponseStatus value)
        {
            return value switch
            {
                GetResearchResponseStatus.Pending => "pending",
                GetResearchResponseStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetResearchResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => GetResearchResponseStatus.Pending,
                "in_progress" => GetResearchResponseStatus.InProgress,
                _ => null,
            };
        }
    }
}