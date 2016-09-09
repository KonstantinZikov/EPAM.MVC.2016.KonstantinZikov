using System.Reflection;
using System.Web.Mvc;

namespace Controllers.Infrastructure.Attributes
{
    public class LocalAttribute : ActionMethodSelectorAttribute
    {
        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            return controllerContext.RequestContext.HttpContext.Request.IsLocal;
        }
    }
}