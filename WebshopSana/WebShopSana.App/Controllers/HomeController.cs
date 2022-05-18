using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebShopSana.App.Models;
using WebShopSana.BL.ProductsBL;

namespace WebShopSana.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductsServiceBL _productsServiceBL;

        public HomeController(ILogger<HomeController> logger, IProductsServiceBL productsServiceBl)
        {
            _logger = logger;
            _productsServiceBL = productsServiceBl;
        }

        public IActionResult Index()
        {
            var products = _productsServiceBL.Get();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}