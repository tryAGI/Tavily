
#nullable enable

namespace Tavily
{
    /// <summary>
    /// Tavily Search is a robust search API tailored specifically for LLM Agents. It seamlessly integrates with diverse data sources to ensure a superior, relevant search experience.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ITavilyClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


    }
}