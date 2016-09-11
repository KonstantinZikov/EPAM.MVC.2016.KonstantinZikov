using System.Web;

namespace WebApplication2.Tests
{
    class MockHttpContext : HttpContextBase
    {
        MockHttpRequest request;
        MockHttpResponse response;

        public MockHttpContext(string path = "/", string requestUrl = "~/")
        {
            request = new MockHttpRequest(path, requestUrl);
            response = new MockHttpResponse();
        }

        public override HttpRequestBase Request { get { return request; } }
        public override HttpResponseBase Response { get { return response; } }
    }
}
