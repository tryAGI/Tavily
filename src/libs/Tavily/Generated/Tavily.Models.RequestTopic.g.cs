
#nullable enable

namespace Tavily
{
    /// <summary>
    /// The category of the search.`news` is useful for retrieving real-time updates, particularly about politics, sports, and major current events covered by mainstream media sources. `general` is for broader, more general-purpose searches that may include a wide range of sources.<br/>
    /// Default Value: general
    /// </summary>
    public enum RequestTopic
    {
        /// <summary>
        /// 
        /// </summary>
        General,
        /// <summary>
        /// 
        /// </summary>
        News,
        /// <summary>
        /// 
        /// </summary>
        Finance,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestTopicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestTopic value)
        {
            return value switch
            {
                RequestTopic.General => "general",
                RequestTopic.News => "news",
                RequestTopic.Finance => "finance",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestTopic? ToEnum(string value)
        {
            return value switch
            {
                "general" => RequestTopic.General,
                "news" => RequestTopic.News,
                "finance" => RequestTopic.Finance,
                _ => null,
            };
        }
    }
}