#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// Invite teammates<br/>
        /// Invite new teammates to your Scale account by email.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ScaleAI.TeamMember>> InviteTeamMembersAsync(

            global::ScaleAI.InviteTeamRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invite teammates<br/>
        /// Invite new teammates to your Scale account by email.
        /// </summary>
        /// <param name="emails">
        /// Email addresses to invite.
        /// </param>
        /// <param name="teamRole">
        /// Role to assign.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ScaleAI.TeamMember>> InviteTeamMembersAsync(
            global::System.Collections.Generic.IList<string> emails,
            global::ScaleAI.InviteTeamRequestTeamRole teamRole,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}