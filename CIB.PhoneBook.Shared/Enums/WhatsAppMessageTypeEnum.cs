using System.ComponentModel;
using System.Runtime.Serialization;

namespace CIB.PhoneBook.Shared.Enums
{
    [DataContract(Namespace = "CIB.PhoneBook.Shared.Enums", Name = "WhatsAppMessageTypeEnum")]
    public enum WhatsAppMessageTypeEnum
    {
        [Description("TextMessage"), EnumMember(Value = "Text Message")]
        TextMessage = 0,
        [Description("Image"), EnumMember(Value = "Image")]
        Image = 1,
        [Description("Link"), EnumMember(Value = "Link")]
        Link = 2,
        [Description("Media"), EnumMember(Value = "Media")]
        Media = 3,
    }
}
