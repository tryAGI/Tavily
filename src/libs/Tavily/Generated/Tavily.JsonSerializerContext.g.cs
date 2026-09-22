
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

            typeof(global::Tavily.JsonConverters.SearchRequestSearchDepthJsonConverter),

            typeof(global::Tavily.JsonConverters.SearchRequestSearchDepthNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.SearchRequestTopicJsonConverter),

            typeof(global::Tavily.JsonConverters.SearchRequestTopicNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.SearchRequestTimeRangeJsonConverter),

            typeof(global::Tavily.JsonConverters.SearchRequestTimeRangeNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.SearchRequestIncludeAnswerJsonConverter),

            typeof(global::Tavily.JsonConverters.SearchRequestIncludeAnswerNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.SearchRequestIncludeRawContentJsonConverter),

            typeof(global::Tavily.JsonConverters.SearchRequestIncludeRawContentNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.SearchRequestIncludeDomainsModeJsonConverter),

            typeof(global::Tavily.JsonConverters.SearchRequestIncludeDomainsModeNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.SearchRequestCountryJsonConverter),

            typeof(global::Tavily.JsonConverters.SearchRequestCountryNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.ExtractRequestExtractDepthJsonConverter),

            typeof(global::Tavily.JsonConverters.ExtractRequestExtractDepthNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.ExtractRequestFormatJsonConverter),

            typeof(global::Tavily.JsonConverters.ExtractRequestFormatNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CrawlRequestExtractDepthJsonConverter),

            typeof(global::Tavily.JsonConverters.CrawlRequestExtractDepthNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CrawlRequestFormatJsonConverter),

            typeof(global::Tavily.JsonConverters.CrawlRequestFormatNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateResearchRequestModelJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateResearchRequestModelNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateResearchRequestOutputSchemaPropertiesTypeJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateResearchRequestOutputSchemaPropertiesTypeNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateResearchRequestCitationFormatJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateResearchRequestCitationFormatNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateResearchRequestOutputLengthJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateResearchRequestOutputLengthNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateResearchRequestFileTypeJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateResearchRequestFileTypeNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateLogsRequestEndpointJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateLogsRequestEndpointNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateOrgUsageRequestDepthJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateOrgUsageRequestDepthNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.GetResearchResponseStatusJsonConverter),

            typeof(global::Tavily.JsonConverters.GetResearchResponseStatusNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.GetResearchResponseDiscriminatorStatusJsonConverter),

            typeof(global::Tavily.JsonConverters.GetResearchResponseDiscriminatorStatusNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateLogsResponseLogEndpointJsonConverter),

            typeof(global::Tavily.JsonConverters.CreateLogsResponseLogEndpointNullableJsonConverter),

            typeof(global::Tavily.JsonConverters.GetResearchResponse2JsonConverter),

            typeof(global::Tavily.JsonConverters.OneOfJsonConverter<string, object>),

            typeof(global::Tavily.JsonConverters.OneOfJsonConverter<string, int?>),

            typeof(global::Tavily.JsonConverters.OneOfJsonConverter<bool?, global::Tavily.SearchRequestIncludeAnswer?>),

            typeof(global::Tavily.JsonConverters.OneOfJsonConverter<bool?, global::Tavily.SearchRequestIncludeRawContent?>),

            typeof(global::Tavily.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Tavily.JsonConverters.OneOfJsonConverter<double?, string>),

            typeof(global::Tavily.JsonConverters.OneOfJsonConverter<double?, string>),

            typeof(global::Tavily.JsonConverters.OneOfJsonConverter<double?, string>),

            typeof(global::Tavily.JsonConverters.OneOfJsonConverter<double?, string>),

            typeof(global::Tavily.JsonConverters.OneOfJsonConverter<double?, string>),

            typeof(global::Tavily.JsonConverters.AllOfJsonConverter<global::Tavily.ApiError, global::Tavily.ExtractResponse3>),

            typeof(global::Tavily.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResearchTaskCompleted))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResearchTaskCompletedStatus), TypeInfoPropertyName = "ResearchTaskCompletedStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.OneOf<string, object>), TypeInfoPropertyName = "OneOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.ResearchTaskCompletedSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResearchTaskCompletedSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResearchTaskFailed))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ResearchTaskFailedStatus), TypeInfoPropertyName = "ResearchTaskFailedStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.UsageMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.UsageByType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ApiError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ApiErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.ValidationErrorDetailItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ValidationErrorDetailItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.OneOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.OneOf<string, int?>), TypeInfoPropertyName = "OneOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.SearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.SearchRequestSearchDepth), TypeInfoPropertyName = "SearchRequestSearchDepth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.SearchRequestTopic), TypeInfoPropertyName = "SearchRequestTopic2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.SearchRequestTimeRange), TypeInfoPropertyName = "SearchRequestTimeRange2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.OneOf<bool?, global::Tavily.SearchRequestIncludeAnswer?>), TypeInfoPropertyName = "OneOfBooleanSearchRequestIncludeAnswer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.SearchRequestIncludeAnswer), TypeInfoPropertyName = "SearchRequestIncludeAnswer2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.OneOf<bool?, global::Tavily.SearchRequestIncludeRawContent?>), TypeInfoPropertyName = "OneOfBooleanSearchRequestIncludeRawContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.SearchRequestIncludeRawContent), TypeInfoPropertyName = "SearchRequestIncludeRawContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.SearchRequestIncludeDomainsMode), TypeInfoPropertyName = "SearchRequestIncludeDomainsMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.SearchRequestCountry), TypeInfoPropertyName = "SearchRequestCountry2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ExtractRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ExtractRequestExtractDepth), TypeInfoPropertyName = "ExtractRequestExtractDepth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ExtractRequestFormat), TypeInfoPropertyName = "ExtractRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CrawlRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CrawlRequestExtractDepth), TypeInfoPropertyName = "CrawlRequestExtractDepth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CrawlRequestFormat), TypeInfoPropertyName = "CrawlRequestFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.MapRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchRequestModel), TypeInfoPropertyName = "CreateResearchRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchRequestOutputSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Tavily.CreateResearchRequestOutputSchemaProperties2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchRequestOutputSchemaProperties2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchRequestOutputSchemaPropertiesType), TypeInfoPropertyName = "CreateResearchRequestOutputSchemaPropertiesType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchRequestCitationFormat), TypeInfoPropertyName = "CreateResearchRequestCitationFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchRequestOutputLength), TypeInfoPropertyName = "CreateResearchRequestOutputLength2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.CreateResearchRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchRequestFile))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchRequestFileType), TypeInfoPropertyName = "CreateResearchRequestFileType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateFeedbackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.OneOf<double?, string>), TypeInfoPropertyName = "OneOfDoubleString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.CreateFeedbackRequestExtraScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateFeedbackRequestExtraScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.CreateFeedbackRequestUrlsScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateFeedbackRequestUrlsScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.CreateFeedbackRequestUrlsScoreScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateFeedbackRequestUrlsScoreScore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateLogsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.CreateLogsRequestEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateLogsRequestEndpoint), TypeInfoPropertyName = "CreateLogsRequestEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateOrgUsageRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateOrgUsageRequestDepth), TypeInfoPropertyName = "CreateOrgUsageRequestDepth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.SearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.SearchResponseImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.SearchResponseImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.SearchResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.SearchResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.SearchResponseResultImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.SearchResponseResultImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ExtractResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.ExtractResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ExtractResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.ExtractResponseFailedResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ExtractResponseFailedResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.AllOf<global::Tavily.ApiError, global::Tavily.ExtractResponse3>), TypeInfoPropertyName = "AllOfApiErrorExtractResponse32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ExtractResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ExtractResponseDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.ExtractResponseDetailFailedResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.ExtractResponseDetailFailedResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CrawlResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.CrawlResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CrawlResponseResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.MapResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateResearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetResearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetResearchResponseStatus), TypeInfoPropertyName = "GetResearchResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetResearchResponse2), TypeInfoPropertyName = "GetResearchResponse22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetResearchResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetResearchResponseDiscriminatorStatus), TypeInfoPropertyName = "GetResearchResponseDiscriminatorStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateFeedbackResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateFeedbackResponse2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateFeedbackResponseDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateFeedbackResponse3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateFeedbackResponseDetail2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateFeedbackResponse4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateFeedbackResponseDetail3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateFeedbackResponse5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateFeedbackResponseDetail4))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateFeedbackResponse6))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateFeedbackResponseDetail5))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetUsageResponseKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.GetUsageResponseAccount))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.CreateLogsResponseLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateLogsResponseLog))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateLogsResponseLogEndpoint), TypeInfoPropertyName = "CreateLogsResponseLogEndpoint2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateOrgUsageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateOrgUsageResponseOrganization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateOrgUsageResponseOrganizationFilters))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateOrgUsageResponseTotals))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Tavily.CreateOrgUsageResponseKey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.CreateOrgUsageResponseKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.ResearchTaskCompletedSource>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.ValidationErrorDetailItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.OneOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Tavily.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.CreateResearchRequestFile>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.CreateFeedbackRequestExtraScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.CreateFeedbackRequestUrlsScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.CreateFeedbackRequestUrlsScoreScore>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.CreateLogsRequestEndpoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.SearchResponseImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.SearchResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.SearchResponseResultImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.ExtractResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.ExtractResponseFailedResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.ExtractResponseDetailFailedResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.CrawlResponseResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.CreateLogsResponseLog>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Tavily.CreateOrgUsageResponseKey>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}