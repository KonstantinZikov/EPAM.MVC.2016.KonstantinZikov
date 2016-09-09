using System.Web.Mvc;

namespace Models.Infrastructure
{
    public class CustomValueProviderFactory : ValueProviderFactory
    {
        public override IValueProvider GetValueProvider(ControllerContext controllerContext)
        {
            return new CountryValueProvider();
        }
    }
}