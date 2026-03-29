#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Set Studio batch priorities<br/>
        /// Set the priorities of Studio batches.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SetStudioBatchPrioritiesAsync(

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Studio batch priorities<br/>
        /// Set the priorities of Studio batches.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SetStudioBatchPrioritiesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}