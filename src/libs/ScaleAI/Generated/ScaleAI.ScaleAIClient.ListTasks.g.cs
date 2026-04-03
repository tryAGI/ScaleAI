
#nullable enable

namespace ScaleAI
{
    public partial class ScaleAIClient
    {
        partial void PrepareListTasksArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? project,
            ref string? batch,
            ref global::ScaleAI.ListTasksStatus? status,
            ref string? type,
            ref global::System.DateTime? startTime,
            ref global::System.DateTime? endTime,
            ref global::System.DateTime? completedAfter,
            ref global::System.DateTime? completedBefore,
            ref global::ScaleAI.ListTasksCustomerReviewStatus? customerReviewStatus,
            ref int? limit,
            ref string? uniqueId,
            ref string? tags,
            ref bool? includeAttachmentUrl,
            ref string? nextToken);
        partial void PrepareListTasksRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? project,
            string? batch,
            global::ScaleAI.ListTasksStatus? status,
            string? type,
            global::System.DateTime? startTime,
            global::System.DateTime? endTime,
            global::System.DateTime? completedAfter,
            global::System.DateTime? completedBefore,
            global::ScaleAI.ListTasksCustomerReviewStatus? customerReviewStatus,
            int? limit,
            string? uniqueId,
            string? tags,
            bool? includeAttachmentUrl,
            string? nextToken);
        partial void ProcessListTasksResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListTasksResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List tasks<br/>
        /// Returns a paginated list of tasks with optional filtering by project, batch, status, and time range.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="batch"></param>
        /// <param name="status"></param>
        /// <param name="type"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="completedAfter"></param>
        /// <param name="completedBefore"></param>
        /// <param name="customerReviewStatus"></param>
        /// <param name="limit"></param>
        /// <param name="uniqueId"></param>
        /// <param name="tags"></param>
        /// <param name="includeAttachmentUrl"></param>
        /// <param name="nextToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ScaleAI.TaskListResponse> ListTasksAsync(
            string? project = default,
            string? batch = default,
            global::ScaleAI.ListTasksStatus? status = default,
            string? type = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::System.DateTime? completedAfter = default,
            global::System.DateTime? completedBefore = default,
            global::ScaleAI.ListTasksCustomerReviewStatus? customerReviewStatus = default,
            int? limit = default,
            string? uniqueId = default,
            string? tags = default,
            bool? includeAttachmentUrl = default,
            string? nextToken = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListTasksArguments(
                httpClient: HttpClient,
                project: ref project,
                batch: ref batch,
                status: ref status,
                type: ref type,
                startTime: ref startTime,
                endTime: ref endTime,
                completedAfter: ref completedAfter,
                completedBefore: ref completedBefore,
                customerReviewStatus: ref customerReviewStatus,
                limit: ref limit,
                uniqueId: ref uniqueId,
                tags: ref tags,
                includeAttachmentUrl: ref includeAttachmentUrl,
                nextToken: ref nextToken);

            var __pathBuilder = new global::ScaleAI.PathBuilder(
                path: "/tasks",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("project", project)
                .AddOptionalParameter("batch", batch)
                .AddOptionalParameter("status", status?.ToValueString())
                .AddOptionalParameter("type", type)
                .AddOptionalParameter("start_time", startTime?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("end_time", endTime?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("completed_after", completedAfter?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("completed_before", completedBefore?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("customer_review_status", customerReviewStatus?.ToValueString())
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("unique_id", uniqueId)
                .AddOptionalParameter("tags", tags)
                .AddOptionalParameter("include_attachment_url", includeAttachmentUrl?.ToString().ToLowerInvariant())
                .AddOptionalParameter("next_token", nextToken) 
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
            PrepareListTasksRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                project: project,
                batch: batch,
                status: status,
                type: type,
                startTime: startTime,
                endTime: endTime,
                completedAfter: completedAfter,
                completedBefore: completedBefore,
                customerReviewStatus: customerReviewStatus,
                limit: limit,
                uniqueId: uniqueId,
                tags: tags,
                includeAttachmentUrl: includeAttachmentUrl,
                nextToken: nextToken);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListTasksResponse(
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
                ProcessListTasksResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::ScaleAI.TaskListResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::ScaleAI.TaskListResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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