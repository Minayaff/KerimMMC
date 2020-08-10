using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KerimMMC.Route
{
    public class RouteCultureProvider : IRequestCultureProvider
    {
        private CultureInfo defaultCulture;
        private CultureInfo defaultUICulture;

        public RouteCultureProvider(RequestCulture requestCulture)
        {
            this.defaultCulture = requestCulture.Culture;
            this.defaultUICulture = requestCulture.UICulture;
        }

        public Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
        {
            //Parsing language from url path, which looks like "/en/home/index"
            PathString url = httpContext.Request.Path;

            // Test any culture in route
            if (url.ToString().Length <= 1)
            {
                // Set default Culture and default UICulture
                return Task.FromResult<ProviderCultureResult>(new ProviderCultureResult(this.defaultCulture.Name, this.defaultUICulture.Name));
            }

            var parts = httpContext.Request.Path.Value.Split('/');
            var culture = parts[1];
            switch (culture)
            {

                case "az":
                    {
                        culture = "az-Latn-AZ";
                        break;
                    }
                case "ru":
                    {
                        culture = "ru-RU";
                        break;
                    }
                case "en":
                    {
                        culture = "en-US";
                        break;
                    }
                default:
                    {
                        culture = "az-Latn-AZ";
                        break;
                    }
            }

            CultureInfo newCulture = new CultureInfo(culture);

            // Test if the culture is properly formatted
            if (!Regex.IsMatch(culture, @"^[a-z]{2}(-[A-Z]{2})*$"))
            {
                // Set default Culture and default UICulture
                return Task.FromResult<ProviderCultureResult>(new ProviderCultureResult(this.defaultCulture.Name, this.defaultUICulture.Name));
            }

            // Set Culture and UICulture from route culture parameter
            return Task.FromResult<ProviderCultureResult>(new ProviderCultureResult(newCulture.Name, newCulture.Name));
        }
    }
}
