#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Import a file from URL<br/>
        /// Import a file from a URL for use as task attachments.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.FileUploadResponse> ImportFileAsync(

            global::ScaleAI.ImportFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Import a file from URL<br/>
        /// Import a file from a URL for use as task attachments.
        /// </summary>
        /// <param name="fileUrl">
        /// URL of the file to import.
        /// </param>
        /// <param name="projectName">
        /// Project to associate the file with.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.FileUploadResponse> ImportFileAsync(
            string fileUrl,
            string? projectName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}