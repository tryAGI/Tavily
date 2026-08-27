
#nullable enable

namespace Tavily
{
    /// <summary>
    /// Typed control over response size. Ranges are targets, not hard caps — individual responses can fall outside when the question requires it.<br/>
    /// Default Value: standard
    /// </summary>
    public enum CreateResearchRequestOutputLength
    {
        /// <summary>
        ///
        /// </summary>
        Long,
        /// <summary>
        ///
        /// </summary>
        Short,
        /// <summary>
        ///
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResearchRequestOutputLengthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResearchRequestOutputLength value)
        {
            return value switch
            {
                CreateResearchRequestOutputLength.Long => "long",
                CreateResearchRequestOutputLength.Short => "short",
                CreateResearchRequestOutputLength.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResearchRequestOutputLength? ToEnum(string value)
        {
            return value switch
            {
                "long" => CreateResearchRequestOutputLength.Long,
                "short" => CreateResearchRequestOutputLength.Short,
                "standard" => CreateResearchRequestOutputLength.Standard,
                _ => null,
            };
        }
    }
}