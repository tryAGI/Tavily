
#nullable enable

namespace Tavily
{
    /// <summary>
    ///
    /// </summary>
    public enum SearchRequestIncludeRawContent
    {
        /// <summary>
        ///
        /// </summary>
        Markdown,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchRequestIncludeRawContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchRequestIncludeRawContent value)
        {
            return value switch
            {
                SearchRequestIncludeRawContent.Markdown => "markdown",
                SearchRequestIncludeRawContent.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchRequestIncludeRawContent? ToEnum(string value)
        {
            return value switch
            {
                "markdown" => SearchRequestIncludeRawContent.Markdown,
                "text" => SearchRequestIncludeRawContent.Text,
                _ => null,
            };
        }
    }
}