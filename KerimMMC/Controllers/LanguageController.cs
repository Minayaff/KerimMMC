using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace KerimMMC.Controllers
{
    public class LanguageController : Controller
    {
        //RedirectToDefaultLanguage
        public IActionResult Index()
        {
            var defaultCookieName = CookieRequestCultureProvider.DefaultCookieName;
            var lang = HttpContext.Request.Cookies[defaultCookieName];
            if (lang != null)
            {
                if (lang.Contains("az-Latn-AZ"))
                {
                    lang = "az";
                }
                else if (lang.Contains("ru-RU"))
                {
                    lang = "ru";
                }
                else if (lang.Contains("en-US"))
                {
                    lang = "en";
                }
                else
                {
                    lang = "az";
                }
            }
            else
            {
                lang = "az";
            }
            if (lang == "az")
            {
                return RedirectToAction("Index", "Home");

            }
            return RedirectToAction("Index", "Home", new { lang = lang });
        }

        public IActionResult SetCulture(string selectedCulture)
        {
            string from = string.Empty;
            string to = string.Empty;

            var defaultCookieName = CookieRequestCultureProvider.DefaultCookieName;
            var requestCulture = string.Empty;

            switch (selectedCulture)
            {
                case "ru":
                    {
                        requestCulture = "ru-RU";
                        break;
                    }
                case "az":
                    {
                        requestCulture = "az-Latn-AZ";
                        break;
                    }
                case "en":
                    {
                        requestCulture = "en-US";
                        break;
                    }
                default:
                    {
                        requestCulture = "az-Latn-AZ";
                        break;
                    }
            }

            var makeCookieValue = CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(requestCulture));

            Response.Cookies.Append(
                defaultCookieName,
                makeCookieValue,
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            to = selectedCulture;
            var returnUrl = Request.Headers["Referer"].ToString();

            var returnUrlSections = returnUrl.Split(new[] { Request.Host.ToString() }, StringSplitOptions.None);
            var url = string.Empty;
            if (returnUrlSections.Length > 1)
            {
                var urlPath = returnUrlSections[1].Split(new[] { "//" }, StringSplitOptions.None)[0];
                if (urlPath == "/" || urlPath == "/" + from)
                {
                    url = returnUrlSections[0] + Request.Host + "/" + to;
                }
                else
                {
                    var urlPathSections = urlPath.Split(new[] { "/" }, StringSplitOptions.None);
                    if (urlPathSections.Length > 0)
                    {
                        urlPathSections[1] = to;
                        url = returnUrlSections[0] + Request.Host + string.Join("/", urlPathSections);
                    }
                }
            }
            else
            {
                url = returnUrl;
            }

            return Redirect(url);
        }

        #region Helper
        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }
        #endregion
    }
}
