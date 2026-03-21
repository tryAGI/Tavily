#nullable enable

namespace Tavily.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateSearchRequestIncludeAnswerJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Tavily.CreateSearchRequestIncludeAnswer>
    {
        /// <inheritdoc />
        public override global::Tavily.CreateSearchRequestIncludeAnswer Read(
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
                        return global::Tavily.CreateSearchRequestIncludeAnswerExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Tavily.CreateSearchRequestIncludeAnswer)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Tavily.CreateSearchRequestIncludeAnswer);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Tavily.CreateSearchRequestIncludeAnswer value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Tavily.CreateSearchRequestIncludeAnswerExtensions.ToValueString(value));
        }
    }
}
