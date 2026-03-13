
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Tavily
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::Tavily.JsonConverters.ResearchTaskCompletedStatusJsonConverter),
            typeof(global::Tavily.JsonConverters.ResearchTaskCompletedStatusNullableJsonConverter),
            typeof(global::Tavily.JsonConverters.ResearchTaskFailedStatusJsonConverter),
            typeof(global::Tavily.JsonConverters.ResearchTaskFailedStatusNullableJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestSearchDepthJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestSearchDepthNullableJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestTopicJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestTopicNullableJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestTimeRangeJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestTimeRangeNullableJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestIncludeAnswerJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestIncludeAnswerNullableJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestIncludeRawContentJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestIncludeRawContentNullableJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestCountryJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestCountryNullableJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestExtractDepthJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestExtractDepthNullableJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestFormatJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestFormatNullableJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestExtractDepth2JsonConverter),
            typeof(global::Tavily.JsonConverters.RequestExtractDepth2NullableJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestFormat2JsonConverter),
            typeof(global::Tavily.JsonConverters.RequestFormat2NullableJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestModelJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestModelNullableJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestOutputSchemaPropertiesTypeJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestOutputSchemaPropertiesTypeNullableJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestCitationFormatJsonConverter),
            typeof(global::Tavily.JsonConverters.RequestCitationFormatNullableJsonConverter),
            typeof(global::Tavily.JsonConverters.ResponseDiscriminatorStatusJsonConverter),
            typeof(global::Tavily.JsonConverters.ResponseDiscriminatorStatusNullableJsonConverter),
            typeof(global::Tavily.JsonConverters.ResponseStatusJsonConverter),
            typeof(global::Tavily.JsonConverters.ResponseStatusNullableJsonConverter),
            typeof(global::Tavily.JsonConverters.Response38JsonConverter),
            typeof(global::Tavily.JsonConverters.OneOfJsonConverter<string, object>),
            typeof(global::Tavily.JsonConverters.OneOfJsonConverter<bool?, global::Tavily.RequestIncludeAnswer?>),
            typeof(global::Tavily.JsonConverters.OneOfJsonConverter<bool?, global::Tavily.RequestIncludeRawContent?>),
            typeof(global::Tavily.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),
            typeof(global::Tavily.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}