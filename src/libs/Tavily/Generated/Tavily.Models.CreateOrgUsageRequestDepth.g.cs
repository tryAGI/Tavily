
#nullable enable

namespace Tavily
{
    /// <summary>
    /// Scope usage to a single request depth.<br/>
    /// Example: advanced
    /// </summary>
    public enum CreateOrgUsageRequestDepth
    {
        /// <summary>
        /// 
        /// </summary>
        Advanced,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Basic,
        /// <summary>
        /// 
        /// </summary>
        Fast,
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
        UltraFast,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateOrgUsageRequestDepthExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateOrgUsageRequestDepth value)
        {
            return value switch
            {
                CreateOrgUsageRequestDepth.Advanced => "advanced",
                CreateOrgUsageRequestDepth.Auto => "auto",
                CreateOrgUsageRequestDepth.Basic => "basic",
                CreateOrgUsageRequestDepth.Fast => "fast",
                CreateOrgUsageRequestDepth.Mini => "mini",
                CreateOrgUsageRequestDepth.Pro => "pro",
                CreateOrgUsageRequestDepth.UltraFast => "ultra-fast",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateOrgUsageRequestDepth? ToEnum(string value)
        {
            return value switch
            {
                "advanced" => CreateOrgUsageRequestDepth.Advanced,
                "auto" => CreateOrgUsageRequestDepth.Auto,
                "basic" => CreateOrgUsageRequestDepth.Basic,
                "fast" => CreateOrgUsageRequestDepth.Fast,
                "mini" => CreateOrgUsageRequestDepth.Mini,
                "pro" => CreateOrgUsageRequestDepth.Pro,
                "ultra-fast" => CreateOrgUsageRequestDepth.UltraFast,
                _ => null,
            };
        }
    }
}