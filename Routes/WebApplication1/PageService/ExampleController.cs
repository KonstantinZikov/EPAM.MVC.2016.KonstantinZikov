using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PageService.Controllers
{
    public class ExampleController : Controller
    {
        public ActionResult Index(string data)
        {
            data = data ?? "null";
            ViewBag.data = "data: " + data;
            return View();
        }
    }
}
