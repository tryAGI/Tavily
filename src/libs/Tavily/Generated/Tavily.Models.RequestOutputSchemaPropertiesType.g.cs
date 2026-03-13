
#nullable enable

namespace Tavily
{
    /// <summary>
    /// The type of the property. Must be one of: object, string, integer, number, or array.
    /// </summary>
    public enum RequestOutputSchemaPropertiesType
    {
        /// <summary>
        /// object, string, integer, number, or array.
        /// </summary>
        Object,
        /// <summary>
        /// object, string, integer, number, or array.
        /// </summary>
        String,
        /// <summary>
        /// object, string, integer, number, or array.
        /// </summary>
        Integer,
        /// <summary>
        /// object, string, integer, number, or array.
        /// </summary>
        Number,
        /// <summary>
        /// object, string, integer, number, or array.
        /// </summary>
        Array,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestOutputSchemaPropertiesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestOutputSchemaPropertiesType value)
        {
            return value switch
            {
                RequestOutputSchemaPropertiesType.Object => "object",
                RequestOutputSchemaPropertiesType.String => "string",
                RequestOutputSchemaPropertiesType.Integer => "integer",
                RequestOutputSchemaPropertiesType.Number => "number",
                RequestOutputSchemaPropertiesType.Array => "array",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestOutputSchemaPropertiesType? ToEnum(string value)
        {
            return value switch
            {
                "object" => RequestOutputSchemaPropertiesType.Object,
                "string" => RequestOutputSchemaPropertiesType.String,
                "integer" => RequestOutputSchemaPropertiesType.Integer,
                "number" => RequestOutputSchemaPropertiesType.Number,
                "array" => RequestOutputSchemaPropertiesType.Array,
                _ => null,
            };
        }
    }
}