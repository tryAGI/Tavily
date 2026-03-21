
#nullable enable

namespace Tavily
{
    /// <summary>
    /// The time range back from the current date to filter results based on publish date or last updated date. Useful when looking for sources that have published or updated data.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public enum CreateSearchRequestTimeRange
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
    public static class CreateSearchRequestTimeRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSearchRequestTimeRange value)
        {
            return value switch
            {
                CreateSearchRequestTimeRange.Day => "day",
                CreateSearchRequestTimeRange.Week => "week",
                CreateSearchRequestTimeRange.Month => "month",
                CreateSearchRequestTimeRange.Year => "year",
                CreateSearchRequestTimeRange.D => "d",
                CreateSearchRequestTimeRange.W => "w",
                CreateSearchRequestTimeRange.M => "m",
                CreateSearchRequestTimeRange.Y => "y",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSearchRequestTimeRange? ToEnum(string value)
        {
            return value switch
            {
                "day" => CreateSearchRequestTimeRange.Day,
                "week" => CreateSearchRequestTimeRange.Week,
                "month" => CreateSearchRequestTimeRange.Month,
                "year" => CreateSearchRequestTimeRange.Year,
                "d" => CreateSearchRequestTimeRange.D,
                "w" => CreateSearchRequestTimeRange.W,
                "m" => CreateSearchRequestTimeRange.M,
                "y" => CreateSearchRequestTimeRange.Y,
                _ => null,
            };
        }
    }
}