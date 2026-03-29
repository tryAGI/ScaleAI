
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// Type of attachment.
    /// </summary>
    public enum CreateTaskRequestAttachmentType
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
    public static class CreateTaskRequestAttachmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestAttachmentType value)
        {
            return value switch
            {
                CreateTaskRequestAttachmentType.Image => "image",
                CreateTaskRequestAttachmentType.Pdf => "pdf",
                CreateTaskRequestAttachmentType.Text => "text",
                CreateTaskRequestAttachmentType.Video => "video",
                CreateTaskRequestAttachmentType.Website => "website",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestAttachmentType? ToEnum(string value)
        {
            return value switch
            {
                "image" => CreateTaskRequestAttachmentType.Image,
                "pdf" => CreateTaskRequestAttachmentType.Pdf,
                "text" => CreateTaskRequestAttachmentType.Text,
                "video" => CreateTaskRequestAttachmentType.Video,
                "website" => CreateTaskRequestAttachmentType.Website,
                _ => null,
            };
        }
    }
}