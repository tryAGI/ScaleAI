#nullable enable

namespace ScaleAI.JsonConverters
{
    /// <inheritdoc />
    public sealed class TeamMemberRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ScaleAI.TeamMemberRole>
    {
        /// <inheritdoc />
        public override global::ScaleAI.TeamMemberRole Read(
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
                        return global::ScaleAI.TeamMemberRoleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ScaleAI.TeamMemberRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ScaleAI.TeamMemberRole);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ScaleAI.TeamMemberRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::ScaleAI.TeamMemberRoleExtensions.ToValueString(value));
        }
    }
}
