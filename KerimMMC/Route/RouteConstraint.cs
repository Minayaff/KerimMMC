using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KerimMMC.Route
{
    public class RouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (!values.ContainsKey("lang"))
            {
                return false;
            }

            var lang = values["lang"].ToString().ToLower();

            return (lang == "az" || lang == "ru" || lang == "en");
        }
    }

    public class AccountRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (!values.ContainsKey("account"))
            {
                return false;
            }

            var value = values["account"].ToString().ToLower();

            return (value == "login" || value == "register");
        }
    }


}
