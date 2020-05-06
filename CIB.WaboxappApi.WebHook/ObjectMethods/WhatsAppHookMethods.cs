using System.Configuration;
using CIB.PhoneBook.Shared.Models;
using CIB.PhoneBook.Shared.Utilities;

namespace CIB.WhatsAppApi.WebHook.ObjectMethods
{
    public static class WhatsAppHookMethods
    {
        private static WcfProxy Proxy { get; } = new WcfProxy();

        public static WhatsAppHookMessageDto Create(WhatsAppHookMessageDto dto)
        {
        //    return Proxy.PerformRemote<IWhatsAppHookService, WhatsAppHookMessageDto>(x => x.Create(dto, new CrudRequest
        //    {
        //        IdDealer  = ConfigurationManager.AppSettings["IdDealer"].ToInt(),
        //        Username = "System",
        //        RequestUrl = HttpContext.Current.Request.Url?.AbsoluteUri,
        //        IdChangedBy = UserMethods.GetByUsernameAndIdDealer("System", ConfigurationManager.AppSettings["IdDealer"].ToInt()).ID,
        //        DealerName = ConfigurationManager.AppSettings["DealerName"],
        //        Browser = UserMethods.GetBrowser(),
        //        BrowserVersion = UserMethods.GetBrowserVersion(),
        //        IpAddress = UserMethods.GetUserIp(),
        //        UserAgent = UserMethods.GetUserAgent(),
        //}));
        }
    }
}