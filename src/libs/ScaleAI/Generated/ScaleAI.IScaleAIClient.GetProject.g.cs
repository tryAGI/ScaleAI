#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Retrieve a project<br/>
        /// Get details of a specific project by name.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Project> GetProjectAsync(
            string projectName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}