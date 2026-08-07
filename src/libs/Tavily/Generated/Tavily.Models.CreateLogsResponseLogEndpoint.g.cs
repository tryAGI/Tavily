
#nullable enable

namespace Tavily
{
    /// <summary>
    /// Which Tavily API was called<br/>
    /// Example: search
    /// </summary>
    public enum CreateLogsResponseLogEndpoint
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
    public static class CreateLogsResponseLogEndpointExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateLogsResponseLogEndpoint value)
        {
            return value switch
            {
                CreateLogsResponseLogEndpoint.Crawl => "crawl",
                CreateLogsResponseLogEndpoint.Extract => "extract",
                CreateLogsResponseLogEndpoint.Map => "map",
                CreateLogsResponseLogEndpoint.Research => "research",
                CreateLogsResponseLogEndpoint.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateLogsResponseLogEndpoint? ToEnum(string value)
        {
            return value switch
            {
                "crawl" => CreateLogsResponseLogEndpoint.Crawl,
                "extract" => CreateLogsResponseLogEndpoint.Extract,
                "map" => CreateLogsResponseLogEndpoint.Map,
                "research" => CreateLogsResponseLogEndpoint.Research,
                "search" => CreateLogsResponseLogEndpoint.Search,
                _ => null,
            };
        }
    }
}