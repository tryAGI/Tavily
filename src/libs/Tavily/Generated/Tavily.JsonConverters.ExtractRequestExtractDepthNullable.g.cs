#nullable enable

namespace Tavily.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExtractRequestExtractDepthNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Tavily.ExtractRequestExtractDepth?>
    {
        /// <inheritdoc />
        public override global::Tavily.ExtractRequestExtractDepth? Read(
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
                        return global::Tavily.ExtractRequestExtractDepthExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Tavily.ExtractRequestExtractDepth)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Tavily.ExtractRequestExtractDepth?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Tavily.ExtractRequestExtractDepth? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Tavily.ExtractRequestExtractDepthExtensions.ToValueString(value.Value));
            }
        }
    }
}
