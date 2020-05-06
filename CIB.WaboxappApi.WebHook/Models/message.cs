namespace CIB.WhatsAppApi.WebHook.Models
{
    public class message
    {
        public string dtm { get; set; }
        public string uid { get; set; }
        public string cuid { get; set; }
        public string dir { get; set; }
        public string type { get; set; }
        public body body { get; set; }
        public string ack { get; set; }

        
    }
}