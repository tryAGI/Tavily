
#nullable enable

namespace Tavily
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseDiscriminatorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseDiscriminatorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseDiscriminatorStatus value)
        {
            return value switch
            {
                ResponseDiscriminatorStatus.Completed => "completed",
                ResponseDiscriminatorStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseDiscriminatorStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ResponseDiscriminatorStatus.Completed,
                "failed" => ResponseDiscriminatorStatus.Failed,
                _ => null,
            };
        }
    }
}