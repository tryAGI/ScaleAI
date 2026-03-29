#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// List Studio batches<br/>
        /// Get a list of all Studio batches.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListStudioBatchesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}