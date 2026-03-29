#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// List all teammates<br/>
        /// Get a list of all team members in your Scale account.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::ScaleAI.TeamMember>> ListTeamMembersAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}