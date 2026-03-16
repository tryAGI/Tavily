#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Tavily.JsonConverters
{
    /// <inheritdoc />
    public class Response39JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Tavily.Response39>
    {
        /// <inheritdoc />
        public override global::Tavily.Response39 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Tavily.ResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Tavily.ResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Tavily.ResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Tavily.ResearchTaskCompleted? completed = default;
            if (discriminator?.Status == global::Tavily.ResponseDiscriminatorStatus.Completed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Tavily.ResearchTaskCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Tavily.ResearchTaskCompleted> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Tavily.ResearchTaskCompleted)}");
                completed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Tavily.ResearchTaskFailed? failed = default;
            if (discriminator?.Status == global::Tavily.ResponseDiscriminatorStatus.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Tavily.ResearchTaskFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Tavily.ResearchTaskFailed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Tavily.ResearchTaskFailed)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Tavily.Response39(
                discriminator?.Status,
                completed,

                failed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Tavily.Response39 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Tavily.ResearchTaskCompleted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Tavily.ResearchTaskCompleted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Tavily.ResearchTaskCompleted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completed, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Tavily.ResearchTaskFailed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Tavily.ResearchTaskFailed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Tavily.ResearchTaskFailed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed, typeInfo);
            }
        }
    }
}