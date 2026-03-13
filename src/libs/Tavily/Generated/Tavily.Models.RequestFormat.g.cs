
#nullable enable

namespace Tavily
{
    /// <summary>
    /// The format of the extracted web page content. `markdown` returns content in markdown format. `text` returns plain text and may increase latency.<br/>
    /// Default Value: markdown
    /// </summary>
    public enum RequestFormat
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
    public static class RequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestFormat value)
        {
            return value switch
            {
                RequestFormat.Markdown => "markdown",
                RequestFormat.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "markdown" => RequestFormat.Markdown,
                "text" => RequestFormat.Text,
                _ => null,
            };
        }
    }
}