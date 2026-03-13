#nullable enable

namespace Tavily.JsonConverters
{
    /// <inheritdoc />
    public sealed class RequestCitationFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Tavily.RequestCitationFormat>
    {
        /// <inheritdoc />
        public override global::Tavily.RequestCitationFormat Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Tavily.RequestCitationFormatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Tavily.RequestCitationFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Tavily.RequestCitationFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Tavily.RequestCitationFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Tavily.RequestCitationFormatExtensions.ToValueString(value));
        }
    }
}
