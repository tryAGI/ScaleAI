
#nullable enable

namespace ScaleAI
{
    public partial class ScaleAIClient
    {


        private static readonly global::ScaleAI.EndPointSecurityRequirement s_CreateProjectSecurityRequirement0 =
            new global::ScaleAI.EndPointSecurityRequirement
            {
                Authorizations = new global::ScaleAI.EndPointAuthorizationRequirement[]
                {                    new global::ScaleAI.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::ScaleAI.EndPointSecurityRequirement[] s_CreateProjectSecurityRequirements =
            new global::ScaleAI.EndPointSecurityRequirement[]
            {                s_CreateProjectSecurityRequirement0,
            };
        partial void PrepareCreateProjectArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::ScaleAI.CreateProjectRequest request);
        partial void PrepareCreateProjectRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::ScaleAI.CreateProjectRequest request);
        partial void ProcessCreateProjectResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateProjectResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a project<br/>
        /// Create a new project for organizing tasks and batches.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::ScaleAI.Project> CreateProjectAsync(

            global::ScaleAI.CreateProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateProjectArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::ScaleAI.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateProjectSecurityRequirements,
                operationName: "CreateProjectAsync");

            var __pathBuilder = new global::ScaleAI.PathBuilder(
                path: "/projects",
                baseUri: HttpClient.BaseAddress);
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            PrepareCreateProjectRequest(
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
            ProcessCreateProjectResponse(
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
                ProcessCreateProjectResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::ScaleAI.Project.FromJson(__content, JsonSerializerContext) ??
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
                        await global::ScaleAI.Project.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// <summary>
        /// Create a project<br/>
        /// Create a new project for organizing tasks and batches.
        /// </summary>
        /// <param name="type">
        /// Task type: imageannotation, textcollection, namedentityrecognition, etc.
        /// </param>
        /// <param name="name">
        /// Unique project name identifier.
        /// </param>
        /// <param name="rapid">
        /// Whether this is a Scale Rapid project.
        /// </param>
        /// <param name="studio">
        /// Whether this is a Scale Studio project.
        /// </param>
        /// <param name="params">
        /// Default task parameters for this project.
        /// </param>
        /// <param name="pipeline">
        /// Pipeline type for Studio projects.
        /// </param>
        /// <param name="consensusAttempts">
        /// Number of consensus attempts (Studio consensus projects only).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::ScaleAI.Project> CreateProjectAsync(
            global::ScaleAI.CreateProjectRequestType type,
            string name,
            bool? rapid = default,
            bool? studio = default,
            object? @params = default,
            global::ScaleAI.CreateProjectRequestPipeline? pipeline = default,
            int? consensusAttempts = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::ScaleAI.CreateProjectRequest
            {
                Type = type,
                Name = name,
                Rapid = rapid,
                Studio = studio,
                Params = @params,
                Pipeline = pipeline,
                ConsensusAttempts = consensusAttempts,
            };

            return await CreateProjectAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}