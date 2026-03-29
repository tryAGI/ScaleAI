
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// Pipeline type for Studio projects.
    /// </summary>
    public enum CreateProjectRequestPipeline
    {
        /// <summary>
        /// 
        /// </summary>
        ConsensusTask,
        /// <summary>
        /// 
        /// </summary>
        StandardTask,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectRequestPipelineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectRequestPipeline value)
        {
            return value switch
            {
                CreateProjectRequestPipeline.ConsensusTask => "consensus_task",
                CreateProjectRequestPipeline.StandardTask => "standard_task",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectRequestPipeline? ToEnum(string value)
        {
            return value switch
            {
                "consensus_task" => CreateProjectRequestPipeline.ConsensusTask,
                "standard_task" => CreateProjectRequestPipeline.StandardTask,
                _ => null,
            };
        }
    }
}