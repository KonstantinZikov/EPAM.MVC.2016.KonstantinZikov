using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace JsonService.Controllers
{
    public class ExampleController : Controller
    {
        public ActionResult Index(string data)
        {
            data = data ?? "null";
            var result = new JsonResult();
            result.Data = "Json: " + data;
            return result;
        }
    }
}
