#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Create a project<br/>
        /// Create a new project for organizing tasks and batches.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Project> CreateProjectAsync(

            global::ScaleAI.CreateProjectRequest request,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a project<br/>
        /// Create a new project for organizing tasks and batches.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.AutoSDKHttpResponse<global::ScaleAI.Project>> CreateProjectAsResponseAsync(

            global::ScaleAI.CreateProjectRequest request,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Project> CreateProjectAsync(
            global::ScaleAI.CreateProjectRequestType type,
            string name,
            bool? rapid = default,
            bool? studio = default,
            object? @params = default,
            global::ScaleAI.CreateProjectRequestPipeline? pipeline = default,
            int? consensusAttempts = default,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}