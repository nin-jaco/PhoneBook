using System;

namespace CIB.WhatsAppApi.WebHook.Models
{
    [Serializable]
    public class OMessage
    {
        public string @event { get; set; }
        public string token { get; set; }
        public string uid { get; set; }
        public contact contact { get; set; }
        public message message { get; set; }
        
    }
}