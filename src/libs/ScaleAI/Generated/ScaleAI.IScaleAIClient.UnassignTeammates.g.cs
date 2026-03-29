#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Unassign teammates from projects<br/>
        /// Remove team members from Studio project assignments.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UnassignTeammatesAsync(

            global::ScaleAI.UnassignTeamRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unassign teammates from projects<br/>
        /// Remove team members from Studio project assignments.
        /// </summary>
        /// <param name="emails">
        /// Email addresses of teammates.
        /// </param>
        /// <param name="projects">
        /// Project names to unassign from.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UnassignTeammatesAsync(
            global::System.Collections.Generic.IList<string> emails,
            global::System.Collections.Generic.IList<string>? projects = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}