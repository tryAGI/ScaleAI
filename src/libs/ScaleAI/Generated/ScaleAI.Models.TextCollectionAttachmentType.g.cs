
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// Attachment type.
    /// </summary>
    public enum TextCollectionAttachmentType
    {
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Pdf,
        /// <summary>
        ///
        /// </summary>
        Text,
        /// <summary>
        ///
        /// </summary>
        Video,
        /// <summary>
        ///
        /// </summary>
        Website,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextCollectionAttachmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextCollectionAttachmentType value)
        {
            return value switch
            {
                TextCollectionAttachmentType.Image => "image",
                TextCollectionAttachmentType.Pdf => "pdf",
                TextCollectionAttachmentType.Text => "text",
                TextCollectionAttachmentType.Video => "video",
                TextCollectionAttachmentType.Website => "website",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextCollectionAttachmentType? ToEnum(string value)
        {
            return value switch
            {
                "image" => TextCollectionAttachmentType.Image,
                "pdf" => TextCollectionAttachmentType.Pdf,
                "text" => TextCollectionAttachmentType.Text,
                "video" => TextCollectionAttachmentType.Video,
                "website" => TextCollectionAttachmentType.Website,
                _ => null,
            };
        }
    }
}