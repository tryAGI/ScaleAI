#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// List all projects<br/>
        /// Returns a list of all projects in your account.
        /// </summary>
        /// <param name="archived"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ScaleAI.Project>> ListProjectsAsync(
            bool? archived = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}