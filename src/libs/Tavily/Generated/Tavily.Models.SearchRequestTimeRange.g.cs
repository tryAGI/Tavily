
#nullable enable

namespace Tavily
{
    /// <summary>
    /// The time range back from the current date to filter results based on publish date or last updated date. Useful when looking for sources that have published or updated data. By default, results with no detectable published date are not removed; set `filter_by_published_date` to `true` to remove them.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public enum SearchRequestTimeRange
    {
        /// <summary>
        ///
        /// </summary>
        D,
        /// <summary>
        ///
        /// </summary>
        Day,
        /// <summary>
        ///
        /// </summary>
        M,
        /// <summary>
        ///
        /// </summary>
        Month,
        /// <summary>
        ///
        /// </summary>
        W,
        /// <summary>
        ///
        /// </summary>
        Week,
        /// <summary>
        ///
        /// </summary>
        Y,
        /// <summary>
        ///
        /// </summary>
        Year,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRequestTimeRangeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestTimeRange value)
        {
            return value switch
            {
                SearchRequestTimeRange.D => "d",
                SearchRequestTimeRange.Day => "day",
                SearchRequestTimeRange.M => "m",
                SearchRequestTimeRange.Month => "month",
                SearchRequestTimeRange.W => "w",
                SearchRequestTimeRange.Week => "week",
                SearchRequestTimeRange.Y => "y",
                SearchRequestTimeRange.Year => "year",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestTimeRange? ToEnum(string value)
        {
            return value switch
            {
                "d" => SearchRequestTimeRange.D,
                "day" => SearchRequestTimeRange.Day,
                "m" => SearchRequestTimeRange.M,
                "month" => SearchRequestTimeRange.Month,
                "w" => SearchRequestTimeRange.W,
                "week" => SearchRequestTimeRange.Week,
                "y" => SearchRequestTimeRange.Y,
                "year" => SearchRequestTimeRange.Year,
                _ => null,
            };
        }
    }
}