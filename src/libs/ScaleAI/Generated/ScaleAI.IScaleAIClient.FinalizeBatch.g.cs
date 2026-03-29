#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Finalize a batch<br/>
        /// Finalize a batch to indicate no more tasks will be added and begin processing.
        /// </summary>
        /// <param name="batchName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Batch> FinalizeBatchAsync(
            string batchName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}