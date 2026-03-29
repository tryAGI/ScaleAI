#nullable enable

namespace ScaleAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class TextCollectionFieldTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ScaleAI.TextCollectionFieldType?>
    {
        /// <inheritdoc />
        public override global::ScaleAI.TextCollectionFieldType? Read(
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
                        return global::ScaleAI.TextCollectionFieldTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ScaleAI.TextCollectionFieldType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ScaleAI.TextCollectionFieldType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ScaleAI.TextCollectionFieldType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ScaleAI.TextCollectionFieldTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
