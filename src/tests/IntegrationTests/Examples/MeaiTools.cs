/* order: 20, title: MEAI Tools, slug: meai-tools */

namespace ScaleAI.IntegrationTests.Examples;

[TestClass]
public class MeaiTools
{
    //// Scale AI provides `AIFunction` tools that can be used with any `IChatClient`
    //// for function/tool calling scenarios.

    [TestMethod]
    public void CreateTools()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SCALEAI_API_KEY") is { Length: > 0 } value
                ? value
                : throw new AssertInconclusiveException("SCALEAI_API_KEY environment variable is not found.");

        using var client = new ScaleAIClient(apiKey);

        //// Create tools for projects, tasks, and batch status.
        var listProjectsTool = client.AsListProjectsTool();
        var getProjectTool = client.AsGetProjectTool();
        var listTasksTool = client.AsListTasksTool();
        var getTaskTool = client.AsGetTaskTool();
        var getBatchStatusTool = client.AsGetBatchStatusTool();

        Assert.AreEqual("ScaleAI_ListProjects", listProjectsTool.Name);
        Assert.AreEqual("ScaleAI_GetProject", getProjectTool.Name);
        Assert.AreEqual("ScaleAI_ListTasks", listTasksTool.Name);
        Assert.AreEqual("ScaleAI_GetTask", getTaskTool.Name);
        Assert.AreEqual("ScaleAI_GetBatchStatus", getBatchStatusTool.Name);

        //// These tools can be passed to any IChatClient that supports function calling.
        var tools = new[] { listProjectsTool, getProjectTool, listTasksTool, getTaskTool, getBatchStatusTool };
        Assert.AreEqual(5, tools.Length);
    }
}
