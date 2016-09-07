using StarWars.Infrastructure;
using System.Web.Mvc;

namespace StarWars.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                id = 0;
            }
            var user = Repository.Get(id.Value);
            if (user != null)
            {
                return View("PersonView",user);
            }
            return new HttpNotFoundResult();
        }

        [ChildActionOnly]
        public ActionResult Footer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ChangeSide(int? id)
        {
            var user = Repository.Get(id.Value);
            if (user.Fraction == Fraction.Empire)
            {
                user.Fraction = Fraction.Rebels;
            }
            else
            {
                user.Fraction = Fraction.Empire;
            }
            return new EmptyResult();
        }
    }
}