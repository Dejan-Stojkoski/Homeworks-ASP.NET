using EStoreApp.Services.Services.Interfaces;
using EStoreApp.Web.Models.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace EStoreApp.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductOrderService _productOrderService;

        public ProductController(IProductOrderService productOrderService)
        {
            _productOrderService = productOrderService;
        }

        public IActionResult Details(int id)
        {
            var product = ProductOrderMapper.ProductToProductDetailsViewModel(_productOrderService.GetProductById(id));
            if(product != null)
            {
                return View(product);
            }

            return View("Error");
        }
    }
}
