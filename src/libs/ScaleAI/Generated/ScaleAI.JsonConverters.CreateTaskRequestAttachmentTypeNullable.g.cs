#nullable enable

namespace ScaleAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTaskRequestAttachmentTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ScaleAI.CreateTaskRequestAttachmentType?>
    {
        /// <inheritdoc />
        public override global::ScaleAI.CreateTaskRequestAttachmentType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::ScaleAI.CreateTaskRequestAttachmentTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ScaleAI.CreateTaskRequestAttachmentType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ScaleAI.CreateTaskRequestAttachmentType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ScaleAI.CreateTaskRequestAttachmentType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ScaleAI.CreateTaskRequestAttachmentTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
