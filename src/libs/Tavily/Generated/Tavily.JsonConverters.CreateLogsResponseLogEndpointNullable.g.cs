#nullable enable

namespace Tavily.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateLogsResponseLogEndpointNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Tavily.CreateLogsResponseLogEndpoint?>
    {
        /// <inheritdoc />
        public override global::Tavily.CreateLogsResponseLogEndpoint? Read(
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
                        return global::Tavily.CreateLogsResponseLogEndpointExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Tavily.CreateLogsResponseLogEndpoint)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Tavily.CreateLogsResponseLogEndpoint?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Tavily.CreateLogsResponseLogEndpoint? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Tavily.CreateLogsResponseLogEndpointExtensions.ToValueString(value.Value));
            }
        }
    }
}
