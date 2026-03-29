
#nullable enable

namespace ScaleAI
{
    /// <summary>
    /// Task type: imageannotation, textcollection, namedentityrecognition, etc.
    /// </summary>
    public enum CreateProjectRequestType
    {
        /// <summary>
        /// 
        /// </summary>
        Audiotranscription,
        /// <summary>
        /// 
        /// </summary>
        Categorization,
        /// <summary>
        /// 
        /// </summary>
        Comparison,
        /// <summary>
        /// 
        /// </summary>
        Cuboidannotation,
        /// <summary>
        /// 
        /// </summary>
        Datacollection,
        /// <summary>
        /// 
        /// </summary>
        Documenttranscription,
        /// <summary>
        /// imageannotation, textcollection, namedentityrecognition, etc.
        /// </summary>
        Imageannotation,
        /// <summary>
        /// 
        /// </summary>
        Lidarsegmentation,
        /// <summary>
        /// 
        /// </summary>
        Lidartopdown,
        /// <summary>
        /// 
        /// </summary>
        Lineannotation,
        /// <summary>
        /// imageannotation, textcollection, namedentityrecognition, etc.
        /// </summary>
        Namedentityrecognition,
        /// <summary>
        /// 
        /// </summary>
        Pointannotation,
        /// <summary>
        /// 
        /// </summary>
        Polyannotation,
        /// <summary>
        /// 
        /// </summary>
        Segmentannotation,
        /// <summary>
        /// imageannotation, textcollection, namedentityrecognition, etc.
        /// </summary>
        Textcollection,
        /// <summary>
        /// 
        /// </summary>
        Videoannotation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectRequestType value)
        {
            return value switch
            {
                CreateProjectRequestType.Audiotranscription => "audiotranscription",
                CreateProjectRequestType.Categorization => "categorization",
                CreateProjectRequestType.Comparison => "comparison",
                CreateProjectRequestType.Cuboidannotation => "cuboidannotation",
                CreateProjectRequestType.Datacollection => "datacollection",
                CreateProjectRequestType.Documenttranscription => "documenttranscription",
                CreateProjectRequestType.Imageannotation => "imageannotation",
                CreateProjectRequestType.Lidarsegmentation => "lidarsegmentation",
                CreateProjectRequestType.Lidartopdown => "lidartopdown",
                CreateProjectRequestType.Lineannotation => "lineannotation",
                CreateProjectRequestType.Namedentityrecognition => "namedentityrecognition",
                CreateProjectRequestType.Pointannotation => "pointannotation",
                CreateProjectRequestType.Polyannotation => "polyannotation",
                CreateProjectRequestType.Segmentannotation => "segmentannotation",
                CreateProjectRequestType.Textcollection => "textcollection",
                CreateProjectRequestType.Videoannotation => "videoannotation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectRequestType? ToEnum(string value)
        {
            return value switch
            {
                "audiotranscription" => CreateProjectRequestType.Audiotranscription,
                "categorization" => CreateProjectRequestType.Categorization,
                "comparison" => CreateProjectRequestType.Comparison,
                "cuboidannotation" => CreateProjectRequestType.Cuboidannotation,
                "datacollection" => CreateProjectRequestType.Datacollection,
                "documenttranscription" => CreateProjectRequestType.Documenttranscription,
                "imageannotation" => CreateProjectRequestType.Imageannotation,
                "lidarsegmentation" => CreateProjectRequestType.Lidarsegmentation,
                "lidartopdown" => CreateProjectRequestType.Lidartopdown,
                "lineannotation" => CreateProjectRequestType.Lineannotation,
                "namedentityrecognition" => CreateProjectRequestType.Namedentityrecognition,
                "pointannotation" => CreateProjectRequestType.Pointannotation,
                "polyannotation" => CreateProjectRequestType.Polyannotation,
                "segmentannotation" => CreateProjectRequestType.Segmentannotation,
                "textcollection" => CreateProjectRequestType.Textcollection,
                "videoannotation" => CreateProjectRequestType.Videoannotation,
                _ => null,
            };
        }
    }
}