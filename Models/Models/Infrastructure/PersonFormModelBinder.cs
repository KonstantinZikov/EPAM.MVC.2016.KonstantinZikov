using System.Web.Mvc;

namespace Models.Infrastructure
{
    public class PersonFormModelBinder : BasePersonModelBinder
    {
        protected override string GetValue(string key, ControllerContext context)
        {
            return context.HttpContext.Request.Form[key];
        }
    }
}