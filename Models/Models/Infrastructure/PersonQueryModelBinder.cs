using System.Web.Mvc;

namespace Models.Infrastructure
{
    public class PersonQueryFormModelBinder : BasePersonModelBinder
    {
        protected override string GetValue(string key, ControllerContext context)
        {
            return context.HttpContext.Request.QueryString[key];
        }
    }
}