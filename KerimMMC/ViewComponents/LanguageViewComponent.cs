using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace KerimMMC.ViewComponents
{
    public class LanguageViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var lang = Request.Path.ToString().Split("/")[1].ToUpper();

            return View("Language", lang);
        }

    }
}
