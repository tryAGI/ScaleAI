
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace ScaleAI
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::ScaleAI.JsonConverters.CreateProjectRequestTypeJsonConverter),

            typeof(global::ScaleAI.JsonConverters.CreateProjectRequestTypeNullableJsonConverter),

            typeof(global::ScaleAI.JsonConverters.CreateProjectRequestPipelineJsonConverter),

            typeof(global::ScaleAI.JsonConverters.CreateProjectRequestPipelineNullableJsonConverter),

            typeof(global::ScaleAI.JsonConverters.BatchStatusJsonConverter),

            typeof(global::ScaleAI.JsonConverters.BatchStatusNullableJsonConverter),

            typeof(global::ScaleAI.JsonConverters.BatchStatusStatusJsonConverter),

            typeof(global::ScaleAI.JsonConverters.BatchStatusStatusNullableJsonConverter),

            typeof(global::ScaleAI.JsonConverters.TaskStatusJsonConverter),

            typeof(global::ScaleAI.JsonConverters.TaskStatusNullableJsonConverter),

            typeof(global::ScaleAI.JsonConverters.TaskCustomerReviewStatusJsonConverter),

            typeof(global::ScaleAI.JsonConverters.TaskCustomerReviewStatusNullableJsonConverter),

            typeof(global::ScaleAI.JsonConverters.CreateTaskRequestAttachmentTypeJsonConverter),

            typeof(global::ScaleAI.JsonConverters.CreateTaskRequestAttachmentTypeNullableJsonConverter),

            typeof(global::ScaleAI.JsonConverters.TeamMemberRoleJsonConverter),

            typeof(global::ScaleAI.JsonConverters.TeamMemberRoleNullableJsonConverter),

            typeof(global::ScaleAI.JsonConverters.InviteTeamRequestTeamRoleJsonConverter),

            typeof(global::ScaleAI.JsonConverters.InviteTeamRequestTeamRoleNullableJsonConverter),

            typeof(global::ScaleAI.JsonConverters.SetRoleRequestTeamRoleJsonConverter),

            typeof(global::ScaleAI.JsonConverters.SetRoleRequestTeamRoleNullableJsonConverter),

            typeof(global::ScaleAI.JsonConverters.TextCollectionFieldTypeJsonConverter),

            typeof(global::ScaleAI.JsonConverters.TextCollectionFieldTypeNullableJsonConverter),

            typeof(global::ScaleAI.JsonConverters.TextCollectionAttachmentTypeJsonConverter),

            typeof(global::ScaleAI.JsonConverters.TextCollectionAttachmentTypeNullableJsonConverter),

            typeof(global::ScaleAI.JsonConverters.ListBatchesStatusJsonConverter),

            typeof(global::ScaleAI.JsonConverters.ListBatchesStatusNullableJsonConverter),

            typeof(global::ScaleAI.JsonConverters.ListTasksStatusJsonConverter),

            typeof(global::ScaleAI.JsonConverters.ListTasksStatusNullableJsonConverter),

            typeof(global::ScaleAI.JsonConverters.ListTasksCustomerReviewStatusJsonConverter),

            typeof(global::ScaleAI.JsonConverters.ListTasksCustomerReviewStatusNullableJsonConverter),

            typeof(global::ScaleAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.Project))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScaleAI.ParamHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.ParamHistory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.CreateProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.CreateProjectRequestType), TypeInfoPropertyName = "CreateProjectRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.CreateProjectRequestPipeline), TypeInfoPropertyName = "CreateProjectRequestPipeline2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.UpdateProjectParamsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.Batch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.BatchStatus), TypeInfoPropertyName = "BatchStatus2_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.CreateBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.BatchStatus2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.BatchStatusStatus), TypeInfoPropertyName = "BatchStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.BatchPrioritizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.BatchListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScaleAI.Batch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.Task))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.TaskStatus), TypeInfoPropertyName = "TaskStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.TaskCustomerReviewStatus), TypeInfoPropertyName = "TaskCustomerReviewStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.CreateTaskRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.CreateTaskRequestAttachmentType), TypeInfoPropertyName = "CreateTaskRequestAttachmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.TaskListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScaleAI.Task>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.SetMetadataRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.UpdateUniqueIdRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.FileUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.TeamMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.TeamMemberRole), TypeInfoPropertyName = "TeamMemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.InviteTeamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.InviteTeamRequestTeamRole), TypeInfoPropertyName = "InviteTeamRequestTeamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.SetRoleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.SetRoleRequestTeamRole), TypeInfoPropertyName = "SetRoleRequestTeamRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.AssignTeamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.UnassignTeamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.TextCollectionField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.TextCollectionFieldType), TypeInfoPropertyName = "TextCollectionFieldType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.TextCollectionAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.TextCollectionAttachmentType), TypeInfoPropertyName = "TextCollectionAttachmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.CreateTextCollectionTaskRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScaleAI.TextCollectionField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScaleAI.TextCollectionAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.SuccessResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.UploadFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.ImportFileRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.ListBatchesStatus), TypeInfoPropertyName = "ListBatchesStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.ListTasksStatus), TypeInfoPropertyName = "ListTasksStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ScaleAI.ListTasksCustomerReviewStatus), TypeInfoPropertyName = "ListTasksCustomerReviewStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScaleAI.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ScaleAI.TeamMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScaleAI.ParamHistory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScaleAI.Batch>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScaleAI.Task>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScaleAI.TextCollectionField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScaleAI.TextCollectionAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScaleAI.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ScaleAI.TeamMember>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}