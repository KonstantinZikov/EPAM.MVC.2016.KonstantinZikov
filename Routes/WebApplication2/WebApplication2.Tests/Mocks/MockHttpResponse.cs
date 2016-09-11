using System.Web;

namespace WebApplication2.Tests
{
    class MockHttpResponse : HttpResponseBase
    {
        public override string ApplyAppPathModifier(string virtualPath)
        {
            return virtualPath;
        }
    }
}
