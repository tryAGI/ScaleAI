#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// List all assignments<br/>
        /// Get a list of all Studio project assignments.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListAssignmentsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}