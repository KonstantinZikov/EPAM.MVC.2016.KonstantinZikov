using Controllers.Infrastructure;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Controllers.Controllers
{
    public class CustomerController : Controller
    {
        [ActionName("Add-User")]
        public ActionResult AddUser()
        {
            return View("AddUser");
        }

        [HttpPost]
        [ActionName("Add-User")]
        public async Task<ActionResult> AddUser(User model)
        {
            await Task.Run(() => {
                model.Id = ++Repository.Count;
                Repository.Users.Add(model);
                Thread.Sleep(1000);
            });
            return View("AddUser");
        }

        [ActionName("User-List")]
        public ActionResult UserList()
        {
            return View("UserList",Repository.Users);
        }

        [HttpPost]
        [ActionName("User-List")]
        public ActionResult UserListPost()
        {
            var result = new JsonResult();
            result.Data = Repository.Users;
            return result;
        }
    }
}