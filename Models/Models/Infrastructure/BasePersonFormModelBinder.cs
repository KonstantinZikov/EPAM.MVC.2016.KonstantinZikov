using Models.Models;
using System;
using System.Web.Mvc;

namespace Models.Infrastructure
{
    public abstract class BasePersonModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var standartValue = "<Not defined>";
            Person model = new Person();

            model.FirstName = GetValue("FirstName", controllerContext) ?? standartValue;

            model.LastName = GetValue("LastName", controllerContext) ?? standartValue;

            var birthDateString = GetValue("BirthDate", controllerContext) ?? "";
            DateTime birthDate;
            if (CustomDateValidator.Validate(birthDateString, out birthDate)){
                model.BirthDate = birthDate;
            }

            // Role
            Role role;
            if (!Enum.TryParse(GetValue("Role", controllerContext),out role)){
                role = Role.Guest;
            }

            if (role == Role.Admin && !controllerContext.HttpContext.Request.IsLocal)
            {
                role = Role.User;
            }

            // Address
            {
                model.HomeAddress = new Address();
                var line1 = GetValue("HomeAddress.Line1", controllerContext) ?? "";
                if (line1.Contains("Po BOX"))
                {
                    line1 = standartValue;
                }
                model.HomeAddress.Line1 = line1;

                var line2 = GetValue("HomeAddress.Line2", controllerContext);
                if (string.IsNullOrEmpty(line2) || line2.Contains("Po BOX"))
                {
                    line2 = standartValue;
                }
                model.HomeAddress.Line2 = line2;
                var city = GetValue("HomeAddress.City", controllerContext) ?? "";
                model.HomeAddress.City = city;
                model.HomeAddress.Country = GetValue("HomeAddress.Country", controllerContext) ?? "";
                var postalCode = GetValue("HomeAddress.PostalCode", controllerContext) ?? "";
                if (postalCode.Length < 6)
                {
                    postalCode = standartValue;
                }
                model.HomeAddress.PostalCode = postalCode;

                if (postalCode != standartValue && !string.IsNullOrEmpty(city) && line1 != standartValue)
                {
                    model.AddressSummary = $"{postalCode} {city}, {line1}";
                }
                else
                {
                    model.AddressSummary = standartValue;
                }
            }

            return model;
        }

        protected abstract string GetValue(string key, ControllerContext context);
    }
}