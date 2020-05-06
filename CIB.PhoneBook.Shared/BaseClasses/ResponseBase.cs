using System.Runtime.Serialization;

namespace CIB.PhoneBook.Shared.BaseClasses
{
    [DataContract(Namespace = "MotovateOnTheMove.Shared.CodeLibrary.BaseClasses", Name = "ResponseBase")]
    [KnownType(typeof(ResponseBase))]
    public class ResponseBase
    {
        [DataMember]
        public bool IsSuccess { get; set; }

        [DataMember]
        public string SuccessMessage { get; set; }

        [DataMember]
        public int? LocalErrorCode { get; set; }

        [DataMember]
        public string FriendlyErrorMessage { get; set; }

    }
}
