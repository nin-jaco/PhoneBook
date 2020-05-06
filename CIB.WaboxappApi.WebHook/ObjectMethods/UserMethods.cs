using System.Web;
using CIB.PhoneBook.Shared.Utilities;

namespace CIB.WhatsAppApi.WebHook.ObjectMethods
{
    public static class UserMethods
    {
        private static WcfProxy Proxy { get; } = new WcfProxy();

        
        public static string GetBrowserVersion()
        {
            return System.Web.HttpContext.Current.Request.Browser.Version;
        }

        public static string GetBrowser()
        {
            return System.Web.HttpContext.Current.Request.Browser.Browser;
        }

        public static string GetUserAgent()
        {
            return System.Web.HttpContext.Current.Request.UserAgent;
        }

        public static string GetRequestUrl()
        {
            return HttpContext.Current.Request.Url?.AbsoluteUri;
        }

        public static string GetUserIp()
        {
            string ipList = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_CLUSTER_CLIENT_IP"];

            if (!string.IsNullOrEmpty(ipList))
            {
                return ipList.Split(',')[0];
            }

            ipList = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipList))
            {
                return ipList.Split(',')[0];
            }

            return HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
        }

        
    }
}