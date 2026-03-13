
#nullable enable

namespace Tavily
{
    /// <summary>
    /// The format for citations in the research report.<br/>
    /// Default Value: numbered
    /// </summary>
    public enum RequestCitationFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Numbered,
        /// <summary>
        /// 
        /// </summary>
        Mla,
        /// <summary>
        /// 
        /// </summary>
        Apa,
        /// <summary>
        /// 
        /// </summary>
        Chicago,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestCitationFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestCitationFormat value)
        {
            return value switch
            {
                RequestCitationFormat.Numbered => "numbered",
                RequestCitationFormat.Mla => "mla",
                RequestCitationFormat.Apa => "apa",
                RequestCitationFormat.Chicago => "chicago",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestCitationFormat? ToEnum(string value)
        {
            return value switch
            {
                "numbered" => RequestCitationFormat.Numbered,
                "mla" => RequestCitationFormat.Mla,
                "apa" => RequestCitationFormat.Apa,
                "chicago" => RequestCitationFormat.Chicago,
                _ => null,
            };
        }
    }
}