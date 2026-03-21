
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

            typeof(global::Tavily.JsonConverters.CreateSearchRequestSearchDepthJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateSearchRequestSearchDepthNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateSearchRequestTopicJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateSearchRequestTopicNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateSearchRequestTimeRangeJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateSearchRequestTimeRangeNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateSearchRequestIncludeAnswerJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateSearchRequestIncludeAnswerNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateSearchRequestIncludeRawContentJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateSearchRequestIncludeRawContentNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateSearchRequestCountryJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateSearchRequestCountryNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateExtractRequestExtractDepthJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateExtractRequestExtractDepthNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateExtractRequestFormatJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateExtractRequestFormatNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateCrawlRequestExtractDepthJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateCrawlRequestExtractDepthNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateCrawlRequestFormatJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateCrawlRequestFormatNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateResearchRequestModelJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateResearchRequestModelNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateResearchRequestOutputSchemaPropertiesTypeJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateResearchRequestOutputSchemaPropertiesTypeNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateResearchRequestCitationFormatJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateResearchRequestCitationFormatNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.GetResearchResponseDiscriminatorStatusJsonConverter),

            typeof(global::Tavily.JsonConverters.GetResearchResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.GetResearchResponseStatusJsonConverter),

            typeof(global::Tavily.JsonConverters.GetResearchResponseStatusNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.GetResearchResponseJsonConverter),

            typeof(global::Tavily.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Tavily.JsonConverters.OneOfJsonConverter<bool?, global::Tavily.CreateSearchRequestIncludeAnswer?>),

            typeof(global::Tavily.JsonConverters.OneOfJsonConverter<bool?, global::Tavily.CreateSearchRequestIncludeRawContent?>),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchRequestSearchDepth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchRequestTopic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchRequestTimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.OneOf<bool?, global::Tavily.CreateSearchRequestIncludeAnswer?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchRequestIncludeAnswer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.OneOf<bool?, global::Tavily.CreateSearchRequestIncludeRawContent?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchRequestIncludeRawContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchRequestCountry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateExtractRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.OneOf<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateExtractRequestExtractDepth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateExtractRequestFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateCrawlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateCrawlRequestExtractDepth))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateCrawlRequestFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateMapRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchRequestOutputSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Tavily.CreateResearchRequestOutputSchemaProperties2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchRequestOutputSchemaProperties2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchRequestOutputSchemaPropertiesType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchRequestCitationFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.CreateSearchResponseImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchResponseImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.CreateSearchResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchResponseDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchResponseDetail2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchResponseDetail3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchResponseDetail4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchResponseDetail5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateSearchResponseDetail6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateExtractResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.CreateExtractResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateExtractResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.CreateExtractResponseFailedResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateExtractResponseFailedResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateExtractResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateExtractResponseDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateExtractResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateExtractResponseDetail2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateExtractResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateExtractResponseDetail3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateExtractResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateExtractResponseDetail4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateExtractResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateExtractResponseDetail5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateExtractResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateExtractResponseDetail6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateCrawlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.CreateCrawlResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateCrawlResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateCrawlResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateCrawlResponseDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateCrawlResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateCrawlResponseDetail2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateCrawlResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateCrawlResponseDetail3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateCrawlResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateCrawlResponseDetail4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateCrawlResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateCrawlResponseDetail5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateCrawlResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateCrawlResponseDetail6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateCrawlResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateCrawlResponseDetail7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateMapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateMapResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateMapResponseDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateMapResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateMapResponseDetail2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateMapResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateMapResponseDetail3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateMapResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateMapResponseDetail4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateMapResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateMapResponseDetail5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateMapResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateMapResponseDetail6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateMapResponse8))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateMapResponseDetail7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchResponseDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchResponseDetail2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchResponseDetail3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchResponseDetail4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchResponseDetail5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchResponse7))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchResponseDetail6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetResearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetResearchResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetResearchResponseDiscriminatorStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetResearchResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetResearchResponseStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetResearchResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetResearchResponseDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetResearchResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetResearchResponseDetail2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetResearchResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetResearchResponseDetail3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetUsageResponseKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetUsageResponseAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetUsageResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetUsageResponseDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetUsageResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetUsageResponseDetail2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.ResearchTaskCompletedSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.CreateSearchResponseImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.CreateSearchResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.CreateExtractResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.CreateExtractResponseFailedResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.CreateCrawlResponseResult>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}