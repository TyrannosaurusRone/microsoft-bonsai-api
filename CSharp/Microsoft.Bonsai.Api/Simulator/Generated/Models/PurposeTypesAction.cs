// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bonsai.SimulatorApi.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for PurposeTypesAction.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PurposeTypesAction
    {
        [EnumMember(Value = "Inactive")]
        Inactive,
        [EnumMember(Value = "Debug")]
        Debug,
        [EnumMember(Value = "Train")]
        Train,
        [EnumMember(Value = "Assess")]
        Assess
    }
    internal static class PurposeTypesActionEnumExtension
    {
        internal static string ToSerializedValue(this PurposeTypesAction? value)
        {
            return value == null ? null : ((PurposeTypesAction)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this PurposeTypesAction value)
        {
            switch( value )
            {
                case PurposeTypesAction.Inactive:
                    return "Inactive";
                case PurposeTypesAction.Debug:
                    return "Debug";
                case PurposeTypesAction.Train:
                    return "Train";
                case PurposeTypesAction.Assess:
                    return "Assess";
            }
            return null;
        }

        internal static PurposeTypesAction? ParsePurposeTypesAction(this string value)
        {
            switch( value )
            {
                case "Inactive":
                    return PurposeTypesAction.Inactive;
                case "Debug":
                    return PurposeTypesAction.Debug;
                case "Train":
                    return PurposeTypesAction.Train;
                case "Assess":
                    return PurposeTypesAction.Assess;
            }
            return null;
        }
    }
}
