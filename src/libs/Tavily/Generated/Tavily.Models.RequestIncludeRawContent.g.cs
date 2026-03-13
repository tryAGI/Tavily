
#nullable enable

namespace Tavily
{
    /// <summary>
    /// 
    /// </summary>
    public enum RequestIncludeRawContent
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
    public static class RequestIncludeRawContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestIncludeRawContent value)
        {
            return value switch
            {
                RequestIncludeRawContent.Markdown => "markdown",
                RequestIncludeRawContent.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestIncludeRawContent? ToEnum(string value)
        {
            return value switch
            {
                "markdown" => RequestIncludeRawContent.Markdown,
                "text" => RequestIncludeRawContent.Text,
                _ => null,
            };
        }
    }
}