using System.ComponentModel;
using System.Runtime.Serialization;

namespace CIB.WhatsAppApi.WebHook.Enums
{
    [DataContract(Namespace = "CIB.WhatsAppApi.WebHook.Enums", Name = "AckStatusEnum")]
    public enum AckStatusEnum
    {
        [Description("Message still not sent to WhatsApp servers"), EnumMember(Value = "MessageNotSent")]
        MessageNotSent = 0,
        [Description("Message sent to WhatsApp servers"), EnumMember(Value = "MessageSent")]
        MessageSent = 1,
        [Description("Message delivered to recipient"), EnumMember(Value = "MessageDelivered")]
        MessageDelivered = 2,
        [Description("Message read by recipient"), EnumMember(Value = "MessageRead")]
        MessageRead = 3,
    }
}