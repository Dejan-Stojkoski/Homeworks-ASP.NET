using System.Collections.Generic;
using System.Linq;
using EStoreApp.Web.Models.Domain;
using EStoreApp.Web.Models.ViewModels;

namespace EStoreApp.Web.Models.Mapper
{
    public static class ProductMapper
    {
        public static ProductDetailsViewModel ProductToProductDetailsViewModel(Product product)
        {
            return new ProductDetailsViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price
            };
        }

        public static ProductViewModel ProductToProductViewModel(Product product)
        {
            return new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Category = product.Category,
                Price = product.Price
            };
        }

        public static Product ProductViewModelToProduct(ProductViewModel product)
        {
            return new Product
            {
                Id = StaticDB.Products.Last().Id + 1,
                Name = product.Name,
                Description = product.Description,
                Category = product.Category,
                Price = product.Price,
                Reviews = new List<Review>()
            };
        }
    }
}
