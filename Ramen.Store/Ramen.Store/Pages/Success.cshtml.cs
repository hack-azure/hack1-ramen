using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ramen.Store.Pages
{
    public class SuccessModel : PageModel
    {
        public void OnGet()
        {
            var param = Request.Query["id"];
            ViewData["param"] = param;
        }
    }
}