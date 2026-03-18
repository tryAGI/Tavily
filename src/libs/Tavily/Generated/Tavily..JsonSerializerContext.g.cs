
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResearchTaskCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResearchTaskCompletedStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.OneOf<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.ResearchTaskCompletedSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResearchTaskCompletedSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResearchTaskFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResearchTaskFailedStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Request))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.RequestSearchDepth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.RequestTopic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.RequestTimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.OneOf<bool?, global::Tavily.RequestIncludeAnswer?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.RequestIncludeAnswer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.OneOf<bool?, global::Tavily.RequestIncludeRawContent?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.RequestIncludeRawContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.RequestCountry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Request2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.OneOf<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.RequestExtractDepth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.RequestFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Request3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.RequestExtractDepth2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.RequestFormat2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Request4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Request5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.RequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.RequestOutputSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Tavily.RequestOutputSchemaProperties2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.RequestOutputSchemaProperties2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.RequestOutputSchemaPropertiesType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.RequestCitationFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.ResponseImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.ResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.ResponseResult2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseResult2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.ResponseFailedResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseFailedResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail9))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail10))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail11))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail12))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.ResponseResult3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseResult3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail13))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail14))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail15))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail16))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response20))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail17))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response21))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail18))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail19))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response23))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response24))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail20))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response25))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail21))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response26))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail22))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response27))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail23))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response28))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail24))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response29))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail25))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response30))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail26))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response31))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail27))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response33))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail28))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response34))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail29))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response35))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail30))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response36))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail31))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response37))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail32))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response38))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDiscriminatorStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response39))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response40))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail33))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response41))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail34))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response42))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail35))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response43))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response44))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail36))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.Response45))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResponseDetail37))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.ResearchTaskCompletedSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.ResponseImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.ResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.ResponseResult2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.ResponseFailedResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.ResponseResult3>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}