
#nullable enable

namespace ScaleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class FileUploadResponse
    {
        /// <summary>
        /// File identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// File display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// URL of the uploaded file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// File identifier.
        /// </param>
        /// <param name="name">
        /// File display name.
        /// </param>
        /// <param name="fileUrl">
        /// URL of the uploaded file.
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of upload.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileUploadResponse(
            string? id,
            string? name,
            string? fileUrl,
            global::System.DateTime? createdAt)
        {
            this.Id = id;
            this.Name = name;
            this.FileUrl = fileUrl;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadResponse" /> class.
        /// </summary>
        public FileUploadResponse()
        {
        }

    }
}