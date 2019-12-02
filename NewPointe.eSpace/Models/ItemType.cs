using System.Runtime.Serialization;

namespace NewPointe.eSpace.Models
{
    public enum ItemType
    {
        [EnumMember(Value = "Space")]
        SPACE,

        [EnumMember(Value = "Resource")]
        RESOURCE,

        [EnumMember(Value = "Service")]
        SERVICE
    }
}
