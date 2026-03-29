#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Reset Studio batch priorities<br/>
        /// Reset all Studio batch priorities to defaults.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ResetStudioBatchPrioritiesAsync(

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reset Studio batch priorities<br/>
        /// Reset all Studio batch priorities to defaults.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ResetStudioBatchPrioritiesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}