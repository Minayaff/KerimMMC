using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace KerimMMC.Controllers
{
    public class BaseController : Controller
    {
        private string _culture;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);

            var lang = string.IsNullOrEmpty(RouteData.Values["lang"].ToString()) ? "az" : RouteData.Values["lang"].ToString();

            switch (lang)
            {
                case "ru":
                    {
                        _culture = "ru-RU";
                        break;
                    }
                case "en":
                    {
                        _culture = "en-US";
                        break;
                    }
                case "az":
                default:
                    {
                        _culture = "az-Latn-AZ";
                        break;
                    }

            }
            Response.Cookies.Append(
               CookieRequestCultureProvider.DefaultCookieName,
               CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(_culture)),
               new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
           );

            context.RouteData.Values.Remove("lang");
            context.RouteData.Values.Add("lang", lang);
        }
    }
}
