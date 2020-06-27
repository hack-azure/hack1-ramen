using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stripe;

namespace Ramen.Store.Pages
{
    public class SuccessModel : PageModel
    {
        public void OnGet()
        {
            StripeConfiguration.ApiKey = Environment.GetEnvironmentVariable("StripeApiKey"); var options = new ProductListOptions
            {
                Limit = 3,
            };
            var service = new ProductService();
            StripeList<Product> products = service.List(
                options
            ); var imageUrl = products.Data[0].Images[0]; var param = Request.Query["id"];
            ViewData["param"] = param;
            ViewData["imageUrl"] = imageUrl;
        }
    }
}

