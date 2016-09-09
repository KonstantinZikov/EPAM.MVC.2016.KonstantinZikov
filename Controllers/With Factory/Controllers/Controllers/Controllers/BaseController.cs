using System.Web.Mvc;

namespace Controllers.Controllers
{
    public class BaseController : Controller
    {
        protected override void HandleUnknownAction(string actionName)
        {
            Response.Write("<h1>404!! PAGE NOT FOUND</h1>");
        }
    }
}