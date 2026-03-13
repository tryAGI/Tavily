#nullable enable

namespace Tavily.JsonConverters
{
    /// <inheritdoc />
    public sealed class ResponseDiscriminatorStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Tavily.ResponseDiscriminatorStatus?>
    {
        /// <inheritdoc />
        public override global::Tavily.ResponseDiscriminatorStatus? Read(
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
                        return global::Tavily.ResponseDiscriminatorStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Tavily.ResponseDiscriminatorStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Tavily.ResponseDiscriminatorStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Tavily.ResponseDiscriminatorStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Tavily.ResponseDiscriminatorStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
