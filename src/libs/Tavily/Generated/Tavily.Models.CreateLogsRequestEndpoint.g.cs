
#nullable enable

namespace Tavily
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateLogsRequestEndpoint
    {
        /// <summary>
        /// 
        /// </summary>
        Crawl,
        /// <summary>
        /// 
        /// </summary>
        Extract,
        /// <summary>
        /// 
        /// </summary>
        Map,
        /// <summary>
        /// 
        /// </summary>
        Research,
        /// <summary>
        /// 
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateLogsRequestEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLogsRequestEndpoint value)
        {
            return value switch
            {
                CreateLogsRequestEndpoint.Crawl => "crawl",
                CreateLogsRequestEndpoint.Extract => "extract",
                CreateLogsRequestEndpoint.Map => "map",
                CreateLogsRequestEndpoint.Research => "research",
                CreateLogsRequestEndpoint.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLogsRequestEndpoint? ToEnum(string value)
        {
            return value switch
            {
                "crawl" => CreateLogsRequestEndpoint.Crawl,
                "extract" => CreateLogsRequestEndpoint.Extract,
                "map" => CreateLogsRequestEndpoint.Map,
                "research" => CreateLogsRequestEndpoint.Research,
                "search" => CreateLogsRequestEndpoint.Search,
                _ => null,
            };
        }
    }
}