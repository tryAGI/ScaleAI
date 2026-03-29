
#nullable enable

namespace ScaleAI
{
    public sealed partial class ScaleAIClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingBearer(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::ScaleAI.EndPointAuthorization
            {
                Type = "Http",
                Location = "Header",
                Name = "Bearer",
                Value = apiKey,
            });
        }
    }
}