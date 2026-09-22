
#nullable enable

namespace Tavily
{
    /// <summary>
    /// The format of the extracted web page content. `markdown` returns content in markdown format. `text` returns plain text and may increase latency.<br/>
    /// Default Value: markdown
    /// </summary>
    public enum CrawlRequestFormat
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
    public static class CrawlRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CrawlRequestFormat value)
        {
            return value switch
            {
                CrawlRequestFormat.Markdown => "markdown",
                CrawlRequestFormat.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CrawlRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "markdown" => CrawlRequestFormat.Markdown,
                "text" => CrawlRequestFormat.Text,
                _ => null,
            };
        }
    }
}