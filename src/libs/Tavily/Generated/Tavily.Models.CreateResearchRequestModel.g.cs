
#nullable enable

namespace Tavily
{
    /// <summary>
    /// The model used by the research agent. "mini" is optimized for targeted, efficient research and works best for narrow or well-scoped questions. "pro" provides comprehensive, multi-angle research and is suited for complex topics that span multiple subtopics or domains<br/>
    /// Default Value: auto
    /// </summary>
    public enum CreateResearchRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Mini,
        /// <summary>
        /// 
        /// </summary>
        Pro,
        /// <summary>
        /// 
        /// </summary>
        Auto,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResearchRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResearchRequestModel value)
        {
            return value switch
            {
                CreateResearchRequestModel.Mini => "mini",
                CreateResearchRequestModel.Pro => "pro",
                CreateResearchRequestModel.Auto => "auto",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResearchRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "mini" => CreateResearchRequestModel.Mini,
                "pro" => CreateResearchRequestModel.Pro,
                "auto" => CreateResearchRequestModel.Auto,
                _ => null,
            };
        }
    }
}