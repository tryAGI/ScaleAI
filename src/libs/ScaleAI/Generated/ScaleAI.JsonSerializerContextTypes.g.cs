
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace ScaleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.Project? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScaleAI.ParamHistory>? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.ParamHistory? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.CreateProjectRequest? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.CreateProjectRequestType? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.CreateProjectRequestPipeline? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.UpdateProjectParamsRequest? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.Batch? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.BatchStatus? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.CreateBatchRequest? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.BatchStatus2? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.BatchStatusStatus? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.BatchPrioritizeRequest? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.BatchListResponse? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScaleAI.Batch>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.Task? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.TaskStatus? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.TaskCustomerReviewStatus? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.CreateTaskRequest? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.CreateTaskRequestAttachmentType? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.TaskListResponse? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScaleAI.Task>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.SetMetadataRequest? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.UpdateUniqueIdRequest? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.FileUploadResponse? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.TeamMember? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.TeamMemberRole? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.InviteTeamRequest? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.InviteTeamRequestTeamRole? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.SetRoleRequest? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.SetRoleRequestTeamRole? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.AssignTeamRequest? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.UnassignTeamRequest? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.TextCollectionField? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.TextCollectionFieldType? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.TextCollectionAttachment? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.TextCollectionAttachmentType? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.CreateTextCollectionTaskRequest? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScaleAI.TextCollectionField>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScaleAI.TextCollectionAttachment>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.SuccessResponse? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.ErrorResponse? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.UploadFileRequest? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public byte[]? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.ImportFileRequest? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.ListBatchesStatus? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.ListTasksStatus? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::ScaleAI.ListTasksCustomerReviewStatus? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScaleAI.Project>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ScaleAI.TeamMember>? Type55 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ScaleAI.ParamHistory>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ScaleAI.Batch>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ScaleAI.Task>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ScaleAI.TextCollectionField>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ScaleAI.TextCollectionAttachment>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ScaleAI.Project>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::ScaleAI.TeamMember>? ListType7 { get; set; }
    }
}