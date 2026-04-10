#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Assign teammates to projects<br/>
        /// Assign team members to Studio projects.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> AssignTeammatesAsync(

            global::ScaleAI.AssignTeamRequest request,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Assign teammates to projects<br/>
        /// Assign team members to Studio projects.
        /// </summary>
        /// <param name="emails">
        /// Email addresses of teammates.
        /// </param>
        /// <param name="projects">
        /// Project names to assign to.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> AssignTeammatesAsync(
            global::System.Collections.Generic.IList<string> emails,
            global::System.Collections.Generic.IList<string> projects,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}