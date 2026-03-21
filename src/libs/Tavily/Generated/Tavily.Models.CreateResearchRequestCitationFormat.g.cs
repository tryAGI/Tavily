
#nullable enable

namespace Tavily
{
    /// <summary>
    /// The format for citations in the research report.<br/>
    /// Default Value: numbered
    /// </summary>
    public enum CreateResearchRequestCitationFormat
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
    public static class CreateResearchRequestCitationFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResearchRequestCitationFormat value)
        {
            return value switch
            {
                CreateResearchRequestCitationFormat.Numbered => "numbered",
                CreateResearchRequestCitationFormat.Mla => "mla",
                CreateResearchRequestCitationFormat.Apa => "apa",
                CreateResearchRequestCitationFormat.Chicago => "chicago",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResearchRequestCitationFormat? ToEnum(string value)
        {
            return value switch
            {
                "numbered" => CreateResearchRequestCitationFormat.Numbered,
                "mla" => CreateResearchRequestCitationFormat.Mla,
                "apa" => CreateResearchRequestCitationFormat.Apa,
                "chicago" => CreateResearchRequestCitationFormat.Chicago,
                _ => null,
            };
        }
    }
}