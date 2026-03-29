#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Retrieve a batch<br/>
        /// Get details of a specific batch by name.
        /// </summary>
        /// <param name="batchName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Batch> GetBatchAsync(
            string batchName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}