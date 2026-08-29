
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// Field type.
    /// </summary>
    public enum TextCollectionFieldType
    {
        /// <summary>
        ///
        /// </summary>
        Category,
        /// <summary>
        ///
        /// </summary>
        Number,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextCollectionFieldTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextCollectionFieldType value)
        {
            return value switch
            {
                TextCollectionFieldType.Category => "category",
                TextCollectionFieldType.Number => "number",
                TextCollectionFieldType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextCollectionFieldType? ToEnum(string value)
        {
            return value switch
            {
                "category" => TextCollectionFieldType.Category,
                "number" => TextCollectionFieldType.Number,
                "text" => TextCollectionFieldType.Text,
                _ => null,
            };
        }
    }
}