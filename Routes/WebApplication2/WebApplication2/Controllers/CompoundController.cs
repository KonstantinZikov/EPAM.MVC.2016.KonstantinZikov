using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class CompoundController : Controller
    {        
        public ActionResult Index(int data)
        {
            return View();
        }
    }
}