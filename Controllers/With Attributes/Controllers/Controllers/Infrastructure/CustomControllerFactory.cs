using Controllers.Controllers;
using System;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace Controllers.Infrastructure
{
    public class CustomControllerFactory : IControllerFactory
    {
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            Type type = null;
            switch (controllerName)
            {
                case "User":
                    requestContext.RouteData.Values["controller"] = "Customer";
                    goto customer;
                case "Customer":
                    customer:
                    type = typeof(CustomerController);
                    break;
                case "Home":
                    type = typeof(HomeController);
                    break;
                case "Admin":
                    type = typeof(AdminController);
                    break;
                default:
                    type = typeof(BaseController);
                    break;
            }
            return Activator.CreateInstance(type) as IController;
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
            => SessionStateBehavior.Default;
        

        public void ReleaseController(IController controller)        
           => (controller as IDisposable)?.Dispose();
        
    }
}