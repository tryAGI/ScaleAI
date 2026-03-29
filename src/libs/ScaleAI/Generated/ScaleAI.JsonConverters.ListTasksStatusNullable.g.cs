#nullable enable

namespace ScaleAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListTasksStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ScaleAI.ListTasksStatus?>
    {
        /// <inheritdoc />
        public override global::ScaleAI.ListTasksStatus? Read(
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
                        return global::ScaleAI.ListTasksStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ScaleAI.ListTasksStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ScaleAI.ListTasksStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ScaleAI.ListTasksStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ScaleAI.ListTasksStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
