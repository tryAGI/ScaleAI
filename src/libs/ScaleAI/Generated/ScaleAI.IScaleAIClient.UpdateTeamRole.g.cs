#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Update teammate role<br/>
        /// Update the role of existing team members.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ScaleAI.TeamMember>> UpdateTeamRoleAsync(

            global::ScaleAI.SetRoleRequest request,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update teammate role<br/>
        /// Update the role of existing team members.
        /// </summary>
        /// <param name="emails">
        /// Email addresses to update.
        /// </param>
        /// <param name="teamRole">
        /// New role to assign.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ScaleAI.TeamMember>> UpdateTeamRoleAsync(
            global::System.Collections.Generic.IList<string> emails,
            global::ScaleAI.SetRoleRequestTeamRole teamRole,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}