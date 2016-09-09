using System;
using System.Globalization;
using System.Web.Mvc;

namespace Models.Infrastructure
{
    public class CountryValueProvider : IValueProvider
    {
        public bool ContainsPrefix(string prefix)
        {
            return prefix.ToLower()
                .IndexOf("country", StringComparison.Ordinal) > 1;
        }

        public ValueProviderResult GetValue(string key)
        {
            if (ContainsPrefix(key))
            {
                return new ValueProviderResult
                    ("Belarus", "Belarus", CultureInfo.InvariantCulture);
            }
            return null;
        }
    }
}