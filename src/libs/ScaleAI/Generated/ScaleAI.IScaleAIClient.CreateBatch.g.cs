#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Create a batch<br/>
        /// Create a new batch within a project for grouping tasks.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Batch> CreateBatchAsync(

            global::ScaleAI.CreateBatchRequest request,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a batch<br/>
        /// Create a new batch within a project for grouping tasks.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.AutoSDKHttpResponse<global::ScaleAI.Batch>> CreateBatchAsResponseAsync(

            global::ScaleAI.CreateBatchRequest request,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a batch<br/>
        /// Create a new batch within a project for grouping tasks.
        /// </summary>
        /// <param name="project">
        /// Project name to create this batch in.
        /// </param>
        /// <param name="name">
        /// Unique batch name identifier.
        /// </param>
        /// <param name="callback">
        /// Webhook URL or email for batch completion notification.
        /// </param>
        /// <param name="calibrationBatch">
        /// Whether this is a calibration batch (Rapid projects).
        /// </param>
        /// <param name="selfLabelBatch">
        /// Whether this is a self-label batch (Rapid projects).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Batch> CreateBatchAsync(
            string project,
            string name,
            string? callback = default,
            bool? calibrationBatch = default,
            bool? selfLabelBatch = default,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}