using Controllers.Infrastructure;
using System.Linq;
using System.Web.Mvc;

namespace Controllers.Controllers
{
    public class AdminController : Controller
    {
		[HttpGet]
        public ActionResult Edit(int id)
        {
            var user = Repository.Users.SingleOrDefault(u => u.Id == id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User model)
        {
            var user = Repository.Users.Single(u => u.Id == model.Id);
            user.Name = model.Name;
            user.Surname = model.Surname;
            return View();
        }
    }
}