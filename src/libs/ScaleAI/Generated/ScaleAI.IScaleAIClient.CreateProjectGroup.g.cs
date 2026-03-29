#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Create a project group<br/>
        /// Create a new group within a Studio project.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateProjectGroupAsync(
            string projectName,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a project group<br/>
        /// Create a new group within a Studio project.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateProjectGroupAsync(
            string projectName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}