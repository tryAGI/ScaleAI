
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextCollectionField
    {
        /// <summary>
        /// Unique field identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FieldId { get; set; }

        /// <summary>
        /// Field type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ScaleAI.JsonConverters.TextCollectionFieldTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ScaleAI.TextCollectionFieldType Type { get; set; }

        /// <summary>
        /// Field title.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Field description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Choices for category-type fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<string>? Choices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextCollectionField" /> class.
        /// </summary>
        /// <param name="fieldId">
        /// Unique field identifier.
        /// </param>
        /// <param name="type">
        /// Field type.
        /// </param>
        /// <param name="title">
        /// Field title.
        /// </param>
        /// <param name="description">
        /// Field description.
        /// </param>
        /// <param name="choices">
        /// Choices for category-type fields.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextCollectionField(
            string fieldId,
            global::ScaleAI.TextCollectionFieldType type,
            string title,
            string? description,
            global::System.Collections.Generic.IList<string>? choices)
        {
            this.FieldId = fieldId ?? throw new global::System.ArgumentNullException(nameof(fieldId));
            this.Type = type;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description;
            this.Choices = choices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextCollectionField" /> class.
        /// </summary>
        public TextCollectionField()
        {
        }

    }
}