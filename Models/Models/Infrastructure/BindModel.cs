using Models.Models;
using System.Web.Mvc;

namespace Models.Infrastructure
{
    public class CustomBiner : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            Address model = (Address)bindingContext.Model ?? new Address();

            model.City = GetValue(bindingContext, "City");
            model.Country = GetValue(bindingContext, "Country");
            return model;
        }

        private string GetValue(ModelBindingContext context, string name)
        {
            name = (context.ModelName == "" ? "" : context.ModelName + ".") + name;
            ValueProviderResult result = context.ValueProvider.GetValue(name);

            if (result == null || result.AttemptedValue == "")
            {
                return "<Not Specified>";
            }

            return result.AttemptedValue;
        }
    }
}