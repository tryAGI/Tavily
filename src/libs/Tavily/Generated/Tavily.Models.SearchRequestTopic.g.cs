
#nullable enable

namespace Tavily
{
    /// <summary>
    /// The category of the search.`news` is useful for retrieving real-time updates, particularly about politics, sports, and major current events covered by mainstream media sources. `general` is for broader, more general-purpose searches that may include a wide range of sources.<br/>
    /// Default Value: general
    /// </summary>
    public enum SearchRequestTopic
    {
        /// <summary>
        ///
        /// </summary>
        Finance,
        /// <summary>
        ///
        /// </summary>
        General,
        /// <summary>
        ///
        /// </summary>
        News,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRequestTopicExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestTopic value)
        {
            return value switch
            {
                SearchRequestTopic.Finance => "finance",
                SearchRequestTopic.General => "general",
                SearchRequestTopic.News => "news",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestTopic? ToEnum(string value)
        {
            return value switch
            {
                "finance" => SearchRequestTopic.Finance,
                "general" => SearchRequestTopic.General,
                "news" => SearchRequestTopic.News,
                _ => null,
            };
        }
    }
}