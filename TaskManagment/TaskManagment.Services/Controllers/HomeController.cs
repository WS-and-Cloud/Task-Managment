using System.Web.Mvc;

namespace TaskManagment.Services.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}