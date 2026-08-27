
#nullable enable

namespace Tavily
{
    /// <summary>
    /// The encoding of the `data` field.<br/>
    /// Default Value: base64
    /// </summary>
    public enum CreateResearchRequestFileType
    {
        /// <summary>
        ///
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResearchRequestFileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResearchRequestFileType value)
        {
            return value switch
            {
                CreateResearchRequestFileType.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResearchRequestFileType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => CreateResearchRequestFileType.Base64,
                _ => null,
            };
        }
    }
}