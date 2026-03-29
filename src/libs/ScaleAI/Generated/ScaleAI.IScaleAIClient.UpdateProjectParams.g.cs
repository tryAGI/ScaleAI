#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Update project parameters<br/>
        /// Update default parameters for a project. Creates a new version in param_history.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Project> UpdateProjectParamsAsync(
            string projectName,

            global::ScaleAI.UpdateProjectParamsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update project parameters<br/>
        /// Update default parameters for a project. Creates a new version in param_history.
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="patch">
        /// If true, merge with existing params instead of replacing.
        /// </param>
        /// <param name="instruction">
        /// Instruction text to append to task instructions.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.Project> UpdateProjectParamsAsync(
            string projectName,
            bool? patch = default,
            string? instruction = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}