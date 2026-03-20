
#nullable enable

namespace Tavily
{
    public partial class TavilyClient
    {
        partial void PrepareCreateExtractArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Tavily.Request2 request);
        partial void PrepareCreateExtractRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Tavily.Request2 request);
        partial void ProcessCreateExtractResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateExtractResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieve raw web content from specified URLs<br/>
        /// Extract web page content from one or more specified URLs using Tavily Extract.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Tavily.ApiException"></exception>
        /// <remarks>
        /// from tavily import TavilyClient<br/>
        /// tavily_client = TavilyClient(api_key="tvly-YOUR_API_KEY")<br/>
        /// response = tavily_client.extract("https://en.wikipedia.org/wiki/Artificial_intelligence")<br/>
        /// print(response)
        /// </remarks>
        public async global::System.Threading.Tasks.Task<global::Tavily.Response8> CreateExtractAsync(

            global::Tavily.Request2 request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateExtractArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Tavily.PathBuilder(
                path: "/extract",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateExtractRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateExtractResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::Tavily.Response9? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::Tavily.Response9.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::Tavily.Response9.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Tavily.ApiException<global::Tavily.Response9>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unauthorized - Your API key is wrong or missing.
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::Tavily.Response10? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::Tavily.Response10.FromJson(__content_401, JsonSerializerContext);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::Tavily.Response10.FromJson(__content_401, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::Tavily.ApiException<global::Tavily.Response10>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Too many requests - Rate limit exceeded
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::Tavily.Response11? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::Tavily.Response11.FromJson(__content_429, JsonSerializerContext);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::Tavily.Response11.FromJson(__content_429, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::Tavily.ApiException<global::Tavily.Response11>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Key limit or Plan Limit exceeded
            if ((int)__response.StatusCode == 432)
            {
                string? __content_432 = null;
                global::System.Exception? __exception_432 = null;
                global::Tavily.Response12? __value_432 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_432 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_432 = global::Tavily.Response12.FromJson(__content_432, JsonSerializerContext);
                    }
                    else
                    {
                        __content_432 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_432 = global::Tavily.Response12.FromJson(__content_432, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_432 = __ex;
                }

                throw new global::Tavily.ApiException<global::Tavily.Response12>(
                    message: __content_432 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_432,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_432,
                    ResponseObject = __value_432,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // PayGo limit exceeded
            if ((int)__response.StatusCode == 433)
            {
                string? __content_433 = null;
                global::System.Exception? __exception_433 = null;
                global::Tavily.Response13? __value_433 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_433 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_433 = global::Tavily.Response13.FromJson(__content_433, JsonSerializerContext);
                    }
                    else
                    {
                        __content_433 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_433 = global::Tavily.Response13.FromJson(__content_433, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_433 = __ex;
                }

                throw new global::Tavily.ApiException<global::Tavily.Response13>(
                    message: __content_433 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_433,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_433,
                    ResponseObject = __value_433,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Internal Server Error - We had a problem with our server.
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::Tavily.Response14? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::Tavily.Response14.FromJson(__content_500, JsonSerializerContext);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::Tavily.Response14.FromJson(__content_500, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::Tavily.ApiException<global::Tavily.Response14>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateExtractResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Tavily.Response8.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Tavily.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Tavily.Response8.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Tavily.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Retrieve raw web content from specified URLs<br/>
        /// Extract web page content from one or more specified URLs using Tavily Extract.
        /// </summary>
        /// <param name="urls"></param>
        /// <param name="query">
        /// User intent for reranking extracted content chunks. When provided, chunks are reranked based on relevance to this query.
        /// </param>
        /// <param name="chunksPerSource">
        /// Chunks are short content snippets (maximum 500 characters each) pulled directly from the source. Use `chunks_per_source` to define the maximum number of relevant chunks returned per source and to control the `raw_content` length. Chunks will appear in the `raw_content` field as: `&lt;chunk 1&gt; [...] &lt;chunk 2&gt; [...] &lt;chunk 3&gt;`. Available only when `query` is provided. Must be between 1 and 5.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="extractDepth">
        /// The depth of the extraction process. `advanced` extraction retrieves more data, including tables and embedded content, with higher success but may increase latency.`basic` extraction costs 1 credit per 5 successful URL extractions, while `advanced` extraction costs 2 credits per 5 successful URL extractions.<br/>
        /// Default Value: basic
        /// </param>
        /// <param name="includeImages">
        /// Include a list of images extracted from the URLs in the response. Default is false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeFavicon">
        /// Whether to include the favicon URL for each result.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="format">
        /// The format of the extracted web page content. `markdown` returns content in markdown format. `text` returns plain text and may increase latency.<br/>
        /// Default Value: markdown
        /// </param>
        /// <param name="timeout">
        /// Maximum time in seconds to wait for the URL extraction before timing out. Must be between 1.0 and 60.0 seconds. If not specified, default timeouts are applied based on extract_depth: 10 seconds for basic extraction and 30 seconds for advanced extraction.<br/>
        /// Default Value: None
        /// </param>
        /// <param name="includeUsage">
        /// Whether to include credit usage information in the response. `NOTE:`The value may be 0 if the total successful URL extractions has not yet reached 5 calls. See our [Credits &amp; Pricing documentation](https://docs.tavily.com/documentation/api-credits) for details.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Tavily.Response8> CreateExtractAsync(
            global::Tavily.OneOf<string, global::System.Collections.Generic.IList<string>> urls,
            string? query = default,
            int? chunksPerSource = default,
            global::Tavily.RequestExtractDepth? extractDepth = default,
            bool? includeImages = default,
            bool? includeFavicon = default,
            global::Tavily.RequestFormat? format = default,
            float? timeout = default,
            bool? includeUsage = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Tavily.Request2
            {
                Urls = urls,
                Query = query,
                ChunksPerSource = chunksPerSource,
                ExtractDepth = extractDepth,
                IncludeImages = includeImages,
                IncludeFavicon = includeFavicon,
                Format = format,
                Timeout = timeout,
                IncludeUsage = includeUsage,
            };

            return await CreateExtractAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}