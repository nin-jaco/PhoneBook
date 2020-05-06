namespace CIB.WhatsAppApi.WebHook.Models
{
    public class body
    {
        //text
        public string text { get; set; }
        //others
        public string caption { get; set; }
        public string mimetype { get; set; }
        public int size { get; set; }
        public string thumb { get; set; }
        public string url { get; set; }
        //audio
        public int duration { get; set; }
        //vcard
        public string contact { get; set; }
        public string vCard { get; set; }
        //location
        public string name { get; set; }
        public string lng { get; set; }
        public string lat { get; set; }
    }
}