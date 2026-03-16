
#nullable enable

namespace Tavily
{
    /// <summary>
    /// The time range back from the current date to filter results based on publish date or last updated date. Useful when looking for sources that have published or updated data.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public enum RequestTimeRange
    {
        /// <summary>
        /// 
        /// </summary>
        Day,
        /// <summary>
        /// 
        /// </summary>
        Week,
        /// <summary>
        /// 
        /// </summary>
        Month,
        /// <summary>
        /// 
        /// </summary>
        Year,
        /// <summary>
        /// 
        /// </summary>
        D,
        /// <summary>
        /// 
        /// </summary>
        W,
        /// <summary>
        /// 
        /// </summary>
        M,
        /// <summary>
        /// 
        /// </summary>
        Y,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestTimeRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestTimeRange value)
        {
            return value switch
            {
                RequestTimeRange.Day => "day",
                RequestTimeRange.Week => "week",
                RequestTimeRange.Month => "month",
                RequestTimeRange.Year => "year",
                RequestTimeRange.D => "d",
                RequestTimeRange.W => "w",
                RequestTimeRange.M => "m",
                RequestTimeRange.Y => "y",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestTimeRange? ToEnum(string value)
        {
            return value switch
            {
                "day" => RequestTimeRange.Day,
                "week" => RequestTimeRange.Week,
                "month" => RequestTimeRange.Month,
                "year" => RequestTimeRange.Year,
                "d" => RequestTimeRange.D,
                "w" => RequestTimeRange.W,
                "m" => RequestTimeRange.M,
                "y" => RequestTimeRange.Y,
                _ => null,
            };
        }
    }
}