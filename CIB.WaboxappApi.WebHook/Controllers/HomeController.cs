

using System.Web.Mvc;

namespace CIB.WhatsAppApi.WebHook.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
