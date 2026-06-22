
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
        public global::Tavily.CreateSearchRequestCountry? Type23 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateExtractRequest? Type24 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.OneOf<string, global::System.Collections.Generic.IList<string>>? Type25 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateExtractRequestExtractDepth? Type26 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateExtractRequestFormat? Type27 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public float? Type28 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateCrawlRequest? Type29 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateCrawlRequestExtractDepth? Type30 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateCrawlRequestFormat? Type31 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateMapRequest? Type32 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchRequest? Type33 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchRequestModel? Type34 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchRequestOutputSchema? Type35 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Tavily.CreateResearchRequestOutputSchemaProperties2>? Type36 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchRequestOutputSchemaProperties2? Type37 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchRequestOutputSchemaPropertiesType? Type38 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchRequestCitationFormat? Type39 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchRequestOutputLength? Type40 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateResearchRequestFile>? Type41 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchRequestFile? Type42 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchRequestFileType? Type43 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageRequest? Type44 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.DateTime? Type45 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageRequestDepth? Type46 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateSearchResponse? Type47 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateSearchResponseImage>? Type48 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateSearchResponseImage? Type49 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateSearchResponseResult>? Type50 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateSearchResponseResult? Type51 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateSearchResponseResultImage>? Type52 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateSearchResponseResultImage? Type53 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateSearchResponse2? Type54 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateSearchResponseDetail? Type55 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateSearchResponse3? Type56 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateSearchResponseDetail2? Type57 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateSearchResponse4? Type58 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateSearchResponseDetail3? Type59 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateSearchResponse5? Type60 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateSearchResponseDetail4? Type61 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateSearchResponse6? Type62 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateSearchResponseDetail5? Type63 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateSearchResponse7? Type64 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateSearchResponseDetail6? Type65 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateExtractResponse? Type66 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateExtractResponseResult>? Type67 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateExtractResponseResult? Type68 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateExtractResponseFailedResult>? Type69 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateExtractResponseFailedResult? Type70 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateExtractResponse2? Type71 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateExtractResponseDetail? Type72 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateExtractResponse3? Type73 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateExtractResponseDetail2? Type74 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateExtractResponse4? Type75 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateExtractResponseDetail3? Type76 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateExtractResponse5? Type77 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateExtractResponseDetail4? Type78 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateExtractResponse6? Type79 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateExtractResponseDetail5? Type80 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateExtractResponse7? Type81 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateExtractResponseDetail6? Type82 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateCrawlResponse? Type83 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateCrawlResponseResult>? Type84 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateCrawlResponseResult? Type85 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateCrawlResponse2? Type86 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateCrawlResponseDetail? Type87 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateCrawlResponse3? Type88 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateCrawlResponseDetail2? Type89 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateCrawlResponse4? Type90 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateCrawlResponseDetail3? Type91 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateCrawlResponse5? Type92 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateCrawlResponseDetail4? Type93 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateCrawlResponse6? Type94 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateCrawlResponseDetail5? Type95 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateCrawlResponse7? Type96 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateCrawlResponseDetail6? Type97 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateCrawlResponse8? Type98 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateCrawlResponseDetail7? Type99 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateMapResponse? Type100 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateMapResponse2? Type101 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateMapResponseDetail? Type102 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateMapResponse3? Type103 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateMapResponseDetail2? Type104 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateMapResponse4? Type105 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateMapResponseDetail3? Type106 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateMapResponse5? Type107 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateMapResponseDetail4? Type108 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateMapResponse6? Type109 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateMapResponseDetail5? Type110 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateMapResponse7? Type111 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateMapResponseDetail6? Type112 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateMapResponse8? Type113 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateMapResponseDetail7? Type114 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchResponse? Type115 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchResponse2? Type116 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchResponseDetail? Type117 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchResponse3? Type118 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchResponseDetail2? Type119 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchResponse4? Type120 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchResponseDetail3? Type121 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchResponse5? Type122 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchResponseDetail4? Type123 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchResponse6? Type124 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchResponseDetail5? Type125 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchResponse7? Type126 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateResearchResponseDetail6? Type127 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.GetResearchResponse? Type128 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.GetResearchResponseDiscriminator? Type129 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.GetResearchResponseDiscriminatorStatus? Type130 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.GetResearchResponse2? Type131 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.GetResearchResponseStatus? Type132 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.GetResearchResponse3? Type133 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.GetResearchResponseDetail? Type134 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.GetResearchResponse4? Type135 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.GetResearchResponseDetail2? Type136 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.GetResearchResponse5? Type137 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.GetResearchResponseDetail3? Type138 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.GetUsageResponse? Type139 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.GetUsageResponseKey? Type140 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.GetUsageResponseAccount? Type141 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.GetUsageResponse2? Type142 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.GetUsageResponseDetail? Type143 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.GetUsageResponse3? Type144 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.GetUsageResponseDetail2? Type145 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponse? Type146 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseOrganization? Type147 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseOrganizationFilters? Type148 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseTotals? Type149 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::Tavily.CreateOrgUsageResponseKey>? Type150 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseKey? Type151 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponse2? Type152 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseDetail? Type153 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponse3? Type154 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseDetail2? Type155 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponse4? Type156 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseDetail3? Type157 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponse5? Type158 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseDetail4? Type159 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponse6? Type160 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseDetail5? Type161 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponse7? Type162 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseDetail6? Type163 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponse8? Type164 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseDetail7? Type165 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponse9? Type166 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::Tavily.CreateOrgUsageResponseDetail8? Type167 { get; set; }

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
        public global::System.Collections.Generic.List<global::Tavily.CreateSearchResponseImage>? ListType4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateSearchResponseResult>? ListType5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateSearchResponseResultImage>? ListType6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateExtractResponseResult>? ListType7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateExtractResponseFailedResult>? ListType8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateCrawlResponseResult>? ListType9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::Tavily.CreateOrgUsageResponseKey>? ListType10 { get; set; }
    }
}