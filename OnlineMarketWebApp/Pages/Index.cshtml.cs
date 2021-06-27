using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using OnlineMarketWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMarketWebApp.Pages
{
    public class IndexModel : PageModel
    {
        OnlineMarketDBContext _contetx;

        public IndexModel(OnlineMarketDBContext context)
        {
            _contetx = context;
        }

        public Banner banner { get; set; }

        public List<HomeProduct> HomeProducts { get; set; }

        public List<Product> Products { get; set; }

        public List<Slider> Sliders { get; set; }

        public void OnGet()
        {
            banner = _contetx.Banners.FirstOrDefault();

            HomeProducts = _contetx.HomeProducts.ToList();

            Products = _contetx.Products.ToList();

            Sliders = _contetx.Sliders.ToList();
        }
    }
}
