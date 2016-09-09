using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models.Infrastructure
{
    public class PersonFormProvider : FormValueProvider
    {
        public bool ContainsPrefix(string prefix)
        {
            return prefix.ToLower()
                .IndexOf("person", StringComparison.Ordinal) > 1;
        }

        public ValueProviderResult GetValue(string key)
        {
            HttpContext.Current.Request.Form.
            throw new NotImplementedException();
        }
    }
}