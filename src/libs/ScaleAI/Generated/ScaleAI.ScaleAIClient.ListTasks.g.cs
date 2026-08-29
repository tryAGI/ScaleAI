
#nullable enable

namespace ScaleAI
{
    public partial class ScaleAIClient
    {


        private static readonly global::ScaleAI.EndPointSecurityRequirement s_ListTasksSecurityRequirement0 =
            new global::ScaleAI.EndPointSecurityRequirement
            {
                Authorizations = new global::ScaleAI.EndPointAuthorizationRequirement[]
                {                    new global::ScaleAI.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::ScaleAI.EndPointSecurityRequirement[] s_ListTasksSecurityRequirements =
            new global::ScaleAI.EndPointSecurityRequirement[]
            {                s_ListTasksSecurityRequirement0,
            };
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
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
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ListTasksAsResponseAsync(
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
                nextToken: nextToken,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ScaleAI.AutoSDKHttpResponse<global::ScaleAI.TaskListResponse>> ListTasksAsResponseAsync(
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
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
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


            var __authorizations = global::ScaleAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListTasksSecurityRequirements,
                operationName: "ListTasksAsync");

            using var __timeoutCancellationTokenSource = global::ScaleAI.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::ScaleAI.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::ScaleAI.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

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
                __path = global::ScaleAI.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                global::ScaleAI.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

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

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::ScaleAI.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::ScaleAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListTasks",
                                methodName: "ListTasksAsync",
                                pathTemplate: "\"/tasks\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::ScaleAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::ScaleAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ScaleAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListTasks",
                                methodName: "ListTasksAsync",
                                pathTemplate: "\"/tasks\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ScaleAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::ScaleAI.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::ScaleAI.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::ScaleAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ScaleAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListTasks",
                                methodName: "ListTasksAsync",
                                pathTemplate: "\"/tasks\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::ScaleAI.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessListTasksResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::ScaleAI.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::ScaleAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListTasks",
                                methodName: "ListTasksAsync",
                                pathTemplate: "\"/tasks\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::ScaleAI.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::ScaleAI.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListTasks",
                                methodName: "ListTasksAsync",
                                pathTemplate: "\"/tasks\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
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

                                    var __value = global::ScaleAI.TaskListResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::ScaleAI.AutoSDKHttpResponse<global::ScaleAI.TaskListResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ScaleAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::ScaleAI.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::ScaleAI.TaskListResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::ScaleAI.AutoSDKHttpResponse<global::ScaleAI.TaskListResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::ScaleAI.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::ScaleAI.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}