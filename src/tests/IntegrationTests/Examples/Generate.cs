/* order: 10, title: Getting Started, slug: getting-started */

namespace ScaleAI.IntegrationTests.Examples;

[TestClass]
public class GettingStarted
{
    //// Scale AI provides programmatic access to data labeling, RLHF, and AI evaluation.
    //// Create a client using your API key and interact with projects, tasks, and batches.

    [TestMethod]
    public void CreateClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SCALEAI_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("SCALEAI_API_KEY environment variable is not found.");

        using var client = new ScaleAIClient(apiKey);

        //// The client provides direct access to all Scale AI API endpoints.
        Assert.IsNotNull(client);
    }
}
