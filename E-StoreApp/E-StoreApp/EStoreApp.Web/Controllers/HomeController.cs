using System.Collections.Generic;
using EStoreApp.Services.Services.Interfaces;
using EStoreApp.Web.Models;
using EStoreApp.Web.Models.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EStoreApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private IProductOrderService _productOrderService;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IProductOrderService productOrderService)
        {
            _logger = logger;
            _productOrderService = productOrderService;
        }

        public IActionResult Index()
        {
            var products = _productOrderService.GetProducts();

            List<ProductsViewModel> productsViewModel = new List<ProductsViewModel>();
            products.ForEach(x => productsViewModel.Add(ProductOrderMapper.ProductToProductsViewModel(x)));

            return View(productsViewModel);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Promotions()
        {
            return View();
        }
    }
}
