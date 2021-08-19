using System.Collections.Generic;
using System.Linq;
using EStoreApp.Web.Models.Mapper;
using EStoreApp.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EStoreApp.Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<ProductDetailsViewModel> products = new List<ProductDetailsViewModel>();
            StaticDB.Products.ForEach(x => products.Add(ProductMapper.ProductToProductDetailsViewModel(x)));

            return View(products);
        }

        public IActionResult Details(int id)
        {
            if(id > 0)
            {
                var product = StaticDB.Products.SingleOrDefault(x => x.Id == id);

                if (product != null)
                {
                    return View(ProductMapper.ProductToProductDetailsViewModel(product));
                }

                return View("ResourceNotFound");
            }

            return View("Error");
        }

        public IActionResult Edit(int? id)
        {
            if(id != null)
            {
                var product = StaticDB.Products.SingleOrDefault(x => x.Id == id);

                if(product == null)
                {
                    return View("ResourceNotFound");
                }

                return View(ProductMapper.ProductToProductViewModel(product));
            }

            return View("Error");
        }

        [HttpPost]
        public IActionResult Edit(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product = StaticDB.Products.SingleOrDefault(x => x.Id == model.Id);

                if(product == null)
                {
                    return View("ResourceNotFound");
                }

                product.Name = model.Name;
                product.Description = model.Description;
                product.Price = model.Price;

                return RedirectToAction("Index");
            }

            return View("Error");
        }

        public IActionResult Delete(int? id)
        {
            if(id != null)
            {
                var product = StaticDB.Products.SingleOrDefault(x => x.Id == id);

                if(product == null)
                {
                    return View("ResourceNotFound");
                }

                return View(ProductMapper.ProductToProductDetailsViewModel(product));
            }

            return View("Error");
        }

        public IActionResult DeletePost(int? id)
        {
            if(id != null)
            {
                var product = StaticDB.Products.SingleOrDefault(x => x.Id == id);

                if(product == null)
                {
                    return View("ResourceNotFound");
                }

                StaticDB.Products.Remove(product);
                return RedirectToAction("Index");
            }

            return View("Error");
        }

        public IActionResult Create()
        {
            var product = new ProductViewModel();
            return View(product);
        }

        [HttpPost]
        public IActionResult Create(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                StaticDB.Products.Add(ProductMapper.ProductViewModelToProduct(model));

                return RedirectToAction("Index");
            }

            return View("Error");
        }


    }
}
