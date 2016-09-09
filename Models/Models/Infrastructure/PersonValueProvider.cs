using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models.Infrastructure
{
    public class PersonValueProvider : IValueProvider
    {
        public bool ContainsPrefix(string prefix)
        {
            return prefix.ToLower()
                .IndexOf("country", StringComparison.Ordinal) > 1;
        }

        public ValueProviderResult GetValue(string key)
        {
            throw new NotImplementedException();
        }
    }
}