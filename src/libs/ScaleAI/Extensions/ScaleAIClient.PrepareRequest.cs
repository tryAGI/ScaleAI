#nullable enable

namespace ScaleAI;

public partial class ScaleAIClient
{
    /// <summary>
    /// Scale AI uses HTTP Basic Auth (API key as username, empty password).
    /// Convert the Bearer token to Basic auth header on each request.
    /// </summary>
    partial void PrepareRequest(
        global::System.Net.Http.HttpClient client,
        global::System.Net.Http.HttpRequestMessage request)
    {
        var apiKey = Authorizations.FirstOrDefault()?.Value;
        if (apiKey is { Length: > 0 })
        {
            // Scale AI Basic Auth: API key as username, empty password
            var credentials = global::System.Convert.ToBase64String(
                global::System.Text.Encoding.UTF8.GetBytes($"{apiKey}:"));

            request.Headers.Authorization =
                new global::System.Net.Http.Headers.AuthenticationHeaderValue("Basic", credentials);
        }
    }
}
