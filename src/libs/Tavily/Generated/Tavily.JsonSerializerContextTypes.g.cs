
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Tavily
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Tavily.ResearchTaskCompleted? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.ResearchTaskCompletedStatus? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.OneOf<string, object>? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.ResearchTaskCompletedSource>? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.ResearchTaskCompletedSource? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.ResearchTaskFailed? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.ResearchTaskFailedStatus? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.UsageMetrics? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.UsageByType? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.ApiError? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.ApiErrorDetail? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.ValidationError? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.ValidationErrorDetailItem>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.ValidationErrorDetailItem? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.OneOf<string, int?>>? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.OneOf<string, int?>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.SearchRequest? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.SearchRequestSearchDepth? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.SearchRequestTopic? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.SearchRequestTimeRange? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.OneOf<bool?, global::Tavily.SearchRequestIncludeAnswer?>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.SearchRequestIncludeAnswer? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.OneOf<bool?, global::Tavily.SearchRequestIncludeRawContent?>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.SearchRequestIncludeRawContent? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.SearchRequestIncludeDomainsMode? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.SearchRequestCountry? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.ExtractRequest? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.OneOf<string, global::System.Collections.Generic.IList<string>>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.ExtractRequestExtractDepth? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.ExtractRequestFormat? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CrawlRequest? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CrawlRequestExtractDepth? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CrawlRequestFormat? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.MapRequest? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchRequest? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchRequestModel? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchRequestOutputSchema? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Tavily.CreateResearchRequestOutputSchemaProperties2>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchRequestOutputSchemaProperties2? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchRequestOutputSchemaPropertiesType? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchRequestCitationFormat? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchRequestOutputLength? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateResearchRequestFile>? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchRequestFile? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchRequestFileType? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateFeedbackRequest? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.OneOf<double?, string>? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateFeedbackRequestExtraScore>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateFeedbackRequestExtraScore? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateFeedbackRequestUrlsScore>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateFeedbackRequestUrlsScore? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateFeedbackRequestUrlsScoreScore>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateFeedbackRequestUrlsScoreScore? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsRequest? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateLogsRequestEndpoint>? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsRequestEndpoint? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageRequest? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageRequestDepth? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.SearchResponse? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.SearchResponseImage>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.SearchResponseImage? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.SearchResponseResult>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.SearchResponseResult? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.SearchResponseResultImage>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.SearchResponseResultImage? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.ExtractResponse? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.ExtractResponseResult>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.ExtractResponseResult? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.ExtractResponseFailedResult>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.ExtractResponseFailedResult? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.AllOf<global::Tavily.ApiError, global::Tavily.ExtractResponse3>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.ExtractResponse3? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.ExtractResponseDetail? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.ExtractResponseDetailFailedResult>? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.ExtractResponseDetailFailedResult? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CrawlResponse? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CrawlResponseResult>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CrawlResponseResult? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.MapResponse? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchResponse? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetResearchResponse? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetResearchResponseStatus? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetResearchResponse2? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetResearchResponseDiscriminator? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetResearchResponseDiscriminatorStatus? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateFeedbackResponse? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateFeedbackResponse2? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateFeedbackResponseDetail? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateFeedbackResponse3? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateFeedbackResponseDetail2? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateFeedbackResponse4? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateFeedbackResponseDetail3? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateFeedbackResponse5? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateFeedbackResponseDetail4? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateFeedbackResponse6? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateFeedbackResponseDetail5? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetUsageResponse? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetUsageResponseKey? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetUsageResponseAccount? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsResponse? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateLogsResponseLog>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsResponseLog? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsResponseLogEndpoint? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponse? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseOrganization? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseOrganizationFilters? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseTotals? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateOrgUsageResponseKey>? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseKey? Type116 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.ResearchTaskCompletedSource>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.ValidationErrorDetailItem>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.OneOf<string, int?>>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.OneOf<string, global::System.Collections.Generic.List<string>>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateResearchRequestFile>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateFeedbackRequestExtraScore>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateFeedbackRequestUrlsScore>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateFeedbackRequestUrlsScoreScore>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateLogsRequestEndpoint>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.SearchResponseImage>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.SearchResponseResult>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.SearchResponseResultImage>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.ExtractResponseResult>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.ExtractResponseFailedResult>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.ExtractResponseDetailFailedResult>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CrawlResponseResult>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateLogsResponseLog>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateOrgUsageResponseKey>? ListType18 { get; set; }
    }
}