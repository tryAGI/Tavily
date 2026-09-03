
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
        public global::Tavily.CreateSearchRequest? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchRequestSearchDepth? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchRequestTopic? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchRequestTimeRange? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.OneOf<bool?, global::Tavily.CreateSearchRequestIncludeAnswer?>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchRequestIncludeAnswer? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.OneOf<bool?, global::Tavily.CreateSearchRequestIncludeRawContent?>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchRequestIncludeRawContent? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchRequestIncludeDomainsMode? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchRequestCountry? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateExtractRequest? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.OneOf<string, global::System.Collections.Generic.IList<string>>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateExtractRequestExtractDepth? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateExtractRequestFormat? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateCrawlRequest? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateCrawlRequestExtractDepth? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateCrawlRequestFormat? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateMapRequest? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchRequest? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchRequestModel? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchRequestOutputSchema? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Tavily.CreateResearchRequestOutputSchemaProperties2>? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchRequestOutputSchemaProperties2? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchRequestOutputSchemaPropertiesType? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchRequestCitationFormat? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchRequestOutputLength? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateResearchRequestFile>? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchRequestFile? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchRequestFileType? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsRequest? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateLogsRequestEndpoint>? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsRequestEndpoint? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageRequest? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageRequestDepth? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchResponse? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateSearchResponseImage>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchResponseImage? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateSearchResponseResult>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchResponseResult? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateSearchResponseResultImage>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchResponseResultImage? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchResponse2? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchResponseDetail? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchResponse3? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchResponseDetail2? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchResponse4? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchResponseDetail3? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchResponse5? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchResponseDetail4? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchResponse6? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchResponseDetail5? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchResponse7? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateSearchResponseDetail6? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateExtractResponse? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateExtractResponseResult>? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateExtractResponseResult? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateExtractResponseFailedResult>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateExtractResponseFailedResult? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateExtractResponse2? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateExtractResponseDetail? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateExtractResponse3? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateExtractResponseDetail2? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateExtractResponse4? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateExtractResponseDetail3? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateExtractResponse5? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateExtractResponseDetail4? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateExtractResponse6? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateExtractResponseDetail5? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateExtractResponse7? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateExtractResponseDetail6? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateCrawlResponse? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateCrawlResponseResult>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateCrawlResponseResult? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateCrawlResponse2? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateCrawlResponseDetail? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateCrawlResponse3? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateCrawlResponseDetail2? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateCrawlResponse4? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateCrawlResponseDetail3? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateCrawlResponse5? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateCrawlResponseDetail4? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateCrawlResponse6? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateCrawlResponseDetail5? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateCrawlResponse7? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateCrawlResponseDetail6? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateCrawlResponse8? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateCrawlResponseDetail7? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateMapResponse? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateMapResponse2? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateMapResponseDetail? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateMapResponse3? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateMapResponseDetail2? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateMapResponse4? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateMapResponseDetail3? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateMapResponse5? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateMapResponseDetail4? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateMapResponse6? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateMapResponseDetail5? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateMapResponse7? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateMapResponseDetail6? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateMapResponse8? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateMapResponseDetail7? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchResponse? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchResponse2? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchResponseDetail? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchResponse3? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchResponseDetail2? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchResponse4? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchResponseDetail3? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchResponse5? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchResponseDetail4? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchResponse6? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchResponseDetail5? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchResponse7? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateResearchResponseDetail6? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetResearchResponse? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetResearchResponseStatus? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetResearchResponse2? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetResearchResponseDiscriminator? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetResearchResponseDiscriminatorStatus? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetResearchResponse3? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetResearchResponseDetail? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetResearchResponse4? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetResearchResponseDetail2? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetResearchResponse5? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetResearchResponseDetail3? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetUsageResponse? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetUsageResponseKey? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetUsageResponseAccount? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetUsageResponse2? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetUsageResponseDetail? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetUsageResponse3? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.GetUsageResponseDetail2? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsResponse? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateLogsResponseLog>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsResponseLog? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsResponseLogEndpoint? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsResponse2? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsResponseDetail? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsResponse3? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsResponseDetail2? Type157 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsResponse4? Type158 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsResponseDetail3? Type159 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsResponse5? Type160 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsResponseDetail4? Type161 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsResponse6? Type162 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateLogsResponseDetail5? Type163 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponse? Type164 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseOrganization? Type165 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseOrganizationFilters? Type166 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseTotals? Type167 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateOrgUsageResponseKey>? Type168 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseKey? Type169 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponse2? Type170 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseDetail? Type171 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponse3? Type172 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseDetail2? Type173 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponse4? Type174 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseDetail3? Type175 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponse5? Type176 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseDetail4? Type177 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponse6? Type178 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseDetail5? Type179 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponse7? Type180 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseDetail6? Type181 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponse8? Type182 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseDetail7? Type183 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponse9? Type184 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseDetail8? Type185 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.ResearchTaskCompletedSource>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Tavily.OneOf<string, global::System.Collections.Generic.List<string>>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateResearchRequestFile>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateLogsRequestEndpoint>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateSearchResponseImage>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateSearchResponseResult>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateSearchResponseResultImage>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateExtractResponseResult>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateExtractResponseFailedResult>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateCrawlResponseResult>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateLogsResponseLog>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateOrgUsageResponseKey>? ListType12 { get; set; }
    }
}