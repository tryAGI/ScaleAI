
#nullable enable

namespace ScaleAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextCollectionAttachment
    {
        /// <summary>
        /// Attachment type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScaleAI.JsonConverters.TextCollectionAttachmentTypeJsonConverter))]
        public global::ScaleAI.TextCollectionAttachmentType? Type { get; set; }

        /// <summary>
        /// Attachment content (text or URL).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextCollectionAttachment" /> class.
        /// </summary>
        /// <param name="type">
        /// Attachment type.
        /// </param>
        /// <param name="content">
        /// Attachment content (text or URL).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextCollectionAttachment(
            global::ScaleAI.TextCollectionAttachmentType? type,
            string? content)
        {
            this.Type = type;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextCollectionAttachment" /> class.
        /// </summary>
        public TextCollectionAttachment()
        {
        }

    }
}