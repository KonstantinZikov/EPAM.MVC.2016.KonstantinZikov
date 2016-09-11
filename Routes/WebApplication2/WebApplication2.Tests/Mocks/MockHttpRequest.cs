using System.Collections.Specialized;
using System.Web;

namespace WebApplication2.Tests
{
    class MockHttpRequest: HttpRequestBase
    {
        string path;
        string requestUrl;

        public MockHttpRequest(string path, string requestUrl)
        {
            this.path = path;
            this.requestUrl = requestUrl;
        }

        public override string ApplicationPath
        {
            get
            {
                return path;
            }
        }

        public override string AppRelativeCurrentExecutionFilePath
        {
            get
            {
                return requestUrl;
            }
        }

        public override string PathInfo
        {
            get
            {
                return "";
            }
        }

        public override NameValueCollection ServerVariables
        {
            get
            {
                return new NameValueCollection();
            }
        }
    }
}
