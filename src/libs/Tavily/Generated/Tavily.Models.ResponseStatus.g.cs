
#nullable enable

namespace Tavily
{
    /// <summary>
    /// Current status of the research task.
    /// </summary>
    public enum ResponseStatus
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
    public static class ResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseStatus value)
        {
            return value switch
            {
                ResponseStatus.Pending => "pending",
                ResponseStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => ResponseStatus.Pending,
                "in_progress" => ResponseStatus.InProgress,
                _ => null,
            };
        }
    }
}