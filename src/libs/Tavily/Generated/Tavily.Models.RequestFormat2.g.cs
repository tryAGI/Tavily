
#nullable enable

namespace Tavily
{
    /// <summary>
    /// The format of the extracted web page content. `markdown` returns content in markdown format. `text` returns plain text and may increase latency.<br/>
    /// Default Value: markdown
    /// </summary>
    public enum RequestFormat2
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
    public static class RequestFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestFormat2 value)
        {
            return value switch
            {
                RequestFormat2.Markdown => "markdown",
                RequestFormat2.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestFormat2? ToEnum(string value)
        {
            return value switch
            {
                "markdown" => RequestFormat2.Markdown,
                "text" => RequestFormat2.Text,
                _ => null,
            };
        }
    }
}