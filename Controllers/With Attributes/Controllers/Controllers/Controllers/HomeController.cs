using System.Web.Mvc;
using System.Web.SessionState;
namespace Controllers.Controllers
{
    [SessionState(SessionStateBehavior.Disabled)]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}