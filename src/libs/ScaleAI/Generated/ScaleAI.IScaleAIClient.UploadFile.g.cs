#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Upload a file<br/>
        /// Upload a local file for use as task attachments.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.FileUploadResponse> UploadFileAsync(

            global::ScaleAI.UploadFileRequest request,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file<br/>
        /// Upload a local file for use as task attachments.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.AutoSDKHttpResponse<global::ScaleAI.FileUploadResponse>> UploadFileAsResponseAsync(

            global::ScaleAI.UploadFileRequest request,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file<br/>
        /// Upload a local file for use as task attachments.
        /// </summary>
        /// <param name="file">
        /// The file to upload.
        /// </param>
        /// <param name="filename">
        /// The file to upload.
        /// </param>
        /// <param name="displayName">
        /// Human-readable file name.
        /// </param>
        /// <param name="projectName">
        /// Project to associate the file with.
        /// </param>
        /// <param name="referenceId">
        /// Unique upload identifier for idempotency.
        /// </param>
        /// <param name="metadata">
        /// JSON string of additional metadata.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.FileUploadResponse> UploadFileAsync(
            byte[] file,
            string filename,
            string? displayName = default,
            string? projectName = default,
            string? referenceId = default,
            string? metadata = default,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a file<br/>
        /// Upload a local file for use as task attachments.
        /// </summary>
        /// <param name="file">
        /// The file to upload.
        /// </param>
        /// <param name="filename">
        /// The file to upload.
        /// </param>
        /// <param name="displayName">
        /// Human-readable file name.
        /// </param>
        /// <param name="projectName">
        /// Project to associate the file with.
        /// </param>
        /// <param name="referenceId">
        /// Unique upload identifier for idempotency.
        /// </param>
        /// <param name="metadata">
        /// JSON string of additional metadata.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.FileUploadResponse> UploadFileAsync(
            global::System.IO.Stream file,
            string filename,
            string? displayName = default,
            string? projectName = default,
            string? referenceId = default,
            string? metadata = default,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file<br/>
        /// Upload a local file for use as task attachments.
        /// </summary>
        /// <param name="file">
        /// The file to upload.
        /// </param>
        /// <param name="filename">
        /// The file to upload.
        /// </param>
        /// <param name="displayName">
        /// Human-readable file name.
        /// </param>
        /// <param name="projectName">
        /// Project to associate the file with.
        /// </param>
        /// <param name="referenceId">
        /// Unique upload identifier for idempotency.
        /// </param>
        /// <param name="metadata">
        /// JSON string of additional metadata.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.AutoSDKHttpResponse<global::ScaleAI.FileUploadResponse>> UploadFileAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            string? displayName = default,
            string? projectName = default,
            string? referenceId = default,
            string? metadata = default,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}