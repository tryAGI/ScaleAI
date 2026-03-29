namespace ScaleAI.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ScaleAIClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SCALEAI_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("SCALEAI_API_KEY environment variable is not found.");

        var client = new ScaleAIClient(apiKey);
        
        return client;
    }
}
