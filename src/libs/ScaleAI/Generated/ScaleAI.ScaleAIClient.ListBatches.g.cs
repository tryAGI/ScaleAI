
#nullable enable

namespace ScaleAI
{
    public partial class ScaleAIClient
    {
        partial void PrepareListBatchesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? project,
            ref global::ScaleAI.ListBatchesStatus? status,
            ref bool? detailed,
            ref global::System.DateTime? startTime,
            ref global::System.DateTime? endTime,
            ref int? limit,
            ref int? offset);
        partial void PrepareListBatchesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? project,
            global::ScaleAI.ListBatchesStatus? status,
            bool? detailed,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            int? limit,
            int? offset);
        partial void ProcessListBatchesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListBatchesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List all batches<br/>
        /// Returns a paginated list of all batches, optionally filtered by project or status.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="status"></param>
        /// <param name="detailed"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ScaleAI.BatchListResponse> ListBatchesAsync(
            string? project = default,
            global::ScaleAI.ListBatchesStatus? status = default,
            bool? detailed = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            int? limit = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListBatchesArguments(
                httpClient: HttpClient,
                project: ref project,
                status: ref status,
                detailed: ref detailed,
                startTime: ref startTime,
                endTime: ref endTime,
                limit: ref limit,
                offset: ref offset);

            var __pathBuilder = new global::ScaleAI.PathBuilder(
                path: "/batches",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("project", project)
                .AddOptionalParameter("status", status?.ToValueString())
                .AddOptionalParameter("detailed", detailed?.ToString().ToLowerInvariant())
                .AddOptionalParameter("start_time", startTime?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("end_time", endTime?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("offset", offset?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListBatchesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                project: project,
                status: status,
                detailed: detailed,
                startTime: startTime,
                endTime: endTime,
                limit: limit,
                offset: offset);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListBatchesResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

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
                ProcessListBatchesResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::ScaleAI.BatchListResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::ScaleAI.ApiException(
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
                        await global::ScaleAI.BatchListResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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

                    throw new global::ScaleAI.ApiException(
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
    }
}