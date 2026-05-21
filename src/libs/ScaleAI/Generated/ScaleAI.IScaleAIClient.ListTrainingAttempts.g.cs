#nullable enable

namespace ScaleAI
{
    public partial interface IScaleAIClient
    {
        /// <summary>
        /// List training attempts<br/>
        /// Get a list of labeler training attempts for quality management.
        /// </summary>
        /// <param name="qualityTaskIds"></param>
        /// <param name="labelerEmails"></param>
        /// <param name="nextToken"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListTrainingAttemptsAsync(
            global::System.Collections.Generic.IList<string>? qualityTaskIds = default,
            global::System.Collections.Generic.IList<string>? labelerEmails = default,
            string? nextToken = default,
            int? limit = default,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List training attempts<br/>
        /// Get a list of labeler training attempts for quality management.
        /// </summary>
        /// <param name="qualityTaskIds"></param>
        /// <param name="labelerEmails"></param>
        /// <param name="nextToken"></param>
        /// <param name="limit"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::ScaleAI.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::ScaleAI.AutoSDKHttpResponse<string>> ListTrainingAttemptsAsResponseAsync(
            global::System.Collections.Generic.IList<string>? qualityTaskIds = default,
            global::System.Collections.Generic.IList<string>? labelerEmails = default,
            string? nextToken = default,
            int? limit = default,
            global::ScaleAI.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}